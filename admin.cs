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
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using System.Xml;
using FYP_PROJECT.Helpers.CommonHelpers;
using FYP_PROJECT.Helpers.AdminHelpers;
using System.Globalization;
using Guna.Charts.WinForms;
using Guna.Charts.Interfaces;

namespace FYP_PROJECT
{
    public partial class admin : Form
    {
        // Create a CultureInfo for Pakistan
        CultureInfo pakCulture = new CultureInfo("ur-PK");
        private ButtonAnimationHelper animationHelper;
        private ButtonAnimationHelper buttonAnimationHelper;
        Bitmap logoImage = Properties.Resources.pristine_shine_logo; // Replace with your actual logo resource
        private string selectedMonthForPrint = "";
        private DataTable incomeTable = new DataTable();
        private DataTable expenseTable = new DataTable();
        private decimal totalIncome = 0;
        private decimal totalExpense = 0;
        public admin()
        {
            InitializeComponent();
            // Format currency (optional usage)
            decimal amount = 12345.67m;
            string formattedAmount = amount.ToString("C", pakCulture);
            // Set up animation helper once
            buttonAnimationHelper = new ButtonAnimationHelper(admin_menu_pnl);
            animationHelper = buttonAnimationHelper;
            // Now initialize UI using helper
            AdminUIInitializer.InitializeUI(this, animationHelper, admin_welcomePage_btn);
        }
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
        private void LoadEmployeeRolePieChart()
        {
            // 1) Get data  ──────────────────────────────
            var roleCounts = EmployeeHelper.GetEmployeeCountByRole();
            if (roleCounts.Count == 0)
            {
                MessageBox.Show("No employee records found.");
                return;
            }

            // 2) Build dataset  ─────────────────────────
            var ds = new GunaPieDataset
            {
                Label = "Employees by Role",
                FillColors = new ColorCollection
        {
            Color.MediumSeaGreen, Color.CornflowerBlue, Color.OrangeRed,
            Color.MediumPurple,  Color.Goldenrod,      Color.Teal,
            Color.SandyBrown,    Color.DarkCyan
        }
            };

            foreach (var kv in roleCounts)          // kv.Key = role, kv.Value = count
                ds.DataPoints.Add(kv.Key, kv.Value);

            // 3) Push to chart  ─────────────────────────
            gunaChart4.Datasets.Clear();
            gunaChart4.Datasets.Add(ds);

            gunaChart4.Legend.Position = LegendPosition.Right;
            gunaChart4.ForeColor = Color.White;   // labels / legend text
            gunaChart4.BackColor = Color.Black;   // match your black panel

            gunaChart4.Update();
        }
        private void admin_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.app_icon;
            string currentMonth = DateTime.Now.ToString("MMMM");
            // Select current month in comboBox
            admin_financialReportMonthSelection_cb.SelectedItem = currentMonth;
            admin_name_lbl.Text = Session.Name;               // Set name from session
            admin_designation_lbl.Text = Session.Occupation; // Set role from session
            // Load current month's profit
            LoadMonthlyProfit(currentMonth);
            //Initialize all required fields on load
            UpdateDashboardLabels();
            LoadEmployees();
            LoadAllServicesToGrid();
            LoadAllClientsToGrid();
            int alertCount = AppointmentHelper.LoadAlertAppointments(admin_schedule_gridView);
            admin_scheduleDueService_lbl.Text = alertCount.ToString();
            LoadExpenseData();
            FinanceHelper.LoadIncomeData(admin_financialReportIncome_gridView);
            LoadCompletedAppointments();
            LoadAppointmentsThisMonth();
            LoadTodayAppointments();
            LoadAllUsersToGrid();
            LoadAdminInfoToLabels();
         

