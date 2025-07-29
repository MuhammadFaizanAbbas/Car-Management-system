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
using FYP_PROJECT.Helpers.CommonHelpers;
using FYP_PROJECT.Helpers.EmployeeHelpers;
using Guna.UI2.WinForms;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;


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
            buttonAnimator = new ButtonAnimationHelper(employee_menu_pnl);
            // Mark welcome page button as active using helper
            animationHelper = new ButtonAnimationHelper(employee_menu_pnl); // or employee_menu_pnl
            animationHelper.SetActiveButton(employee_welcomePage_btn); // or employee_welcomePage_btn
            logoImage = Image.FromFile(@"C:\Users\abbas\OneDrive\Desktop\FYP_PROJECT\Image\pristine_shine_logo.png");
            printDocument1.PrintPage += PrintDocument1_PrintPage;
            employee_appointmentDiscount_tb.TextChanged += employee_appointmentDiscount_tb_TextChanged;

        }
        //for animation and active state of button
        private ButtonAnimationHelper buttonAnimator;
        private ButtonAnimationHelper animationHelper;
        string aiImagePath;
        private Image logoImage;
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
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
             buttonAnimator.SetActiveButton((Guna2Button)sender);

            Login_form login
                = new Login_form();
            UIHelper.ShowFormWithFade(this, login);

        }
        private void Empoyee_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.app_icon;
            LoadServices();
            LoadAssignableEmployees();
            LoadPendingAppointments();
            LoadUserInfoIntoLabels();
        }
        private void employee_welcomePage_btn_Click(object sender, EventArgs e)
        {
            buttonAnimator.SetActiveButton((Guna2Button)sender);
            employee_search_pnl.Hide();
            aiDetection_pnl.Hide();
            employee_appointment_pnl.Hide();
            employee_schedule_pnl.Hide();
            employee_user_pnl.Hide();
        }
        private void employee_search_btn_Click(object sender, EventArgs e)
        {
            buttonAnimator.SetActiveButton((Guna2Button)sender);
            employee_search_pnl.Show();
            aiDetection_pnl.Hide();
            employee_schedule_pnl.Hide();
            employee_appointment_pnl.Hide();
            employee_user_pnl.Hide();

        }
        private void employee_aiDetection_btn_Click(object sender, EventArgs e)
        {
            buttonAnimator.SetActiveButton((Guna2Button)sender);
            aiDetection_pnl.Show();
            employee_search_pnl.Hide();
            employee_appointment_pnl.Hide();
            employee_schedule_pnl.Hide();
            employee_user_pnl.Hide();

        }
        private void employee_schedule_btn_Click(object sender, EventArgs e)
        {
            buttonAnimator.SetActiveButton((Guna2Button)sender);
            LoadPendingAppointments();
            employee_schedule_pnl.Show();
            aiDetection_pnl.Hide();
            employee_appointment_pnl.Hide();
            employee_search_pnl.Hide();
            employee_user_pnl.Hide();
        }
        private void employee_appointment_btn_Click(object sender, EventArgs e)
        {
            buttonAnimator.SetActiveButton((Guna2Button)sender);
            employee_schedule_pnl.Hide();
            aiDetection_pnl.Hide();
            employee_search_pnl.Hide();
            employee_appointment_pnl.Show();
            employee_appointmentDetails_pnl.Show();
            employee_user_pnl.Hide();
        }
        private void employee_user_btn_Click(object sender, EventArgs e)
        {
            buttonAnimator.SetActiveButton((Guna2Button)sender);
            LoadUserInfoIntoLabels();
            employee_user_pnl.Show();
            employee_schedule_pnl.Hide();
            aiDetection_pnl.Hide();
            employee_search_pnl.Hide();
            employee_appointment_pnl.Hide();
            employee_appointmentDetails_pnl.Hide();
        }
        private void employee_appointmentProceed_btn_Click(object sender, EventArgs e)
        {
            try
            {
                decimal total = AppointmentHelper.CalculateTotalFromSelectedServices(employee_appointmentServices_checkListBox);
                employee_appointmentTotal_tb.Text = total.ToString("0.00");

                // Set default discount
                employee_appointmentDiscount_tb.Text = "0.00";

                // Calculate and set grand total
                decimal discount = 0;
                decimal grandTotal = total - discount;
                employee_appointment_GrandTotal_tb.Text = grandTotal.ToString("0.00");

                employee_appointmentPayment_pnl.Show();
                employee_appointmentDetails_pnl.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating service total: " + ex.Message);
            }
        }
        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void employee_appointmentDiscount_tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal total = 0;
                decimal.TryParse(employee_appointmentTotal_tb.Text, out total);

                decimal discount = 0;
                decimal.TryParse(employee_appointmentDiscount_tb.Text, out discount);

                if (discount < 0) discount = 0;
                if (discount > total) discount = total;

                decimal grandTotal = total - discount;
                employee_appointment_GrandTotal_tb.Text = grandTotal.ToString("0.00");
            }
            catch
            {
                employee_appointment_GrandTotal_tb.Text = "0.00";
            }
        }

        private void employee_appointmentDone_btn_Click(object sender, EventArgs e)
        {
            // Set summary labels like before (optional, for UI update)
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

            // Call helper method
            AppointmentHelper.SaveAppointment(
                employee_appointmentOwnerName_tb.Text.Trim(),
                employee_appointmentCnic_tb.Text.Trim(),
                employee_appointmentPhone_tb.Text.Trim(),
                employee_appointmentAddress_tb.Text.Trim(),
                employee_appointmentCarNumber_tb.Text.Trim(),
                employee_appointmentMake_tb.Text.Trim(),
                employee_appointmentCarModel_tb.Text.Trim(),
                employee_appointmentColor_tb.Text.Trim(),
                employee_appointmentYear_tb.Text.Trim(),
                employee_appointmentDate_datePicker.Value,
                decimal.Parse(employee_appointmentTotal_tb.Text.Trim()),
                decimal.Parse(employee_appointmentDiscount_tb.Text.Trim()),
                decimal.Parse(employee_appointment_GrandTotal_tb.Text.Trim()),
                employee_appointmentPaymentMethod_listBox.SelectedItem?.ToString() ?? "N/A",
                employee_name_lbl.Text,
                employee_appointmentEmployeeName_listBox.SelectedItem?.ToString() ?? "",
                employee_appointmentServices_checkListBox.CheckedItems.Cast<string>().ToList(),
                employee_name_lbl // just passing for reference, if needed
            );
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
        // To load services in grid
        private void LoadServices()
        {
            AppointmentHelper.LoadServices(employee_appointmentServices_checkListBox, serviceMap);
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
            AppointmentHelper.LoadPendingAppointments(employee_schedule_gridView);
        }
        private void employee_scheduleMarkAsDone_btn_Click(object sender, EventArgs e)
        {

            if (employee_schedule_gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to mark as done.");
                return;
            }

            int appointmentId = Convert.ToInt32(employee_schedule_gridView.SelectedRows[0].Cells["Appointment_Id"].Value);

            AppointmentService service = new AppointmentService();
            if (service.MarkAppointmentAsComplete(appointmentId, out string message))
            {
                MessageBox.Show(message);
                LoadPendingAppointments(); // refresh
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void employee_searchBar_btn_Click(object sender, EventArgs e)
                {
            string input = employee_search_tb.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter car number or CNIC.");
                return;
            }

            CarSearchService searchService = new CarSearchService();
            searchService.SearchAndDisplay(
                input,
                employee_servicesDone_lbl,
                employee_lastServiceDate_lbl,
                employee_searchCarDataGridView,
                employee_searchGridView
            );
        }
        private void employee_searchGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async void aiDetection_RunAi_btn_Click(object sender, EventArgs e)
        {
            if (aiDetection_pictureBox.Image == null)
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            Image resizedImage = ImageAndAIHelpers.ResizeImage(aiDetection_pictureBox.Image, 150, 150);
            string base64Image = ImageAndAIHelpers.ImageToBase64(resizedImage, ImageFormat.Jpeg);

            string apiKey = "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";  // Use your real key here!

            OpenAIResponse result = await OpenAIHelper.GetCarDetailingSuggestionsAsync(base64Image, apiKey);

            if (result != null)
            {
                aiDetection_DetectedIssues_lbl.Text = "Detected Issues:\n" + result.DetectedIssues;
                aiDetection_SuggestedServices_lbl.Text = "Suggested Services:\n" + result.SuggestedServices;

                // Save to database
                DatabaseHelper.SaveAIResultToDatabase(result.DetectedIssues, result.SuggestedServices);
            }
            else
            {
                MessageBox.Show("Failed to get response from AI.");
            }
        }

        private void employee_appointmentPrint_btn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Assign logo image only once (in constructor or form load)
            PrintHelper.LogoImage = logoImage; // logoImage is your image variable

            PrintHelper.PrintAppointment(
                e,
                appointmentDate: employee_appointmentDate_datePicker.Value,
                ownerName: employee_appointmentOwnerName_tb.Text,
                cnic: employee_appointmentCnic_tb.Text,
                phone: employee_appointmentPhone_tb.Text,
                address: employee_appointmentAddress_tb.Text,
                carNumber: employee_appointmentCarNumber_tb.Text,
                make: employee_appointmentMake_tb.Text,
                carModel: employee_appointmentCarModel_tb.Text,
                color: employee_appointmentColor_tb.Text,
                year: employee_appointmentYear_tb.Text,
                services: employee_appointmentServices_checkListBox.CheckedItems.Cast<string>().ToList(),
                paymentMethods: employee_appointmentPaymentMethod_listBox.SelectedItems.Cast<string>().ToList(),
                assignedEmployees: employee_appointmentEmployeeName_listBox.SelectedItems.Cast<string>().ToList(),
                bookedBy: employee_name_lbl.Text,
                total: employee_appointmentTotal_tb.Text,
                discount: employee_appointmentDiscount_tb.Text,
                grandTotal: employee_appointment_GrandTotal_tb.Text
            );
        }
        private void employee_search_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
        private void search_clear_btn_Click(object sender, EventArgs e)
        {
            // Clear the two labels used for search results
            employee_servicesDone_lbl.Text = "";
            employee_lastServiceDate_lbl.Text = "";

            // Clear the two DataGridViews
            employee_searchCarDataGridView.DataSource = null;
            employee_searchGridView.DataSource = null;

            // Clear search textbox (if any)
            employee_search_tb.Text = "";

            // Optional: Reset other UI controls like dropdowns, radio buttons if present
            // e.g., search_type_comboBox.SelectedIndex = -1;

            // Optional: Hide any error or info labels if shown previously
            // errorLabel.Visible = false;
        }
        private void employee_userEdit_btn_Click(object sender, EventArgs e)
        {


            employeeEditName_tb.Text = Session.Name;
            employeeEditPassword_tb.Text = Session.Password;
            employeeEditEmail_tb.Text = Session.Email;
            employeeEditPhone_tb.Text = Session.PhoneNumber;
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
            employee_userEdit_pnl.Show();
        }
        private void employee_userEditBack_btn_Click(object sender, EventArgs e)
        {


            employeeEditName_tb.Text = Session.Name;
            employeeEditPassword_tb.Text = Session.Password;
            employeeEditEmail_tb.Text = Session.Email;
            employeeEditPhone_tb.Text = Session.PhoneNumber;

            // (Optional) hide labels if needed
            label58.Show(); employee_userPhone_lbl.Show();
            label59.Show(); employee_userCnic_lbl.Show();
            label56.Show(); employee_userEmail_lbl.Show();
            label57.Show(); label40.Show();
            employee_userSecurityQuestion_lbl.Show();
            label60.Show(); employee_userSecurityAnswer_lbl.Show();

            employee_userEdit_pnl.Hide();
        }
        //for user page
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
   
        //To upload image in ai panel
        private void aiDetection_UploadImage_btn_Click(object sender, EventArgs e)
        {

            if (ImageHelper.TrySelectImage(out string selectedImagePath, out Image selectedImage, out string errorMessage))
            {
                aiDetection_pictureBox.Image = selectedImage;
                aiDetection_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                aiImagePath = selectedImagePath;
            }
            else
            {
                MessageBox.Show(errorMessage, "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // To load Employees in appointment process
        private void LoadAssignableEmployees()
        {
            employee_appointmentEmployeeName_listBox.Items.Clear();

            var employees = EmployeeHelper.GetAssignableEmployeeNames();

            foreach (var empName in employees)
            {
                employee_appointmentEmployeeName_listBox.Items.Add(empName);
            }
        }
        private void employee_userEdit_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employee_userEditDone_btn_Click(object sender, EventArgs e)
        {
            // Get new values from textboxes
            string newName = employeeEditName_tb.Text.Trim();
            string newPassword = employeeEditPassword_tb.Text.Trim();
            string newEmail = employeeEditEmail_tb.Text.Trim();
            string newPhone = employeeEditPhone_tb.Text.Trim();

            // Use old values from session to find the correct row
            string oldName = Session.Name;
            string oldPassword = Session.Password;
            string oldEmail = Session.Email;
            string oldPhone = Session.PhoneNumber;

            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string updateQuery = @"
                UPDATE users 
                SET 
                    User_Name = @newName,
                    User_Password = @newPassword,
                    User_Email = @newEmail,
                    User_PhoneNumber = @newPhone
                WHERE 
                    User_Name = @oldName AND 
                    User_Password = @oldPassword AND 
                    User_Email = @oldEmail AND 
                    User_PhoneNumber = @oldPhone AND 
                    User_Account_Type = 'Employee'";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        // New values
                        cmd.Parameters.AddWithValue("@newName", newName);
                        cmd.Parameters.AddWithValue("@newPassword", newPassword);
                        cmd.Parameters.AddWithValue("@newEmail", newEmail);
                        cmd.Parameters.AddWithValue("@newPhone", newPhone);

                        // Old values
                        cmd.Parameters.AddWithValue("@oldName", oldName);
                        cmd.Parameters.AddWithValue("@oldPassword", oldPassword);
                        cmd.Parameters.AddWithValue("@oldEmail", oldEmail);
                        cmd.Parameters.AddWithValue("@oldPhone", oldPhone);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Update session
                            Session.Name = newName;
                            Session.Password = newPassword;
                            Session.Email = newEmail;
                            Session.PhoneNumber = newPhone;

                            // (Optional) hide labels if needed
                            label58.Show(); employee_userPhone_lbl.Show();
                            label59.Show(); employee_userCnic_lbl.Show();
                            label56.Show(); employee_userEmail_lbl.Show();
                            label57.Show(); label40.Show();
                            employee_userSecurityQuestion_lbl.Show();
                            label60.Show(); employee_userSecurityAnswer_lbl.Show();

                            employee_userEdit_pnl.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No matching user found or no changes made.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aiDetection_pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
