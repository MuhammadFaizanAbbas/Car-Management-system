using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FYP_PROJECT.Helpers.CommonHelpers
{
    public class CarSearchService
    {
        public void SearchAndDisplay(
            string searchInput,
            Label servicesDoneLbl,
            Label lastServiceDateLbl,
            DataGridView carGridView,
            DataGridView appointmentGridView
        )
        {
            using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    bool isCarNumber = IsCarNumber(searchInput);

                    if (isCarNumber)
                    {
                        string carQuery = @"
                        SELECT Client_Car_Number, Client_Car_Model, Client_Car_Make, Client_Car_Year, Client_Car_Color
                        FROM clients
                        WHERE REPLACE(Client_Car_Number, ' ', '') = REPLACE(@input, ' ', '')
                        LIMIT 1;";

                        using (MySqlCommand cmdCar = new MySqlCommand(carQuery, conn))
                        {
                            cmdCar.Parameters.AddWithValue("@input", searchInput);
                            using (MySqlDataAdapter carAdapter = new MySqlDataAdapter(cmdCar))
                            {
                                DataTable carTable = new DataTable();
                                carAdapter.Fill(carTable);
                                carGridView.DataSource = carTable;
                            }
                        }

                        // Appointments for this car number
                        string appointmentQuery = @"
                            SELECT 
                                c.Client_Name,
                                a.Appointment_Date,
                                a.Appointment_Status,
                                a.Appointment_Grand_Total
                            FROM appointment a
                            INNER JOIN clients c ON a.Appointment_Client_Id = c.Client_Id
                            WHERE c.Client_Car_Number = @input
                            ORDER BY a.Appointment_Date DESC;";
                        using (MySqlCommand cmdApp = new MySqlCommand(appointmentQuery, conn))
                        {
                            cmdApp.Parameters.AddWithValue("@input", searchInput);
                            using (MySqlDataAdapter appAdapter = new MySqlDataAdapter(cmdApp))
                            {
                                DataTable appointmentTable = new DataTable();
                                appAdapter.Fill(appointmentTable);
                                appointmentGridView.DataSource = appointmentTable;

                                servicesDoneLbl.Text = $"Total Appointments: {appointmentTable.Rows.Count}";

                                if (appointmentTable.Rows.Count > 0)
                                {
                                    lastServiceDateLbl.Text = Convert.ToDateTime(appointmentTable.Rows[0]["Appointment_Date"]).ToString("dd MMM yyyy");
                                }
                                else
                                {
                                    lastServiceDateLbl.Text = "N/A";
                                }
                            }
                        }
                    }
                    else
                    {
                        // All cars for this CNIC
                        string carsQuery = @"
                        SELECT 
                            Client_Car_Number,
                            MAX(Client_Car_Model) AS Client_Car_Model,
                            MAX(Client_Car_Make) AS Client_Car_Make,
                            MAX(Client_Car_Year) AS Client_Car_Year,
                            MAX(Client_Car_Color) AS Client_Car_Color
                        FROM clients
                        WHERE Client_CNIC = @input
                        GROUP BY Client_Car_Number;";

                        using (MySqlCommand cmdCars = new MySqlCommand(carsQuery, conn))
                        {
                            cmdCars.Parameters.AddWithValue("@input", searchInput);
                            using (MySqlDataAdapter carsAdapter = new MySqlDataAdapter(cmdCars))
                            {
                                DataTable carsTable = new DataTable();
                                carsAdapter.Fill(carsTable);
                                carGridView.DataSource = carsTable;

                                servicesDoneLbl.Text = $"Total Cars: {carsTable.Rows.Count}";
                            }
                        }

                        // Appointments for this CNIC (all cars)
                        string appointmentQuery = @"
                        SELECT 
                            c.Client_Name,
                            a.Appointment_Date,
                            a.Appointment_Status,
                            a.Appointment_Grand_Total
                        FROM appointment a
                        INNER JOIN clients c ON a.Appointment_Client_Id = c.Client_Id
                        WHERE c.Client_CNIC = @input
                        ORDER BY a.Appointment_Date DESC;";

                        using (MySqlCommand cmdApp = new MySqlCommand(appointmentQuery, conn))
                        {
                            cmdApp.Parameters.AddWithValue("@input", searchInput);
                            using (MySqlDataAdapter appAdapter = new MySqlDataAdapter(cmdApp))
                            {
                                DataTable appointmentTable = new DataTable();
                                appAdapter.Fill(appointmentTable);
                                appointmentGridView.DataSource = appointmentTable;

                                if (appointmentTable.Rows.Count > 0)
                                {
                                    lastServiceDateLbl.Text = Convert.ToDateTime(appointmentTable.Rows[0]["Appointment_Date"]).ToString("dd MMM yyyy");
                                }
                                else
                                {
                                    lastServiceDateLbl.Text = "N/A";
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search error: " + ex.Message);
                }
            }
        }

        // Helper method
        private bool IsCarNumber(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;

            // Treat any input with 8 characters or less as a car number
            return input.Trim().Length <= 8;
        }
    }
}
