using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace FYP_PROJECT
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();

            employee_search_pnl.Visible = false;
            aiDetection_pnl.Visible = false;
            employee_schedule_pnl.Visible = false;
            employee_appointment_pnl.Visible = false;
            employee_appointmentDetails_pnl.Visible = false;
            employee_appointmentPayment_pnl.Visible = false;
            employee_appointmentPaymentSummry_pnl.Visible = false;
            employee_userEdit_pnl.Visible = false;
            employee_user_pnl.Visible = false;
            SetActiveButton(employee_welcomePage_btn);
            logoImage = Image.FromFile(@"C:\Users\abbas\OneDrive\Desktop\FYP_PROJECT\Image\pristine_shine_logo.png");
            printDocument1.PrintPage += PrintDocument1_PrintPage;
        }
        //for animation and active state of button

        private Dictionary<Guna.UI2.WinForms.Guna2Button, float> buttonFontSizes = new Dictionary<Guna.UI2.WinForms.Guna2Button, float>();
        private Guna.UI2.WinForms.Guna2Button currentActiveButton = null;
        private Timer fontAnimationTimer;
        private float animationStep = 0.5f;
        int client_Id;
        string aiImagePath;
        private Image logoImage;
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private void SetActiveButton(Guna.UI2.WinForms.Guna2Button activeBtn)
        {
            foreach (Control ctrl in employee_menu_pnl.Controls)
            {
                if (ctrl is Guna.UI2.WinForms.Guna2Button btn)
                {
                    // Skip the active button to avoid resetting it
                    if (btn == activeBtn)
                        continue;

                    if (!buttonFontSizes.ContainsKey(btn))
                        buttonFontSizes[btn] = btn.Font.Size;

                    btn.FillColor = Color.FromArgb(20, 20, 30);
                    btn.ForeColor = Color.Gainsboro;
                    btn.BorderRadius = 8;
                    btn.TextAlign = HorizontalAlignment.Left;
                    btn.Padding = new Padding(15, 0, 0, 0);
                    btn.Font = new Font("Segoe UI", btn.Font.Size, FontStyle.Regular);

                    btn.HoverState.FillColor = Color.FromArgb(50, 50, 100);
                    btn.HoverState.ForeColor = Color.White;
                    btn.HoverState.BorderColor = Color.FromArgb(128, 128, 255);
                }
            }

            if (currentActiveButton != activeBtn)
            {
                AnimateFontSizeTransition(currentActiveButton, activeBtn);
                currentActiveButton = activeBtn;
            }

            // Update colors and font immediately for active button
            activeBtn.FillColor = Color.FromArgb(128, 128, 255);
            activeBtn.ForeColor = Color.White;
            activeBtn.Font = new Font("Segoe UI", activeBtn.Font.Size, FontStyle.Bold);
        }

        private void AnimateFontSizeTransition(Guna.UI2.WinForms.Guna2Button oldBtn, Guna.UI2.WinForms.Guna2Button newBtn)
        {
            float baseSizeOld = oldBtn != null && buttonFontSizes.ContainsKey(oldBtn) ? buttonFontSizes[oldBtn] : 10;
            float baseSizeNew = newBtn != null && buttonFontSizes.ContainsKey(newBtn) ? buttonFontSizes[newBtn] : 10;

            float targetSizeOld = baseSizeOld;
            float targetSizeNew = baseSizeNew + 2; // Grow 4pt

            fontAnimationTimer?.Stop();
            fontAnimationTimer = new Timer();
            fontAnimationTimer.Interval = 15;

            fontAnimationTimer.Tick += (s, e) =>
            {
                bool allDone = true;

                // Animate old (shrink)
                if (oldBtn != null && oldBtn.Font.Size > targetSizeOld)
                {
                    float newSize = oldBtn.Font.Size - animationStep;
                    if (newSize <= targetSizeOld)
                    {
                        newSize = targetSizeOld;
                        oldBtn.Font = new Font("Segoe UI", newSize, FontStyle.Regular);
                    }
                    else
                    {
                        oldBtn.Font = new Font("Segoe UI", newSize, FontStyle.Regular);
                        allDone = false;
                    }
                }

                // Animate new (grow)
                if (newBtn != null && newBtn.Font.Size < targetSizeNew)
                {
                    float newSize = newBtn.Font.Size + animationStep;
                    if (newSize >= targetSizeNew)
                    {
                        newSize = targetSizeNew;
                        newBtn.Font = new Font("Segoe UI", newSize, FontStyle.Bold);
                    }
                    else
                    {
                        newBtn.Font = new Font("Segoe UI", newSize, FontStyle.Bold);
                        allDone = false;
                    }
                }

                if (allDone)
                    fontAnimationTimer.Stop();
            };

            fontAnimationTimer.Start();
        }

        private void employee_menu_pnl_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 90;
            Panel panel = sender as Panel;

            if (panel == null)
                return;

            GraphicsPath path = new GraphicsPath();

            path.AddLine(0, 0, panel.Width - borderRadius, 0);  // Top edge
            path.AddArc(panel.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90);  // Top-right

            path.AddLine(panel.Width, 0, panel.Width, panel.Height - borderRadius);  // Right edge
            path.AddArc(panel.Width - borderRadius * 2, panel.Height - borderRadius * 2,
                        borderRadius * 2, borderRadius * 2, 0, 90);  // Bottom-right

            path.AddLine(panel.Width - borderRadius, panel.Height, 0, panel.Height);  // Bottom
            path.AddLine(0, panel.Height, 0, 0);  // Left edge

            path.CloseFigure();
            panel.Region = new Region(path);
            e.Graphics.FillPath(new SolidBrush(panel.BackColor), path);
        }

        private void employee_closeApplication_btn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Are you sure you want to close this application?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            // else do nothing (user clicked No)
        }

        private void employee_logOut_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);

            Login_form login
                = new Login_form();
            ShowFormWithFade(login);

        }

        private void Empoyee_Load(object sender, EventArgs e)
        {
            LoadServices();
            LoadAssignableEmployees();
            LoadPendingAppointments();
            LoadUserInfoIntoLabels();
        }

        private void employee_welcomePage_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            employee_search_pnl.Hide();
            aiDetection_pnl.Hide();
            employee_appointment_pnl.Hide();
            employee_schedule_pnl.Hide();
            employee_user_pnl.Hide();
        }

        private void employee_search_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            employee_search_pnl.Show();
            aiDetection_pnl.Hide();
            employee_schedule_pnl.Hide();
            employee_appointment_pnl.Hide();
            employee_user_pnl.Hide();

        }

      

        private void aiDetection_UploadImage_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an Image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                try
                {
                    // Display image in PictureBox
                    aiDetection_pictureBox.Image = Image.FromFile(selectedImagePath);
                    aiDetection_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    // Save the image path for later use in AI detection

                    aiImagePath = selectedImagePath;
                    // (Make sure aiDetection_ImagePath_lbl is either hidden or not visible to users)
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }

        }

        private void employee_aiDetection_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            aiDetection_pnl.Show();
            employee_search_pnl.Hide();
            employee_appointment_pnl.Hide();
            employee_schedule_pnl.Hide();
            employee_user_pnl.Hide();

        }

        private void employee_schedule_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            LoadPendingAppointments();
            employee_schedule_pnl.Show();
            aiDetection_pnl.Hide();
            employee_appointment_pnl.Hide();
            employee_search_pnl.Hide();
            employee_user_pnl.Hide();
        }

        private void employee_appointment_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            employee_schedule_pnl.Hide();
            aiDetection_pnl.Hide();
            employee_search_pnl.Hide();
            employee_appointment_pnl.Show();
            employee_appointmentDetails_pnl.Show();
            employee_user_pnl.Hide();
        }

        private void employee_user_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            LoadUserInfoIntoLabels();
            employee_user_pnl.Show();
            employee_schedule_pnl.Hide();
            aiDetection_pnl.Hide();
            employee_search_pnl.Hide();
            employee_appointment_pnl.Hide();
            employee_appointmentDetails_pnl.Hide();
        }
        private void ShowFormWithFade(Form targetForm)
        {
            targetForm.Opacity = 0;
            targetForm.Show();

            Timer fadeIn = new Timer();
            fadeIn.Interval = 1;
            fadeIn.Tick += (s, e) =>
            {
                if (targetForm.Opacity >= 1)
                {
                    fadeIn.Stop();
                    this.Hide(); // hide login form AFTER new form is visible
                }
                else
                {
                    targetForm.Opacity += 0.08;
                }
            };
            fadeIn.Start();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void employee_appointmentProceed_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";
            decimal total = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    foreach (var item in employee_appointmentServices_checkListBox.CheckedItems)
                    {
                        string serviceName = item.ToString();
                        string query = "SELECT Service_Price FROM services WHERE Service_Name = @serviceName LIMIT 1";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@serviceName", serviceName);
                            object priceObj = cmd.ExecuteScalar();

                            if (priceObj != null && decimal.TryParse(priceObj.ToString(), out decimal price))
                                total += price;
                        }
                    }

                    // Update the Total textbox
                    employee_appointmentTotal_tb.Text = total.ToString("0.00");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error calculating service total: " + ex.Message);
                }
            }

            employee_appointmentPayment_pnl.Show();
            employee_appointmentDetails_pnl.Hide();
        }


        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {


        }

        private void employee_appointmentDone_btn_Click(object sender, EventArgs e)
        {
            // Set summary labels
            employee_appointmentSummaryOwnerName_lbl.Text = employee_appointmentOwnerName_tb.Text;
            employee_appointmentSummaryCnic_lbl.Text = employee_appointmentCnic_tb.Text;
            employee_appointmentSummaryPhone_lbl.Text = employee_appointmentPhone_tb.Text;
            employee_appointmentSummaryAddress_lbl.Text = employee_appointmentAddress_tb.Text;
            employee_appointmentSummaryNumber_lbl.Text = employee_appointmentCarNumber_tb.Text;
            employee_appointmentSummaryMake_lbl.Text = employee_appointmentMake_tb.Text;
            employee_appointmentSummaryModel_lbl.Text = employee_appointmentCarModel_tb.Text;
            employee_appointmentSummaryColor_lbl.Text = employee_appointmentColor_tb.Text;
            employee_appointmentSummaryYear_lbl.Text = employee_appointmentYear_tb.Text;
            employee_appointmentSummaryAppointmentDate_lbl.Text = employee_appointmentDate_datePicker.Value.ToString("dd MMM yyyy");

            employee_appointmentSummaryTotal_lbl.Text = "Total: " + employee_appointmentTotal_tb.Text;
            employee_appointmentSummaryDiscount_lbl.Text = "Discount: " + employee_appointmentDiscount_tb.Text;
            employee_appointmentSummaryGrandTotal_lbl.Text = "Grand Total: " + employee_appointment_GrandTotal_tb.Text;

            if (employee_appointmentPaymentMethod_listBox.SelectedItem != null)
                employee_appointmentSummaryPaymentMethod_lbl.Text = employee_appointmentPaymentMethod_listBox.SelectedItem.ToString();
            else
                employee_appointmentSummaryPaymentMethod_lbl.Text = "N/A";

            if (employee_appointmentEmployeeName_listBox.SelectedItem != null)
                employee_appointmentSummaryBookedBy_lbl.Text = employee_name_lbl.Text;
            else
                employee_appointmentSummaryBookedBy_lbl.Text = "N/A";

            if (employee_appointmentEmployeeName_listBox.SelectedItem != null)
                employee_appointmentSummaryAssignedPerson_lbl.Text = employee_appointmentEmployeeName_listBox.SelectedItem.ToString();
            else
                employee_appointmentSummaryAssignedPerson_lbl.Text = "N/A";

            employee_appointmentSummaryService_lbl.Text = string.Join("\n",
            employee_appointmentServices_checkListBox.CheckedItems.Cast<string>());

            employee_appointmentPaymentSummry_pnl.Show();
            employee_appointmentPayment_pnl.Hide();

            // ✅ Add appointment to database
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 1. Insert client record
                    string insertClient = @"INSERT INTO clients 
            (Client_Name, Client_CNIC, Client_Phone, Client_Address, Client_Car_Number, Client_Car_Make, Client_Car_Model, Client_Car_Color, Client_Car_Year)
            VALUES (@name, @cnic, @phone, @address, @carNumber, @make, @model, @color, @year);
            SELECT LAST_INSERT_ID();";

                    int clientId;
                    using (MySqlCommand cmd = new MySqlCommand(insertClient, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", employee_appointmentOwnerName_tb.Text.Trim());
                        cmd.Parameters.AddWithValue("@cnic", employee_appointmentCnic_tb.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", employee_appointmentPhone_tb.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", employee_appointmentAddress_tb.Text.Trim());
                        cmd.Parameters.AddWithValue("@carNumber", employee_appointmentCarNumber_tb.Text.Trim());
                        cmd.Parameters.AddWithValue("@make", employee_appointmentMake_tb.Text.Trim());
                        cmd.Parameters.AddWithValue("@model", employee_appointmentCarModel_tb.Text.Trim());
                        cmd.Parameters.AddWithValue("@color", employee_appointmentColor_tb.Text.Trim());
                        cmd.Parameters.AddWithValue("@year", employee_appointmentYear_tb.Text.Trim());

                        clientId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 2. Get selected Employee_Id
                    string selectedEmpName = employee_appointmentEmployeeName_listBox.SelectedItem?.ToString();
                    int employeeId = -1;
                    if (!string.IsNullOrEmpty(selectedEmpName))
                    {
                        string getEmpIdQuery = "SELECT Employee_Id FROM employees WHERE Employee_Name = @empName LIMIT 1";
                        using (MySqlCommand empCmd = new MySqlCommand(getEmpIdQuery, conn))
                        {
                            empCmd.Parameters.AddWithValue("@empName", selectedEmpName);
                            object result = empCmd.ExecuteScalar();
                            if (result != null)
                                employeeId = Convert.ToInt32(result);
                        }
                    }

                    // 3. Get selected Service Ids
                    List<int> serviceIds = new List<int>();
                    foreach (var serviceName in employee_appointmentServices_checkListBox.CheckedItems)
                    {
                        string getServiceId = "SELECT Service_Id FROM services WHERE Service_Name = @name ";
                        using (MySqlCommand svcCmd = new MySqlCommand(getServiceId, conn))
                        {
                            svcCmd.Parameters.AddWithValue("@name", serviceName.ToString());
                            object svcIdObj = svcCmd.ExecuteScalar();
                            if (svcIdObj != null)
                                serviceIds.Add(Convert.ToInt32(svcIdObj));
                        }
                    }

                    // 4. Insert one appointment per service
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
                            appointCmd.Parameters.AddWithValue("@date", employee_appointmentDate_datePicker.Value);
                            appointCmd.Parameters.AddWithValue("@total", employee_appointmentTotal_tb.Text.Trim());
                            appointCmd.Parameters.AddWithValue("@discount", employee_appointmentDiscount_tb.Text.Trim());
                            appointCmd.Parameters.AddWithValue("@grandTotal", employee_appointment_GrandTotal_tb.Text.Trim());
                            appointCmd.Parameters.AddWithValue("@payment", employee_appointmentPaymentMethod_listBox.SelectedItem?.ToString() ?? "N/A");
                            appointCmd.Parameters.AddWithValue("@bookedBy", employee_name_lbl.Text);
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
        private void LoadAssignableEmployees()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";
            string[] excludedRoles = { "CEO", "Manager", "Supervisor" };

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Employee_Name FROM employees WHERE Employee_Role NOT IN ('CEO', 'Manager', 'Supervisor')";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        employee_appointmentEmployeeName_listBox.Items.Clear();

                        while (reader.Read())
                        {
                            employee_appointmentEmployeeName_listBox.Items.Add(reader.GetString("Employee_Name"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employee names: " + ex.Message);
                }
            }
        }
        private void employee_appontmentEmployeeName_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void employee_appointmentOk_btn_Click(object sender, EventArgs e)
        {
            // Clear textboxes
            employee_appointmentOwnerName_tb.Clear();
            employee_appointmentCnic_tb.Clear();
            employee_appointmentPhone_tb.Clear();
            employee_appointmentAddress_tb.Clear();
            employee_appointmentCarNumber_tb.Clear();
            employee_appointmentMake_tb.Clear();
            employee_appointmentCarModel_tb.Clear();
            employee_appointmentColor_tb.Clear();
            employee_appointmentYear_tb.Clear();
            employee_appointmentTotal_tb.Clear();
            employee_appointmentDiscount_tb.Clear();
            employee_appointment_GrandTotal_tb.Clear();

            // Reset DateTimePicker to current date
            employee_appointmentDate_datePicker.Value = DateTime.Now;

            // Clear listbox selections
            employee_appointmentPaymentMethod_listBox.ClearSelected();
            employee_appointmentEmployeeName_listBox.ClearSelected();

            // Uncheck all checked items in service checklist
            for (int i = 0; i < employee_appointmentServices_checkListBox.Items.Count; i++)
            {
                employee_appointmentServices_checkListBox.SetItemChecked(i, false);
            }

            // Hide summary/payment panels and show main details panel
            employee_appointmentPayment_pnl.Hide();
            employee_appointmentPaymentSummry_pnl.Hide();
            employee_appointmentDetails_pnl.Show();
        }

        private Dictionary<string, int> serviceMap = new Dictionary<string, int>();

        private void LoadServices()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Service_ID, Service_Name FROM services";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        serviceMap.Clear();
                        employee_appointmentServices_checkListBox.Items.Clear();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32("Service_ID");
                            string name = reader.GetString("Service_Name");

                            serviceMap[name] = id;
                            employee_appointmentServices_checkListBox.Items.Add(name);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading services: " + ex.Message);
                }
            }
        }
        private void SaveAppointmentToDatabase(int clientId)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            // Get selected service IDs (you must have stored these from checklist earlier)
            List<int> selectedServiceIds = GetSelectedServiceIds(); // You must implement this

            if (selectedServiceIds.Count == 0)
            {
                MessageBox.Show("No services selected.");
                return;
            }

            int selectedEmployeeId = GetSelectedEmployeeId(); // You must implement this

            if (selectedEmployeeId == -1)
            {
                MessageBox.Show("Please select an employee.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    foreach (int serviceId in selectedServiceIds)
                    {
                        string query = @"INSERT INTO appointment 
                (Appointment_Client_Id, Appointment_Service_Id, Appointment_Employee_Id,
                Appointment_Date, Appointment_Total, Appointment_Discount, Appointment_Grand_Total,
                Appointment_Pay_Method, Appointment_Booked_By, Appointment_Alert, Appointment_Status)
                VALUES
                (@ClientId, @ServiceId, @EmployeeId, @Date, @Total, @Discount, @GrandTotal, 
                @PayMethod, @BookedBy, 'True', 'Pending')";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ClientId", clientId);
                            cmd.Parameters.AddWithValue("@ServiceId", serviceId);
                            cmd.Parameters.AddWithValue("@EmployeeId", selectedEmployeeId);
                            cmd.Parameters.AddWithValue("@Date", employee_appointmentDate_datePicker.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@Total", employee_appointmentTotal_tb.Text.Trim());
                            cmd.Parameters.AddWithValue("@Discount", employee_appointmentDiscount_tb.Text.Trim());
                            cmd.Parameters.AddWithValue("@GrandTotal", employee_appointment_GrandTotal_tb.Text.Trim());
                            cmd.Parameters.AddWithValue("@PayMethod", employee_appointmentPaymentMethod_listBox.SelectedItem?.ToString() ?? "N/A");
                            cmd.Parameters.AddWithValue("@BookedBy", employee_name_lbl.Text.Trim());

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Appointment saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving appointment: " + ex.Message);
                }
            }
        }
        private List<int> GetSelectedServiceIds()
        {
            List<int> serviceIds = new List<int>();
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    foreach (string serviceName in employee_appointmentServices_checkListBox.CheckedItems)
                    {
                        string query = "SELECT Service_Id FROM service WHERE Service_Name = @name";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", serviceName);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    serviceIds.Add(reader.GetInt32("Service_Id"));
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading service IDs: " + ex.Message);
                }
            }

            return serviceIds;
        }
        private int GetSelectedEmployeeId()
        {
            string selectedName = employee_appointmentEmployeeName_listBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedName)) return -1;

            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Employee_Id FROM employees WHERE Employee_Name = @name LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", selectedName);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            return Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employee ID: " + ex.Message);
                }
            }

            return -1;
        }


        private void employee_appointmentServices_checkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void employee_appointmentTotal_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void employee_name_lbl_Click(object sender, EventArgs e)
        {

        }
        public string EmployeeName
        {
            get => employee_name_lbl.Text;
            set => employee_name_lbl.Text = value;
        }

        public string EmployeeDesignation
        {
            get => employee_designation_lbl.Text;
            set => employee_designation_lbl.Text = value;
        }

        private void employee_schedule_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadPendingAppointments()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
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
                        employee_schedule_gridView.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading appointments: " + ex.Message);
                }
            }
        }

        private void employee_scheduleMarkAsDone_btn_Click(object sender, EventArgs e)
        {
            if (employee_schedule_gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to mark as done.");
                return;
            }

            int appointmentId = Convert.ToInt32(employee_schedule_gridView.SelectedRows[0].Cells["Appointment_Id"].Value);
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // ✅ First, get the grand total of the appointment
                    decimal grandTotal = 0;
                    string selectQuery = "SELECT Appointment_Grand_Total FROM appointment WHERE Appointment_Id = @appointmentId";

                    using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                        object result = selectCmd.ExecuteScalar();

                        if (result != null && decimal.TryParse(result.ToString(), out grandTotal))
                        {
                            // ✅ Then, update the appointment status
                            string updateQuery = "UPDATE appointment SET Appointment_Status = 'Complete' WHERE Appointment_Id = @appointmentId";
                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                                int rowsAffected = updateCmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // ✅ Insert into income table
                                    string insertIncomeQuery = @"
                                INSERT INTO income (Income_Source, Income_Amount, Income_Date, Income_Appointment_Id)
                                VALUES ('Appointment', @amount, @date, @appointmentId)";

                                    using (MySqlCommand incomeCmd = new MySqlCommand(insertIncomeQuery, conn))
                                    {
                                        incomeCmd.Parameters.AddWithValue("@amount", grandTotal);
                                        incomeCmd.Parameters.AddWithValue("@date", DateTime.Now.Date); // Current date
                                        incomeCmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                                        incomeCmd.ExecuteNonQuery(); // Insert into income table
                                    }

                                    MessageBox.Show("Appointment marked as complete and income recorded.");
                                    LoadPendingAppointments(); // Refresh grid
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update the appointment status.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Could not retrieve appointment total.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void SearchCarByNumberOrCnic(string searchInput)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 1. Find all clients with matching car number or CNIC
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
                                    // For now, just use first match to update the labels (optional)
                                    if (clientIds.Count == 0)
                                    {
                                        employee_carNumber_lbl.Text = reader["Client_Car_Number"].ToString();
                                        employee_ownerName_lbl.Text = reader["Client_Name"].ToString();
                                        employee_address_lbl.Text = reader["Client_Address"].ToString();
                                        employee_phoneNumber_lbl.Text = reader["Client_Phone"].ToString();
                                        employee_model_lbl.Text = reader["Client_Car_Model"].ToString();
                                        employee_make_lbl.Text = reader["Client_Car_Make"].ToString();
                                        employee_Year_lbl.Text = reader["Client_Car_Year"].ToString();
                                        employee_color_lbl.Text = reader["Client_Car_Color"].ToString();
                                    }

                                    clientIds.Add(Convert.ToInt32(reader["Client_Id"]));
                                }
                            }
                            else
                            {
                                MessageBox.Show("No client found with that car number or CNIC.");

                                // Clear labels
                                employee_carNumber_lbl.Text = "";
                                employee_ownerName_lbl.Text = "";
                                employee_address_lbl.Text = "";
                                employee_phoneNumber_lbl.Text = "";
                                employee_model_lbl.Text = "";
                                employee_make_lbl.Text = "";
                                employee_Year_lbl.Text = "";
                                employee_color_lbl.Text = "";
                                employee_servicesDone_lbl.Text = "";
                                employee_searchGridView.DataSource = null;
                                return;
                            }
                        }
                    }

                    // 2. Fetch all appointments for these client IDs
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
                        employee_searchGridView.DataSource = dt;

                        // Set service count
                        employee_servicesDone_lbl.Text = dt.Rows.Count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching: " + ex.Message);
                }
            }
        }



        private void employee_searchBar_btn_Click(object sender, EventArgs e)
                {
                    string carNumberOrCnic = employee_search_tb.Text.Trim();
                    if (!string.IsNullOrEmpty(carNumberOrCnic))
                    {
                        SearchCarByNumberOrCnic(carNumberOrCnic);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a car number to search.");
                    }
                }

                private void employee_searchGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {

                }
        private void SaveAiDetection(string issue, string suggestion)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO ai_detections (Ai_Issue, Ai_Suggestion, Ai_Date) 
                             VALUES (@issue, @suggestion, @date)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@issue", issue);
                        cmd.Parameters.AddWithValue("@suggestion", suggestion);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("AI Detection saved successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving AI detection: " + ex.Message);
                }
            }
        }

        private void aiDetection_RunAi_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty( aiImagePath))
            {
                MessageBox.Show("Please upload an image.");
                return;
            }

            var (issue, suggestion) = RunAiModel(aiImagePath);

            aiDetection_DetectedIssues_lbl.Text = issue;
            aiDetection_SuggestedServices_lbl.Text = suggestion;

            SaveAiDetection(issue, suggestion);
        }
        private (string issue, string suggestion) RunAiModel(string imagePath)
        {
            string pythonExe = @"C:\Program Files\Python310\python.exe"; // Update this path
            string scriptPath = @"C:\Users\abbas\OneDrive\Desktop\FYP_PROJECT\Ai Script\predict_car_damage.py"; // Update this path

            ProcessStartInfo start = new ProcessStartInfo
            {
                FileName = pythonExe,
                Arguments = $"\"{scriptPath}\" \"{imagePath}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(start))
            {
                process.WaitForExit();  // Wait for python to finish

                string error = process.StandardError.ReadToEnd();
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Python error: " + error);
                    return ("Error", "Error");
                }

                string resultJson = process.StandardOutput.ReadToEnd();

                var jsonDoc = JsonDocument.Parse(resultJson);
                string issue = jsonDoc.RootElement.GetProperty("issue").GetString();
                string suggestion = jsonDoc.RootElement.GetProperty("suggestion").GetString();

                return (issue, suggestion);
            }
        }

        private void employee_appointmentPrint_btn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            var marginBounds = e.MarginBounds;
            int pageWidth = marginBounds.Width;
            int pageHeight = marginBounds.Height;
            int startX = marginBounds.Left;
            int startY = marginBounds.Top;
            int y = startY;

            // 1. Draw bigger logo centered at top (250x250)
            int logoWidth = 250;      // increased size
            int logoHeight = 250;
            int logoX = startX + (pageWidth - logoWidth) / 2;
            g.DrawImage(logoImage, new Rectangle(logoX, y, logoWidth, logoHeight));
            y += logoHeight + 10;

            // 2. Draw header "Appointment Details"
            using (Font headerFont = new Font("Arial", 24, FontStyle.Bold))
            {
                SizeF headerSize = g.MeasureString("Appointment Details", headerFont);
                g.DrawString("Appointment Details", headerFont, Brushes.DarkBlue, startX + (pageWidth - headerSize.Width) / 2, y);
                y += (int)headerSize.Height + 20;
            }

            using (Font detailsFont = new Font("Arial", 12))
            {
                int lineHeight = (int)g.MeasureString("A", detailsFont).Height + 5;

                // Prepare your strings
                string appointmentDate = employee_appointmentDate_datePicker.Value.ToShortDateString();

                string ownerName = employee_appointmentOwnerName_tb.Text;
                string cnic = employee_appointmentCnic_tb.Text;
                string phone = employee_appointmentPhone_tb.Text;
                string address = employee_appointmentAddress_tb.Text;
                string carNumber = employee_appointmentCarNumber_tb.Text;
                string make = employee_appointmentMake_tb.Text;
                string carModel = employee_appointmentCarModel_tb.Text;
                string color = employee_appointmentColor_tb.Text;
                string year = employee_appointmentYear_tb.Text;

                var paymentMethods = employee_appointmentPaymentMethod_listBox.SelectedItems;
                string paymentMethodsStr = string.Join(", ", paymentMethods.Cast<string>());

                var employeeNames = employee_appointmentEmployeeName_listBox.SelectedItems;
                string employeeNamesStr = string.Join(", ", employeeNames.Cast<string>());

                List<string> selectedServices = new List<string>();
                for (int i = 0; i < employee_appointmentServices_checkListBox.Items.Count; i++)
                {
                    if (employee_appointmentServices_checkListBox.GetItemChecked(i))
                    {
                        selectedServices.Add(employee_appointmentServices_checkListBox.Items[i].ToString());
                    }
                }
                string servicesStr = string.Join(", ", selectedServices);

                string total = employee_appointmentTotal_tb.Text;
                string discount = employee_appointmentDiscount_tb.Text;
                string grandTotal = employee_appointment_GrandTotal_tb.Text;

                // Helper function to draw label and value
                void DrawLine(string label, string value)
                {
                    g.DrawString(label, detailsFont, Brushes.Black, startX + 20, y);
                    g.DrawString(value, detailsFont, Brushes.Black, startX + 180, y);
                    y += lineHeight;
                }

                DrawLine("Appointment Date:", appointmentDate);
                DrawLine("Owner Name:", ownerName);
                DrawLine("CNIC:", cnic);
                DrawLine("Phone:", phone);
                DrawLine("Address:", address);
                DrawLine("Car Number:", carNumber);
                DrawLine("Make:", make);
                DrawLine("Car Model:", carModel);
                DrawLine("Color:", color);
                DrawLine("Year:", year);
                DrawLine("Services:", servicesStr);
                DrawLine("Payment Method(s):", paymentMethodsStr);

                DrawLine("Booked By:", employee_name_lbl.Text);

                DrawLine("Assigned Employee:", employeeNamesStr);  // Changed label from Employee(s)

                y += 20;

                // Draw totals
                int footerStartY = startY + pageHeight - 150;
                int rightMargin = startX + pageWidth - 250;

                using (Font totalFont = new Font("Arial", 14, FontStyle.Bold))
                {
                    g.DrawString("Total:", totalFont, Brushes.Black, rightMargin, footerStartY);
                    g.DrawString(total, totalFont, Brushes.Black, rightMargin + 150, footerStartY);
                    footerStartY += lineHeight + 5;

                    g.DrawString("Discount:", totalFont, Brushes.Black, rightMargin, footerStartY);
                    g.DrawString(discount, totalFont, Brushes.Black, rightMargin + 150, footerStartY);
                    footerStartY += lineHeight + 5;

                    g.DrawString("Grand Total:", totalFont, Brushes.Black, rightMargin, footerStartY);
                    g.DrawString(grandTotal, totalFont, Brushes.Black, rightMargin + 150, footerStartY);
                }

                // Footer text centered at bottom
                string footerText = $"Pristine Shine © {DateTime.Now.Year} All rights reserved";
                using (Font footerFont = new Font("Arial", 10, FontStyle.Italic))
                {
                    SizeF footerSize = g.MeasureString(footerText, footerFont);
                    float footerX = startX + (pageWidth - footerSize.Width) / 2;
                    float footerY = startY + pageHeight - 40;
                    g.DrawString(footerText, footerFont, Brushes.Gray, footerX, footerY);
                }
            }
        }

        private void employee_search_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_clear_btn_Click(object sender, EventArgs e)
        {
            // Clear all client detail labels
            employee_carNumber_lbl.Text = "";
            employee_ownerName_lbl.Text = "";
            employee_address_lbl.Text = "";
            employee_phoneNumber_lbl.Text = "";
            employee_model_lbl.Text = "";
            employee_make_lbl.Text = "";
            employee_Year_lbl.Text = "";
            employee_color_lbl.Text = "";
            employee_servicesDone_lbl.Text = "";

            // Clear DataGridView
            employee_searchGridView.DataSource = null;

            // Optional: if you have a TextBox for entering search input, clear that too
            employee_search_tb.Text = "";

            // Optional: if you have any radio buttons, dropdowns, etc., reset them here
            // e.g., search_type_comboBox.SelectedIndex = -1;

            // Optional: Hide error messages or alerts if shown previously
            // errorLabel.Visible = false;
        }

        private void employee_userEdit_btn_Click(object sender, EventArgs e)
        {
            label58.Hide();
            employee_userPhone_lbl.Hide();
            label59.Hide();
            employee_userCnic_lbl.Hide();
            label56.Hide();
            employee_userEmail_lbl.Hide();
            label57.Hide();
            label40.Hide();
            employee_userSecurityQuestion_lbl.Hide();
            label60.Hide();
            employee_userSecurityAnswer_lbl.Hide();
            LoadUserDataToGrid();
            employee_userEdit_pnl.Show();
        }

        private void employee_userEditBack_btn_Click(object sender, EventArgs e)
        {

            label58.Show();
            employee_userPhone_lbl.Show();
            label59.Show();
            employee_userCnic_lbl.Show();
            label56.Show();
            employee_userEmail_lbl.Show();
            label57.Show();
            label60.Show();
            label40.Show();
            employee_userSecurityQuestion_lbl.Show();
            employee_userSecurityAnswer_lbl.Show();
            employee_userEdit_pnl.Hide();
        }
        private void LoadUserInfoIntoLabels()
        {
            employee_userAccountType_lbl.Text = Session.AccountType;
            employee_user_Name_lbl.Text = Session.Name;
            employee_userUsername_lbl.Text = Session.Username;
            employee_userPassword_lbl.Text = Session.Password; // 🔒 Consider masking it
            employee_userOccupation_lbl.Text = Session.Occupation;
            employee_userPhone_lbl.Text = Session.PhoneNumber;
            employee_userCnic_lbl.Text = Session.Cnic;
            employee_userEmail_lbl.Text = Session.Email;
            employee_userSecurityQuestion_lbl.Text = Session.SecurityQuestion;
            employee_userSecurityAnswer_lbl.Text = Session.SecurityAnswer;
        }

        private void employee_userEdit_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadUserDataToGrid()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    User_Name AS 'Name',
                    User_Email AS 'Email',
                    User_PhoneNumber AS 'Phone Number',
                    User_Password AS 'Password'
                FROM users 
                WHERE User_Cnic = @cnic 
                  AND User_Account_Type = 'Employee'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cnic", Session.Cnic);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            employee_userEdit_gridView.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void employee_userEdit_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    

