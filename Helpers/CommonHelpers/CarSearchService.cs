using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FYP_PROJECT.Helpers.CommonHelpers
{
    public class CarSearchService
    {
        

        public void SearchAndDisplay(
            string searchInput,
            Label carNumberLbl,
            Label ownerNameLbl,
            Label addressLbl,
            Label phoneLbl,
            Label modelLbl,
            Label makeLbl,
            Label yearLbl,
            Label colorLbl,
            Label servicesDoneLbl,
            DataGridView resultGridView
        )
        {
            using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    string clientQuery = @"
                    SELECT 
                        Client_Id,
                        Client_Name,
                        Client_Address,
                        Client_Phone,
                        Client_Car_Number,
                        Client_Car_Model,
                        Client_Car_Make,
                        Client_Car_Year,
                        Client_Car_Color
                    FROM clients
                    WHERE Client_Car_Number = @input OR Client_CNIC = @input";

                    List<int> clientIds = new List<int>();

                    using (MySqlCommand cmd = new MySqlCommand(clientQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@input", searchInput);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (clientIds.Count == 0)
                                    {
                                        carNumberLbl.Text = reader["Client_Car_Number"].ToString();
                                        ownerNameLbl.Text = reader["Client_Name"].ToString();
                                        addressLbl.Text = reader["Client_Address"].ToString();
                                        phoneLbl.Text = reader["Client_Phone"].ToString();
                                        modelLbl.Text = reader["Client_Car_Model"].ToString();
                                        makeLbl.Text = reader["Client_Car_Make"].ToString();
                                        yearLbl.Text = reader["Client_Car_Year"].ToString();
                                        colorLbl.Text = reader["Client_Car_Color"].ToString();
                                    }

                                    clientIds.Add(Convert.ToInt32(reader["Client_Id"]));
                                }
                            }
                            else
                            {
                                MessageBox.Show("No client found with that car number or CNIC.");

                                carNumberLbl.Text = "";
                                ownerNameLbl.Text = "";
                                addressLbl.Text = "";
                                phoneLbl.Text = "";
                                modelLbl.Text = "";
                                makeLbl.Text = "";
                                yearLbl.Text = "";
                                colorLbl.Text = "";
                                servicesDoneLbl.Text = "";
                                resultGridView.DataSource = null;
                                return;
                            }
                        }
                    }

                    // Fetch appointments
                    string appointmentQuery = @"
                    SELECT 
                        a.Appointment_Id,
                        c.Client_Name,
                        a.Appointment_Date,
                        a.Appointment_Total,
                        a.Appointment_Discount,
                        a.Appointment_Grand_Total,
                        a.Appointment_Pay_Method,
                        a.Appointment_Status
                    FROM appointment a
                    INNER JOIN clients c ON a.Appointment_Client_Id = c.Client_Id
                    WHERE a.Appointment_Client_Id IN (" + string.Join(",", clientIds) + ")";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(appointmentQuery, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        resultGridView.DataSource = dt;

                        servicesDoneLbl.Text = dt.Rows.Count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching: " + ex.Message);
                }
            }
        }
    }
}
