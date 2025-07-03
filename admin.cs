using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FYP_PROJECT
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();

            //hiding dashboard panel at startup
            admin_dashboard_pnl.Visible = false;
            admin_search_pnl.Visible = false;
            admin_employee_pnl.Visible = false;
            admin_service_pnl.Visible = false;
            admin_clients_pnl.Visible = false;
            admin_schedule_pnl.Visible = false;
            admin_financialReport_pnl.Visible = false;
            admin_appointment_pnl.Visible = false;
            admin_user_pnl.Visible = false;
            admin_userManagerOtherUsers_pnl.Visible = false;
            admin_userEdit_pnl.Visible = false;
            addExpennse_pnl.Visible = false;
            addService_pnl.Visible = false;
            updateService_pnl.Visible = false;
            // 2 – Mark Welcome as the active choice
            SetActiveButton(admin_welcomePage_btn);
        }
        Bitmap logoImage = Properties.Resources.pristine_shine_logo; // Replace with your actual logo resource
        private string selectedMonthForPrint = "";
        private DataTable incomeTable = new DataTable();
        private DataTable expenseTable = new DataTable();
        private decimal totalIncome = 0;
        private decimal totalExpense = 0;
        private void admin_menu_pnl_Paint(object sender, PaintEventArgs e)
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

        //for animation and active state of button

        private Dictionary<Guna.UI2.WinForms.Guna2Button, float> buttonFontSizes = new Dictionary<Guna.UI2.WinForms.Guna2Button, float>();
        private Guna.UI2.WinForms.Guna2Button currentActiveButton = null;
        private Timer fontAnimationTimer;
        private float animationStep = 0.5f;
        private void SetActiveButton(Guna.UI2.WinForms.Guna2Button activeBtn)
        {
            foreach (Control ctrl in admin_menu_pnl.Controls)
            {
                if (ctrl is Guna.UI2.WinForms.Guna2Button btn)
                {
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

            // Update colors immediately (optional)
            activeBtn.FillColor = Color.FromArgb(128, 128, 255);
            activeBtn.ForeColor = Color.White;
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





        private void admin_Load(object sender, EventArgs e)
        {
            string currentMonth = DateTime.Now.ToString("MMMM");

            // Select current month in comboBox
            admin_financialReportMonthSelection_cb.SelectedItem = currentMonth;

            // Load current month's profit
            LoadMonthlyProfit(currentMonth);
            LoadAllServicesToGrid();
            LoadAllClientsToGrid();
            LoadAlertAppointments();
            LoadExpenseData();
            LoadIncomeData();
            LoadCompletedAppointments();
            LoadAppointmentsThisMonth();
            LoadTodayAppointments();
            LoadAllUsersToGrid();
            LoadLoggedInAdminToGrid();
            LoadAdminInfoToLabels();
        }

        private void admin_dashboard_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            admin_dashboard_pnl.Show();
            admin_search_pnl.Hide();
            admin_employee_pnl.Hide();
            admin_service_pnl.Hide();
            admin_clients_pnl.Hide();
            admin_schedule_pnl.Hide();
            admin_financialReport_pnl.Hide();
            admin_appointment_pnl.Hide();
            admin_user_pnl.Hide();
        }

        private void admin_search_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            admin_dashboard_pnl.Hide();
            admin_search_pnl.Show();
            admin_employee_pnl.Hide();
            admin_service_pnl.Hide();
            admin_clients_pnl.Hide();
            admin_schedule_pnl.Hide();
            admin_financialReport_pnl.Hide();
            admin_appointment_pnl.Hide();
            admin_user_pnl.Hide();
        }

        private void admin_employees_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            admin_dashboard_pnl.Hide();
            admin_search_pnl.Hide();
            admin_employee_pnl.Show();
            admin_service_pnl.Hide();
            admin_clients_pnl.Hide();
            admin_schedule_pnl.Hide();
            admin_financialReport_pnl.Hide();
            admin_appointment_pnl.Hide();
            admin_user_pnl.Hide();
        }

        private void admin_service_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            LoadAllServicesToGrid();
            admin_dashboard_pnl.Hide();
            admin_search_pnl.Hide();
            admin_employee_pnl.Hide();
            admin_service_pnl.Show();
            admin_clients_pnl.Hide();
            admin_schedule_pnl.Hide();
            admin_financialReport_pnl.Hide();
            admin_appointment_pnl.Hide();
            admin_user_pnl.Hide();
        }

        private void admin_client_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            admin_dashboard_pnl.Hide();
            admin_search_pnl.Hide();
            admin_employee_pnl.Hide();
            admin_service_pnl.Hide();
            admin_clients_pnl.Show();
            admin_schedule_pnl.Hide();
            admin_financialReport_pnl.Hide();
            admin_appointment_pnl.Hide();
            admin_user_pnl.Hide();
        }

        private void admin_schedule_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            LoadAlertAppointments();
            admin_dashboard_pnl.Hide();
            admin_search_pnl.Hide();
            admin_employee_pnl.Hide();
            admin_service_pnl.Hide();
            admin_clients_pnl.Hide();
            admin_schedule_pnl.Show();
            admin_financialReport_pnl.Hide();
            admin_appointment_pnl.Hide();
            admin_user_pnl.Hide();
        }

        private void admin_financialReport_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            LoadExpenseData();
            LoadIncomeData();
            admin_dashboard_pnl.Hide();
            admin_search_pnl.Hide();
            admin_employee_pnl.Hide();
            admin_service_pnl.Hide();
            admin_clients_pnl.Hide();
            admin_schedule_pnl.Hide();
            admin_financialReport_pnl.Show();
            admin_appointment_pnl.Hide();
            admin_user_pnl.Hide();
        }

        private void admin_appointment_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            admin_dashboard_pnl.Hide();
            admin_search_pnl.Hide();
            admin_employee_pnl.Hide();
            admin_service_pnl.Hide();
            admin_clients_pnl.Hide();
            admin_schedule_pnl.Hide();
            admin_financialReport_pnl.Hide();
            LoadCompletedAppointments();
            LoadAppointmentsThisMonth();
            LoadTodayAppointments();
            admin_appointment_pnl.Show();
            admin_user_pnl.Hide();
        }

        private void admin_user_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);

            admin_dashboard_pnl.Hide();
            admin_search_pnl.Hide();
            admin_employee_pnl.Hide();
            admin_service_pnl.Hide();
            admin_clients_pnl.Hide();
            admin_schedule_pnl.Hide();
            admin_financialReport_pnl.Hide();
            admin_appointment_pnl.Hide();
            admin_user_pnl.Show();
        }
        // for form animation to avoid flicker while changing the form
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
        private void admin_logOut_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);

            Login_form login
                = new Login_form();
            ShowFormWithFade(login);
        }

        private void admin_closeApplication_btn_Click(object sender, EventArgs e)
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


        private void admin_accountType_lbl_Click(object sender, EventArgs e)
        {

        }

        private void admin_dashboard_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void admin_welcomePage_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            admin_dashboard_pnl.Hide();
            admin_search_pnl.Hide();
            admin_employee_pnl.Hide();
            admin_service_pnl.Hide();
            admin_clients_pnl.Hide();
            admin_schedule_pnl.Hide();
            admin_financialReport_pnl.Hide();
            admin_appointment_pnl.Hide();
            admin_user_pnl.Hide();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadAlertAppointments()
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
                    a.Appointment_Date,
                    a.Appointment_Total,
                    a.Appointment_Grand_Total,
                    a.Appointment_Pay_Method,
                    a.Appointment_Status,
                    c.Client_Name,
                    c.Client_Phone,
                    c.Client_Car_Number,
                    c.Client_Car_Model,
                    c.Client_Car_Make,
                    c.Client_Car_Year
                FROM 
                    appointment a
                INNER JOIN 
                    clients c ON a.Appointment_Client_Id = c.Client_id
                WHERE 
                    a.Appointment_Alert = '1'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        admin_schedule_gridView.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading alert appointments: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadIncomeData()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    a.Appointment_Id AS 'Appointment ID',
                    c.Client_Name AS 'Client Name',
                    a.Appointment_Date AS 'Date',
                    a.Appointment_Grand_Total AS 'Grand Total',
                    a.Appointment_Pay_Method AS 'Payment Method',
                    a.Appointment_Status AS 'Status'
                FROM appointment a
                INNER JOIN clients c ON a.Appointment_Client_Id = c.Client_Id
                WHERE a.Appointment_Grand_Total > 0";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        admin_financialReportIncome_gridView.DataSource = dt;

                        // Optional styling
                        admin_financialReportIncome_gridView.Columns["Grand Total"].DefaultCellStyle.Format = "C0"; // Currency format
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading income data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admin_userEdit_btn_Click(object sender, EventArgs e)
        {
            phone_lbl.Hide();
            admin_userPhone_lbl.Hide();
            cnic_lbl.Hide();
            admin_userCnic_lbl.Hide();
            email_lbl.Hide();
            admin_userEmail_lbl.Hide();
            securityQ_lbl.Hide();
            admin_userSecurityQuestion_lbl.Hide();
            securityA_lbl.Hide();
            admin_userSecurityAnswer_lbl.Hide();
            LoadLoggedInAdminToGrid();
            admin_userEdit_pnl.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LoadAllUsersToGrid();
            LoadLoggedInAdminToGrid();
            LoadAdminInfoToLabels();
            phone_lbl.Show();
            admin_userPhone_lbl.Show();
            cnic_lbl.Show();
            admin_userCnic_lbl.Show();
            email_lbl.Show();
            admin_userEmail_lbl.Show();
            securityQ_lbl.Show();
            admin_userSecurityQuestion_lbl.Show();
            securityA_lbl.Show();
            admin_userSecurityAnswer_lbl.Show();
            admin_userEdit_pnl.Hide();
            admin_userManagerOtherUsers_pnl.Hide();
        }

        private void admin_userManageOtherUsers_btn_Click(object sender, EventArgs e)
        {
            phone_lbl.Hide();
            admin_userPhone_lbl.Hide();
            cnic_lbl.Hide();
            admin_userCnic_lbl.Hide();
            email_lbl.Hide();
            admin_userEmail_lbl.Hide();
            securityQ_lbl.Hide();
            admin_userSecurityQuestion_lbl.Hide();
            securityA_lbl.Hide();
            admin_userSecurityAnswer_lbl.Hide();
            LoadAllUsersToGrid();
            admin_userEdit_pnl.Hide();
            admin_userManagerOtherUsers_pnl.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            LoadAllUsersToGrid();
            LoadLoggedInAdminToGrid();
            LoadAdminInfoToLabels();
            phone_lbl.Show();
            admin_userPhone_lbl.Show();
            cnic_lbl.Show();
            admin_userCnic_lbl.Show();
            email_lbl.Show();
            admin_userEmail_lbl.Show();
            securityQ_lbl.Show();
            admin_userSecurityQuestion_lbl.Show();
            securityA_lbl.Show();
            admin_userSecurityAnswer_lbl.Show();
            admin_userEdit_pnl.Hide();
            admin_userManagerOtherUsers_pnl.Hide();
        }

        private void employee_accountType_lbl_Click(object sender, EventArgs e)
        {

        }

        private void admin_designation_lbl_Click(object sender, EventArgs e)
        {

        }

        private void admin_name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void admin_appointmentCompletedToday_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadCompletedAppointments()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    a.Appointment_Id AS 'ID',
                    c.Client_Name AS 'Client Name',
                    a.Appointment_Date AS 'Date',
                    a.Appointment_Total AS 'Total',
                    a.Appointment_Discount AS 'Discount',
                    a.Appointment_Grand_Total AS 'Grand Total',
                    a.Appointment_Pay_Method AS 'Payment Method',
                    a.Appointment_Status AS 'Status'
                FROM appointment a
                INNER JOIN clients c ON a.Appointment_Client_Id = c.Client_Id
                WHERE a.Appointment_Status = 'Complete'
                ORDER BY a.Appointment_Date DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        admin_appointmentCompletedToday_gridView.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading completed appointments:\n" + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void admin_appointmentThisMonth_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadAppointmentsThisMonth()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    a.Appointment_Id AS 'ID',
                    c.Client_Name AS 'Client Name',
                    a.Appointment_Date AS 'Date',
                    a.Appointment_Total AS 'Total',
                    a.Appointment_Discount AS 'Discount',
                    a.Appointment_Grand_Total AS 'Grand Total',
                    a.Appointment_Pay_Method AS 'Payment Method',
                    a.Appointment_Status AS 'Status'
                FROM appointment a
                INNER JOIN clients c ON a.Appointment_Client_Id = c.Client_Id
                WHERE MONTH(a.Appointment_Date) = MONTH(CURDATE())
                  AND YEAR(a.Appointment_Date) = YEAR(CURDATE())
                ORDER BY a.Appointment_Date DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        admin_appointmentThisMonth_gridview.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading this month's appointments:\n" + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void admin_appointmentTodayAppointment_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadTodayAppointments()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    a.Appointment_Id AS 'ID',
                    c.Client_Name AS 'Client Name',
                    a.Appointment_Date AS 'Date',
                    a.Appointment_Total AS 'Total',
                    a.Appointment_Discount AS 'Discount',
                    a.Appointment_Grand_Total AS 'Grand Total',
                    a.Appointment_Pay_Method AS 'Payment Method',
                    a.Appointment_Status AS 'Status'
                FROM appointment a
                INNER JOIN clients c ON a.Appointment_Client_Id = c.Client_Id
                WHERE DATE(a.Appointment_Date) = CURDATE()
                ORDER BY a.Appointment_Date DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        admin_appointmentTodayAppointment_gridView.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading today's appointments:\n" + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void admin_editOtherUsers_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadAllUsersToGrid()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    User_Employee_Id AS 'Employee ID',
                    User_Account_Type AS 'Account Type',
                    User_Name AS 'Name',
                    User_UserName AS 'Username',
                    User_Password AS 'Password',
                    User_Occupation AS 'Occupation',
                    User_Email AS 'Email',
                    User_PhoneNumber AS 'Phone Number',
                    User_Cnic AS 'CNIC',
                    User_SecurityQuestions AS 'Security Question',
                    User_SecurityAnswer AS 'Security Answer'
                FROM users";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            admin_editOtherUsers_gridView.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading users: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void admin_userEdit_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadAdminInfoToLabels()
        {
            admin_accountType_lbl.Text = Session.AccountType;
            admin_user_Name_lbl.Text = Session.Name;
            admin_userUsername_lbl.Text = Session.Username;
            admin_userPassword_lbl.Text = Session.Password;
            admin_userOccupation_lbl.Text = Session.Occupation;
            admin_userPhone_lbl.Text = Session.PhoneNumber;
            admin_userCnic_lbl.Text = Session.Cnic;
            admin_userEmail_lbl.Text = Session.Email;
            admin_userSecurityQuestion_lbl.Text = Session.SecurityQuestion;
            admin_userSecurityAnswer_lbl.Text = Session.SecurityAnswer;
        }
        private void LoadLoggedInAdminToGrid()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    User_Account_Type AS 'Account Type',
                    User_Name AS 'Name',
                    User_UserName AS 'Username',
                    User_Password AS 'Password',
                    User_Occupation AS 'Occupation',
                    User_Email AS 'Email',
                    User_PhoneNumber AS 'Phone Number',
                    User_Cnic AS 'CNIC',
                    User_SecurityQuestions AS 'Security Question',
                    User_SecurityAnswer AS 'Security Answer'
                FROM users 
                WHERE User_Cnic = @cnic AND User_Account_Type = 'Admin'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cnic", Session.Cnic);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            admin_userEdit_gridView.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading logged-in admin data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void admin_financialReportExpenses_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadExpenseData()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    Expense_Id AS 'ID',
                    Expense_Discription AS 'Description',
                    Expense_Amount AS 'Amount (Rs)',
                    Expense_Date AS 'Date'
                FROM expenses
                ORDER BY Expense_Date DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        admin_financialReportExpenses_gridView.DataSource = dt;

                        // Optional styling
                        admin_financialReportExpenses_gridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                        admin_financialReportExpenses_gridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                        admin_financialReportExpenses_gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading expense data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void admin_financialReportProfit_lbl_Click(object sender, EventArgs e)
        {

        }

        private void admin_financialReportMonthSelection_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (admin_financialReportMonthSelection_cb.SelectedItem != null)
            {
                string selectedMonth = admin_financialReportMonthSelection_cb.SelectedItem.ToString();
                LoadMonthlyProfit(selectedMonth);
            }
        }
        private void LoadMonthlyProfit(string monthName)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";
            int selectedMonth = DateTime.ParseExact(monthName, "MMMM", null).Month;
            int currentYear = DateTime.Now.Year;

            decimal totalIncome = 0;
            decimal totalExpense = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Total income for the selected month
                    string incomeQuery = @"SELECT IFNULL(SUM(Income_Amount), 0) 
                            FROM income 
                            WHERE MONTH(Income_Date) = @month AND YEAR(Income_Date) = @year";

                    using (MySqlCommand incomeCmd = new MySqlCommand(incomeQuery, conn))
                    {
                        incomeCmd.Parameters.AddWithValue("@month", selectedMonth);
                        incomeCmd.Parameters.AddWithValue("@year", currentYear);
                        totalIncome = Convert.ToDecimal(incomeCmd.ExecuteScalar());
                    }

                    // Total expense for the selected month
                    string expenseQuery = @"SELECT IFNULL(SUM(Expense_Amount), 0) 
                             FROM expenses 
                             WHERE MONTH(Expense_Date) = @month AND YEAR(Expense_Date) = @year";

                    using (MySqlCommand expenseCmd = new MySqlCommand(expenseQuery, conn))
                    {
                        expenseCmd.Parameters.AddWithValue("@month", selectedMonth);
                        expenseCmd.Parameters.AddWithValue("@year", currentYear);
                        totalExpense = Convert.ToDecimal(expenseCmd.ExecuteScalar());
                    }


                    // Calculate profit
                    decimal profit = totalIncome - totalExpense;
                    admin_financialReportProfit_lbl.Text = "Rs " + profit.ToString("N0"); // Format as thousands
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error calculating profit: " + ex.Message);
                }
            }
        }

        private void admin_financialReportPrint_btn_Click(object sender, EventArgs e)
        {
            if (admin_financialReportMonthSelection_cb.SelectedItem == null)
            {
                MessageBox.Show("Please select a month first.");
                return;
            }

            selectedMonthForPrint = admin_financialReportMonthSelection_cb.SelectedItem.ToString();
            int month = DateTime.ParseExact(selectedMonthForPrint, "MMMM", null).Month;
            int year = DateTime.Now.Year;

            incomeTable.Clear();
            expenseTable.Clear();
            totalIncome = 0;
            totalExpense = 0;

            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Fetch income
                    string incomeQuery = @"SELECT Income_Id, Income_Source, Income_Amount, Income_Date, Income_Appointment_Id 
                       FROM income 
                       WHERE MONTH(Income_Date) = @month AND YEAR(Income_Date) = @year";

                    using (MySqlCommand cmd = new MySqlCommand(incomeQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(incomeTable);
                        }

                        foreach (DataRow row in incomeTable.Rows)
                        {
                            totalIncome += Convert.ToDecimal(row["Income_Amount"]);
                        }
                    }

                    // Fetch expenses
                    string expenseQuery = @"SELECT Expense_Id, Expense_Discription, Expense_Amount, Expense_Date 
                        FROM expenses 
                        WHERE MONTH(Expense_Date) = @month AND YEAR(Expense_Date) = @year";

                    using (MySqlCommand cmd = new MySqlCommand(expenseQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(expenseTable);
                        }

                        foreach (DataRow row in expenseTable.Rows)
                        {
                            totalExpense += Convert.ToDecimal(row["Expense_Amount"]);
                        }
                    }

                    // Show print preview
                    PrintDocument doc = new PrintDocument();
                    doc.PrintPage += PrintFinancialReport;
                    PrintPreviewDialog preview = new PrintPreviewDialog
                    {
                        Document = doc,
                        Width = 1000,
                        Height = 800
                    };
                    preview.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching data: " + ex.Message);
                }
            }
        }

        private void PrintFinancialReport(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int y = 40;
            int pageWidth = e.PageBounds.Width;
            int margin = 50;
            int lineHeight = 30;

            // 1. Logo
            if (logoImage != null)
            {
                int logoWidth = 120;
                int logoHeight = 120;
                int logoX = (pageWidth - logoWidth) / 2;
                g.DrawImage(logoImage, new Rectangle(logoX, y, logoWidth, logoHeight));
                y += logoHeight + 10;
            }

            // 2. Title
            using (Font headerFont = new Font("Segoe UI", 20, FontStyle.Bold))
            {
                string title = $"Financial Report - {selectedMonthForPrint}";
                SizeF size = g.MeasureString(title, headerFont);
                g.DrawString(title, headerFont, Brushes.DarkBlue, (pageWidth - size.Width) / 2, y);
                y += (int)size.Height + 20;
            }

            // 3. Income Section
            using (Font sectionFont = new Font("Segoe UI", 14, FontStyle.Bold))
            {
                g.DrawString("Income", sectionFont, Brushes.Green, margin, y);
                y += lineHeight;
            }

            using (Font itemFont = new Font("Segoe UI", 11))
            {
                foreach (DataRow row in incomeTable.Rows)
                {
                    string id = row["Income_Id"].ToString();
                    string source = row["Income_Source"].ToString();
                    string date = Convert.ToDateTime(row["Income_Date"]).ToShortDateString();
                    string amount = Convert.ToDecimal(row["Income_Amount"]).ToString("N0");
                    string appId = row["Income_Appointment_Id"] != DBNull.Value ? row["Income_Appointment_Id"].ToString() : "N/A";

                    string line = $"ID: {id} | {date} | Source: {source} | Amount: Rs {amount} | Appointment ID: {appId}";
                    g.DrawString(line, itemFont, Brushes.Black, margin, y);
                    y += lineHeight;
                }

                y += 10;
                g.DrawString($"Total Income Entries: {incomeTable.Rows.Count}", itemFont, Brushes.Black, margin, y);
                y += lineHeight;
                g.DrawString($"Total Income Amount: Rs {totalIncome.ToString("N0")}", itemFont, Brushes.DarkGreen, margin, y);
                y += lineHeight + 10;
            }

            // Divider
            g.DrawLine(Pens.Gray, margin, y, pageWidth - margin, y);
            y += 15;

            // 4. Expense Section
            using (Font sectionFont = new Font("Segoe UI", 14, FontStyle.Bold))
            {
                g.DrawString("Expenses", sectionFont, Brushes.Red, margin, y);
                y += lineHeight;
            }

            using (Font itemFont = new Font("Segoe UI", 11))
            {
                foreach (DataRow row in expenseTable.Rows)
                {
                    string id = row["Expense_Id"].ToString();
                    string desc = row["Expense_Discription"].ToString();
                    string date = Convert.ToDateTime(row["Expense_Date"]).ToShortDateString();
                    string amount = Convert.ToDecimal(row["Expense_Amount"]).ToString("N0");

                    string line = $"ID: {id} | {date} | Description: {desc} | Amount: Rs {amount}";
                    g.DrawString(line, itemFont, Brushes.Black, margin, y);
                    y += lineHeight;
                }

                y += 10;
                g.DrawString($"Total Expense Entries: {expenseTable.Rows.Count}", itemFont, Brushes.Black, margin, y);
                y += lineHeight;
                g.DrawString($"Total Expense Amount: Rs {totalExpense.ToString("N0")}", itemFont, Brushes.DarkRed, margin, y);
                y += lineHeight + 10;
            }

            // 5. Net Profit
            decimal profit = totalIncome - totalExpense;
            using (Font profitFont = new Font("Segoe UI", 14, FontStyle.Bold))
            {
                string profitText = $"Net Profit: Rs {profit.ToString("N0")}";
                g.DrawString(profitText, profitFont, Brushes.DarkBlue, margin, y);
                y += lineHeight;
            }

            // 6. Footer
            using (Font footerFont = new Font("Segoe UI", 9, FontStyle.Italic))
            {
                string footer = $"Pristine Shine © {DateTime.Now.Year} All rights reserved";
                SizeF footerSize = g.MeasureString(footer, footerFont);
                g.DrawString(footer, footerFont, Brushes.Gray, (pageWidth - footerSize.Width) / 2, e.PageBounds.Height - 50);
            }
        }

        private void admin_financialReportExpenses_btn_Click(object sender, EventArgs e)
        {
            addExpennse_pnl.Show();
        }

        private void addExpenseBack_btn_Click(object sender, EventArgs e)
        {
            // Validate input first
            if (string.IsNullOrWhiteSpace(expenseDiscription_tb.Text) || string.IsNullOrWhiteSpace(expenseAmount_tb.Text))
            {
                MessageBox.Show("Please enter both description and amount.");
                return;
            }

            if (!decimal.TryParse(expenseAmount_tb.Text.Trim(), out decimal amount))
            {
                MessageBox.Show("Please enter a valid numeric amount.");
                return;
            }

            string description = expenseDiscription_tb.Text.Trim();

            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO expenses (Expense_Discription, Expense_Amount, Expense_Date) VALUES (@desc, @amount, @date)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@desc", description);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Expense added successfully.");

                        // Optional: clear input fields
                        expenseDiscription_tb.Clear();
                        expenseAmount_tb.Clear();

                        // Hide the panel
                        addExpennse_pnl.Hide();

                        // Optional: Reload expense grid if you have a method for that
                        LoadExpenseData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding expense: " + ex.Message);
                }
            }
        }

        private void admin_scheduleTurnOffAlert_Click(object sender, EventArgs e)
        {
            if (admin_schedule_gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment from the grid.");
                return;
            }

            // Get Appointment_Id from selected row
            int appointmentId = Convert.ToInt32(admin_schedule_gridView.SelectedRows[0].Cells["Appointment_Id"].Value);

            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE appointment SET Appointment_Alert = '0' WHERE Appointment_Id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", appointmentId);
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Alert turned off successfully.");
                            LoadAlertAppointments(); // Refresh grid if needed
                        }
                        else
                        {
                            MessageBox.Show("No appointment updated. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating alert: " + ex.Message);
                }
            }
        }

        private void admin_scheduleSendAlert_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";
            int successCount = 0;
            int failCount = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT a.Appointment_Id, c.Client_Name, c.Client_Phone, c.Client_Car_Model
                             FROM appointment a
                             JOIN clients c ON a.Appointment_Client_Id = c.Client_id
                             WHERE a.Appointment_Alert = '1'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string clientName = reader["Client_Name"].ToString();
                            string clientPhone = reader["Client_Phone"].ToString();
                            string clientCarModel = reader["Client_Car_Model"].ToString();

                            string message = $"Dear {clientName}, it's time for your car ({clientCarModel})'s next service. To extend its life and maintain performance, book an appointment with Pristine Shine today!";

                            if (SendSms(clientPhone, message, out string error))
                            {
                                successCount++;
                            }
                            else
                            {
                                failCount++;
                                Console.WriteLine($"Failed to send to {clientPhone}: {error}");
                            }
                        }
                    }

                    MessageBox.Show($"SMS sending complete.\nSuccess: {successCount}\nFailed: {failCount}", "SMS Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending alerts:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private bool SendSms(string toNumber, string messageBody, out string errorMessage)
        {
            errorMessage = "";
            try
            {
                using (var client = new HttpClient())
                {
                    var values = new Dictionary<string, string>
            {
                { "mocean-api-key", "1f2fbc99" },
                { "mocean-api-secret", "8f6ea851" },
                { "mocean-from", "Fazi420" },
                { "mocean-to", toNumber },
                { "mocean-text", messageBody }
            };

                    var content = new FormUrlEncodedContent(values);
                    var response = client.PostAsync("https://rest.moceanapi.com/rest/2/sms", content).Result;
                    var responseString = response.Content.ReadAsStringAsync().Result;

                    // ✅ Parse <status> tag from XML
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(responseString);
                    XmlNode statusNode = doc.SelectSingleNode("//status");

                    if (statusNode != null && statusNode.InnerText == "0")
                    {
                        return true; // Success
                    }
                    else
                    {
                        errorMessage = "Mocean response status is not 0:\n" + responseString;
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Exception: " + ex.Message;
                return false;
            }
        }

        private void admin_client_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadAllClientsToGrid()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT 
                                Client_id AS 'ID',
                                Client_Name AS 'Name',
                                Client_Phone AS 'Phone',
                                Client_Address AS 'Address',
                                Client_Cnic AS 'CNIC',
                                Client_Car_Number AS 'Car Number',
                                Client_Car_Model AS 'Car Model',
                                Client_Car_Make AS 'Car Make',
                                Client_Car_Year AS 'Car Year',
                                Client_Car_Color AS 'Car Color'
                            FROM clients";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        admin_client_gridView.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading clients: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void admin_service_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadAllServicesToGrid()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT 
                                Service_id AS 'ID',
                                Service_Name AS 'Name',
                                Service_Discription AS 'Description',
                                Service_Price AS 'Price'
                            FROM services";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        admin_service_gridView.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading services: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void admin_serviceAdd_btn_Click(object sender, EventArgs e)
        {
            addService_pnl.Show();
        }

        private void addServiceDone_btn_Click(object sender, EventArgs e)
        {
            string name = addServiceName_tb.Text.Trim();
            string description = addServiceDiscription_tb.Text.Trim();
            string price = addServicePrice_tb.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Please fill all fields before adding the service.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO services (Service_Name, Service_Discription, Service_Price)
                             VALUES (@name, @description, @price)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@price", price);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Service added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Optionally clear fields
                            addServiceName_tb.Clear();
                            addServiceDiscription_tb.Clear();
                            addServicePrice_tb.Clear();

                            // Optionally reload grid view if showing all services
                            LoadAllServicesToGrid();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            addService_pnl.Hide(); // Finally hide the panel
        }

        private void addServiceBack_btn_Click(object sender, EventArgs e)
        {
            addService_pnl.Hide();
        }

        private void updateServiceDone_btn_Click(object sender, EventArgs e)
        {
            string id = updateServiceDone_btn.Tag?.ToString();
            string name = updateServiceName_tb.Text.Trim();
            string description = updateServiceDiscription_tb.Text.Trim();
            string price = updateServicePrice_tb.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("All fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE services 
                             SET Service_Name = @name, 
                                 Service_Discription = @description, 
                                 Service_Price = @price 
                             WHERE Service_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Service updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            updateService_pnl.Hide();
                            LoadAllServicesToGrid(); // Refresh grid view
                        }
                        else
                        {
                            MessageBox.Show("No changes were made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating service:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void admin_serviceUpdate_btn_Click(object sender, EventArgs e)
        {
            if (admin_service_gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a service to update.");
                return;
            }

            DataGridViewRow selectedRow = admin_service_gridView.SelectedRows[0];

            // Use correct column names based on DataPropertyName or aliases used
            updateServiceName_tb.Text = selectedRow.Cells["Name"].Value.ToString();
            updateServiceDiscription_tb.Text = selectedRow.Cells["Description"].Value.ToString();
            updateServicePrice_tb.Text = selectedRow.Cells["Price"].Value.ToString();

            // Store Service_id for later use
            updateServiceDone_btn.Tag = selectedRow.Cells["Id"].Value.ToString();

            updateService_pnl.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            updateService_pnl.Hide();
        }

        private void admin_serviceDelete_btn_Click(object sender, EventArgs e)
        {

            if (admin_service_gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a service to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this service?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            DataGridViewRow selectedRow = admin_service_gridView.SelectedRows[0];
            int serviceId = Convert.ToInt32(selectedRow.Cells["Id"].Value);  // Make sure 'Id' is the correct column name

            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM services WHERE Service_id = @serviceId";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@serviceId", serviceId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Service deleted successfully.");
                            LoadAllServicesToGrid(); // Make sure you have a method to reload the service grid
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the service.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting service: " + ex.Message);
                }
            }
        }
    }
}
