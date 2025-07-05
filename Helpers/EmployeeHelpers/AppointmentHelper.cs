using FYP_PROJECT.Helpers.CommonHelpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FYP_PROJECT.Helpers.EmployeeHelpers
{
    public static class AppointmentHelper
    {
        public static void LoadPendingAppointments(DataGridView targetGridView)
        {
            using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                      SELECT 
                        a.Appointment_Id,
                        c.Client_Name,
                        a.Appointment_Date,
                        a.Appointment_Total,
                        a.Appointment_Discount,
                        a.Appointment_Grand_Total,
                        a.Appointment_Pay_Method,
                        a.Appointment_Status,
                        s.Service_Name AS Service
                     FROM appointment a
                     INNER JOIN clients c ON a.Appointment_Client_Id = c.Client_Id
                     LEFT JOIN services s ON a.Appointment_Service_Id = s.Service_Id
                     WHERE a.Appointment_Status = 'Pending'";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        targetGridView.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading appointments: " + ex.Message);
                }
            }
        }
        public static void LoadServices(
           CheckedListBox serviceCheckListBox,
           Dictionary<string, int> serviceMap)
        {
            using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Service_ID, Service_Name FROM services";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        serviceMap.Clear();
                        serviceCheckListBox.Items.Clear();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32("Service_ID");
                            string name = reader.GetString("Service_Name");

                            serviceMap[name] = id;
                            serviceCheckListBox.Items.Add(name);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading services: " + ex.Message);
                }
            }
        }
        public static decimal CalculateTotalFromSelectedServices(CheckedListBox serviceList)
        {
            decimal total = 0;
            using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
            {
                conn.Open();

                foreach (var item in serviceList.CheckedItems)
                {
                    string serviceName = item.ToString();
                    string query = "SELECT Service_Price FROM services WHERE Service_Name = @serviceName";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@serviceName", serviceName);
                        object priceObj = cmd.ExecuteScalar();

                        if (priceObj != null && decimal.TryParse(priceObj.ToString(), out decimal price))
                            total += price;
                    }
                }
            }

            return total;
        }
        public static void SaveAppointment(
            string ownerName,
            string cnic,
            string phone,
            string address,
            string carNumber,
            string make,
            string model,
            string color,
            string year,
            DateTime appointmentDate,
            decimal total,
            decimal discount,
            decimal grandTotal,
            string paymentMethod,
            string bookedBy,
            string assignedEmployeeName,
            List<string> serviceNames,
            Label employeeNameLabel // for showing who booked
            )
        {
            using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    // 1. Insert client and get clientId
                    string insertClient = @"INSERT INTO clients 
    (Client_Name, Client_CNIC, Client_Phone, Client_Address, Client_Car_Number, Client_Car_Make, Client_Car_Model, Client_Car_Color, Client_Car_Year)
    VALUES (@name, @cnic, @phone, @address, @carNumber, @make, @model, @color, @year);
    SELECT LAST_INSERT_ID();";

                    int clientId;
                    using (MySqlCommand cmd = new MySqlCommand(insertClient, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", ownerName);
                        cmd.Parameters.AddWithValue("@cnic", cnic);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@carNumber", carNumber);
                        cmd.Parameters.AddWithValue("@make", make);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@color", color);
                        cmd.Parameters.AddWithValue("@year", year);

                        clientId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 2. Get Employee_Id for assigned employee (if any)
                    int employeeId = -1;
                    if (!string.IsNullOrEmpty(assignedEmployeeName))
                    {
                        string getEmpIdQuery = "SELECT Employee_Id FROM employees WHERE Employee_Name = @empName LIMIT 1";
                        using (MySqlCommand empCmd = new MySqlCommand(getEmpIdQuery, conn))
                        {
                            empCmd.Parameters.AddWithValue("@empName", assignedEmployeeName);
                            object result = empCmd.ExecuteScalar();
                            if (result != null)
                                employeeId = Convert.ToInt32(result);
                        }
                    }

                    // 3. Get service IDs
                    List<int> serviceIds = new List<int>();
                    foreach (var serviceName in serviceNames)
                    {
                        string getServiceId = "SELECT Service_Id FROM services WHERE Service_Name = @name";
                        using (MySqlCommand svcCmd = new MySqlCommand(getServiceId, conn))
                        {
                            svcCmd.Parameters.AddWithValue("@name", serviceName);
                            object svcIdObj = svcCmd.ExecuteScalar();
                            if (svcIdObj != null)
                                serviceIds.Add(Convert.ToInt32(svcIdObj));
                        }
                    }

                    // 4. Insert appointment for each service
                    foreach (int serviceId in serviceIds)
                    {
                        string insertAppointment = @"INSERT INTO appointment
            (Appointment_Client_Id, Appointment_Service_Id, Appointment_Employee_Id, Appointment_Date, Appointment_Total, Appointment_Discount, Appointment_Grand_Total, Appointment_Pay_Method, Appointment_Booked_By, Appointment_Alert, Appointment_Status)
            VALUES
            (@clientId, @serviceId, @employeeId, @date, @total, @discount, @grandTotal, @payment, @bookedBy, @alert, @status);";

                        using (MySqlCommand appointCmd = new MySqlCommand(insertAppointment, conn))
                        {
                            appointCmd.Parameters.AddWithValue("@clientId", clientId);
                            appointCmd.Parameters.AddWithValue("@serviceId", serviceId);
                            appointCmd.Parameters.AddWithValue("@employeeId", employeeId);
                            appointCmd.Parameters.AddWithValue("@date", appointmentDate);
                            appointCmd.Parameters.AddWithValue("@total", total);
                            appointCmd.Parameters.AddWithValue("@discount", discount);
                            appointCmd.Parameters.AddWithValue("@grandTotal", grandTotal);
                            appointCmd.Parameters.AddWithValue("@payment", paymentMethod);
                            appointCmd.Parameters.AddWithValue("@bookedBy", bookedBy);
                            appointCmd.Parameters.AddWithValue("@alert", true);
                            appointCmd.Parameters.AddWithValue("@status", "Pending");

                            appointCmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Appointment and client saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