            gunaChart2.YAxes.GridLines.Display = false;
            gunaChart2.XAxes.GridLines.Display = false;
           
            
            gunaChart2.XAxes.GridLines.Display = false;
            gunaChart2.YAxes.GridLines.Display = false;
            gunaChart2.XAxes.Ticks.Font.Size = 10;
           
            
            BuildLast30DaysIncomeBar();   
            LoadIncomePieChart();
            BuildServicesDoneThisMonthBar();
            LoadEmployeeRolePieChart();


        }
        private bool _isClosing = false;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _isClosing = true;              // tell all code to stop touching UI
            base.OnFormClosing(e);
        }
        private void SafeUpdateChart(Guna.Charts.WinForms.GunaChart chart)
        {
            if (_isClosing) return;                     // skip if the form is closing

            if (chart.InvokeRequired)
                chart.Invoke((MethodInvoker)(() => chart.Update()));
            else
                chart.Update();
        }
        private void admin_dashboard_btn_Click(object sender, EventArgs e)
        {
            buttonAnimationHelper.SetActiveButton((Guna2Button)sender);
            gunaChart2.BackColor = Color.Black;
            gunaChart2.ForeColor = Color.White;

            gunaChart2.YAxes.GridLines.Display = false;
            gunaChart2.XAxes.GridLines.Display = false;


            gunaChart2.XAxes.GridLines.Display = false;
            gunaChart2.YAxes.GridLines.Display = false;
            gunaChart2.XAxes.Ticks.Font.Size = 10;
            BuildLast30DaysIncomeBar();
            LoadIncomePieChart();
            BuildServicesDoneThisMonthBar();
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

        private void BuildLast30DaysIncomeBar()
        {
            var data = IncomeHelper.GetLast30DaysIncome(); // label => amount
            if (data.Count == 0)
            {
                MessageBox.Show("No income found for the last 30 days.");
                return;
            }

            // 1) Slim bar dataset – looks like candle stems
            var ds = new GunaBarDataset
            {
                Label = "Last 30 Days Income",
                BarPercentage = 0.15 // super-thin bars for candle style
            };

            // Add data points
            foreach (var kv in data) // kv.Key = "Jul 11", kv.Value = amount
                ds.DataPoints.Add(kv.Key, kv.Value);

            // Set bar colors (optional)
                ds.FillColors = new Guna.Charts.WinForms.ColorCollection
                {
                    Color.DarkOrange, Color.OrangeRed, Color.MediumVioletRed,
                    Color.LightSalmon, Color.Firebrick, Color.Tomato,
                    Color.Crimson, Color.IndianRed
                };

            // 2) Chart styling
            gunaChart2.Datasets.Clear();
            gunaChart2.Datasets.Add(ds);

          
            gunaChart2.Legend.Position = Guna.Charts.WinForms.LegendPosition.Bottom;

            gunaChart2.XAxes.GridLines.Display = false;
            gunaChart2.YAxes.GridLines.Display = false;
            gunaChart2.XAxes.Ticks.Font.Size = 10;
            gunaChart2.XAxes.Ticks.Font.Name = "Segoe UI";
            gunaChart2.YAxes.Ticks.Font.Size = 10;
            gunaChart2.YAxes.Ticks.Font.Name = "Segoe UI";

            gunaChart2.Update();
        }
        private void BuildServicesDoneThisMonthBar()
        {
            var data = IncomeHelper.GetServicesDoneThisMonth(); // Fully qualified static call

            if (data.Count == 0)
            {
                MessageBox.Show("No service records found for this month.");
                return;
            }

            var ds = new GunaBarDataset
            {
                Label = "Services Done This Month",
                BarPercentage = 0.15
            };

            foreach (var kv in data)
                ds.DataPoints.Add(kv.Key, kv.Value);

            ds.FillColors = new Guna.Charts.WinForms.ColorCollection
    {
        Color.MediumSeaGreen, Color.SeaGreen, Color.ForestGreen,
        Color.LightGreen, Color.DarkOliveGreen, Color.OliveDrab,
        Color.YellowGreen, Color.DarkGreen
    };

            gunaChart3.Datasets.Clear();
            gunaChart3.Datasets.Add(ds);
          
            gunaChart3.Legend.Position = Guna.Charts.WinForms.LegendPosition.Bottom;

            gunaChart3.XAxes.GridLines.Display = false;
            gunaChart3.YAxes.GridLines.Display = false;
            gunaChart3.XAxes.Ticks.Font.Size = 10;
            gunaChart3.XAxes.Ticks.Font.Name = "Segoe UI";
            gunaChart3.YAxes.Ticks.Font.Size = 10;
            gunaChart3.YAxes.Ticks.Font.Name = "Segoe UI";

            gunaChart3.Update();
        }

        private void LoadIncomePieChart()
        {
            var incomeData = IncomeHelper.GetYearlyIncomeByMonth();
            double totalIncome = incomeData.Values.Sum();

            if (totalIncome == 0)
            {
                MessageBox.Show("No income data for this year.");
                return;
            }

            var dataset = new GunaPieDataset
            {
                Label = "Monthly Income % (This Year)",
                FillColors = new Guna.Charts.WinForms.ColorCollection
        {
            Color.DarkOrange, Color.OrangeRed, Color.MediumVioletRed,
            Color.LightSalmon, Color.Firebrick, Color.Tomato,
            Color.Crimson, Color.IndianRed, Color.IndianRed,
            Color.LightCoral, Color.Salmon, Color.Peru
        }
            };

            foreach (var entry in incomeData)
            {
                double percent = Math.Round((entry.Value / totalIncome) * 100, 2);
                dataset.DataPoints.Add(entry.Key, percent);
            }

            gunaChart1.Datasets.Clear();
            gunaChart1.Datasets.Add(dataset);
            gunaChart1.Legend.Position = LegendPosition.Right;
                         // white labels/legend
            gunaChart1.Update();
        }
        private void admin_search_btn_Click(object sender, EventArgs e)
        {
            buttonAnimationHelper.SetActiveButton((Guna2Button)sender);
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
            buttonAnimationHelper.SetActiveButton((Guna2Button)sender);
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
            buttonAnimationHelper.SetActiveButton((Guna2Button)sender);
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
            buttonAnimationHelper.SetActiveButton((Guna2Button)sender);
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
            buttonAnimationHelper.SetActiveButton((Guna2Button)sender);
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
            buttonAnimationHelper.SetActiveButton((Guna2Button)sender);
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
            buttonAnimationHelper.SetActiveButton((Guna2Button)sender);
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
            buttonAnimationHelper.SetActiveButton((Guna2Button)sender);
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
        private void admin_logOut_btn_Click(object sender, EventArgs e)
        {
            buttonAnimationHelper.SetActiveButton((Guna2Button)sender);

            Login_form login
                = new Login_form();
            UIHelper.ShowFormWithFade(this, login);
        }
        // close applicaton button
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
        private void admin_dashboard_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void admin_welcomePage_btn_Click(object sender, EventArgs e)
        {
            buttonAnimationHelper.SetActiveButton((Guna2Button)sender);
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
            int alertCount = AppointmentHelper.LoadAlertAppointments(admin_schedule_gridView);
            admin_scheduleDueService_lbl.Text = alertCount.ToString();
        }
        private void LoadIncomeData()
        {
            FinanceHelper.LoadIncomeData(admin_financialReportIncome_gridView);
        }
        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void admin_userEdit_btn_Click(object sender, EventArgs e)
        { // Hide labels (optional UI logic)
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
            // Load data from Session into input controls (TextBoxes and ComboBox)
            adminEditName_tb.Text = Session.Name;
            adminEditUsername_tb.Text = Session.Username;
            adminEditPassword_tb.Text = Session.Password;
            adminEditEmail_tb.Text = Session.Email;
            adminEditPhone_tb.Text = Session.PhoneNumber;
            adminEditCnic_tb.Text = Session.Cnic;
            adminEditOccupation_tb.Text = Session.Occupation;
            adminEditSecurityAnswer_tb.Text = Session.SecurityAnswer;

            // Set selected item for security question ComboBox
            if (adminEditSecurityQuestion_cb.Items.Contains(Session.SecurityQuestion))
            {
                adminEditSecurityQuestion_cb.SelectedItem = Session.SecurityQuestion;
            }
            else
            {
                adminEditSecurityQuestion_cb.Text = Session.SecurityQuestion; // fallback in case it's not in the dropdown
            }

            // Finally show the edit panel
            admin_userEdit_pnl.Show();
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LoadAllUsersToGrid();
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
            AppointmentHelper.LoadCompletedAppointments(admin_appointmentCompletedToday_gridView);
        }
        private void admin_appointmentThisMonth_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadAppointmentsThisMonth()
        {
            AppointmentHelper.LoadAppointmentsThisMonth(admin_appointmentThisMonth_gridview);
        }
        private void admin_appointmentTodayAppointment_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadTodayAppointments()
        {
            AppointmentHelper.LoadTodayAppointments(admin_appointmentTodayAppointment_gridView);
        }
        private void admin_editOtherUsers_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadAllUsersToGrid()
        {
            UserHelper.LoadAllUsersToGrid(admin_editOtherUsers_gridView);
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
        private void admin_financialReportExpenses_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadExpenseData()
        {
            ExpenseHelper.LoadExpenseData(admin_financialReportExpenses_gridView);
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
            ProfitHelper.LoadMonthlyProfit(monthName, admin_financialReportProfit_lbl);
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

            using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
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
                int logoWidth = 240;
                int logoHeight = 240;
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
            using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
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
            admin_serviceDelete_btn.Hide();
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
            admin_serviceDelete_btn.Show();
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

        private void admin_employee_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadEmployees()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";
            string query = "SELECT Employee_id AS 'ID', Employee_Name AS 'Name', Employee_PhoneNumber AS 'Phone', " +
                           "Employee_Email AS 'Email', Employee_Cnic AS 'CNIC', Employee_Role AS 'Role', " +
                           "Employee_Salary AS 'Salary', Employee_Address AS 'Address' FROM employees";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable employeeTable = new DataTable();
                        adapter.Fill(employeeTable);
                        admin_employee_gridView.DataSource = employeeTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employee data: " + ex.Message);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            employeeAdd_pnl.Show();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEmployeeBack_btn_Click(object sender, EventArgs e)
        {
            employeeAdd_pnl.Hide();
        }

        private void addEmployeeDone_btn_Click(object sender, EventArgs e)
        {
            string name = addEmployeeName_tb.Text.Trim();
            string phone = addEmployeeNumber_tb.Text.Trim();
            string email = addEmployeeEmail_tb.Text.Trim();
            string cnic = addEmployeeCnic_tb.Text.Trim();
            string role = addEmployeeRole_tb.Text.Trim();
            string salary = addEmployeeSalary_tb.Text.Trim();
            string address = addEmployeeAddress_tb.Text.Trim();

            // Basic validation
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(cnic) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(salary) ||
                string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";
            string query = @"INSERT INTO employees 
        (Employee_Name, Employee_PhoneNumber, Employee_Email, Employee_Cnic, Employee_Role, Employee_Salary, Employee_Address)
        VALUES (@name, @phone, @email, @cnic, @role, @salary, @address)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@cnic", cnic);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@salary", salary);
                        cmd.Parameters.AddWithValue("@address", address);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee added successfully.");
                            LoadEmployees(); // Refresh employee grid
                            employeeAdd_pnl.Hide(); // Optionally hide panel
                             // ✅ Clear all input fields
                            addEmployeeName_tb.Text = "";
                            addEmployeeNumber_tb.Text = "";
                            addEmployeeEmail_tb.Text = "";
                            addEmployeeCnic_tb.Text = "";
                            addEmployeeRole_tb.Text = "";
                            addEmployeeSalary_tb.Text = "";
                            addEmployeeAddress_tb.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to add employee.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void updateEmployeeBack_btn_Click(object sender, EventArgs e)
        {
            employeeUpdate_pnl.Hide();
        }

        private void employeeUpdate_btn_Click(object sender, EventArgs e)
        {
            if (admin_employee_gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to update.");
                return;
            }

            DataGridViewRow selectedRow = admin_employee_gridView.SelectedRows[0];

            // Populate textboxes with selected data
            updateEmployeeName_tb.Text = selectedRow.Cells["Name"].Value.ToString();
            updateEmployeeNumber_tb.Text = selectedRow.Cells["Phone"].Value.ToString();
            updateEmployeeEmail_tb.Text = selectedRow.Cells["Email"].Value.ToString();
            updateEmployeeCnic_tb.Text = selectedRow.Cells["Cnic"].Value.ToString();
            updateEmployeeRole_tb.Text = selectedRow.Cells["Role"].Value.ToString();
            updateEmployeeSalary_tb.Text = selectedRow.Cells["Salary"].Value.ToString();
            updateEmployeeAddress_tb.Text = selectedRow.Cells["Address"].Value.ToString();

            // Save the ID in Tag for later update
            updateEmployeeDone_btn.Tag = selectedRow.Cells["id"].Value.ToString();

            // Show update panel
            employeeUpdate_pnl.Show();
        }

        private void updateEmployeeDone_btn_Click(object sender, EventArgs e)
        {
            if (updateEmployeeDone_btn.Tag == null)
            {
                MessageBox.Show("No employee selected.");
                return;
            }

            int employeeId = Convert.ToInt32(updateEmployeeDone_btn.Tag);

            string name = updateEmployeeName_tb.Text.Trim();
            string phone = updateEmployeeNumber_tb.Text.Trim();
            string email = updateEmployeeEmail_tb.Text.Trim();
            string cnic = updateEmployeeCnic_tb.Text.Trim();
            string role = updateEmployeeRole_tb.Text.Trim();
            string salary = updateEmployeeSalary_tb.Text.Trim();
            string address = updateEmployeeAddress_tb.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(cnic) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(salary) ||
                string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";
            string query = @"UPDATE employees SET 
                        Employee_Name = @name, 
                        Employee_PhoneNumber = @phone, 
                        Employee_Email = @email,
                        Employee_Cnic = @cnic,
                        Employee_Role = @role,
                        Employee_Salary = @salary,
                        Employee_Address = @address
                     WHERE Employee_id = @id";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@cnic", cnic);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@salary", salary);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@id", employeeId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee updated successfully.");
                            LoadEmployees(); // Refresh grid
                            employeeUpdate_pnl.Hide(); // Hide update panel
                        }
                        else
                        {
                            MessageBox.Show("No changes were made.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating employee: " + ex.Message);
                }
            }

        }

        private void employeeDelete_btn_Click(object sender, EventArgs e)
        {
            if (admin_employee_gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to delete.");
                return;
            }

            // Confirm delete
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult != DialogResult.Yes)
                return;

            // Get Employee_id of selected row
            DataGridViewRow selectedRow = admin_employee_gridView.SelectedRows[0];
            int employeeId = Convert.ToInt32(selectedRow.Cells["id"].Value);

            // Delete from database
            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM employees WHERE Employee_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", employeeId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee deleted successfully.");
                            LoadEmployees(); // Reload the employee grid view
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete employee.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        // Search Button
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

      
        private void UpdateDashboardLabels()
        {
            try
            {
                DashboardSummary summary = DashboardHelper.GetDashboardSummary();

                admin_monthIncome_lbl.Text = summary.ThisMonthIncome.ToString("C", pakCulture);  // Currency format
                admin_yearIncome_lbl.Text = summary.ThisYearIncome.ToString("C", pakCulture);
                admin_totalServiceDone_lbl.Text = summary.TotalServicesDone.ToString();
                admin_totalEmployees_lbl.Text = summary.TotalEmployees.ToString();
                
                admin_totalProfit_lbl.Text = summary.TotalProfit.ToString("C", pakCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update dashboard: " + ex.Message);
            }
        }

        private void admin_userEditDone_btn_Click(object sender, EventArgs e)
        {
            bool success = AdminUpdateHelper.UpdateAdminProfile(
                adminEditName_tb.Text.Trim(),
                adminEditUsername_tb.Text.Trim(),
                adminEditPassword_tb.Text.Trim(),
                adminEditEmail_tb.Text.Trim(),
                adminEditPhone_tb.Text.Trim(),
                adminEditSecurityQuestion_cb.Text.Trim(),
                adminEditSecurityAnswer_tb.Text.Trim()
            );

            if (success)
            {
                MessageBox.Show("Admin profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
            else
            {
                MessageBox.Show("No changes were made.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void admin_totalSalariesAndProfit_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admin_totalProfit_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void admin_monthlySalaries_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void admin_totalServiceAndEmployees_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admin_totalEmployees_lbl_Click(object sender, EventArgs e)
        {

        }

        private void admin_totalServiceDone_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void admin_dashboard_income_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admin_monthIncome_lbl_Click(object sender, EventArgs e)
        {

        }

        private void admin_yearIncome_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void admin_search_pnl_Paint(object sender, PaintEventArgs e)
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void employee_searchGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employee_color_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void employee_Year_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void employee_make_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void employee_model_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employee_phoneNumber_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void employee_address_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void employee_ownerName_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employee_carNumber_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void employee_servicesDone_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void employee_search_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_employee_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeeUpdate_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void updateEmployeeAddress_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateEmployeeSalary_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateEmployeeEmail_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateEmployeeCnic_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateEmployeeRole_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateEmployeeNumber_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateEmployeeName_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeAdd_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void addEmployeeAddress_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEmployeeSalary_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEmployeeEmail_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEmployeeRole_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEmployeeNumber_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEmployeeName_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void admin_service_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addService_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addServicePrice_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void addServiceDiscription_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void addServiceName_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateService_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateServicePrice_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateServiceDiscription_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateServiceName_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void admin_clients_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void admin_schedule_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admin_scheduleDueService_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void admin_financialReport_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addExpennse_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void expenseDiscription_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void expenseAmount_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void admin_appointment_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void admin_user_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admin_userSecurityAnswer_lbl_Click(object sender, EventArgs e)
        {

        }

        private void admin_userSecurityQuestion_lbl_Click(object sender, EventArgs e)
        {

        }

        private void admin_userEmail_lbl_Click(object sender, EventArgs e)
        {

        }

        private void admin_userManagerOtherUsers_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void admin_userCnic_lbl_Click(object sender, EventArgs e)
        {

        }

        private void admin_userPhone_lbl_Click(object sender, EventArgs e)
        {

        }

        private void cnic_lbl_Click(object sender, EventArgs e)
        {

        }

        private void phone_lbl_Click(object sender, EventArgs e)
        {

        }

        private void securityA_lbl_Click(object sender, EventArgs e)
        {

        }

        private void email_lbl_Click(object sender, EventArgs e)
        {

        }

        private void securityQ_lbl_Click(object sender, EventArgs e)
        {

        }

        private void admin_userEdit_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void admin_userOccupation_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void admin_userPassword_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void admin_userUsername_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void admin_user_Name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void admin_userAccountType_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void admin_userManageOtherUsersEdit_btn_Click(object sender, EventArgs e)
        {
            if (admin_editOtherUsers_gridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = admin_editOtherUsers_gridView.SelectedRows[0];

                editUserName_tb.Text = selectedRow.Cells["Name"].Value?.ToString();
                editUserUsername_tb.Text = selectedRow.Cells["Username"].Value?.ToString();
                editUserPassword_tb.Text = selectedRow.Cells["Password"].Value?.ToString();
                editUserEmail_tb.Text = selectedRow.Cells["Email"].Value?.ToString();
                editUserPhone_tb.Text = selectedRow.Cells["Phone Number"].Value?.ToString();
                editUserCnic_tb.Text = selectedRow.Cells["Cnic"].Value?.ToString();
                editUserOccupation_tb.Text = selectedRow.Cells["Occupation"].Value?.ToString();
                editUserAccountType_tb.Text = selectedRow.Cells["Account Type"].Value?.ToString();

                // Set combo box value
                string question = selectedRow.Cells["Security Question"].Value?.ToString();
                if (editUserSecurityQuestion_cb.Items.Contains(question))
                {
                    editUserSecurityQuestion_cb.SelectedItem = question;
                }
                else
                {
                    editUserSecurityQuestion_cb.Text = question;
                }

                editUserSecurityAnswer_tb.Text = selectedRow.Cells["Security Answer"].Value?.ToString();
                manageOtherUserEdit_pnl.Show();
            }
            else
            {
                MessageBox.Show("Please select a user row to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            admin_userManagerOtherUsers_pnl.Show();
            manageOtherUserEdit_pnl.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (admin_editOtherUsers_gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = admin_editOtherUsers_gridView.SelectedRows[0];

            int userId = Convert.ToInt32(row.Cells["ID"].Value);
            string oldCnic = row.Cells["Cnic"].Value?.ToString();
            string oldEmail = row.Cells["Email"].Value?.ToString();
            string oldUsername = row.Cells["Username"].Value?.ToString();
            string oldPassword = row.Cells["Password"].Value?.ToString();
            string oldAccountType = row.Cells["Account Type"].Value?.ToString();

            // New values from TextBoxes / ComboBoxes
            string newName = editUserName_tb.Text.Trim();
            string newUsername = editUserUsername_tb.Text.Trim();
            string newPassword = editUserPassword_tb.Text.Trim();
            string newEmail = editUserEmail_tb.Text.Trim();
            string newPhone = editUserPhone_tb.Text.Trim();
            string newOccupation = editUserOccupation_tb.Text.Trim();
            string newQuestion = editUserSecurityQuestion_cb.Text.Trim();
            string newAnswer = editUserSecurityAnswer_tb.Text.Trim();
            string newAccountType = editUserAccountType_tb.Text.Trim();
            if (userId <= 0)
            {
                MessageBox.Show("Invalid user ID from grid. Please check column alias.");
                return;
            }
            bool updated = UserUpdateHelper.UpdateUserFromGrid(
                newName, newUsername, newPassword, newEmail,
                newPhone, newOccupation, newQuestion, newAnswer,newAccountType,
                userId
            );

            if (updated)
            {
                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optionally reload grid or refresh
                LoadAllUsersToGrid();
                manageOtherUserEdit_pnl.Hide();
            }
            else
            {
                MessageBox.Show("No update occurred. Please verify the data.", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminEditName_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminEditUsername_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminEditPassword_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminEditOccupation_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminEditEmail_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminEditPhone_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminEditCnic_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminEditSecurityAnswer_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminEditSecurityQuestion_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label39_Click_1(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
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

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void manageOtherUserEdit_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label40_Click_1(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void editUserSecurityQuestion_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editUserSecurityAnswer_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void editUserCnic_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void editUserPhone_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void editUserEmail_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void editUserOccupation_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void editUserPassword_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void editUserUsername_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void editUserName_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaChart1_Load(object sender, EventArgs e)
        {

        }
    }
}
