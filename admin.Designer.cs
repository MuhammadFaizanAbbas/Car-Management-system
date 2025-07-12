using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;

namespace FYP_PROJECT
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Clear datasets first – stops background rendering queues
                gunaChart1?.Datasets.Clear();
                gunaChart2?.Datasets.Clear();
                gunaChart3?.Datasets.Clear();
                gunaChart4?.Datasets.Clear();

                // Dispose the charts themselves
                gunaChart1?.Dispose();
                gunaChart2?.Dispose();
                gunaChart3?.Dispose();
                gunaChart4?.Dispose();

                // Now dispose the component container
                components?.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            Guna.Charts.WinForms.ChartFont chartFont1 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont2 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont3 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont4 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid1 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick1 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont5 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid2 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick2 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont6 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid3 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel1 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont7 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick3 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont8 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont9 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont10 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont11 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont12 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid4 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick4 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont13 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid5 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick5 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont14 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid6 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel2 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont15 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick6 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont16 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont17 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont18 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont19 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont20 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid7 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick7 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont21 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid8 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick8 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont22 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid9 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel3 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont23 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick9 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont24 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont25 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont26 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont27 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont28 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid10 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick10 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont29 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid11 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick11 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont30 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid12 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel4 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont31 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick12 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont32 = new Guna.Charts.WinForms.ChartFont();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.admin_menu_pnl = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.admin_designation_lbl = new System.Windows.Forms.Label();
            this.admin_name_lbl = new System.Windows.Forms.Label();
            this.admin_accountType_lbl = new System.Windows.Forms.Label();
            this.admin_welcomePage_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.admin_closeApplication_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_dashboard_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_logOut_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_search_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_user_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_employees_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_appointment_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_service_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_financialReport_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_client_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_schedule_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_dashboard_pnl = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.admin_totalProfit_lbl = new System.Windows.Forms.Label();
            this.gunaChart4 = new Guna.Charts.WinForms.GunaChart();
            this.admin_totalEmployees_lbl = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.admin_totalServiceDone_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaChart3 = new Guna.Charts.WinForms.GunaChart();
            this.admin_monthIncome_lbl = new System.Windows.Forms.Label();
            this.gunaChart2 = new Guna.Charts.WinForms.GunaChart();
            this.gunaChart1 = new Guna.Charts.WinForms.GunaChart();
            this.admin_yearIncome_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.admin_search_pnl = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.employee_searchCarDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.search_clear_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.employee_searchGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.employee_servicesDone_lbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.employee_lastServiceDate_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.employee_searchBar_btn = new Guna.UI2.WinForms.Guna2Button();
            this.employee_search_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.admin_employee_pnl = new System.Windows.Forms.Panel();
            this.employeeUpdate_pnl = new Guna.UI2.WinForms.Guna2Panel();
            this.label43 = new System.Windows.Forms.Label();
            this.updateEmployeeDone_btn = new Guna.UI2.WinForms.Guna2Button();
            this.updateEmployeeBack_btn = new Guna.UI2.WinForms.Guna2Button();
            this.updateEmployeeAddress_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.updateEmployeeSalary_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.updateEmployeeEmail_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.updateEmployeeCnic_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.updateEmployeeRole_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.updateEmployeeNumber_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.updateEmployeeName_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.employeeAdd_pnl = new Guna.UI2.WinForms.Guna2Panel();
            this.label42 = new System.Windows.Forms.Label();
            this.addEmployeeDone_btn = new Guna.UI2.WinForms.Guna2Button();
            this.addEmployeeBack_btn = new Guna.UI2.WinForms.Guna2Button();
            this.addEmployeeAddress_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.addEmployeeSalary_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.addEmployeeEmail_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.addEmployeeCnic_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.addEmployeeRole_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.addEmployeeNumber_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.addEmployeeName_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.employeeDelete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.employeeUpdate_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.admin_employee_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.admin_service_pnl = new System.Windows.Forms.Panel();
            this.addService_pnl = new Guna.UI2.WinForms.Guna2Panel();
            this.addServiceBack_btn = new Guna.UI2.WinForms.Guna2Button();
            this.addServicePrice_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.addServiceDiscription_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.addServiceName_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.addServiceDone_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_serviceDelete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.updateService_pnl = new Guna.UI2.WinForms.Guna2Panel();
            this.updateServicePrice_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.updateServiceDiscription_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.updateServiceName_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.updateServiceDone_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.admin_serviceUpdate_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_serviceAdd_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label16 = new System.Windows.Forms.Label();
            this.admin_service_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.admin_clients_pnl = new System.Windows.Forms.Panel();
            this.admin_client_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.admin_schedule_pnl = new System.Windows.Forms.Panel();
            this.admin_scheduleTurnOffAlert = new Guna.UI2.WinForms.Guna2Button();
            this.admin_scheduleSendAlert_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label20 = new System.Windows.Forms.Label();
            this.admin_schedule_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2CustomGradientPanel5 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.admin_scheduleDueService_lbl = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.admin_financialReport_pnl = new System.Windows.Forms.Panel();
            this.addExpennse_pnl = new Guna.UI2.WinForms.Guna2Panel();
            this.expenseDiscription_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.expenseAmount_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.addExpenseBack_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_financialReportPrint_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_financialReportMonthSelection_cb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.admin_financialReportProfit_lbl = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.admin_financialReportExpenses_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.admin_financialReportExpenses_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.admin_financialReportIncome_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label24 = new System.Windows.Forms.Label();
            this.admin_appointment_pnl = new System.Windows.Forms.Panel();
            this.admin_appointmentCompletedToday_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label33 = new System.Windows.Forms.Label();
            this.admin_appointmentThisMonth_gridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label32 = new System.Windows.Forms.Label();
            this.admin_appointmentTodayAppointment_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.admin_user_pnl = new System.Windows.Forms.Panel();
            this.manageOtherUserEdit_pnl = new Guna.UI2.WinForms.Guna2Panel();
            this.label61 = new System.Windows.Forms.Label();
            this.editUserAccountType_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.editUserSecurityQuestion_cb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.editUserSecurityAnswer_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.editUserCnic_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.editUserPhone_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.editUserEmail_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.editUserOccupation_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.editUserPassword_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.editUserUsername_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.editUserName_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.admin_userSecurityAnswer_lbl = new System.Windows.Forms.Label();
            this.admin_userSecurityQuestion_lbl = new System.Windows.Forms.Label();
            this.admin_userEmail_lbl = new System.Windows.Forms.Label();
            this.admin_userManagerOtherUsers_pnl = new System.Windows.Forms.Panel();
            this.admin_userManageOtherUsersEdit_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_userManageOtherUsersBack_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_editOtherUsers_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.admin_userCnic_lbl = new System.Windows.Forms.Label();
            this.admin_userPhone_lbl = new System.Windows.Forms.Label();
            this.cnic_lbl = new System.Windows.Forms.Label();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.securityA_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.securityQ_lbl = new System.Windows.Forms.Label();
            this.admin_userEdit_pnl = new System.Windows.Forms.Panel();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.adminEditSecurityQuestion_cb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.adminEditSecurityAnswer_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.adminEditCnic_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.adminEditPhone_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.adminEditEmail_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.adminEditOccupation_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.adminEditPassword_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.adminEditUsername_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.adminEditName_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.admin_userEditDone_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_userEditBack_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_userManageOtherUsers_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_userEdit_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_userOccupation_lbl = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.admin_userPassword_lbl = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.admin_userUsername_lbl = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.admin_user_Name_lbl = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.admin_userAccountType_lbl = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin_menu_pnl.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.admin_dashboard_pnl.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            this.admin_search_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_searchCarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_searchGridView)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.admin_employee_pnl.SuspendLayout();
            this.employeeUpdate_pnl.SuspendLayout();
            this.employeeAdd_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_employee_gridView)).BeginInit();
            this.admin_service_pnl.SuspendLayout();
            this.addService_pnl.SuspendLayout();
            this.updateService_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_service_gridView)).BeginInit();
            this.admin_clients_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_client_gridView)).BeginInit();
            this.admin_schedule_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_schedule_gridView)).BeginInit();
            this.guna2CustomGradientPanel5.SuspendLayout();
            this.admin_financialReport_pnl.SuspendLayout();
            this.addExpennse_pnl.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_financialReportExpenses_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_financialReportIncome_gridView)).BeginInit();
            this.admin_appointment_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_appointmentCompletedToday_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_appointmentThisMonth_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_appointmentTodayAppointment_gridView)).BeginInit();
            this.admin_user_pnl.SuspendLayout();
            this.manageOtherUserEdit_pnl.SuspendLayout();
            this.admin_userManagerOtherUsers_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_editOtherUsers_gridView)).BeginInit();
            this.admin_userEdit_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_menu_pnl
            // 
            this.admin_menu_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.admin_menu_pnl.BackColor = System.Drawing.Color.Gray;
            this.admin_menu_pnl.Controls.Add(this.guna2CustomGradientPanel1);
            this.admin_menu_pnl.Controls.Add(this.admin_welcomePage_btn);
            this.admin_menu_pnl.Controls.Add(this.label3);
            this.admin_menu_pnl.Controls.Add(this.admin_closeApplication_btn);
            this.admin_menu_pnl.Controls.Add(this.admin_dashboard_btn);
            this.admin_menu_pnl.Controls.Add(this.admin_logOut_btn);
            this.admin_menu_pnl.Controls.Add(this.admin_search_btn);
            this.admin_menu_pnl.Controls.Add(this.admin_user_btn);
            this.admin_menu_pnl.Controls.Add(this.admin_employees_btn);
            this.admin_menu_pnl.Controls.Add(this.admin_appointment_btn);
            this.admin_menu_pnl.Controls.Add(this.admin_service_btn);
            this.admin_menu_pnl.Controls.Add(this.admin_financialReport_btn);
            this.admin_menu_pnl.Controls.Add(this.admin_client_btn);
            this.admin_menu_pnl.Controls.Add(this.admin_schedule_btn);
            this.admin_menu_pnl.Location = new System.Drawing.Point(0, 0);
            this.admin_menu_pnl.Name = "admin_menu_pnl";
            this.admin_menu_pnl.Size = new System.Drawing.Size(200, 751);
            this.admin_menu_pnl.TabIndex = 0;
            this.admin_menu_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.admin_menu_pnl_Paint);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.AutoRoundedCorners = true;
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.BorderThickness = 2;
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.admin_designation_lbl);
            this.guna2CustomGradientPanel1.Controls.Add(this.admin_name_lbl);
            this.guna2CustomGradientPanel1.Controls.Add(this.admin_accountType_lbl);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Gray;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Blue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(21, 25);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(150, 139);
            this.guna2CustomGradientPanel1.TabIndex = 15;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(35, 10);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(77, 53);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 4;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // admin_designation_lbl
            // 
            this.admin_designation_lbl.AutoSize = true;
            this.admin_designation_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_designation_lbl.Location = new System.Drawing.Point(22, 102);
            this.admin_designation_lbl.Name = "admin_designation_lbl";
            this.admin_designation_lbl.Size = new System.Drawing.Size(30, 16);
            this.admin_designation_lbl.TabIndex = 3;
            this.admin_designation_lbl.Text = "N/A";
            this.admin_designation_lbl.Click += new System.EventHandler(this.admin_designation_lbl_Click);
            // 
            // admin_name_lbl
            // 
            this.admin_name_lbl.AutoSize = true;
            this.admin_name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_name_lbl.ForeColor = System.Drawing.Color.Black;
            this.admin_name_lbl.Location = new System.Drawing.Point(22, 86);
            this.admin_name_lbl.Name = "admin_name_lbl";
            this.admin_name_lbl.Size = new System.Drawing.Size(30, 16);
            this.admin_name_lbl.TabIndex = 2;
            this.admin_name_lbl.Text = "N/A";
            this.admin_name_lbl.Click += new System.EventHandler(this.admin_name_lbl_Click);
            // 
            // admin_accountType_lbl
            // 
            this.admin_accountType_lbl.AutoSize = true;
            this.admin_accountType_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_accountType_lbl.Location = new System.Drawing.Point(21, 66);
            this.admin_accountType_lbl.Name = "admin_accountType_lbl";
            this.admin_accountType_lbl.Size = new System.Drawing.Size(59, 20);
            this.admin_accountType_lbl.TabIndex = 1;
            this.admin_accountType_lbl.Text = "Admin";
            this.admin_accountType_lbl.Click += new System.EventHandler(this.employee_accountType_lbl_Click);
            // 
            // admin_welcomePage_btn
            // 
            this.admin_welcomePage_btn.Animated = true;
            this.admin_welcomePage_btn.AutoRoundedCorners = true;
            this.admin_welcomePage_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_welcomePage_btn.BorderThickness = 1;
            this.admin_welcomePage_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_welcomePage_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_welcomePage_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_welcomePage_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_welcomePage_btn.FillColor = System.Drawing.Color.LightGray;
            this.admin_welcomePage_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.admin_welcomePage_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_welcomePage_btn.Location = new System.Drawing.Point(9, 172);
            this.admin_welcomePage_btn.Name = "admin_welcomePage_btn";
            this.admin_welcomePage_btn.Size = new System.Drawing.Size(180, 37);
            this.admin_welcomePage_btn.TabIndex = 14;
            this.admin_welcomePage_btn.Text = "Welcome Page";
            this.admin_welcomePage_btn.UseTransparentBackground = true;
            this.admin_welcomePage_btn.Click += new System.EventHandler(this.admin_welcomePage_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(3, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "-------------------------------";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // admin_closeApplication_btn
            // 
            this.admin_closeApplication_btn.Animated = true;
            this.admin_closeApplication_btn.AutoRoundedCorners = true;
            this.admin_closeApplication_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_closeApplication_btn.BorderThickness = 1;
            this.admin_closeApplication_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_closeApplication_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_closeApplication_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_closeApplication_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_closeApplication_btn.FillColor = System.Drawing.Color.LightGray;
            this.admin_closeApplication_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.admin_closeApplication_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_closeApplication_btn.Location = new System.Drawing.Point(11, 669);
            this.admin_closeApplication_btn.Name = "admin_closeApplication_btn";
            this.admin_closeApplication_btn.Size = new System.Drawing.Size(180, 37);
            this.admin_closeApplication_btn.TabIndex = 11;
            this.admin_closeApplication_btn.Text = "Close Application";
            this.admin_closeApplication_btn.UseTransparentBackground = true;
            this.admin_closeApplication_btn.Click += new System.EventHandler(this.admin_closeApplication_btn_Click);
            // 
            // admin_dashboard_btn
            // 
            this.admin_dashboard_btn.Animated = true;
            this.admin_dashboard_btn.AutoRoundedCorners = true;
            this.admin_dashboard_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_dashboard_btn.BorderThickness = 1;
            this.admin_dashboard_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_dashboard_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_dashboard_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_dashboard_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_dashboard_btn.FillColor = System.Drawing.Color.LightGray;
            this.admin_dashboard_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.admin_dashboard_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_dashboard_btn.Location = new System.Drawing.Point(9, 214);
            this.admin_dashboard_btn.Name = "admin_dashboard_btn";
            this.admin_dashboard_btn.Size = new System.Drawing.Size(180, 37);
            this.admin_dashboard_btn.TabIndex = 1;
            this.admin_dashboard_btn.Text = "Dashboard";
            this.admin_dashboard_btn.UseTransparentBackground = true;
            this.admin_dashboard_btn.Click += new System.EventHandler(this.admin_dashboard_btn_Click);
            // 
            // admin_logOut_btn
            // 
            this.admin_logOut_btn.Animated = true;
            this.admin_logOut_btn.AutoRoundedCorners = true;
            this.admin_logOut_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_logOut_btn.BorderThickness = 1;
            this.admin_logOut_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_logOut_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_logOut_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_logOut_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_logOut_btn.FillColor = System.Drawing.Color.LightGray;
            this.admin_logOut_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.admin_logOut_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_logOut_btn.Location = new System.Drawing.Point(11, 626);
            this.admin_logOut_btn.Name = "admin_logOut_btn";
            this.admin_logOut_btn.Size = new System.Drawing.Size(180, 37);
            this.admin_logOut_btn.TabIndex = 10;
            this.admin_logOut_btn.Text = "LogOut";
            this.admin_logOut_btn.UseTransparentBackground = true;
            this.admin_logOut_btn.Click += new System.EventHandler(this.admin_logOut_btn_Click);
            // 
            // admin_search_btn
            // 
            this.admin_search_btn.Animated = true;
            this.admin_search_btn.AutoRoundedCorners = true;
            this.admin_search_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_search_btn.BorderThickness = 1;
            this.admin_search_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_search_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_search_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_search_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_search_btn.FillColor = System.Drawing.Color.LightGray;
            this.admin_search_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.admin_search_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_search_btn.Location = new System.Drawing.Point(9, 257);
            this.admin_search_btn.Name = "admin_search_btn";
            this.admin_search_btn.Size = new System.Drawing.Size(180, 37);
            this.admin_search_btn.TabIndex = 2;
            this.admin_search_btn.Text = "Search";
            this.admin_search_btn.UseTransparentBackground = true;
            this.admin_search_btn.Click += new System.EventHandler(this.admin_search_btn_Click);
            // 
            // admin_user_btn
            // 
            this.admin_user_btn.Animated = true;
            this.admin_user_btn.AutoRoundedCorners = true;
            this.admin_user_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_user_btn.BorderThickness = 1;
            this.admin_user_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_user_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_user_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_user_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_user_btn.FillColor = System.Drawing.Color.LightGray;
            this.admin_user_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.admin_user_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_user_btn.Location = new System.Drawing.Point(11, 582);
            this.admin_user_btn.Name = "admin_user_btn";
            this.admin_user_btn.Size = new System.Drawing.Size(180, 37);
            this.admin_user_btn.TabIndex = 9;
            this.admin_user_btn.Text = "User";
            this.admin_user_btn.UseTransparentBackground = true;
            this.admin_user_btn.Click += new System.EventHandler(this.admin_user_btn_Click);
            // 
            // admin_employees_btn
            // 
            this.admin_employees_btn.Animated = true;
            this.admin_employees_btn.AutoRoundedCorners = true;
            this.admin_employees_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_employees_btn.BorderThickness = 1;
            this.admin_employees_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_employees_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_employees_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_employees_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_employees_btn.FillColor = System.Drawing.Color.LightGray;
            this.admin_employees_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.admin_employees_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_employees_btn.Location = new System.Drawing.Point(9, 300);
            this.admin_employees_btn.Name = "admin_employees_btn";
            this.admin_employees_btn.Size = new System.Drawing.Size(180, 37);
            this.admin_employees_btn.TabIndex = 3;
            this.admin_employees_btn.Text = "Employees";
            this.admin_employees_btn.UseTransparentBackground = true;
            this.admin_employees_btn.Click += new System.EventHandler(this.admin_employees_btn_Click);
            // 
            // admin_appointment_btn
            // 
            this.admin_appointment_btn.Animated = true;
            this.admin_appointment_btn.AutoRoundedCorners = true;
            this.admin_appointment_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_appointment_btn.BorderThickness = 1;
            this.admin_appointment_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_appointment_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_appointment_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_appointment_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_appointment_btn.FillColor = System.Drawing.Color.LightGray;
            this.admin_appointment_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.admin_appointment_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_appointment_btn.Location = new System.Drawing.Point(11, 515);
            this.admin_appointment_btn.Name = "admin_appointment_btn";
            this.admin_appointment_btn.Size = new System.Drawing.Size(180, 37);
            this.admin_appointment_btn.TabIndex = 8;
            this.admin_appointment_btn.Text = "Appointment";
            this.admin_appointment_btn.UseTransparentBackground = true;
            this.admin_appointment_btn.Click += new System.EventHandler(this.admin_appointment_btn_Click);
            // 
            // admin_service_btn
            // 
            this.admin_service_btn.Animated = true;
            this.admin_service_btn.AutoRoundedCorners = true;
            this.admin_service_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_service_btn.BorderThickness = 1;
            this.admin_service_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_service_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_service_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_service_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_service_btn.FillColor = System.Drawing.Color.LightGray;
            this.admin_service_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.admin_service_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_service_btn.Location = new System.Drawing.Point(9, 343);
            this.admin_service_btn.Name = "admin_service_btn";
            this.admin_service_btn.Size = new System.Drawing.Size(180, 37);
            this.admin_service_btn.TabIndex = 4;
            this.admin_service_btn.Text = "Services";
            this.admin_service_btn.UseTransparentBackground = true;
            this.admin_service_btn.Click += new System.EventHandler(this.admin_service_btn_Click);
            // 
            // admin_financialReport_btn
            // 
            this.admin_financialReport_btn.Animated = true;
            this.admin_financialReport_btn.AutoRoundedCorners = true;
            this.admin_financialReport_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_financialReport_btn.BorderThickness = 1;
            this.admin_financialReport_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_financialReport_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_financialReport_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_financialReport_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_financialReport_btn.FillColor = System.Drawing.Color.LightGray;
            this.admin_financialReport_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.admin_financialReport_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_financialReport_btn.Location = new System.Drawing.Point(11, 472);
            this.admin_financialReport_btn.Name = "admin_financialReport_btn";
            this.admin_financialReport_btn.Size = new System.Drawing.Size(180, 37);
            this.admin_financialReport_btn.TabIndex = 7;
            this.admin_financialReport_btn.Text = "Financial Report";
            this.admin_financialReport_btn.UseTransparentBackground = true;
            this.admin_financialReport_btn.Click += new System.EventHandler(this.admin_financialReport_btn_Click);
            // 
            // admin_client_btn
            // 
            this.admin_client_btn.Animated = true;
            this.admin_client_btn.AutoRoundedCorners = true;
            this.admin_client_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_client_btn.BorderThickness = 1;
            this.admin_client_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_client_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_client_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_client_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_client_btn.FillColor = System.Drawing.Color.LightGray;
            this.admin_client_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.admin_client_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_client_btn.Location = new System.Drawing.Point(9, 386);
            this.admin_client_btn.Name = "admin_client_btn";
            this.admin_client_btn.Size = new System.Drawing.Size(180, 37);
            this.admin_client_btn.TabIndex = 5;
            this.admin_client_btn.Text = "Clients";
            this.admin_client_btn.UseTransparentBackground = true;
            this.admin_client_btn.Click += new System.EventHandler(this.admin_client_btn_Click);
            // 
            // admin_schedule_btn
            // 
            this.admin_schedule_btn.Animated = true;
            this.admin_schedule_btn.AutoRoundedCorners = true;
            this.admin_schedule_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_schedule_btn.BorderThickness = 1;
            this.admin_schedule_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_schedule_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_schedule_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_schedule_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_schedule_btn.FillColor = System.Drawing.Color.LightGray;
            this.admin_schedule_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.admin_schedule_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_schedule_btn.Location = new System.Drawing.Point(9, 429);
            this.admin_schedule_btn.Name = "admin_schedule_btn";
            this.admin_schedule_btn.Size = new System.Drawing.Size(180, 37);
            this.admin_schedule_btn.TabIndex = 6;
            this.admin_schedule_btn.Text = "Schedule";
            this.admin_schedule_btn.UseTransparentBackground = true;
            this.admin_schedule_btn.Click += new System.EventHandler(this.admin_schedule_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(444, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 77);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to the studio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(515, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please select an option form the menu to proceed";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // admin_dashboard_pnl
            // 
            this.admin_dashboard_pnl.BackColor = System.Drawing.Color.Black;
            this.admin_dashboard_pnl.Controls.Add(this.label7);
            this.admin_dashboard_pnl.Controls.Add(this.guna2CustomGradientPanel3);
            this.admin_dashboard_pnl.Controls.Add(this.gunaChart4);
            this.admin_dashboard_pnl.Controls.Add(this.admin_totalEmployees_lbl);
            this.admin_dashboard_pnl.Controls.Add(this.label19);
            this.admin_dashboard_pnl.Controls.Add(this.label6);
            this.admin_dashboard_pnl.Controls.Add(this.admin_totalServiceDone_lbl);
            this.admin_dashboard_pnl.Controls.Add(this.label5);
            this.admin_dashboard_pnl.Controls.Add(this.gunaChart3);
            this.admin_dashboard_pnl.Controls.Add(this.admin_monthIncome_lbl);
            this.admin_dashboard_pnl.Controls.Add(this.gunaChart2);
            this.admin_dashboard_pnl.Controls.Add(this.gunaChart1);
            this.admin_dashboard_pnl.Controls.Add(this.admin_yearIncome_lbl);
            this.admin_dashboard_pnl.Controls.Add(this.label4);
            this.admin_dashboard_pnl.Location = new System.Drawing.Point(221, 3);
            this.admin_dashboard_pnl.Name = "admin_dashboard_pnl";
            this.admin_dashboard_pnl.Size = new System.Drawing.Size(1150, 751);
            this.admin_dashboard_pnl.TabIndex = 4;
            this.admin_dashboard_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.admin_dashboard_pnl_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(747, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "TotalEmployees";
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.AutoRoundedCorners = true;
            this.guna2CustomGradientPanel3.Controls.Add(this.label8);
            this.guna2CustomGradientPanel3.Controls.Add(this.admin_totalProfit_lbl);
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(24, 614);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(512, 75);
            this.guna2CustomGradientPanel3.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(197, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Profit";
            // 
            // admin_totalProfit_lbl
            // 
            this.admin_totalProfit_lbl.AutoSize = true;
            this.admin_totalProfit_lbl.BackColor = System.Drawing.Color.Transparent;
            this.admin_totalProfit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_totalProfit_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.admin_totalProfit_lbl.Location = new System.Drawing.Point(208, 33);
            this.admin_totalProfit_lbl.Name = "admin_totalProfit_lbl";
            this.admin_totalProfit_lbl.Size = new System.Drawing.Size(20, 24);
            this.admin_totalProfit_lbl.TabIndex = 3;
            this.admin_totalProfit_lbl.Text = "0";
            this.admin_totalProfit_lbl.Click += new System.EventHandler(this.admin_totalProfit_lbl_Click);
            // 
            // gunaChart4
            // 
            this.gunaChart4.BackColor = System.Drawing.Color.Black;
            chartFont1.FontName = "Arial";
            this.gunaChart4.Legend.LabelFont = chartFont1;
            this.gunaChart4.Location = new System.Drawing.Point(562, 381);
            this.gunaChart4.Name = "gunaChart4";
            this.gunaChart4.Size = new System.Drawing.Size(580, 287);
            this.gunaChart4.TabIndex = 10;
            chartFont2.FontName = "Arial";
            chartFont2.Size = 12;
            chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart4.Title.Font = chartFont2;
            chartFont3.FontName = "Arial";
            this.gunaChart4.Tooltips.BodyFont = chartFont3;
            chartFont4.FontName = "Arial";
            chartFont4.Size = 9;
            chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart4.Tooltips.TitleFont = chartFont4;
            this.gunaChart4.XAxes.GridLines = grid1;
            chartFont5.FontName = "Arial";
            tick1.Font = chartFont5;
            this.gunaChart4.XAxes.Ticks = tick1;
            this.gunaChart4.YAxes.GridLines = grid2;
            chartFont6.FontName = "Arial";
            tick2.Font = chartFont6;
            this.gunaChart4.YAxes.Ticks = tick2;
            this.gunaChart4.ZAxes.GridLines = grid3;
            chartFont7.FontName = "Arial";
            pointLabel1.Font = chartFont7;
            this.gunaChart4.ZAxes.PointLabels = pointLabel1;
            chartFont8.FontName = "Arial";
            tick3.Font = chartFont8;
            this.gunaChart4.ZAxes.Ticks = tick3;
            // 
            // admin_totalEmployees_lbl
            // 
            this.admin_totalEmployees_lbl.AutoSize = true;
            this.admin_totalEmployees_lbl.BackColor = System.Drawing.Color.Transparent;
            this.admin_totalEmployees_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_totalEmployees_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_totalEmployees_lbl.Location = new System.Drawing.Point(792, 671);
            this.admin_totalEmployees_lbl.Name = "admin_totalEmployees_lbl";
            this.admin_totalEmployees_lbl.Size = new System.Drawing.Size(20, 24);
            this.admin_totalEmployees_lbl.TabIndex = 3;
            this.admin_totalEmployees_lbl.Text = "0";
            this.admin_totalEmployees_lbl.Click += new System.EventHandler(this.admin_totalEmployees_lbl_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(166, 353);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(225, 24);
            this.label19.TabIndex = 9;
            this.label19.Text = "Monthly Services Done";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(720, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Monthly Income";
            // 
            // admin_totalServiceDone_lbl
            // 
            this.admin_totalServiceDone_lbl.AutoSize = true;
            this.admin_totalServiceDone_lbl.BackColor = System.Drawing.Color.Transparent;
            this.admin_totalServiceDone_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_totalServiceDone_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_totalServiceDone_lbl.Location = new System.Drawing.Point(212, 570);
            this.admin_totalServiceDone_lbl.Name = "admin_totalServiceDone_lbl";
            this.admin_totalServiceDone_lbl.Size = new System.Drawing.Size(20, 24);
            this.admin_totalServiceDone_lbl.TabIndex = 2;
            this.admin_totalServiceDone_lbl.Text = "0";
            this.admin_totalServiceDone_lbl.Click += new System.EventHandler(this.admin_totalServiceDone_lbl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(203, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yearly Income";
            // 
            // gunaChart3
            // 
            this.gunaChart3.BackColor = System.Drawing.Color.Black;
            chartFont9.FontName = "Arial";
            this.gunaChart3.Legend.LabelFont = chartFont9;
            this.gunaChart3.Location = new System.Drawing.Point(24, 382);
            this.gunaChart3.Name = "gunaChart3";
            this.gunaChart3.Size = new System.Drawing.Size(512, 185);
            this.gunaChart3.TabIndex = 6;
            chartFont10.FontName = "Arial";
            chartFont10.Size = 12;
            chartFont10.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart3.Title.Font = chartFont10;
            chartFont11.FontName = "Arial";
            this.gunaChart3.Tooltips.BodyFont = chartFont11;
            chartFont12.FontName = "Arial";
            chartFont12.Size = 9;
            chartFont12.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart3.Tooltips.TitleFont = chartFont12;
            this.gunaChart3.XAxes.GridLines = grid4;
            chartFont13.FontName = "Arial";
            tick4.Font = chartFont13;
            this.gunaChart3.XAxes.Ticks = tick4;
            this.gunaChart3.YAxes.GridLines = grid5;
            chartFont14.FontName = "Arial";
            tick5.Font = chartFont14;
            this.gunaChart3.YAxes.Ticks = tick5;
            this.gunaChart3.ZAxes.GridLines = grid6;
            chartFont15.FontName = "Arial";
            pointLabel2.Font = chartFont15;
            this.gunaChart3.ZAxes.PointLabels = pointLabel2;
            chartFont16.FontName = "Arial";
            tick6.Font = chartFont16;
            this.gunaChart3.ZAxes.Ticks = tick6;
            // 
            // admin_monthIncome_lbl
            // 
            this.admin_monthIncome_lbl.AutoSize = true;
            this.admin_monthIncome_lbl.BackColor = System.Drawing.Color.Transparent;
            this.admin_monthIncome_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_monthIncome_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_monthIncome_lbl.Location = new System.Drawing.Point(808, 329);
            this.admin_monthIncome_lbl.Name = "admin_monthIncome_lbl";
            this.admin_monthIncome_lbl.Size = new System.Drawing.Size(20, 24);
            this.admin_monthIncome_lbl.TabIndex = 3;
            this.admin_monthIncome_lbl.Text = "0";
            this.admin_monthIncome_lbl.Click += new System.EventHandler(this.admin_monthIncome_lbl_Click);
            // 
            // gunaChart2
            // 
            this.gunaChart2.BackColor = System.Drawing.Color.Black;
            chartFont17.FontName = "Arial";
            this.gunaChart2.Legend.LabelFont = chartFont17;
            this.gunaChart2.Location = new System.Drawing.Point(565, 141);
            this.gunaChart2.Name = "gunaChart2";
            this.gunaChart2.Size = new System.Drawing.Size(577, 185);
            this.gunaChart2.TabIndex = 5;
            chartFont18.FontName = "Arial";
            chartFont18.Size = 12;
            chartFont18.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart2.Title.Font = chartFont18;
            chartFont19.FontName = "Arial";
            this.gunaChart2.Tooltips.BodyFont = chartFont19;
            chartFont20.FontName = "Arial";
            chartFont20.Size = 9;
            chartFont20.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart2.Tooltips.TitleFont = chartFont20;
            this.gunaChart2.XAxes.GridLines = grid7;
            chartFont21.FontName = "Arial";
            tick7.Font = chartFont21;
            this.gunaChart2.XAxes.Ticks = tick7;
            this.gunaChart2.YAxes.GridLines = grid8;
            chartFont22.FontName = "Arial";
            tick8.Font = chartFont22;
            this.gunaChart2.YAxes.Ticks = tick8;
            this.gunaChart2.ZAxes.GridLines = grid9;
            chartFont23.FontName = "Arial";
            pointLabel3.Font = chartFont23;
            this.gunaChart2.ZAxes.PointLabels = pointLabel3;
            chartFont24.FontName = "Arial";
            tick9.Font = chartFont24;
            this.gunaChart2.ZAxes.Ticks = tick9;
            // 
            // gunaChart1
            // 
            this.gunaChart1.BackColor = System.Drawing.Color.Black;
            chartFont25.FontName = "Arial";
            this.gunaChart1.Legend.LabelFont = chartFont25;
            this.gunaChart1.Location = new System.Drawing.Point(24, 141);
            this.gunaChart1.Name = "gunaChart1";
            this.gunaChart1.Size = new System.Drawing.Size(512, 185);
            this.gunaChart1.TabIndex = 4;
            chartFont26.FontName = "Arial";
            chartFont26.Size = 12;
            chartFont26.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Title.Font = chartFont26;
            chartFont27.FontName = "Arial";
            this.gunaChart1.Tooltips.BodyFont = chartFont27;
            chartFont28.FontName = "Arial";
            chartFont28.Size = 9;
            chartFont28.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Tooltips.TitleFont = chartFont28;
            this.gunaChart1.XAxes.GridLines = grid10;
            chartFont29.FontName = "Arial";
            tick10.Font = chartFont29;
            this.gunaChart1.XAxes.Ticks = tick10;
            this.gunaChart1.YAxes.GridLines = grid11;
            chartFont30.FontName = "Arial";
            tick11.Font = chartFont30;
            this.gunaChart1.YAxes.Ticks = tick11;
            this.gunaChart1.ZAxes.GridLines = grid12;
            chartFont31.FontName = "Arial";
            pointLabel4.Font = chartFont31;
            this.gunaChart1.ZAxes.PointLabels = pointLabel4;
            chartFont32.FontName = "Arial";
            tick12.Font = chartFont32;
            this.gunaChart1.ZAxes.Ticks = tick12;
            this.gunaChart1.Load += new System.EventHandler(this.gunaChart1_Load);
            // 
            // admin_yearIncome_lbl
            // 
            this.admin_yearIncome_lbl.AutoSize = true;
            this.admin_yearIncome_lbl.BackColor = System.Drawing.Color.Transparent;
            this.admin_yearIncome_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_yearIncome_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_yearIncome_lbl.Location = new System.Drawing.Point(212, 329);
            this.admin_yearIncome_lbl.Name = "admin_yearIncome_lbl";
            this.admin_yearIncome_lbl.Size = new System.Drawing.Size(20, 24);
            this.admin_yearIncome_lbl.TabIndex = 2;
            this.admin_yearIncome_lbl.Text = "0";
            this.admin_yearIncome_lbl.Click += new System.EventHandler(this.admin_yearIncome_lbl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(447, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dashboard";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // admin_search_pnl
            // 
            this.admin_search_pnl.Controls.Add(this.label15);
            this.admin_search_pnl.Controls.Add(this.employee_searchCarDataGridView);
            this.admin_search_pnl.Controls.Add(this.search_clear_btn);
            this.admin_search_pnl.Controls.Add(this.label9);
            this.admin_search_pnl.Controls.Add(this.employee_searchGridView);
            this.admin_search_pnl.Controls.Add(this.guna2CustomGradientPanel2);
            this.admin_search_pnl.Controls.Add(this.label10);
            this.admin_search_pnl.Controls.Add(this.label44);
            this.admin_search_pnl.Controls.Add(this.employee_searchBar_btn);
            this.admin_search_pnl.Controls.Add(this.employee_search_tb);
            this.admin_search_pnl.Location = new System.Drawing.Point(206, 698);
            this.admin_search_pnl.Name = "admin_search_pnl";
            this.admin_search_pnl.Size = new System.Drawing.Size(1151, 751);
            this.admin_search_pnl.TabIndex = 5;
            this.admin_search_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.admin_search_pnl_Paint);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(115, 257);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 24);
            this.label15.TabIndex = 21;
            this.label15.Text = "CAR DATA";
            // 
            // employee_searchCarDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.employee_searchCarDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employee_searchCarDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.employee_searchCarDataGridView.ColumnHeadersHeight = 40;
            this.employee_searchCarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employee_searchCarDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.employee_searchCarDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.employee_searchCarDataGridView.Location = new System.Drawing.Point(113, 300);
            this.employee_searchCarDataGridView.Name = "employee_searchCarDataGridView";
            this.employee_searchCarDataGridView.RowHeadersVisible = false;
            this.employee_searchCarDataGridView.Size = new System.Drawing.Size(944, 169);
            this.employee_searchCarDataGridView.TabIndex = 20;
            this.employee_searchCarDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.employee_searchCarDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.employee_searchCarDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.employee_searchCarDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.employee_searchCarDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.employee_searchCarDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.employee_searchCarDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.employee_searchCarDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.employee_searchCarDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.employee_searchCarDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_searchCarDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.employee_searchCarDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.employee_searchCarDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.employee_searchCarDataGridView.ThemeStyle.ReadOnly = false;
            this.employee_searchCarDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.employee_searchCarDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.employee_searchCarDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_searchCarDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.employee_searchCarDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.employee_searchCarDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.employee_searchCarDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // search_clear_btn
            // 
            this.search_clear_btn.Animated = true;
            this.search_clear_btn.AutoRoundedCorners = true;
            this.search_clear_btn.BorderThickness = 1;
            this.search_clear_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.search_clear_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.search_clear_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.search_clear_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.search_clear_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.search_clear_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_clear_btn.ForeColor = System.Drawing.Color.Black;
            this.search_clear_btn.Location = new System.Drawing.Point(959, 42);
            this.search_clear_btn.Name = "search_clear_btn";
            this.search_clear_btn.Size = new System.Drawing.Size(87, 45);
            this.search_clear_btn.TabIndex = 19;
            this.search_clear_btn.Text = "Clear";
            this.search_clear_btn.Click += new System.EventHandler(this.search_clear_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(115, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "APPOINTMENT DATA";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // employee_searchGridView
            // 
            this.employee_searchGridView.AllowUserToAddRows = false;
            this.employee_searchGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.employee_searchGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employee_searchGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.employee_searchGridView.ColumnHeadersHeight = 40;
            this.employee_searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employee_searchGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.employee_searchGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.employee_searchGridView.Location = new System.Drawing.Point(113, 512);
            this.employee_searchGridView.Name = "employee_searchGridView";
            this.employee_searchGridView.ReadOnly = true;
            this.employee_searchGridView.RowHeadersVisible = false;
            this.employee_searchGridView.Size = new System.Drawing.Size(944, 184);
            this.employee_searchGridView.TabIndex = 17;
            this.employee_searchGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.employee_searchGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.employee_searchGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.employee_searchGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.employee_searchGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.employee_searchGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.employee_searchGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.employee_searchGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.employee_searchGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.employee_searchGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_searchGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.employee_searchGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.employee_searchGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.employee_searchGridView.ThemeStyle.ReadOnly = true;
            this.employee_searchGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.employee_searchGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.employee_searchGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_searchGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.employee_searchGridView.ThemeStyle.RowsStyle.Height = 22;
            this.employee_searchGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.employee_searchGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.employee_searchGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employee_searchGridView_CellContentClick);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.AutoRoundedCorners = true;
            this.guna2CustomGradientPanel2.Controls.Add(this.employee_servicesDone_lbl);
            this.guna2CustomGradientPanel2.Controls.Add(this.label12);
            this.guna2CustomGradientPanel2.Controls.Add(this.label17);
            this.guna2CustomGradientPanel2.Controls.Add(this.employee_lastServiceDate_lbl);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(113, 186);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(944, 60);
            this.guna2CustomGradientPanel2.TabIndex = 14;
            this.guna2CustomGradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel2_Paint);
            // 
            // employee_servicesDone_lbl
            // 
            this.employee_servicesDone_lbl.AutoSize = true;
            this.employee_servicesDone_lbl.BackColor = System.Drawing.Color.Transparent;
            this.employee_servicesDone_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_servicesDone_lbl.Location = new System.Drawing.Point(107, 31);
            this.employee_servicesDone_lbl.Name = "employee_servicesDone_lbl";
            this.employee_servicesDone_lbl.Size = new System.Drawing.Size(30, 16);
            this.employee_servicesDone_lbl.TabIndex = 1;
            this.employee_servicesDone_lbl.Text = "N/A";
            this.employee_servicesDone_lbl.Click += new System.EventHandler(this.employee_servicesDone_lbl_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(88, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Services Done";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(737, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Last Service Date";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // employee_lastServiceDate_lbl
            // 
            this.employee_lastServiceDate_lbl.AutoSize = true;
            this.employee_lastServiceDate_lbl.BackColor = System.Drawing.Color.Transparent;
            this.employee_lastServiceDate_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_lastServiceDate_lbl.Location = new System.Drawing.Point(738, 31);
            this.employee_lastServiceDate_lbl.Name = "employee_lastServiceDate_lbl";
            this.employee_lastServiceDate_lbl.Size = new System.Drawing.Size(30, 16);
            this.employee_lastServiceDate_lbl.TabIndex = 1;
            this.employee_lastServiceDate_lbl.Text = "N/A";
            this.employee_lastServiceDate_lbl.Click += new System.EventHandler(this.employee_ownerName_lbl_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(115, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Results";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label44.Location = new System.Drawing.Point(56, 114);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(1039, 13);
            this.label44.TabIndex = 12;
            this.label44.Text = resources.GetString("label44.Text");
            this.label44.Click += new System.EventHandler(this.label44_Click);
            // 
            // employee_searchBar_btn
            // 
            this.employee_searchBar_btn.AutoRoundedCorners = true;
            this.employee_searchBar_btn.BorderThickness = 1;
            this.employee_searchBar_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.employee_searchBar_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.employee_searchBar_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.employee_searchBar_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.employee_searchBar_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.employee_searchBar_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.employee_searchBar_btn.ForeColor = System.Drawing.Color.Black;
            this.employee_searchBar_btn.Location = new System.Drawing.Point(861, 42);
            this.employee_searchBar_btn.Name = "employee_searchBar_btn";
            this.employee_searchBar_btn.Size = new System.Drawing.Size(87, 45);
            this.employee_searchBar_btn.TabIndex = 11;
            this.employee_searchBar_btn.Text = "Search";
            this.employee_searchBar_btn.Click += new System.EventHandler(this.employee_searchBar_btn_Click);
            // 
            // employee_search_tb
            // 
            this.employee_search_tb.Animated = true;
            this.employee_search_tb.AutoRoundedCorners = true;
            this.employee_search_tb.BorderColor = System.Drawing.Color.Blue;
            this.employee_search_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employee_search_tb.DefaultText = "";
            this.employee_search_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.employee_search_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.employee_search_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employee_search_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employee_search_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employee_search_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.employee_search_tb.ForeColor = System.Drawing.Color.Black;
            this.employee_search_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employee_search_tb.Location = new System.Drawing.Point(193, 46);
            this.employee_search_tb.Name = "employee_search_tb";
            this.employee_search_tb.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.employee_search_tb.PlaceholderText = "Enter Car Number or Cnic";
            this.employee_search_tb.SelectedText = "";
            this.employee_search_tb.Size = new System.Drawing.Size(647, 41);
            this.employee_search_tb.TabIndex = 10;
            this.employee_search_tb.TextChanged += new System.EventHandler(this.employee_search_tb_TextChanged);
            // 
            // admin_employee_pnl
            // 
            this.admin_employee_pnl.Controls.Add(this.employeeUpdate_pnl);
            this.admin_employee_pnl.Controls.Add(this.employeeAdd_pnl);
            this.admin_employee_pnl.Controls.Add(this.employeeDelete_btn);
            this.admin_employee_pnl.Controls.Add(this.employeeUpdate_btn);
            this.admin_employee_pnl.Controls.Add(this.guna2Button1);
            this.admin_employee_pnl.Controls.Add(this.admin_employee_gridView);
            this.admin_employee_pnl.Controls.Add(this.label14);
            this.admin_employee_pnl.Location = new System.Drawing.Point(206, 701);
            this.admin_employee_pnl.Name = "admin_employee_pnl";
            this.admin_employee_pnl.Size = new System.Drawing.Size(1151, 748);
            this.admin_employee_pnl.TabIndex = 4;
            this.admin_employee_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.admin_employee_pnl_Paint);
            // 
            // employeeUpdate_pnl
            // 
            this.employeeUpdate_pnl.Controls.Add(this.label43);
            this.employeeUpdate_pnl.Controls.Add(this.updateEmployeeDone_btn);
            this.employeeUpdate_pnl.Controls.Add(this.updateEmployeeBack_btn);
            this.employeeUpdate_pnl.Controls.Add(this.updateEmployeeAddress_tb);
            this.employeeUpdate_pnl.Controls.Add(this.updateEmployeeSalary_tb);
            this.employeeUpdate_pnl.Controls.Add(this.updateEmployeeEmail_tb);
            this.employeeUpdate_pnl.Controls.Add(this.updateEmployeeCnic_tb);
            this.employeeUpdate_pnl.Controls.Add(this.updateEmployeeRole_tb);
            this.employeeUpdate_pnl.Controls.Add(this.updateEmployeeNumber_tb);
            this.employeeUpdate_pnl.Controls.Add(this.updateEmployeeName_tb);
            this.employeeUpdate_pnl.Location = new System.Drawing.Point(0, 104);
            this.employeeUpdate_pnl.Name = "employeeUpdate_pnl";
            this.employeeUpdate_pnl.Size = new System.Drawing.Size(1154, 574);
            this.employeeUpdate_pnl.TabIndex = 6;
            this.employeeUpdate_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.employeeUpdate_pnl_Paint);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label43.Location = new System.Drawing.Point(498, 42);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(168, 25);
            this.label43.TabIndex = 19;
            this.label43.Text = "Update Employee";
            this.label43.Click += new System.EventHandler(this.label43_Click);
            // 
            // updateEmployeeDone_btn
            // 
            this.updateEmployeeDone_btn.Animated = true;
            this.updateEmployeeDone_btn.AutoRoundedCorners = true;
            this.updateEmployeeDone_btn.BackColor = System.Drawing.Color.Transparent;
            this.updateEmployeeDone_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateEmployeeDone_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateEmployeeDone_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateEmployeeDone_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateEmployeeDone_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updateEmployeeDone_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmployeeDone_btn.ForeColor = System.Drawing.Color.Black;
            this.updateEmployeeDone_btn.Location = new System.Drawing.Point(647, 402);
            this.updateEmployeeDone_btn.Name = "updateEmployeeDone_btn";
            this.updateEmployeeDone_btn.Size = new System.Drawing.Size(180, 45);
            this.updateEmployeeDone_btn.TabIndex = 18;
            this.updateEmployeeDone_btn.Text = "Done";
            this.updateEmployeeDone_btn.UseTransparentBackground = true;
            this.updateEmployeeDone_btn.Click += new System.EventHandler(this.updateEmployeeDone_btn_Click);
            // 
            // updateEmployeeBack_btn
            // 
            this.updateEmployeeBack_btn.Animated = true;
            this.updateEmployeeBack_btn.AutoRoundedCorners = true;
            this.updateEmployeeBack_btn.BackColor = System.Drawing.Color.Transparent;
            this.updateEmployeeBack_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateEmployeeBack_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateEmployeeBack_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateEmployeeBack_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateEmployeeBack_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updateEmployeeBack_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmployeeBack_btn.ForeColor = System.Drawing.Color.Black;
            this.updateEmployeeBack_btn.Location = new System.Drawing.Point(340, 402);
            this.updateEmployeeBack_btn.Name = "updateEmployeeBack_btn";
            this.updateEmployeeBack_btn.Size = new System.Drawing.Size(180, 45);
            this.updateEmployeeBack_btn.TabIndex = 17;
            this.updateEmployeeBack_btn.Text = "Back";
            this.updateEmployeeBack_btn.UseTransparentBackground = true;
            this.updateEmployeeBack_btn.Click += new System.EventHandler(this.updateEmployeeBack_btn_Click);
            // 
            // updateEmployeeAddress_tb
            // 
            this.updateEmployeeAddress_tb.Animated = true;
            this.updateEmployeeAddress_tb.AutoRoundedCorners = true;
            this.updateEmployeeAddress_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateEmployeeAddress_tb.DefaultText = "";
            this.updateEmployeeAddress_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.updateEmployeeAddress_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.updateEmployeeAddress_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateEmployeeAddress_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateEmployeeAddress_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateEmployeeAddress_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmployeeAddress_tb.ForeColor = System.Drawing.Color.Black;
            this.updateEmployeeAddress_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateEmployeeAddress_tb.Location = new System.Drawing.Point(778, 270);
            this.updateEmployeeAddress_tb.Name = "updateEmployeeAddress_tb";
            this.updateEmployeeAddress_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.updateEmployeeAddress_tb.PlaceholderText = "Enter Address";
            this.updateEmployeeAddress_tb.SelectedText = "";
            this.updateEmployeeAddress_tb.Size = new System.Drawing.Size(165, 36);
            this.updateEmployeeAddress_tb.TabIndex = 16;
            this.updateEmployeeAddress_tb.TextChanged += new System.EventHandler(this.updateEmployeeAddress_tb_TextChanged);
            // 
            // updateEmployeeSalary_tb
            // 
            this.updateEmployeeSalary_tb.Animated = true;
            this.updateEmployeeSalary_tb.AutoRoundedCorners = true;
            this.updateEmployeeSalary_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateEmployeeSalary_tb.DefaultText = "";
            this.updateEmployeeSalary_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.updateEmployeeSalary_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.updateEmployeeSalary_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateEmployeeSalary_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateEmployeeSalary_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateEmployeeSalary_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.updateEmployeeSalary_tb.ForeColor = System.Drawing.Color.Black;
            this.updateEmployeeSalary_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateEmployeeSalary_tb.Location = new System.Drawing.Point(495, 270);
            this.updateEmployeeSalary_tb.Name = "updateEmployeeSalary_tb";
            this.updateEmployeeSalary_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.updateEmployeeSalary_tb.PlaceholderText = "Enter Salary";
            this.updateEmployeeSalary_tb.SelectedText = "";
            this.updateEmployeeSalary_tb.Size = new System.Drawing.Size(165, 36);
            this.updateEmployeeSalary_tb.TabIndex = 15;
            this.updateEmployeeSalary_tb.TextChanged += new System.EventHandler(this.updateEmployeeSalary_tb_TextChanged);
            // 
            // updateEmployeeEmail_tb
            // 
            this.updateEmployeeEmail_tb.Animated = true;
            this.updateEmployeeEmail_tb.AutoRoundedCorners = true;
            this.updateEmployeeEmail_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateEmployeeEmail_tb.DefaultText = "";
            this.updateEmployeeEmail_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.updateEmployeeEmail_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.updateEmployeeEmail_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateEmployeeEmail_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateEmployeeEmail_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateEmployeeEmail_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmployeeEmail_tb.ForeColor = System.Drawing.Color.Black;
            this.updateEmployeeEmail_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateEmployeeEmail_tb.Location = new System.Drawing.Point(635, 140);
            this.updateEmployeeEmail_tb.Name = "updateEmployeeEmail_tb";
            this.updateEmployeeEmail_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.updateEmployeeEmail_tb.PlaceholderText = "Enter Email";
            this.updateEmployeeEmail_tb.SelectedText = "";
            this.updateEmployeeEmail_tb.Size = new System.Drawing.Size(165, 36);
            this.updateEmployeeEmail_tb.TabIndex = 14;
            this.updateEmployeeEmail_tb.TextChanged += new System.EventHandler(this.updateEmployeeEmail_tb_TextChanged);
            // 
            // updateEmployeeCnic_tb
            // 
            this.updateEmployeeCnic_tb.Animated = true;
            this.updateEmployeeCnic_tb.AutoRoundedCorners = true;
            this.updateEmployeeCnic_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateEmployeeCnic_tb.DefaultText = "";
            this.updateEmployeeCnic_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.updateEmployeeCnic_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.updateEmployeeCnic_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateEmployeeCnic_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateEmployeeCnic_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateEmployeeCnic_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmployeeCnic_tb.ForeColor = System.Drawing.Color.Black;
            this.updateEmployeeCnic_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateEmployeeCnic_tb.Location = new System.Drawing.Point(904, 140);
            this.updateEmployeeCnic_tb.Name = "updateEmployeeCnic_tb";
            this.updateEmployeeCnic_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.updateEmployeeCnic_tb.PlaceholderText = "Enter Cnic";
            this.updateEmployeeCnic_tb.SelectedText = "";
            this.updateEmployeeCnic_tb.Size = new System.Drawing.Size(165, 36);
            this.updateEmployeeCnic_tb.TabIndex = 13;
            this.updateEmployeeCnic_tb.TextChanged += new System.EventHandler(this.updateEmployeeCnic_tb_TextChanged);
            // 
            // updateEmployeeRole_tb
            // 
            this.updateEmployeeRole_tb.Animated = true;
            this.updateEmployeeRole_tb.AutoRoundedCorners = true;
            this.updateEmployeeRole_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateEmployeeRole_tb.DefaultText = "";
            this.updateEmployeeRole_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.updateEmployeeRole_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.updateEmployeeRole_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateEmployeeRole_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateEmployeeRole_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateEmployeeRole_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmployeeRole_tb.ForeColor = System.Drawing.Color.Black;
            this.updateEmployeeRole_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateEmployeeRole_tb.Location = new System.Drawing.Point(208, 267);
            this.updateEmployeeRole_tb.Name = "updateEmployeeRole_tb";
            this.updateEmployeeRole_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.updateEmployeeRole_tb.PlaceholderText = "Enter Role";
            this.updateEmployeeRole_tb.SelectedText = "";
            this.updateEmployeeRole_tb.Size = new System.Drawing.Size(165, 36);
            this.updateEmployeeRole_tb.TabIndex = 12;
            this.updateEmployeeRole_tb.TextChanged += new System.EventHandler(this.updateEmployeeRole_tb_TextChanged);
            // 
            // updateEmployeeNumber_tb
            // 
            this.updateEmployeeNumber_tb.Animated = true;
            this.updateEmployeeNumber_tb.AutoRoundedCorners = true;
            this.updateEmployeeNumber_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateEmployeeNumber_tb.DefaultText = "";
            this.updateEmployeeNumber_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.updateEmployeeNumber_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.updateEmployeeNumber_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateEmployeeNumber_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateEmployeeNumber_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateEmployeeNumber_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmployeeNumber_tb.ForeColor = System.Drawing.Color.Black;
            this.updateEmployeeNumber_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateEmployeeNumber_tb.Location = new System.Drawing.Point(355, 140);
            this.updateEmployeeNumber_tb.Name = "updateEmployeeNumber_tb";
            this.updateEmployeeNumber_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.updateEmployeeNumber_tb.PlaceholderText = "Enter Phone Number";
            this.updateEmployeeNumber_tb.SelectedText = "";
            this.updateEmployeeNumber_tb.Size = new System.Drawing.Size(165, 36);
            this.updateEmployeeNumber_tb.TabIndex = 11;
            this.updateEmployeeNumber_tb.TextChanged += new System.EventHandler(this.updateEmployeeNumber_tb_TextChanged);
            // 
            // updateEmployeeName_tb
            // 
            this.updateEmployeeName_tb.Animated = true;
            this.updateEmployeeName_tb.AutoRoundedCorners = true;
            this.updateEmployeeName_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateEmployeeName_tb.DefaultText = "";
            this.updateEmployeeName_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.updateEmployeeName_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.updateEmployeeName_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateEmployeeName_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateEmployeeName_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateEmployeeName_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmployeeName_tb.ForeColor = System.Drawing.Color.Black;
            this.updateEmployeeName_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateEmployeeName_tb.Location = new System.Drawing.Point(69, 140);
            this.updateEmployeeName_tb.Name = "updateEmployeeName_tb";
            this.updateEmployeeName_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.updateEmployeeName_tb.PlaceholderText = "Enter Name";
            this.updateEmployeeName_tb.SelectedText = "";
            this.updateEmployeeName_tb.Size = new System.Drawing.Size(165, 36);
            this.updateEmployeeName_tb.TabIndex = 10;
            this.updateEmployeeName_tb.TextChanged += new System.EventHandler(this.updateEmployeeName_tb_TextChanged);
            // 
            // employeeAdd_pnl
            // 
            this.employeeAdd_pnl.Controls.Add(this.label42);
            this.employeeAdd_pnl.Controls.Add(this.addEmployeeDone_btn);
            this.employeeAdd_pnl.Controls.Add(this.addEmployeeBack_btn);
            this.employeeAdd_pnl.Controls.Add(this.addEmployeeAddress_tb);
            this.employeeAdd_pnl.Controls.Add(this.addEmployeeSalary_tb);
            this.employeeAdd_pnl.Controls.Add(this.addEmployeeEmail_tb);
            this.employeeAdd_pnl.Controls.Add(this.addEmployeeCnic_tb);
            this.employeeAdd_pnl.Controls.Add(this.addEmployeeRole_tb);
            this.employeeAdd_pnl.Controls.Add(this.addEmployeeNumber_tb);
            this.employeeAdd_pnl.Controls.Add(this.addEmployeeName_tb);
            this.employeeAdd_pnl.Location = new System.Drawing.Point(0, 104);
            this.employeeAdd_pnl.Name = "employeeAdd_pnl";
            this.employeeAdd_pnl.Size = new System.Drawing.Size(1148, 577);
            this.employeeAdd_pnl.TabIndex = 5;
            this.employeeAdd_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.employeeAdd_pnl_Paint);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label42.Location = new System.Drawing.Point(498, 35);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(140, 25);
            this.label42.TabIndex = 9;
            this.label42.Text = "Add Employee";
            this.label42.Click += new System.EventHandler(this.label42_Click);
            // 
            // addEmployeeDone_btn
            // 
            this.addEmployeeDone_btn.Animated = true;
            this.addEmployeeDone_btn.AutoRoundedCorners = true;
            this.addEmployeeDone_btn.BackColor = System.Drawing.Color.Transparent;
            this.addEmployeeDone_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addEmployeeDone_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addEmployeeDone_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addEmployeeDone_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addEmployeeDone_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addEmployeeDone_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeDone_btn.ForeColor = System.Drawing.Color.Black;
            this.addEmployeeDone_btn.Location = new System.Drawing.Point(647, 395);
            this.addEmployeeDone_btn.Name = "addEmployeeDone_btn";
            this.addEmployeeDone_btn.Size = new System.Drawing.Size(180, 45);
            this.addEmployeeDone_btn.TabIndex = 8;
            this.addEmployeeDone_btn.Text = "Done";
            this.addEmployeeDone_btn.UseTransparentBackground = true;
            this.addEmployeeDone_btn.Click += new System.EventHandler(this.addEmployeeDone_btn_Click);
            // 
            // addEmployeeBack_btn
            // 
            this.addEmployeeBack_btn.Animated = true;
            this.addEmployeeBack_btn.AutoRoundedCorners = true;
            this.addEmployeeBack_btn.BackColor = System.Drawing.Color.Transparent;
            this.addEmployeeBack_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addEmployeeBack_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addEmployeeBack_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addEmployeeBack_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addEmployeeBack_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addEmployeeBack_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeBack_btn.ForeColor = System.Drawing.Color.Black;
            this.addEmployeeBack_btn.Location = new System.Drawing.Point(340, 395);
            this.addEmployeeBack_btn.Name = "addEmployeeBack_btn";
            this.addEmployeeBack_btn.Size = new System.Drawing.Size(180, 45);
            this.addEmployeeBack_btn.TabIndex = 7;
            this.addEmployeeBack_btn.Text = "Back";
            this.addEmployeeBack_btn.UseTransparentBackground = true;
            this.addEmployeeBack_btn.Click += new System.EventHandler(this.addEmployeeBack_btn_Click);
            // 
            // addEmployeeAddress_tb
            // 
            this.addEmployeeAddress_tb.Animated = true;
            this.addEmployeeAddress_tb.AutoRoundedCorners = true;
            this.addEmployeeAddress_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addEmployeeAddress_tb.DefaultText = "";
            this.addEmployeeAddress_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addEmployeeAddress_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addEmployeeAddress_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addEmployeeAddress_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addEmployeeAddress_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addEmployeeAddress_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeAddress_tb.ForeColor = System.Drawing.Color.Black;
            this.addEmployeeAddress_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addEmployeeAddress_tb.Location = new System.Drawing.Point(778, 263);
            this.addEmployeeAddress_tb.Name = "addEmployeeAddress_tb";
            this.addEmployeeAddress_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.addEmployeeAddress_tb.PlaceholderText = "Enter Address";
            this.addEmployeeAddress_tb.SelectedText = "";
            this.addEmployeeAddress_tb.Size = new System.Drawing.Size(165, 36);
            this.addEmployeeAddress_tb.TabIndex = 6;
            this.addEmployeeAddress_tb.TextChanged += new System.EventHandler(this.addEmployeeAddress_tb_TextChanged);
            // 
            // addEmployeeSalary_tb
            // 
            this.addEmployeeSalary_tb.Animated = true;
            this.addEmployeeSalary_tb.AutoRoundedCorners = true;
            this.addEmployeeSalary_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addEmployeeSalary_tb.DefaultText = "";
            this.addEmployeeSalary_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addEmployeeSalary_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addEmployeeSalary_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addEmployeeSalary_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addEmployeeSalary_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addEmployeeSalary_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addEmployeeSalary_tb.ForeColor = System.Drawing.Color.Black;
            this.addEmployeeSalary_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addEmployeeSalary_tb.Location = new System.Drawing.Point(495, 263);
            this.addEmployeeSalary_tb.Name = "addEmployeeSalary_tb";
            this.addEmployeeSalary_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.addEmployeeSalary_tb.PlaceholderText = "Enter Salary";
            this.addEmployeeSalary_tb.SelectedText = "";
            this.addEmployeeSalary_tb.Size = new System.Drawing.Size(165, 36);
            this.addEmployeeSalary_tb.TabIndex = 5;
            this.addEmployeeSalary_tb.TextChanged += new System.EventHandler(this.addEmployeeSalary_tb_TextChanged);
            // 
            // addEmployeeEmail_tb
            // 
            this.addEmployeeEmail_tb.Animated = true;
            this.addEmployeeEmail_tb.AutoRoundedCorners = true;
            this.addEmployeeEmail_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addEmployeeEmail_tb.DefaultText = "";
            this.addEmployeeEmail_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addEmployeeEmail_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addEmployeeEmail_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addEmployeeEmail_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addEmployeeEmail_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addEmployeeEmail_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeEmail_tb.ForeColor = System.Drawing.Color.Black;
            this.addEmployeeEmail_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addEmployeeEmail_tb.Location = new System.Drawing.Point(635, 133);
            this.addEmployeeEmail_tb.Name = "addEmployeeEmail_tb";
            this.addEmployeeEmail_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.addEmployeeEmail_tb.PlaceholderText = "Enter Email";
            this.addEmployeeEmail_tb.SelectedText = "";
            this.addEmployeeEmail_tb.Size = new System.Drawing.Size(165, 36);
            this.addEmployeeEmail_tb.TabIndex = 4;
            this.addEmployeeEmail_tb.TextChanged += new System.EventHandler(this.addEmployeeEmail_tb_TextChanged);
            // 
            // addEmployeeCnic_tb
            // 
            this.addEmployeeCnic_tb.Animated = true;
            this.addEmployeeCnic_tb.AutoRoundedCorners = true;
            this.addEmployeeCnic_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addEmployeeCnic_tb.DefaultText = "";
            this.addEmployeeCnic_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addEmployeeCnic_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addEmployeeCnic_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addEmployeeCnic_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addEmployeeCnic_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addEmployeeCnic_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeCnic_tb.ForeColor = System.Drawing.Color.Black;
            this.addEmployeeCnic_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addEmployeeCnic_tb.Location = new System.Drawing.Point(904, 133);
            this.addEmployeeCnic_tb.Name = "addEmployeeCnic_tb";
            this.addEmployeeCnic_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.addEmployeeCnic_tb.PlaceholderText = "Enter Cnic";
            this.addEmployeeCnic_tb.SelectedText = "";
            this.addEmployeeCnic_tb.Size = new System.Drawing.Size(165, 36);
            this.addEmployeeCnic_tb.TabIndex = 3;
            this.addEmployeeCnic_tb.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // addEmployeeRole_tb
            // 
            this.addEmployeeRole_tb.Animated = true;
            this.addEmployeeRole_tb.AutoRoundedCorners = true;
            this.addEmployeeRole_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addEmployeeRole_tb.DefaultText = "";
            this.addEmployeeRole_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addEmployeeRole_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addEmployeeRole_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addEmployeeRole_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addEmployeeRole_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addEmployeeRole_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeRole_tb.ForeColor = System.Drawing.Color.Black;
            this.addEmployeeRole_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addEmployeeRole_tb.Location = new System.Drawing.Point(208, 260);
            this.addEmployeeRole_tb.Name = "addEmployeeRole_tb";
            this.addEmployeeRole_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.addEmployeeRole_tb.PlaceholderText = "Enter Role";
            this.addEmployeeRole_tb.SelectedText = "";
            this.addEmployeeRole_tb.Size = new System.Drawing.Size(165, 36);
            this.addEmployeeRole_tb.TabIndex = 2;
            this.addEmployeeRole_tb.TextChanged += new System.EventHandler(this.addEmployeeRole_tb_TextChanged);
            // 
            // addEmployeeNumber_tb
            // 
            this.addEmployeeNumber_tb.Animated = true;
            this.addEmployeeNumber_tb.AutoRoundedCorners = true;
            this.addEmployeeNumber_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addEmployeeNumber_tb.DefaultText = "";
            this.addEmployeeNumber_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addEmployeeNumber_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addEmployeeNumber_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addEmployeeNumber_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addEmployeeNumber_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addEmployeeNumber_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeNumber_tb.ForeColor = System.Drawing.Color.Black;
            this.addEmployeeNumber_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addEmployeeNumber_tb.Location = new System.Drawing.Point(355, 133);
            this.addEmployeeNumber_tb.Name = "addEmployeeNumber_tb";
            this.addEmployeeNumber_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.addEmployeeNumber_tb.PlaceholderText = "Enter Phone Number";
            this.addEmployeeNumber_tb.SelectedText = "";
            this.addEmployeeNumber_tb.Size = new System.Drawing.Size(165, 36);
            this.addEmployeeNumber_tb.TabIndex = 1;
            this.addEmployeeNumber_tb.TextChanged += new System.EventHandler(this.addEmployeeNumber_tb_TextChanged);
            // 
            // addEmployeeName_tb
            // 
            this.addEmployeeName_tb.Animated = true;
            this.addEmployeeName_tb.AutoRoundedCorners = true;
            this.addEmployeeName_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addEmployeeName_tb.DefaultText = "";
            this.addEmployeeName_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addEmployeeName_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addEmployeeName_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addEmployeeName_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addEmployeeName_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addEmployeeName_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeName_tb.ForeColor = System.Drawing.Color.Black;
            this.addEmployeeName_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addEmployeeName_tb.Location = new System.Drawing.Point(69, 133);
            this.addEmployeeName_tb.Name = "addEmployeeName_tb";
            this.addEmployeeName_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.addEmployeeName_tb.PlaceholderText = "Enter Name";
            this.addEmployeeName_tb.SelectedText = "";
            this.addEmployeeName_tb.Size = new System.Drawing.Size(165, 36);
            this.addEmployeeName_tb.TabIndex = 0;
            this.addEmployeeName_tb.TextChanged += new System.EventHandler(this.addEmployeeName_tb_TextChanged);
            // 
            // employeeDelete_btn
            // 
            this.employeeDelete_btn.Animated = true;
            this.employeeDelete_btn.AutoRoundedCorners = true;
            this.employeeDelete_btn.BackColor = System.Drawing.Color.Transparent;
            this.employeeDelete_btn.BorderColor = System.Drawing.Color.White;
            this.employeeDelete_btn.BorderThickness = 1;
            this.employeeDelete_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.employeeDelete_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.employeeDelete_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.employeeDelete_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.employeeDelete_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.employeeDelete_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.employeeDelete_btn.ForeColor = System.Drawing.Color.Black;
            this.employeeDelete_btn.Location = new System.Drawing.Point(944, 623);
            this.employeeDelete_btn.Name = "employeeDelete_btn";
            this.employeeDelete_btn.Size = new System.Drawing.Size(180, 45);
            this.employeeDelete_btn.TabIndex = 4;
            this.employeeDelete_btn.Text = "DELETE";
            this.employeeDelete_btn.UseTransparentBackground = true;
            this.employeeDelete_btn.Click += new System.EventHandler(this.employeeDelete_btn_Click);
            // 
            // employeeUpdate_btn
            // 
            this.employeeUpdate_btn.Animated = true;
            this.employeeUpdate_btn.AutoRoundedCorners = true;
            this.employeeUpdate_btn.BackColor = System.Drawing.Color.Transparent;
            this.employeeUpdate_btn.BorderColor = System.Drawing.Color.White;
            this.employeeUpdate_btn.BorderThickness = 1;
            this.employeeUpdate_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.employeeUpdate_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.employeeUpdate_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.employeeUpdate_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.employeeUpdate_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.employeeUpdate_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.employeeUpdate_btn.ForeColor = System.Drawing.Color.Black;
            this.employeeUpdate_btn.Location = new System.Drawing.Point(486, 623);
            this.employeeUpdate_btn.Name = "employeeUpdate_btn";
            this.employeeUpdate_btn.Size = new System.Drawing.Size(180, 45);
            this.employeeUpdate_btn.TabIndex = 3;
            this.employeeUpdate_btn.Text = "UPDATE";
            this.employeeUpdate_btn.UseTransparentBackground = true;
            this.employeeUpdate_btn.Click += new System.EventHandler(this.employeeUpdate_btn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Location = new System.Drawing.Point(2, 623);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "ADD";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // admin_employee_gridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.admin_employee_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admin_employee_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.admin_employee_gridView.ColumnHeadersHeight = 40;
            this.admin_employee_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.admin_employee_gridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.admin_employee_gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_employee_gridView.Location = new System.Drawing.Point(3, 114);
            this.admin_employee_gridView.Name = "admin_employee_gridView";
            this.admin_employee_gridView.RowHeadersVisible = false;
            this.admin_employee_gridView.Size = new System.Drawing.Size(1121, 400);
            this.admin_employee_gridView.TabIndex = 1;
            this.admin_employee_gridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_employee_gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.admin_employee_gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.admin_employee_gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.admin_employee_gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.admin_employee_gridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.admin_employee_gridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_employee_gridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.admin_employee_gridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.admin_employee_gridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_employee_gridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.admin_employee_gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.admin_employee_gridView.ThemeStyle.HeaderStyle.Height = 40;
            this.admin_employee_gridView.ThemeStyle.ReadOnly = false;
            this.admin_employee_gridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_employee_gridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.admin_employee_gridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_employee_gridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_employee_gridView.ThemeStyle.RowsStyle.Height = 22;
            this.admin_employee_gridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_employee_gridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_employee_gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admin_employee_gridView_CellContentClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(461, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 39);
            this.label14.TabIndex = 0;
            this.label14.Text = "Employees";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // admin_service_pnl
            // 
            this.admin_service_pnl.Controls.Add(this.addService_pnl);
            this.admin_service_pnl.Controls.Add(this.admin_serviceDelete_btn);
            this.admin_service_pnl.Controls.Add(this.updateService_pnl);
            this.admin_service_pnl.Controls.Add(this.admin_serviceUpdate_btn);
            this.admin_service_pnl.Controls.Add(this.admin_serviceAdd_btn);
            this.admin_service_pnl.Controls.Add(this.label16);
            this.admin_service_pnl.Controls.Add(this.admin_service_gridView);
            this.admin_service_pnl.Location = new System.Drawing.Point(206, 702);
            this.admin_service_pnl.Name = "admin_service_pnl";
            this.admin_service_pnl.Size = new System.Drawing.Size(1145, 750);
            this.admin_service_pnl.TabIndex = 6;
            this.admin_service_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.admin_service_pnl_Paint);
            // 
            // addService_pnl
            // 
            this.addService_pnl.Controls.Add(this.addServiceBack_btn);
            this.addService_pnl.Controls.Add(this.addServicePrice_tb);
            this.addService_pnl.Controls.Add(this.addServiceDiscription_tb);
            this.addService_pnl.Controls.Add(this.addServiceName_tb);
            this.addService_pnl.Controls.Add(this.addServiceDone_btn);
            this.addService_pnl.Location = new System.Drawing.Point(2, 104);
            this.addService_pnl.Name = "addService_pnl";
            this.addService_pnl.Size = new System.Drawing.Size(1145, 577);
            this.addService_pnl.TabIndex = 5;
            this.addService_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.addService_pnl_Paint);
            // 
            // addServiceBack_btn
            // 
            this.addServiceBack_btn.Animated = true;
            this.addServiceBack_btn.AutoRoundedCorners = true;
            this.addServiceBack_btn.BackColor = System.Drawing.Color.Transparent;
            this.addServiceBack_btn.BorderThickness = 1;
            this.addServiceBack_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addServiceBack_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addServiceBack_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addServiceBack_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addServiceBack_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addServiceBack_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addServiceBack_btn.ForeColor = System.Drawing.Color.Black;
            this.addServiceBack_btn.Location = new System.Drawing.Point(287, 352);
            this.addServiceBack_btn.Name = "addServiceBack_btn";
            this.addServiceBack_btn.Size = new System.Drawing.Size(180, 45);
            this.addServiceBack_btn.TabIndex = 7;
            this.addServiceBack_btn.Text = "Back";
            this.addServiceBack_btn.UseTransparentBackground = true;
            this.addServiceBack_btn.Click += new System.EventHandler(this.addServiceBack_btn_Click);
            // 
            // addServicePrice_tb
            // 
            this.addServicePrice_tb.Animated = true;
            this.addServicePrice_tb.AutoRoundedCorners = true;
            this.addServicePrice_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addServicePrice_tb.DefaultText = "";
            this.addServicePrice_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addServicePrice_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addServicePrice_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addServicePrice_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addServicePrice_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addServicePrice_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addServicePrice_tb.ForeColor = System.Drawing.Color.Black;
            this.addServicePrice_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addServicePrice_tb.Location = new System.Drawing.Point(825, 130);
            this.addServicePrice_tb.Name = "addServicePrice_tb";
            this.addServicePrice_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.addServicePrice_tb.PlaceholderText = "Enter Service Price";
            this.addServicePrice_tb.SelectedText = "";
            this.addServicePrice_tb.Size = new System.Drawing.Size(200, 36);
            this.addServicePrice_tb.TabIndex = 3;
            this.addServicePrice_tb.TextChanged += new System.EventHandler(this.addServicePrice_tb_TextChanged);
            // 
            // addServiceDiscription_tb
            // 
            this.addServiceDiscription_tb.Animated = true;
            this.addServiceDiscription_tb.AutoRoundedCorners = true;
            this.addServiceDiscription_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addServiceDiscription_tb.DefaultText = "";
            this.addServiceDiscription_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addServiceDiscription_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addServiceDiscription_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addServiceDiscription_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addServiceDiscription_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addServiceDiscription_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addServiceDiscription_tb.ForeColor = System.Drawing.Color.Black;
            this.addServiceDiscription_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addServiceDiscription_tb.Location = new System.Drawing.Point(466, 130);
            this.addServiceDiscription_tb.Name = "addServiceDiscription_tb";
            this.addServiceDiscription_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.addServiceDiscription_tb.PlaceholderText = "Enter Service Discription";
            this.addServiceDiscription_tb.SelectedText = "";
            this.addServiceDiscription_tb.Size = new System.Drawing.Size(200, 36);
            this.addServiceDiscription_tb.TabIndex = 2;
            this.addServiceDiscription_tb.TextChanged += new System.EventHandler(this.addServiceDiscription_tb_TextChanged);
            // 
            // addServiceName_tb
            // 
            this.addServiceName_tb.Animated = true;
            this.addServiceName_tb.AutoRoundedCorners = true;
            this.addServiceName_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addServiceName_tb.DefaultText = "";
            this.addServiceName_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addServiceName_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addServiceName_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addServiceName_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addServiceName_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addServiceName_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addServiceName_tb.ForeColor = System.Drawing.Color.Black;
            this.addServiceName_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addServiceName_tb.Location = new System.Drawing.Point(105, 130);
            this.addServiceName_tb.Name = "addServiceName_tb";
            this.addServiceName_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.addServiceName_tb.PlaceholderText = "Enter Service Name";
            this.addServiceName_tb.SelectedText = "";
            this.addServiceName_tb.Size = new System.Drawing.Size(200, 36);
            this.addServiceName_tb.TabIndex = 1;
            this.addServiceName_tb.TextChanged += new System.EventHandler(this.addServiceName_tb_TextChanged);
            // 
            // addServiceDone_btn
            // 
            this.addServiceDone_btn.Animated = true;
            this.addServiceDone_btn.AutoRoundedCorners = true;
            this.addServiceDone_btn.BackColor = System.Drawing.Color.Transparent;
            this.addServiceDone_btn.BorderThickness = 1;
            this.addServiceDone_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addServiceDone_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addServiceDone_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addServiceDone_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addServiceDone_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addServiceDone_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.addServiceDone_btn.ForeColor = System.Drawing.Color.Black;
            this.addServiceDone_btn.Location = new System.Drawing.Point(644, 352);
            this.addServiceDone_btn.Name = "addServiceDone_btn";
            this.addServiceDone_btn.Size = new System.Drawing.Size(180, 45);
            this.addServiceDone_btn.TabIndex = 0;
            this.addServiceDone_btn.Text = "Done";
            this.addServiceDone_btn.UseTransparentBackground = true;
            this.addServiceDone_btn.Click += new System.EventHandler(this.addServiceDone_btn_Click);
            // 
            // admin_serviceDelete_btn
            // 
            this.admin_serviceDelete_btn.Animated = true;
            this.admin_serviceDelete_btn.AutoRoundedCorners = true;
            this.admin_serviceDelete_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_serviceDelete_btn.BorderColor = System.Drawing.Color.White;
            this.admin_serviceDelete_btn.BorderThickness = 1;
            this.admin_serviceDelete_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_serviceDelete_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_serviceDelete_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_serviceDelete_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_serviceDelete_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.admin_serviceDelete_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.admin_serviceDelete_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_serviceDelete_btn.Location = new System.Drawing.Point(944, 623);
            this.admin_serviceDelete_btn.Name = "admin_serviceDelete_btn";
            this.admin_serviceDelete_btn.Size = new System.Drawing.Size(180, 45);
            this.admin_serviceDelete_btn.TabIndex = 4;
            this.admin_serviceDelete_btn.Text = "DELETE";
            this.admin_serviceDelete_btn.UseTransparentBackground = true;
            this.admin_serviceDelete_btn.Click += new System.EventHandler(this.admin_serviceDelete_btn_Click);
            // 
            // updateService_pnl
            // 
            this.updateService_pnl.Controls.Add(this.updateServicePrice_tb);
            this.updateService_pnl.Controls.Add(this.updateServiceDiscription_tb);
            this.updateService_pnl.Controls.Add(this.updateServiceName_tb);
            this.updateService_pnl.Controls.Add(this.updateServiceDone_btn);
            this.updateService_pnl.Controls.Add(this.guna2Button6);
            this.updateService_pnl.Location = new System.Drawing.Point(0, 104);
            this.updateService_pnl.Name = "updateService_pnl";
            this.updateService_pnl.Size = new System.Drawing.Size(1145, 577);
            this.updateService_pnl.TabIndex = 6;
            this.updateService_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.updateService_pnl_Paint);
            // 
            // updateServicePrice_tb
            // 
            this.updateServicePrice_tb.Animated = true;
            this.updateServicePrice_tb.AutoRoundedCorners = true;
            this.updateServicePrice_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateServicePrice_tb.DefaultText = "";
            this.updateServicePrice_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.updateServicePrice_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.updateServicePrice_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateServicePrice_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateServicePrice_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateServicePrice_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateServicePrice_tb.ForeColor = System.Drawing.Color.Black;
            this.updateServicePrice_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateServicePrice_tb.Location = new System.Drawing.Point(824, 130);
            this.updateServicePrice_tb.Name = "updateServicePrice_tb";
            this.updateServicePrice_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.updateServicePrice_tb.PlaceholderText = "Enter Service Price";
            this.updateServicePrice_tb.SelectedText = "";
            this.updateServicePrice_tb.Size = new System.Drawing.Size(201, 36);
            this.updateServicePrice_tb.TabIndex = 4;
            this.updateServicePrice_tb.TextChanged += new System.EventHandler(this.updateServicePrice_tb_TextChanged);
            // 
            // updateServiceDiscription_tb
            // 
            this.updateServiceDiscription_tb.Animated = true;
            this.updateServiceDiscription_tb.AutoRoundedCorners = true;
            this.updateServiceDiscription_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateServiceDiscription_tb.DefaultText = "";
            this.updateServiceDiscription_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.updateServiceDiscription_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.updateServiceDiscription_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateServiceDiscription_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateServiceDiscription_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateServiceDiscription_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.updateServiceDiscription_tb.ForeColor = System.Drawing.Color.Black;
            this.updateServiceDiscription_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateServiceDiscription_tb.Location = new System.Drawing.Point(467, 130);
            this.updateServiceDiscription_tb.Name = "updateServiceDiscription_tb";
            this.updateServiceDiscription_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.updateServiceDiscription_tb.PlaceholderText = "Enter Service Discription";
            this.updateServiceDiscription_tb.SelectedText = "";
            this.updateServiceDiscription_tb.Size = new System.Drawing.Size(199, 36);
            this.updateServiceDiscription_tb.TabIndex = 3;
            this.updateServiceDiscription_tb.TextChanged += new System.EventHandler(this.updateServiceDiscription_tb_TextChanged);
            // 
            // updateServiceName_tb
            // 
            this.updateServiceName_tb.Animated = true;
            this.updateServiceName_tb.AutoRoundedCorners = true;
            this.updateServiceName_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateServiceName_tb.DefaultText = "";
            this.updateServiceName_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.updateServiceName_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.updateServiceName_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateServiceName_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateServiceName_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateServiceName_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateServiceName_tb.ForeColor = System.Drawing.Color.Black;
            this.updateServiceName_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateServiceName_tb.Location = new System.Drawing.Point(105, 130);
            this.updateServiceName_tb.Name = "updateServiceName_tb";
            this.updateServiceName_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.updateServiceName_tb.PlaceholderText = "Enter Service Name";
            this.updateServiceName_tb.SelectedText = "";
            this.updateServiceName_tb.Size = new System.Drawing.Size(200, 36);
            this.updateServiceName_tb.TabIndex = 2;
            this.updateServiceName_tb.TextChanged += new System.EventHandler(this.updateServiceName_tb_TextChanged);
            // 
            // updateServiceDone_btn
            // 
            this.updateServiceDone_btn.Animated = true;
            this.updateServiceDone_btn.AutoRoundedCorners = true;
            this.updateServiceDone_btn.BackColor = System.Drawing.Color.Transparent;
            this.updateServiceDone_btn.BorderThickness = 1;
            this.updateServiceDone_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateServiceDone_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateServiceDone_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateServiceDone_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateServiceDone_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updateServiceDone_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateServiceDone_btn.ForeColor = System.Drawing.Color.Black;
            this.updateServiceDone_btn.Location = new System.Drawing.Point(644, 352);
            this.updateServiceDone_btn.Name = "updateServiceDone_btn";
            this.updateServiceDone_btn.Size = new System.Drawing.Size(180, 45);
            this.updateServiceDone_btn.TabIndex = 1;
            this.updateServiceDone_btn.Text = "Done";
            this.updateServiceDone_btn.UseTransparentBackground = true;
            this.updateServiceDone_btn.Click += new System.EventHandler(this.updateServiceDone_btn_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.Animated = true;
            this.guna2Button6.AutoRoundedCorners = true;
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderThickness = 1;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.Black;
            this.guna2Button6.Location = new System.Drawing.Point(287, 352);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(180, 45);
            this.guna2Button6.TabIndex = 0;
            this.guna2Button6.Text = "Back";
            this.guna2Button6.UseTransparentBackground = true;
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // admin_serviceUpdate_btn
            // 
            this.admin_serviceUpdate_btn.Animated = true;
            this.admin_serviceUpdate_btn.AutoRoundedCorners = true;
            this.admin_serviceUpdate_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_serviceUpdate_btn.BorderColor = System.Drawing.Color.White;
            this.admin_serviceUpdate_btn.BorderThickness = 1;
            this.admin_serviceUpdate_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_serviceUpdate_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_serviceUpdate_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_serviceUpdate_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_serviceUpdate_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.admin_serviceUpdate_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.admin_serviceUpdate_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_serviceUpdate_btn.Location = new System.Drawing.Point(486, 623);
            this.admin_serviceUpdate_btn.Name = "admin_serviceUpdate_btn";
            this.admin_serviceUpdate_btn.Size = new System.Drawing.Size(180, 45);
            this.admin_serviceUpdate_btn.TabIndex = 3;
            this.admin_serviceUpdate_btn.Text = "UPDATE";
            this.admin_serviceUpdate_btn.UseTransparentBackground = true;
            this.admin_serviceUpdate_btn.Click += new System.EventHandler(this.admin_serviceUpdate_btn_Click);
            // 
            // admin_serviceAdd_btn
            // 
            this.admin_serviceAdd_btn.Animated = true;
            this.admin_serviceAdd_btn.AutoRoundedCorners = true;
            this.admin_serviceAdd_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_serviceAdd_btn.BorderColor = System.Drawing.Color.White;
            this.admin_serviceAdd_btn.BorderThickness = 1;
            this.admin_serviceAdd_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_serviceAdd_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_serviceAdd_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_serviceAdd_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_serviceAdd_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.admin_serviceAdd_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.admin_serviceAdd_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_serviceAdd_btn.Location = new System.Drawing.Point(2, 623);
            this.admin_serviceAdd_btn.Name = "admin_serviceAdd_btn";
            this.admin_serviceAdd_btn.Size = new System.Drawing.Size(180, 45);
            this.admin_serviceAdd_btn.TabIndex = 2;
            this.admin_serviceAdd_btn.Text = "ADD";
            this.admin_serviceAdd_btn.UseTransparentBackground = true;
            this.admin_serviceAdd_btn.Click += new System.EventHandler(this.admin_serviceAdd_btn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(467, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 39);
            this.label16.TabIndex = 1;
            this.label16.Text = "Services";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // admin_service_gridView
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.admin_service_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admin_service_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.admin_service_gridView.ColumnHeadersHeight = 40;
            this.admin_service_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.admin_service_gridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.admin_service_gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_service_gridView.Location = new System.Drawing.Point(3, 114);
            this.admin_service_gridView.Name = "admin_service_gridView";
            this.admin_service_gridView.RowHeadersVisible = false;
            this.admin_service_gridView.Size = new System.Drawing.Size(1121, 400);
            this.admin_service_gridView.TabIndex = 0;
            this.admin_service_gridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_service_gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.admin_service_gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.admin_service_gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.admin_service_gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.admin_service_gridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.admin_service_gridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_service_gridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.admin_service_gridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.admin_service_gridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_service_gridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.admin_service_gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.admin_service_gridView.ThemeStyle.HeaderStyle.Height = 40;
            this.admin_service_gridView.ThemeStyle.ReadOnly = false;
            this.admin_service_gridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_service_gridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.admin_service_gridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_service_gridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_service_gridView.ThemeStyle.RowsStyle.Height = 22;
            this.admin_service_gridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_service_gridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_service_gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admin_service_gridView_CellContentClick);
            // 
            // admin_clients_pnl
            // 
            this.admin_clients_pnl.Controls.Add(this.admin_client_gridView);
            this.admin_clients_pnl.Controls.Add(this.label18);
            this.admin_clients_pnl.Location = new System.Drawing.Point(206, 707);
            this.admin_clients_pnl.Name = "admin_clients_pnl";
            this.admin_clients_pnl.Size = new System.Drawing.Size(1148, 751);
            this.admin_clients_pnl.TabIndex = 7;
            this.admin_clients_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.admin_clients_pnl_Paint);
            // 
            // admin_client_gridView
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.admin_client_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admin_client_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.admin_client_gridView.ColumnHeadersHeight = 40;
            this.admin_client_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.admin_client_gridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.admin_client_gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_client_gridView.Location = new System.Drawing.Point(3, 114);
            this.admin_client_gridView.Name = "admin_client_gridView";
            this.admin_client_gridView.RowHeadersVisible = false;
            this.admin_client_gridView.Size = new System.Drawing.Size(1121, 400);
            this.admin_client_gridView.TabIndex = 1;
            this.admin_client_gridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_client_gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.admin_client_gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.admin_client_gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.admin_client_gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.admin_client_gridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.admin_client_gridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_client_gridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.admin_client_gridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.admin_client_gridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_client_gridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.admin_client_gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.admin_client_gridView.ThemeStyle.HeaderStyle.Height = 40;
            this.admin_client_gridView.ThemeStyle.ReadOnly = false;
            this.admin_client_gridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_client_gridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.admin_client_gridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_client_gridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_client_gridView.ThemeStyle.RowsStyle.Height = 22;
            this.admin_client_gridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_client_gridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_client_gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admin_client_gridView_CellContentClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(489, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 39);
            this.label18.TabIndex = 0;
            this.label18.Text = "Clients";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // admin_schedule_pnl
            // 
            this.admin_schedule_pnl.Controls.Add(this.admin_scheduleTurnOffAlert);
            this.admin_schedule_pnl.Controls.Add(this.admin_scheduleSendAlert_btn);
            this.admin_schedule_pnl.Controls.Add(this.label20);
            this.admin_schedule_pnl.Controls.Add(this.admin_schedule_gridView);
            this.admin_schedule_pnl.Controls.Add(this.guna2CustomGradientPanel5);
            this.admin_schedule_pnl.Location = new System.Drawing.Point(206, 717);
            this.admin_schedule_pnl.Name = "admin_schedule_pnl";
            this.admin_schedule_pnl.Size = new System.Drawing.Size(1151, 751);
            this.admin_schedule_pnl.TabIndex = 8;
            this.admin_schedule_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.admin_schedule_pnl_Paint);
            // 
            // admin_scheduleTurnOffAlert
            // 
            this.admin_scheduleTurnOffAlert.Animated = true;
            this.admin_scheduleTurnOffAlert.AutoRoundedCorners = true;
            this.admin_scheduleTurnOffAlert.BackColor = System.Drawing.Color.Transparent;
            this.admin_scheduleTurnOffAlert.BorderColor = System.Drawing.Color.White;
            this.admin_scheduleTurnOffAlert.BorderThickness = 1;
            this.admin_scheduleTurnOffAlert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_scheduleTurnOffAlert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_scheduleTurnOffAlert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_scheduleTurnOffAlert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_scheduleTurnOffAlert.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.admin_scheduleTurnOffAlert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.admin_scheduleTurnOffAlert.ForeColor = System.Drawing.Color.Black;
            this.admin_scheduleTurnOffAlert.Location = new System.Drawing.Point(868, 652);
            this.admin_scheduleTurnOffAlert.Name = "admin_scheduleTurnOffAlert";
            this.admin_scheduleTurnOffAlert.Size = new System.Drawing.Size(180, 45);
            this.admin_scheduleTurnOffAlert.TabIndex = 4;
            this.admin_scheduleTurnOffAlert.Text = "Turn off Alert";
            this.admin_scheduleTurnOffAlert.UseTransparentBackground = true;
            this.admin_scheduleTurnOffAlert.Click += new System.EventHandler(this.admin_scheduleTurnOffAlert_Click);
            // 
            // admin_scheduleSendAlert_btn
            // 
            this.admin_scheduleSendAlert_btn.Animated = true;
            this.admin_scheduleSendAlert_btn.AutoRoundedCorners = true;
            this.admin_scheduleSendAlert_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_scheduleSendAlert_btn.BorderColor = System.Drawing.Color.White;
            this.admin_scheduleSendAlert_btn.BorderThickness = 1;
            this.admin_scheduleSendAlert_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_scheduleSendAlert_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_scheduleSendAlert_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_scheduleSendAlert_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_scheduleSendAlert_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.admin_scheduleSendAlert_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.admin_scheduleSendAlert_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_scheduleSendAlert_btn.Location = new System.Drawing.Point(92, 652);
            this.admin_scheduleSendAlert_btn.Name = "admin_scheduleSendAlert_btn";
            this.admin_scheduleSendAlert_btn.Size = new System.Drawing.Size(180, 45);
            this.admin_scheduleSendAlert_btn.TabIndex = 3;
            this.admin_scheduleSendAlert_btn.Text = "Send Alert";
            this.admin_scheduleSendAlert_btn.UseTransparentBackground = true;
            this.admin_scheduleSendAlert_btn.Click += new System.EventHandler(this.admin_scheduleSendAlert_btn_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(485, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(169, 39);
            this.label20.TabIndex = 2;
            this.label20.Text = "Schedule";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // admin_schedule_gridView
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.admin_schedule_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admin_schedule_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.admin_schedule_gridView.ColumnHeadersHeight = 40;
            this.admin_schedule_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.admin_schedule_gridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.admin_schedule_gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_schedule_gridView.Location = new System.Drawing.Point(3, 104);
            this.admin_schedule_gridView.Name = "admin_schedule_gridView";
            this.admin_schedule_gridView.RowHeadersVisible = false;
            this.admin_schedule_gridView.Size = new System.Drawing.Size(1121, 365);
            this.admin_schedule_gridView.TabIndex = 1;
            this.admin_schedule_gridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_schedule_gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.admin_schedule_gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.admin_schedule_gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.admin_schedule_gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.admin_schedule_gridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.admin_schedule_gridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_schedule_gridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.admin_schedule_gridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.admin_schedule_gridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_schedule_gridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.admin_schedule_gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.admin_schedule_gridView.ThemeStyle.HeaderStyle.Height = 40;
            this.admin_schedule_gridView.ThemeStyle.ReadOnly = false;
            this.admin_schedule_gridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_schedule_gridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.admin_schedule_gridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_schedule_gridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_schedule_gridView.ThemeStyle.RowsStyle.Height = 22;
            this.admin_schedule_gridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_schedule_gridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_schedule_gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // guna2CustomGradientPanel5
            // 
            this.guna2CustomGradientPanel5.AutoRoundedCorners = true;
            this.guna2CustomGradientPanel5.Controls.Add(this.admin_scheduleDueService_lbl);
            this.guna2CustomGradientPanel5.Controls.Add(this.label22);
            this.guna2CustomGradientPanel5.FillColor = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel5.FillColor2 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel5.FillColor3 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel5.FillColor4 = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel5.Location = new System.Drawing.Point(311, 495);
            this.guna2CustomGradientPanel5.Name = "guna2CustomGradientPanel5";
            this.guna2CustomGradientPanel5.Size = new System.Drawing.Size(489, 84);
            this.guna2CustomGradientPanel5.TabIndex = 0;
            this.guna2CustomGradientPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel5_Paint);
            // 
            // admin_scheduleDueService_lbl
            // 
            this.admin_scheduleDueService_lbl.AutoSize = true;
            this.admin_scheduleDueService_lbl.BackColor = System.Drawing.Color.Transparent;
            this.admin_scheduleDueService_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_scheduleDueService_lbl.Location = new System.Drawing.Point(236, 47);
            this.admin_scheduleDueService_lbl.Name = "admin_scheduleDueService_lbl";
            this.admin_scheduleDueService_lbl.Size = new System.Drawing.Size(38, 20);
            this.admin_scheduleDueService_lbl.TabIndex = 1;
            this.admin_scheduleDueService_lbl.Text = "N/A";
            this.admin_scheduleDueService_lbl.Click += new System.EventHandler(this.admin_scheduleDueService_lbl_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(196, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 20);
            this.label22.TabIndex = 0;
            this.label22.Text = "Due Services";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // admin_financialReport_pnl
            // 
            this.admin_financialReport_pnl.Controls.Add(this.addExpennse_pnl);
            this.admin_financialReport_pnl.Controls.Add(this.admin_financialReportPrint_btn);
            this.admin_financialReport_pnl.Controls.Add(this.admin_financialReportMonthSelection_cb);
            this.admin_financialReport_pnl.Controls.Add(this.guna2Panel1);
            this.admin_financialReport_pnl.Controls.Add(this.admin_financialReportExpenses_btn);
            this.admin_financialReport_pnl.Controls.Add(this.label28);
            this.admin_financialReport_pnl.Controls.Add(this.label26);
            this.admin_financialReport_pnl.Controls.Add(this.admin_financialReportExpenses_gridView);
            this.admin_financialReport_pnl.Controls.Add(this.admin_financialReportIncome_gridView);
            this.admin_financialReport_pnl.Controls.Add(this.label24);
            this.admin_financialReport_pnl.Location = new System.Drawing.Point(206, 723);
            this.admin_financialReport_pnl.Name = "admin_financialReport_pnl";
            this.admin_financialReport_pnl.Size = new System.Drawing.Size(1151, 748);
            this.admin_financialReport_pnl.TabIndex = 9;
            this.admin_financialReport_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.admin_financialReport_pnl_Paint);
            // 
            // addExpennse_pnl
            // 
            this.addExpennse_pnl.Controls.Add(this.expenseDiscription_tb);
            this.addExpennse_pnl.Controls.Add(this.expenseAmount_tb);
            this.addExpennse_pnl.Controls.Add(this.addExpenseBack_btn);
            this.addExpennse_pnl.Location = new System.Drawing.Point(0, 101);
            this.addExpennse_pnl.Name = "addExpennse_pnl";
            this.addExpennse_pnl.Size = new System.Drawing.Size(1157, 751);
            this.addExpennse_pnl.TabIndex = 9;
            this.addExpennse_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.addExpennse_pnl_Paint);
            // 
            // expenseDiscription_tb
            // 
            this.expenseDiscription_tb.Animated = true;
            this.expenseDiscription_tb.AutoRoundedCorners = true;
            this.expenseDiscription_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expenseDiscription_tb.DefaultText = "";
            this.expenseDiscription_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.expenseDiscription_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.expenseDiscription_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expenseDiscription_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expenseDiscription_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expenseDiscription_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseDiscription_tb.ForeColor = System.Drawing.Color.Black;
            this.expenseDiscription_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expenseDiscription_tb.Location = new System.Drawing.Point(580, 130);
            this.expenseDiscription_tb.Name = "expenseDiscription_tb";
            this.expenseDiscription_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.expenseDiscription_tb.PlaceholderText = "Enter Discription";
            this.expenseDiscription_tb.SelectedText = "";
            this.expenseDiscription_tb.Size = new System.Drawing.Size(255, 95);
            this.expenseDiscription_tb.TabIndex = 3;
            this.expenseDiscription_tb.TextChanged += new System.EventHandler(this.expenseDiscription_tb_TextChanged);
            // 
            // expenseAmount_tb
            // 
            this.expenseAmount_tb.Animated = true;
            this.expenseAmount_tb.AutoRoundedCorners = true;
            this.expenseAmount_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expenseAmount_tb.DefaultText = "";
            this.expenseAmount_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.expenseAmount_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.expenseAmount_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expenseAmount_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expenseAmount_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expenseAmount_tb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseAmount_tb.ForeColor = System.Drawing.Color.Black;
            this.expenseAmount_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expenseAmount_tb.Location = new System.Drawing.Point(240, 130);
            this.expenseAmount_tb.Name = "expenseAmount_tb";
            this.expenseAmount_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.expenseAmount_tb.PlaceholderText = "Enter Amount";
            this.expenseAmount_tb.SelectedText = "";
            this.expenseAmount_tb.Size = new System.Drawing.Size(255, 95);
            this.expenseAmount_tb.TabIndex = 2;
            this.expenseAmount_tb.TextChanged += new System.EventHandler(this.expenseAmount_tb_TextChanged);
            // 
            // addExpenseBack_btn
            // 
            this.addExpenseBack_btn.Animated = true;
            this.addExpenseBack_btn.AutoRoundedCorners = true;
            this.addExpenseBack_btn.BackColor = System.Drawing.Color.Transparent;
            this.addExpenseBack_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addExpenseBack_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addExpenseBack_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addExpenseBack_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addExpenseBack_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addExpenseBack_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseBack_btn.ForeColor = System.Drawing.Color.Black;
            this.addExpenseBack_btn.Location = new System.Drawing.Point(453, 400);
            this.addExpenseBack_btn.Name = "addExpenseBack_btn";
            this.addExpenseBack_btn.Size = new System.Drawing.Size(180, 45);
            this.addExpenseBack_btn.TabIndex = 1;
            this.addExpenseBack_btn.Text = "Done";
            this.addExpenseBack_btn.UseTransparentBackground = true;
            this.addExpenseBack_btn.Click += new System.EventHandler(this.addExpenseBack_btn_Click);
            // 
            // admin_financialReportPrint_btn
            // 
            this.admin_financialReportPrint_btn.Animated = true;
            this.admin_financialReportPrint_btn.AutoRoundedCorners = true;
            this.admin_financialReportPrint_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_financialReportPrint_btn.BorderColor = System.Drawing.Color.White;
            this.admin_financialReportPrint_btn.BorderThickness = 1;
            this.admin_financialReportPrint_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_financialReportPrint_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_financialReportPrint_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_financialReportPrint_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_financialReportPrint_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.admin_financialReportPrint_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_financialReportPrint_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_financialReportPrint_btn.Location = new System.Drawing.Point(876, 659);
            this.admin_financialReportPrint_btn.Name = "admin_financialReportPrint_btn";
            this.admin_financialReportPrint_btn.Size = new System.Drawing.Size(180, 35);
            this.admin_financialReportPrint_btn.TabIndex = 8;
            this.admin_financialReportPrint_btn.Text = "Print";
            this.admin_financialReportPrint_btn.UseTransparentBackground = true;
            this.admin_financialReportPrint_btn.Click += new System.EventHandler(this.admin_financialReportPrint_btn_Click);
            // 
            // admin_financialReportMonthSelection_cb
            // 
            this.admin_financialReportMonthSelection_cb.AutoRoundedCorners = true;
            this.admin_financialReportMonthSelection_cb.BackColor = System.Drawing.Color.Transparent;
            this.admin_financialReportMonthSelection_cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.admin_financialReportMonthSelection_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.admin_financialReportMonthSelection_cb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.admin_financialReportMonthSelection_cb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.admin_financialReportMonthSelection_cb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.admin_financialReportMonthSelection_cb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.admin_financialReportMonthSelection_cb.ItemHeight = 30;
            this.admin_financialReportMonthSelection_cb.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.admin_financialReportMonthSelection_cb.Location = new System.Drawing.Point(10, 650);
            this.admin_financialReportMonthSelection_cb.Name = "admin_financialReportMonthSelection_cb";
            this.admin_financialReportMonthSelection_cb.Size = new System.Drawing.Size(140, 36);
            this.admin_financialReportMonthSelection_cb.TabIndex = 7;
            this.admin_financialReportMonthSelection_cb.SelectedIndexChanged += new System.EventHandler(this.admin_financialReportMonthSelection_cb_SelectedIndexChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.admin_financialReportProfit_lbl);
            this.guna2Panel1.Controls.Add(this.label41);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(166, 629);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(655, 77);
            this.guna2Panel1.TabIndex = 6;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // admin_financialReportProfit_lbl
            // 
            this.admin_financialReportProfit_lbl.AutoSize = true;
            this.admin_financialReportProfit_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_financialReportProfit_lbl.Location = new System.Drawing.Point(320, 40);
            this.admin_financialReportProfit_lbl.Name = "admin_financialReportProfit_lbl";
            this.admin_financialReportProfit_lbl.Size = new System.Drawing.Size(31, 17);
            this.admin_financialReportProfit_lbl.TabIndex = 1;
            this.admin_financialReportProfit_lbl.Text = "N/A";
            this.admin_financialReportProfit_lbl.Click += new System.EventHandler(this.admin_financialReportProfit_lbl_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(93, 3);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(147, 21);
            this.label41.TabIndex = 0;
            this.label41.Text = "This month profit:";
            this.label41.Click += new System.EventHandler(this.label41_Click);
            // 
            // admin_financialReportExpenses_btn
            // 
            this.admin_financialReportExpenses_btn.Animated = true;
            this.admin_financialReportExpenses_btn.AutoRoundedCorners = true;
            this.admin_financialReportExpenses_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_financialReportExpenses_btn.BorderColor = System.Drawing.Color.White;
            this.admin_financialReportExpenses_btn.BorderThickness = 1;
            this.admin_financialReportExpenses_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_financialReportExpenses_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_financialReportExpenses_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_financialReportExpenses_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_financialReportExpenses_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.admin_financialReportExpenses_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.admin_financialReportExpenses_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_financialReportExpenses_btn.Location = new System.Drawing.Point(876, 618);
            this.admin_financialReportExpenses_btn.Name = "admin_financialReportExpenses_btn";
            this.admin_financialReportExpenses_btn.Size = new System.Drawing.Size(180, 35);
            this.admin_financialReportExpenses_btn.TabIndex = 5;
            this.admin_financialReportExpenses_btn.Text = "Add Expenses";
            this.admin_financialReportExpenses_btn.UseTransparentBackground = true;
            this.admin_financialReportExpenses_btn.Click += new System.EventHandler(this.admin_financialReportExpenses_btn_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(789, 139);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(115, 25);
            this.label28.TabIndex = 4;
            this.label28.Text = "Expenses";
            this.label28.Click += new System.EventHandler(this.label28_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label26.Location = new System.Drawing.Point(258, 141);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 25);
            this.label26.TabIndex = 3;
            this.label26.Text = "Income";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // admin_financialReportExpenses_gridView
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.admin_financialReportExpenses_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admin_financialReportExpenses_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.admin_financialReportExpenses_gridView.ColumnHeadersHeight = 40;
            this.admin_financialReportExpenses_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.admin_financialReportExpenses_gridView.DefaultCellStyle = dataGridViewCellStyle21;
            this.admin_financialReportExpenses_gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_financialReportExpenses_gridView.Location = new System.Drawing.Point(591, 172);
            this.admin_financialReportExpenses_gridView.Name = "admin_financialReportExpenses_gridView";
            this.admin_financialReportExpenses_gridView.RowHeadersVisible = false;
            this.admin_financialReportExpenses_gridView.Size = new System.Drawing.Size(465, 435);
            this.admin_financialReportExpenses_gridView.TabIndex = 2;
            this.admin_financialReportExpenses_gridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_financialReportExpenses_gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.admin_financialReportExpenses_gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.admin_financialReportExpenses_gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.admin_financialReportExpenses_gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.admin_financialReportExpenses_gridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.admin_financialReportExpenses_gridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_financialReportExpenses_gridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.admin_financialReportExpenses_gridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.admin_financialReportExpenses_gridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_financialReportExpenses_gridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.admin_financialReportExpenses_gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.admin_financialReportExpenses_gridView.ThemeStyle.HeaderStyle.Height = 40;
            this.admin_financialReportExpenses_gridView.ThemeStyle.ReadOnly = false;
            this.admin_financialReportExpenses_gridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_financialReportExpenses_gridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.admin_financialReportExpenses_gridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_financialReportExpenses_gridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_financialReportExpenses_gridView.ThemeStyle.RowsStyle.Height = 22;
            this.admin_financialReportExpenses_gridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_financialReportExpenses_gridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_financialReportExpenses_gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admin_financialReportExpenses_gridView_CellContentClick);
            // 
            // admin_financialReportIncome_gridView
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.admin_financialReportIncome_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admin_financialReportIncome_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.admin_financialReportIncome_gridView.ColumnHeadersHeight = 40;
            this.admin_financialReportIncome_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.admin_financialReportIncome_gridView.DefaultCellStyle = dataGridViewCellStyle24;
            this.admin_financialReportIncome_gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_financialReportIncome_gridView.Location = new System.Drawing.Point(66, 172);
            this.admin_financialReportIncome_gridView.Name = "admin_financialReportIncome_gridView";
            this.admin_financialReportIncome_gridView.RowHeadersVisible = false;
            this.admin_financialReportIncome_gridView.Size = new System.Drawing.Size(465, 435);
            this.admin_financialReportIncome_gridView.TabIndex = 1;
            this.admin_financialReportIncome_gridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_financialReportIncome_gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.admin_financialReportIncome_gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.admin_financialReportIncome_gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.admin_financialReportIncome_gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.admin_financialReportIncome_gridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.admin_financialReportIncome_gridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_financialReportIncome_gridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.admin_financialReportIncome_gridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.admin_financialReportIncome_gridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_financialReportIncome_gridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.admin_financialReportIncome_gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.admin_financialReportIncome_gridView.ThemeStyle.HeaderStyle.Height = 40;
            this.admin_financialReportIncome_gridView.ThemeStyle.ReadOnly = false;
            this.admin_financialReportIncome_gridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_financialReportIncome_gridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.admin_financialReportIncome_gridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_financialReportIncome_gridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_financialReportIncome_gridView.ThemeStyle.RowsStyle.Height = 22;
            this.admin_financialReportIncome_gridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_financialReportIncome_gridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_financialReportIncome_gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick_1);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label24.Location = new System.Drawing.Point(405, 37);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(285, 39);
            this.label24.TabIndex = 0;
            this.label24.Text = "Financial Report";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // admin_appointment_pnl
            // 
            this.admin_appointment_pnl.Controls.Add(this.admin_appointmentCompletedToday_gridView);
            this.admin_appointment_pnl.Controls.Add(this.label33);
            this.admin_appointment_pnl.Controls.Add(this.admin_appointmentThisMonth_gridview);
            this.admin_appointment_pnl.Controls.Add(this.label32);
            this.admin_appointment_pnl.Controls.Add(this.admin_appointmentTodayAppointment_gridView);
            this.admin_appointment_pnl.Controls.Add(this.label31);
            this.admin_appointment_pnl.Controls.Add(this.label30);
            this.admin_appointment_pnl.Location = new System.Drawing.Point(206, 740);
            this.admin_appointment_pnl.Name = "admin_appointment_pnl";
            this.admin_appointment_pnl.Size = new System.Drawing.Size(1148, 751);
            this.admin_appointment_pnl.TabIndex = 10;
            this.admin_appointment_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.admin_appointment_pnl_Paint);
            // 
            // admin_appointmentCompletedToday_gridView
            // 
            this.admin_appointmentCompletedToday_gridView.AllowUserToAddRows = false;
            this.admin_appointmentCompletedToday_gridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.admin_appointmentCompletedToday_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admin_appointmentCompletedToday_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.admin_appointmentCompletedToday_gridView.ColumnHeadersHeight = 40;
            this.admin_appointmentCompletedToday_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.admin_appointmentCompletedToday_gridView.DefaultCellStyle = dataGridViewCellStyle27;
            this.admin_appointmentCompletedToday_gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_appointmentCompletedToday_gridView.Location = new System.Drawing.Point(3, 550);
            this.admin_appointmentCompletedToday_gridView.Name = "admin_appointmentCompletedToday_gridView";
            this.admin_appointmentCompletedToday_gridView.ReadOnly = true;
            this.admin_appointmentCompletedToday_gridView.RowHeadersVisible = false;
            this.admin_appointmentCompletedToday_gridView.Size = new System.Drawing.Size(1121, 150);
            this.admin_appointmentCompletedToday_gridView.TabIndex = 6;
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.HeaderStyle.Height = 40;
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.ReadOnly = true;
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.RowsStyle.Height = 22;
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_appointmentCompletedToday_gridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_appointmentCompletedToday_gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admin_appointmentCompletedToday_gridView_CellContentClick);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label33.Location = new System.Drawing.Point(3, 514);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(270, 25);
            this.label33.TabIndex = 5;
            this.label33.Text = "Appointments completed";
            this.label33.Click += new System.EventHandler(this.label33_Click);
            // 
            // admin_appointmentThisMonth_gridview
            // 
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.admin_appointmentThisMonth_gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admin_appointmentThisMonth_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.admin_appointmentThisMonth_gridview.ColumnHeadersHeight = 40;
            this.admin_appointmentThisMonth_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.admin_appointmentThisMonth_gridview.DefaultCellStyle = dataGridViewCellStyle30;
            this.admin_appointmentThisMonth_gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_appointmentThisMonth_gridview.Location = new System.Drawing.Point(3, 343);
            this.admin_appointmentThisMonth_gridview.Name = "admin_appointmentThisMonth_gridview";
            this.admin_appointmentThisMonth_gridview.RowHeadersVisible = false;
            this.admin_appointmentThisMonth_gridview.Size = new System.Drawing.Size(1121, 150);
            this.admin_appointmentThisMonth_gridview.TabIndex = 4;
            this.admin_appointmentThisMonth_gridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_appointmentThisMonth_gridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.admin_appointmentThisMonth_gridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.admin_appointmentThisMonth_gridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.admin_appointmentThisMonth_gridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.admin_appointmentThisMonth_gridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.admin_appointmentThisMonth_gridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_appointmentThisMonth_gridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.admin_appointmentThisMonth_gridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.admin_appointmentThisMonth_gridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_appointmentThisMonth_gridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.admin_appointmentThisMonth_gridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.admin_appointmentThisMonth_gridview.ThemeStyle.HeaderStyle.Height = 40;
            this.admin_appointmentThisMonth_gridview.ThemeStyle.ReadOnly = false;
            this.admin_appointmentThisMonth_gridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_appointmentThisMonth_gridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.admin_appointmentThisMonth_gridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_appointmentThisMonth_gridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_appointmentThisMonth_gridview.ThemeStyle.RowsStyle.Height = 22;
            this.admin_appointmentThisMonth_gridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_appointmentThisMonth_gridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_appointmentThisMonth_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admin_appointmentThisMonth_gridview_CellContentClick);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label32.Location = new System.Drawing.Point(3, 313);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(271, 25);
            this.label32.TabIndex = 3;
            this.label32.Text = "Appointments this month";
            this.label32.Click += new System.EventHandler(this.label32_Click);
            // 
            // admin_appointmentTodayAppointment_gridView
            // 
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            this.admin_appointmentTodayAppointment_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admin_appointmentTodayAppointment_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.admin_appointmentTodayAppointment_gridView.ColumnHeadersHeight = 40;
            this.admin_appointmentTodayAppointment_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.admin_appointmentTodayAppointment_gridView.DefaultCellStyle = dataGridViewCellStyle33;
            this.admin_appointmentTodayAppointment_gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_appointmentTodayAppointment_gridView.Location = new System.Drawing.Point(3, 144);
            this.admin_appointmentTodayAppointment_gridView.Name = "admin_appointmentTodayAppointment_gridView";
            this.admin_appointmentTodayAppointment_gridView.RowHeadersVisible = false;
            this.admin_appointmentTodayAppointment_gridView.Size = new System.Drawing.Size(1121, 150);
            this.admin_appointmentTodayAppointment_gridView.TabIndex = 2;
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.HeaderStyle.Height = 40;
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.ReadOnly = false;
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.RowsStyle.Height = 22;
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_appointmentTodayAppointment_gridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_appointmentTodayAppointment_gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admin_appointmentTodayAppointment_gridView_CellContentClick);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label31.Location = new System.Drawing.Point(291, 37);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(242, 39);
            this.label31.TabIndex = 1;
            this.label31.Text = "Appointments";
            this.label31.Click += new System.EventHandler(this.label31_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label30.Location = new System.Drawing.Point(3, 106);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(244, 25);
            this.label30.TabIndex = 0;
            this.label30.Text = "Today\'s Appointments";
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // admin_user_pnl
            // 
            this.admin_user_pnl.Controls.Add(this.manageOtherUserEdit_pnl);
            this.admin_user_pnl.Controls.Add(this.admin_userSecurityAnswer_lbl);
            this.admin_user_pnl.Controls.Add(this.admin_userSecurityQuestion_lbl);
            this.admin_user_pnl.Controls.Add(this.admin_userEmail_lbl);
            this.admin_user_pnl.Controls.Add(this.admin_userManagerOtherUsers_pnl);
            this.admin_user_pnl.Controls.Add(this.admin_userCnic_lbl);
            this.admin_user_pnl.Controls.Add(this.admin_userPhone_lbl);
            this.admin_user_pnl.Controls.Add(this.cnic_lbl);
            this.admin_user_pnl.Controls.Add(this.phone_lbl);
            this.admin_user_pnl.Controls.Add(this.securityA_lbl);
            this.admin_user_pnl.Controls.Add(this.email_lbl);
            this.admin_user_pnl.Controls.Add(this.securityQ_lbl);
            this.admin_user_pnl.Controls.Add(this.admin_userEdit_pnl);
            this.admin_user_pnl.Controls.Add(this.admin_userManageOtherUsers_btn);
            this.admin_user_pnl.Controls.Add(this.admin_userEdit_btn);
            this.admin_user_pnl.Controls.Add(this.admin_userOccupation_lbl);
            this.admin_user_pnl.Controls.Add(this.label38);
            this.admin_user_pnl.Controls.Add(this.admin_userPassword_lbl);
            this.admin_user_pnl.Controls.Add(this.label37);
            this.admin_user_pnl.Controls.Add(this.admin_userUsername_lbl);
            this.admin_user_pnl.Controls.Add(this.label35);
            this.admin_user_pnl.Controls.Add(this.admin_user_Name_lbl);
            this.admin_user_pnl.Controls.Add(this.label36);
            this.admin_user_pnl.Controls.Add(this.admin_userAccountType_lbl);
            this.admin_user_pnl.Controls.Add(this.label34);
            this.admin_user_pnl.Location = new System.Drawing.Point(206, 726);
            this.admin_user_pnl.Name = "admin_user_pnl";
            this.admin_user_pnl.Size = new System.Drawing.Size(1148, 748);
            this.admin_user_pnl.TabIndex = 11;
            this.admin_user_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.admin_user_pnl_Paint);
            // 
            // manageOtherUserEdit_pnl
            // 
            this.manageOtherUserEdit_pnl.Controls.Add(this.label61);
            this.manageOtherUserEdit_pnl.Controls.Add(this.editUserAccountType_tb);
            this.manageOtherUserEdit_pnl.Controls.Add(this.label40);
            this.manageOtherUserEdit_pnl.Controls.Add(this.label53);
            this.manageOtherUserEdit_pnl.Controls.Add(this.label54);
            this.manageOtherUserEdit_pnl.Controls.Add(this.label55);
            this.manageOtherUserEdit_pnl.Controls.Add(this.label56);
            this.manageOtherUserEdit_pnl.Controls.Add(this.label57);
            this.manageOtherUserEdit_pnl.Controls.Add(this.label58);
            this.manageOtherUserEdit_pnl.Controls.Add(this.label59);
            this.manageOtherUserEdit_pnl.Controls.Add(this.label60);
            this.manageOtherUserEdit_pnl.Controls.Add(this.editUserSecurityQuestion_cb);
            this.manageOtherUserEdit_pnl.Controls.Add(this.editUserSecurityAnswer_tb);
            this.manageOtherUserEdit_pnl.Controls.Add(this.editUserCnic_tb);
            this.manageOtherUserEdit_pnl.Controls.Add(this.editUserPhone_tb);
            this.manageOtherUserEdit_pnl.Controls.Add(this.editUserEmail_tb);
            this.manageOtherUserEdit_pnl.Controls.Add(this.editUserOccupation_tb);
            this.manageOtherUserEdit_pnl.Controls.Add(this.editUserPassword_tb);
            this.manageOtherUserEdit_pnl.Controls.Add(this.editUserUsername_tb);
            this.manageOtherUserEdit_pnl.Controls.Add(this.editUserName_tb);
            this.manageOtherUserEdit_pnl.Controls.Add(this.guna2Button2);
            this.manageOtherUserEdit_pnl.Controls.Add(this.guna2Button3);
            this.manageOtherUserEdit_pnl.Location = new System.Drawing.Point(60, 46);
            this.manageOtherUserEdit_pnl.Name = "manageOtherUserEdit_pnl";
            this.manageOtherUserEdit_pnl.Size = new System.Drawing.Size(1014, 608);
            this.manageOtherUserEdit_pnl.TabIndex = 6;
            this.manageOtherUserEdit_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.manageOtherUserEdit_pnl_Paint);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label61.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label61.Location = new System.Drawing.Point(512, 186);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(156, 25);
            this.label61.TabIndex = 58;
            this.label61.Text = "Account Type";
            // 
            // editUserAccountType_tb
            // 
            this.editUserAccountType_tb.Animated = true;
            this.editUserAccountType_tb.AutoRoundedCorners = true;
            this.editUserAccountType_tb.BorderColor = System.Drawing.Color.Black;
            this.editUserAccountType_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editUserAccountType_tb.DefaultText = "";
            this.editUserAccountType_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.editUserAccountType_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.editUserAccountType_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserAccountType_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserAccountType_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserAccountType_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.editUserAccountType_tb.ForeColor = System.Drawing.Color.Black;
            this.editUserAccountType_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserAccountType_tb.Location = new System.Drawing.Point(497, 216);
            this.editUserAccountType_tb.Name = "editUserAccountType_tb";
            this.editUserAccountType_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.editUserAccountType_tb.PlaceholderText = "Account Type";
            this.editUserAccountType_tb.SelectedText = "";
            this.editUserAccountType_tb.Size = new System.Drawing.Size(200, 36);
            this.editUserAccountType_tb.TabIndex = 57;
            this.editUserAccountType_tb.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label40.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label40.Location = new System.Drawing.Point(52, 25);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(72, 25);
            this.label40.TabIndex = 56;
            this.label40.Text = "Name";
            this.label40.Click += new System.EventHandler(this.label40_Click_1);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label53.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label53.Location = new System.Drawing.Point(279, 25);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(118, 25);
            this.label53.TabIndex = 55;
            this.label53.Text = "Username";
            this.label53.Click += new System.EventHandler(this.label53_Click);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label54.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label54.Location = new System.Drawing.Point(510, 25);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(114, 25);
            this.label54.TabIndex = 54;
            this.label54.Text = "Password";
            this.label54.Click += new System.EventHandler(this.label54_Click);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label55.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label55.Location = new System.Drawing.Point(732, 25);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(60, 25);
            this.label55.TabIndex = 53;
            this.label55.Text = "Role";
            this.label55.Click += new System.EventHandler(this.label55_Click);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label56.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label56.Location = new System.Drawing.Point(52, 112);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(70, 25);
            this.label56.TabIndex = 52;
            this.label56.Text = "Email";
            this.label56.Click += new System.EventHandler(this.label56_Click);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label57.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label57.Location = new System.Drawing.Point(279, 112);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(167, 25);
            this.label57.TabIndex = 51;
            this.label57.Text = "Phone Number";
            this.label57.Click += new System.EventHandler(this.label57_Click);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label58.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label58.Location = new System.Drawing.Point(510, 108);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(59, 25);
            this.label58.TabIndex = 50;
            this.label58.Text = "Cnic";
            this.label58.Click += new System.EventHandler(this.label58_Click);
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label59.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label59.Location = new System.Drawing.Point(732, 107);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(199, 25);
            this.label59.TabIndex = 49;
            this.label59.Text = "Security Question";
            this.label59.Click += new System.EventHandler(this.label59_Click);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label60.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label60.Location = new System.Drawing.Point(732, 187);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(182, 25);
            this.label60.TabIndex = 48;
            this.label60.Text = "Security Answer";
            this.label60.Click += new System.EventHandler(this.label60_Click);
            // 
            // editUserSecurityQuestion_cb
            // 
            this.editUserSecurityQuestion_cb.AutoRoundedCorners = true;
            this.editUserSecurityQuestion_cb.BackColor = System.Drawing.Color.Transparent;
            this.editUserSecurityQuestion_cb.BorderColor = System.Drawing.Color.Black;
            this.editUserSecurityQuestion_cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.editUserSecurityQuestion_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editUserSecurityQuestion_cb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserSecurityQuestion_cb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserSecurityQuestion_cb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editUserSecurityQuestion_cb.ForeColor = System.Drawing.Color.Black;
            this.editUserSecurityQuestion_cb.ItemHeight = 30;
            this.editUserSecurityQuestion_cb.Items.AddRange(new object[] {
            "Father Name",
            "Mother Name",
            "Pet Name",
            "School Name",
            "Best Friend Name",
            "How Many Borthers",
            "How Many Sisters"});
            this.editUserSecurityQuestion_cb.Location = new System.Drawing.Point(724, 136);
            this.editUserSecurityQuestion_cb.Name = "editUserSecurityQuestion_cb";
            this.editUserSecurityQuestion_cb.Size = new System.Drawing.Size(200, 36);
            this.editUserSecurityQuestion_cb.TabIndex = 47;
            this.editUserSecurityQuestion_cb.SelectedIndexChanged += new System.EventHandler(this.editUserSecurityQuestion_cb_SelectedIndexChanged);
            // 
            // editUserSecurityAnswer_tb
            // 
            this.editUserSecurityAnswer_tb.Animated = true;
            this.editUserSecurityAnswer_tb.AutoRoundedCorners = true;
            this.editUserSecurityAnswer_tb.BorderColor = System.Drawing.Color.Black;
            this.editUserSecurityAnswer_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editUserSecurityAnswer_tb.DefaultText = "";
            this.editUserSecurityAnswer_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.editUserSecurityAnswer_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.editUserSecurityAnswer_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserSecurityAnswer_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserSecurityAnswer_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserSecurityAnswer_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.editUserSecurityAnswer_tb.ForeColor = System.Drawing.Color.Black;
            this.editUserSecurityAnswer_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserSecurityAnswer_tb.Location = new System.Drawing.Point(724, 216);
            this.editUserSecurityAnswer_tb.Name = "editUserSecurityAnswer_tb";
            this.editUserSecurityAnswer_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.editUserSecurityAnswer_tb.PlaceholderText = "Security Answer";
            this.editUserSecurityAnswer_tb.SelectedText = "";
            this.editUserSecurityAnswer_tb.Size = new System.Drawing.Size(200, 36);
            this.editUserSecurityAnswer_tb.TabIndex = 46;
            this.editUserSecurityAnswer_tb.TextChanged += new System.EventHandler(this.editUserSecurityAnswer_tb_TextChanged);
            // 
            // editUserCnic_tb
            // 
            this.editUserCnic_tb.Animated = true;
            this.editUserCnic_tb.AutoRoundedCorners = true;
            this.editUserCnic_tb.BorderColor = System.Drawing.Color.Black;
            this.editUserCnic_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editUserCnic_tb.DefaultText = "";
            this.editUserCnic_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.editUserCnic_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.editUserCnic_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserCnic_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserCnic_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserCnic_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.editUserCnic_tb.ForeColor = System.Drawing.Color.Black;
            this.editUserCnic_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserCnic_tb.Location = new System.Drawing.Point(497, 136);
            this.editUserCnic_tb.Name = "editUserCnic_tb";
            this.editUserCnic_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.editUserCnic_tb.PlaceholderText = "Cnic";
            this.editUserCnic_tb.SelectedText = "";
            this.editUserCnic_tb.Size = new System.Drawing.Size(200, 36);
            this.editUserCnic_tb.TabIndex = 45;
            this.editUserCnic_tb.TextChanged += new System.EventHandler(this.editUserCnic_tb_TextChanged);
            // 
            // editUserPhone_tb
            // 
            this.editUserPhone_tb.Animated = true;
            this.editUserPhone_tb.AutoRoundedCorners = true;
            this.editUserPhone_tb.BorderColor = System.Drawing.Color.Black;
            this.editUserPhone_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editUserPhone_tb.DefaultText = "";
            this.editUserPhone_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.editUserPhone_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.editUserPhone_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserPhone_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserPhone_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserPhone_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.editUserPhone_tb.ForeColor = System.Drawing.Color.Black;
            this.editUserPhone_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserPhone_tb.Location = new System.Drawing.Point(271, 136);
            this.editUserPhone_tb.Name = "editUserPhone_tb";
            this.editUserPhone_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.editUserPhone_tb.PlaceholderText = "Phone(+923000000000)";
            this.editUserPhone_tb.SelectedText = "";
            this.editUserPhone_tb.Size = new System.Drawing.Size(200, 36);
            this.editUserPhone_tb.TabIndex = 44;
            this.editUserPhone_tb.TextChanged += new System.EventHandler(this.editUserPhone_tb_TextChanged);
            // 
            // editUserEmail_tb
            // 
            this.editUserEmail_tb.Animated = true;
            this.editUserEmail_tb.AutoRoundedCorners = true;
            this.editUserEmail_tb.BorderColor = System.Drawing.Color.Black;
            this.editUserEmail_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editUserEmail_tb.DefaultText = "";
            this.editUserEmail_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.editUserEmail_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.editUserEmail_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserEmail_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserEmail_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserEmail_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.editUserEmail_tb.ForeColor = System.Drawing.Color.Black;
            this.editUserEmail_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserEmail_tb.Location = new System.Drawing.Point(44, 136);
            this.editUserEmail_tb.Name = "editUserEmail_tb";
            this.editUserEmail_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.editUserEmail_tb.PlaceholderText = "Email";
            this.editUserEmail_tb.SelectedText = "";
            this.editUserEmail_tb.Size = new System.Drawing.Size(201, 36);
            this.editUserEmail_tb.TabIndex = 43;
            this.editUserEmail_tb.TextChanged += new System.EventHandler(this.editUserEmail_tb_TextChanged);
            // 
            // editUserOccupation_tb
            // 
            this.editUserOccupation_tb.Animated = true;
            this.editUserOccupation_tb.AutoRoundedCorners = true;
            this.editUserOccupation_tb.BorderColor = System.Drawing.Color.Black;
            this.editUserOccupation_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editUserOccupation_tb.DefaultText = "";
            this.editUserOccupation_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.editUserOccupation_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.editUserOccupation_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserOccupation_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserOccupation_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserOccupation_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.editUserOccupation_tb.ForeColor = System.Drawing.Color.Black;
            this.editUserOccupation_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserOccupation_tb.Location = new System.Drawing.Point(724, 53);
            this.editUserOccupation_tb.Name = "editUserOccupation_tb";
            this.editUserOccupation_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.editUserOccupation_tb.PlaceholderText = "Occupation";
            this.editUserOccupation_tb.SelectedText = "";
            this.editUserOccupation_tb.Size = new System.Drawing.Size(200, 39);
            this.editUserOccupation_tb.TabIndex = 42;
            this.editUserOccupation_tb.TextChanged += new System.EventHandler(this.editUserOccupation_tb_TextChanged);
            // 
            // editUserPassword_tb
            // 
            this.editUserPassword_tb.Animated = true;
            this.editUserPassword_tb.AutoRoundedCorners = true;
            this.editUserPassword_tb.BorderColor = System.Drawing.Color.Black;
            this.editUserPassword_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editUserPassword_tb.DefaultText = "";
            this.editUserPassword_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.editUserPassword_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.editUserPassword_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserPassword_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserPassword_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserPassword_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.editUserPassword_tb.ForeColor = System.Drawing.Color.Black;
            this.editUserPassword_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserPassword_tb.Location = new System.Drawing.Point(497, 54);
            this.editUserPassword_tb.Name = "editUserPassword_tb";
            this.editUserPassword_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.editUserPassword_tb.PlaceholderText = "Password";
            this.editUserPassword_tb.SelectedText = "";
            this.editUserPassword_tb.Size = new System.Drawing.Size(200, 38);
            this.editUserPassword_tb.TabIndex = 41;
            this.editUserPassword_tb.TextChanged += new System.EventHandler(this.editUserPassword_tb_TextChanged);
            // 
            // editUserUsername_tb
            // 
            this.editUserUsername_tb.Animated = true;
            this.editUserUsername_tb.AutoRoundedCorners = true;
            this.editUserUsername_tb.BorderColor = System.Drawing.Color.Black;
            this.editUserUsername_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editUserUsername_tb.DefaultText = "";
            this.editUserUsername_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.editUserUsername_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.editUserUsername_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserUsername_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserUsername_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserUsername_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.editUserUsername_tb.ForeColor = System.Drawing.Color.Black;
            this.editUserUsername_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserUsername_tb.Location = new System.Drawing.Point(271, 54);
            this.editUserUsername_tb.Name = "editUserUsername_tb";
            this.editUserUsername_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.editUserUsername_tb.PlaceholderText = "Username";
            this.editUserUsername_tb.SelectedText = "";
            this.editUserUsername_tb.Size = new System.Drawing.Size(200, 38);
            this.editUserUsername_tb.TabIndex = 40;
            this.editUserUsername_tb.TextChanged += new System.EventHandler(this.editUserUsername_tb_TextChanged);
            // 
            // editUserName_tb
            // 
            this.editUserName_tb.Animated = true;
            this.editUserName_tb.AutoRoundedCorners = true;
            this.editUserName_tb.BorderColor = System.Drawing.Color.Black;
            this.editUserName_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editUserName_tb.DefaultText = "";
            this.editUserName_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.editUserName_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.editUserName_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserName_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editUserName_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserName_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.editUserName_tb.ForeColor = System.Drawing.Color.Black;
            this.editUserName_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editUserName_tb.Location = new System.Drawing.Point(44, 54);
            this.editUserName_tb.Name = "editUserName_tb";
            this.editUserName_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.editUserName_tb.PlaceholderText = "Name";
            this.editUserName_tb.SelectedText = "";
            this.editUserName_tb.Size = new System.Drawing.Size(201, 38);
            this.editUserName_tb.TabIndex = 39;
            this.editUserName_tb.TextChanged += new System.EventHandler(this.editUserName_tb_TextChanged);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Location = new System.Drawing.Point(410, 347);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(183, 37);
            this.guna2Button2.TabIndex = 38;
            this.guna2Button2.Text = "Done";
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.White;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Location = new System.Drawing.Point(410, 401);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(183, 34);
            this.guna2Button3.TabIndex = 37;
            this.guna2Button3.Text = "Back";
            this.guna2Button3.UseTransparentBackground = true;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // admin_userSecurityAnswer_lbl
            // 
            this.admin_userSecurityAnswer_lbl.AutoSize = true;
            this.admin_userSecurityAnswer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_userSecurityAnswer_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_userSecurityAnswer_lbl.Location = new System.Drawing.Point(579, 511);
            this.admin_userSecurityAnswer_lbl.Name = "admin_userSecurityAnswer_lbl";
            this.admin_userSecurityAnswer_lbl.Size = new System.Drawing.Size(35, 20);
            this.admin_userSecurityAnswer_lbl.TabIndex = 33;
            this.admin_userSecurityAnswer_lbl.Text = "N/A";
            this.admin_userSecurityAnswer_lbl.Click += new System.EventHandler(this.admin_userSecurityAnswer_lbl_Click);
            // 
            // admin_userSecurityQuestion_lbl
            // 
            this.admin_userSecurityQuestion_lbl.AutoSize = true;
            this.admin_userSecurityQuestion_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_userSecurityQuestion_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_userSecurityQuestion_lbl.Location = new System.Drawing.Point(579, 459);
            this.admin_userSecurityQuestion_lbl.Name = "admin_userSecurityQuestion_lbl";
            this.admin_userSecurityQuestion_lbl.Size = new System.Drawing.Size(35, 20);
            this.admin_userSecurityQuestion_lbl.TabIndex = 32;
            this.admin_userSecurityQuestion_lbl.Text = "N/A";
            this.admin_userSecurityQuestion_lbl.Click += new System.EventHandler(this.admin_userSecurityQuestion_lbl_Click);
            // 
            // admin_userEmail_lbl
            // 
            this.admin_userEmail_lbl.AutoSize = true;
            this.admin_userEmail_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_userEmail_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_userEmail_lbl.Location = new System.Drawing.Point(579, 403);
            this.admin_userEmail_lbl.Name = "admin_userEmail_lbl";
            this.admin_userEmail_lbl.Size = new System.Drawing.Size(35, 20);
            this.admin_userEmail_lbl.TabIndex = 31;
            this.admin_userEmail_lbl.Text = "N/A";
            this.admin_userEmail_lbl.Click += new System.EventHandler(this.admin_userEmail_lbl_Click);
            // 
            // admin_userManagerOtherUsers_pnl
            // 
            this.admin_userManagerOtherUsers_pnl.Controls.Add(this.admin_userManageOtherUsersEdit_btn);
            this.admin_userManagerOtherUsers_pnl.Controls.Add(this.admin_userManageOtherUsersBack_btn);
            this.admin_userManagerOtherUsers_pnl.Controls.Add(this.admin_editOtherUsers_gridView);
            this.admin_userManagerOtherUsers_pnl.Location = new System.Drawing.Point(60, 46);
            this.admin_userManagerOtherUsers_pnl.Name = "admin_userManagerOtherUsers_pnl";
            this.admin_userManagerOtherUsers_pnl.Size = new System.Drawing.Size(1014, 607);
            this.admin_userManagerOtherUsers_pnl.TabIndex = 13;
            this.admin_userManagerOtherUsers_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.admin_userManagerOtherUsers_pnl_Paint);
            // 
            // admin_userManageOtherUsersEdit_btn
            // 
            this.admin_userManageOtherUsersEdit_btn.Animated = true;
            this.admin_userManageOtherUsersEdit_btn.AutoRoundedCorners = true;
            this.admin_userManageOtherUsersEdit_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_userManageOtherUsersEdit_btn.BorderColor = System.Drawing.Color.White;
            this.admin_userManageOtherUsersEdit_btn.BorderThickness = 1;
            this.admin_userManageOtherUsersEdit_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_userManageOtherUsersEdit_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_userManageOtherUsersEdit_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_userManageOtherUsersEdit_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_userManageOtherUsersEdit_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.admin_userManageOtherUsersEdit_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_userManageOtherUsersEdit_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_userManageOtherUsersEdit_btn.Location = new System.Drawing.Point(722, 380);
            this.admin_userManageOtherUsersEdit_btn.Name = "admin_userManageOtherUsersEdit_btn";
            this.admin_userManageOtherUsersEdit_btn.Size = new System.Drawing.Size(208, 37);
            this.admin_userManageOtherUsersEdit_btn.TabIndex = 5;
            this.admin_userManageOtherUsersEdit_btn.Text = "Edit";
            this.admin_userManageOtherUsersEdit_btn.UseTransparentBackground = true;
            this.admin_userManageOtherUsersEdit_btn.Click += new System.EventHandler(this.admin_userManageOtherUsersEdit_btn_Click);
            // 
            // admin_userManageOtherUsersBack_btn
            // 
            this.admin_userManageOtherUsersBack_btn.Animated = true;
            this.admin_userManageOtherUsersBack_btn.AutoRoundedCorners = true;
            this.admin_userManageOtherUsersBack_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_userManageOtherUsersBack_btn.BorderColor = System.Drawing.Color.White;
            this.admin_userManageOtherUsersBack_btn.BorderThickness = 1;
            this.admin_userManageOtherUsersBack_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_userManageOtherUsersBack_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_userManageOtherUsersBack_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_userManageOtherUsersBack_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_userManageOtherUsersBack_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.admin_userManageOtherUsersBack_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.admin_userManageOtherUsersBack_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_userManageOtherUsersBack_btn.Location = new System.Drawing.Point(64, 380);
            this.admin_userManageOtherUsersBack_btn.Name = "admin_userManageOtherUsersBack_btn";
            this.admin_userManageOtherUsersBack_btn.Size = new System.Drawing.Size(208, 37);
            this.admin_userManageOtherUsersBack_btn.TabIndex = 4;
            this.admin_userManageOtherUsersBack_btn.Text = "Back";
            this.admin_userManageOtherUsersBack_btn.UseTransparentBackground = true;
            this.admin_userManageOtherUsersBack_btn.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // admin_editOtherUsers_gridView
            // 
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            this.admin_editOtherUsers_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admin_editOtherUsers_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.admin_editOtherUsers_gridView.ColumnHeadersHeight = 40;
            this.admin_editOtherUsers_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.admin_editOtherUsers_gridView.DefaultCellStyle = dataGridViewCellStyle36;
            this.admin_editOtherUsers_gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_editOtherUsers_gridView.Location = new System.Drawing.Point(6, 88);
            this.admin_editOtherUsers_gridView.Name = "admin_editOtherUsers_gridView";
            this.admin_editOtherUsers_gridView.RowHeadersVisible = false;
            this.admin_editOtherUsers_gridView.Size = new System.Drawing.Size(985, 246);
            this.admin_editOtherUsers_gridView.TabIndex = 0;
            this.admin_editOtherUsers_gridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_editOtherUsers_gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.admin_editOtherUsers_gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.admin_editOtherUsers_gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.admin_editOtherUsers_gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.admin_editOtherUsers_gridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.admin_editOtherUsers_gridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_editOtherUsers_gridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.admin_editOtherUsers_gridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.admin_editOtherUsers_gridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_editOtherUsers_gridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.admin_editOtherUsers_gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.admin_editOtherUsers_gridView.ThemeStyle.HeaderStyle.Height = 40;
            this.admin_editOtherUsers_gridView.ThemeStyle.ReadOnly = false;
            this.admin_editOtherUsers_gridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.admin_editOtherUsers_gridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.admin_editOtherUsers_gridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_editOtherUsers_gridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_editOtherUsers_gridView.ThemeStyle.RowsStyle.Height = 22;
            this.admin_editOtherUsers_gridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admin_editOtherUsers_gridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admin_editOtherUsers_gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admin_editOtherUsers_gridView_CellContentClick);
            // 
            // admin_userCnic_lbl
            // 
            this.admin_userCnic_lbl.AutoSize = true;
            this.admin_userCnic_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_userCnic_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_userCnic_lbl.Location = new System.Drawing.Point(579, 350);
            this.admin_userCnic_lbl.Name = "admin_userCnic_lbl";
            this.admin_userCnic_lbl.Size = new System.Drawing.Size(35, 20);
            this.admin_userCnic_lbl.TabIndex = 30;
            this.admin_userCnic_lbl.Text = "N/A";
            this.admin_userCnic_lbl.Click += new System.EventHandler(this.admin_userCnic_lbl_Click);
            // 
            // admin_userPhone_lbl
            // 
            this.admin_userPhone_lbl.AutoSize = true;
            this.admin_userPhone_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_userPhone_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_userPhone_lbl.Location = new System.Drawing.Point(579, 300);
            this.admin_userPhone_lbl.Name = "admin_userPhone_lbl";
            this.admin_userPhone_lbl.Size = new System.Drawing.Size(35, 20);
            this.admin_userPhone_lbl.TabIndex = 29;
            this.admin_userPhone_lbl.Text = "N/A";
            this.admin_userPhone_lbl.Click += new System.EventHandler(this.admin_userPhone_lbl_Click);
            // 
            // cnic_lbl
            // 
            this.cnic_lbl.AutoSize = true;
            this.cnic_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cnic_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cnic_lbl.Location = new System.Drawing.Point(473, 345);
            this.cnic_lbl.Name = "cnic_lbl";
            this.cnic_lbl.Size = new System.Drawing.Size(66, 25);
            this.cnic_lbl.TabIndex = 28;
            this.cnic_lbl.Text = "Cnic:";
            this.cnic_lbl.Click += new System.EventHandler(this.cnic_lbl_Click);
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.phone_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.phone_lbl.Location = new System.Drawing.Point(365, 296);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(174, 25);
            this.phone_lbl.TabIndex = 27;
            this.phone_lbl.Text = "Phone Number:";
            this.phone_lbl.Click += new System.EventHandler(this.phone_lbl_Click);
            // 
            // securityA_lbl
            // 
            this.securityA_lbl.AutoSize = true;
            this.securityA_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.securityA_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.securityA_lbl.Location = new System.Drawing.Point(348, 507);
            this.securityA_lbl.Name = "securityA_lbl";
            this.securityA_lbl.Size = new System.Drawing.Size(189, 25);
            this.securityA_lbl.TabIndex = 26;
            this.securityA_lbl.Text = "Security Answer:";
            this.securityA_lbl.Click += new System.EventHandler(this.securityA_lbl_Click);
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.email_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.email_lbl.Location = new System.Drawing.Point(460, 399);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(77, 25);
            this.email_lbl.TabIndex = 25;
            this.email_lbl.Text = "Email:";
            this.email_lbl.Click += new System.EventHandler(this.email_lbl_Click);
            // 
            // securityQ_lbl
            // 
            this.securityQ_lbl.AutoSize = true;
            this.securityQ_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.securityQ_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.securityQ_lbl.Location = new System.Drawing.Point(331, 454);
            this.securityQ_lbl.Name = "securityQ_lbl";
            this.securityQ_lbl.Size = new System.Drawing.Size(206, 25);
            this.securityQ_lbl.TabIndex = 24;
            this.securityQ_lbl.Text = "Security Question:";
            this.securityQ_lbl.Click += new System.EventHandler(this.securityQ_lbl_Click);
            // 
            // admin_userEdit_pnl
            // 
            this.admin_userEdit_pnl.Controls.Add(this.label52);
            this.admin_userEdit_pnl.Controls.Add(this.label51);
            this.admin_userEdit_pnl.Controls.Add(this.label50);
            this.admin_userEdit_pnl.Controls.Add(this.label49);
            this.admin_userEdit_pnl.Controls.Add(this.label48);
            this.admin_userEdit_pnl.Controls.Add(this.label47);
            this.admin_userEdit_pnl.Controls.Add(this.label46);
            this.admin_userEdit_pnl.Controls.Add(this.label45);
            this.admin_userEdit_pnl.Controls.Add(this.label39);
            this.admin_userEdit_pnl.Controls.Add(this.adminEditSecurityQuestion_cb);
            this.admin_userEdit_pnl.Controls.Add(this.adminEditSecurityAnswer_tb);
            this.admin_userEdit_pnl.Controls.Add(this.adminEditCnic_tb);
            this.admin_userEdit_pnl.Controls.Add(this.adminEditPhone_tb);
            this.admin_userEdit_pnl.Controls.Add(this.adminEditEmail_tb);
            this.admin_userEdit_pnl.Controls.Add(this.adminEditOccupation_tb);
            this.admin_userEdit_pnl.Controls.Add(this.adminEditPassword_tb);
            this.admin_userEdit_pnl.Controls.Add(this.adminEditUsername_tb);
            this.admin_userEdit_pnl.Controls.Add(this.adminEditName_tb);
            this.admin_userEdit_pnl.Controls.Add(this.admin_userEditDone_btn);
            this.admin_userEdit_pnl.Controls.Add(this.admin_userEditBack_btn);
            this.admin_userEdit_pnl.Location = new System.Drawing.Point(60, 46);
            this.admin_userEdit_pnl.Name = "admin_userEdit_pnl";
            this.admin_userEdit_pnl.Size = new System.Drawing.Size(1011, 608);
            this.admin_userEdit_pnl.TabIndex = 12;
            this.admin_userEdit_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.admin_userEdit_pnl_Paint);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label52.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label52.Location = new System.Drawing.Point(21, 36);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(72, 25);
            this.label52.TabIndex = 36;
            this.label52.Text = "Name";
            this.label52.Click += new System.EventHandler(this.label52_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label51.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label51.Location = new System.Drawing.Point(248, 36);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(118, 25);
            this.label51.TabIndex = 35;
            this.label51.Text = "Username";
            this.label51.Click += new System.EventHandler(this.label51_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label50.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label50.Location = new System.Drawing.Point(479, 36);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(114, 25);
            this.label50.TabIndex = 34;
            this.label50.Text = "Password";
            this.label50.Click += new System.EventHandler(this.label50_Click);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label49.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label49.Location = new System.Drawing.Point(701, 36);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(60, 25);
            this.label49.TabIndex = 33;
            this.label49.Text = "Role";
            this.label49.Click += new System.EventHandler(this.label49_Click);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label48.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label48.Location = new System.Drawing.Point(21, 123);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(70, 25);
            this.label48.TabIndex = 32;
            this.label48.Text = "Email";
            this.label48.Click += new System.EventHandler(this.label48_Click);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label47.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label47.Location = new System.Drawing.Point(248, 123);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(167, 25);
            this.label47.TabIndex = 31;
            this.label47.Text = "Phone Number";
            this.label47.Click += new System.EventHandler(this.label47_Click);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label46.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label46.Location = new System.Drawing.Point(479, 119);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(59, 25);
            this.label46.TabIndex = 30;
            this.label46.Text = "Cnic";
            this.label46.Click += new System.EventHandler(this.label46_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label45.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label45.Location = new System.Drawing.Point(701, 118);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(199, 25);
            this.label45.TabIndex = 29;
            this.label45.Text = "Security Question";
            this.label45.Click += new System.EventHandler(this.label45_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label39.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label39.Location = new System.Drawing.Point(701, 198);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(182, 25);
            this.label39.TabIndex = 28;
            this.label39.Text = "Security Answer";
            this.label39.Click += new System.EventHandler(this.label39_Click_1);
            // 
            // adminEditSecurityQuestion_cb
            // 
            this.adminEditSecurityQuestion_cb.AutoRoundedCorners = true;
            this.adminEditSecurityQuestion_cb.BackColor = System.Drawing.Color.Transparent;
            this.adminEditSecurityQuestion_cb.BorderColor = System.Drawing.Color.Black;
            this.adminEditSecurityQuestion_cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.adminEditSecurityQuestion_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adminEditSecurityQuestion_cb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditSecurityQuestion_cb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditSecurityQuestion_cb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adminEditSecurityQuestion_cb.ForeColor = System.Drawing.Color.Black;
            this.adminEditSecurityQuestion_cb.ItemHeight = 30;
            this.adminEditSecurityQuestion_cb.Items.AddRange(new object[] {
            "Father Name",
            "Mother Name",
            "Pet Name",
            "School Name",
            "Best Friend Name",
            "How Many Borthers",
            "How Many Sisters"});
            this.adminEditSecurityQuestion_cb.Location = new System.Drawing.Point(693, 147);
            this.adminEditSecurityQuestion_cb.Name = "adminEditSecurityQuestion_cb";
            this.adminEditSecurityQuestion_cb.Size = new System.Drawing.Size(200, 36);
            this.adminEditSecurityQuestion_cb.TabIndex = 24;
            this.adminEditSecurityQuestion_cb.SelectedIndexChanged += new System.EventHandler(this.adminEditSecurityQuestion_cb_SelectedIndexChanged);
            // 
            // adminEditSecurityAnswer_tb
            // 
            this.adminEditSecurityAnswer_tb.Animated = true;
            this.adminEditSecurityAnswer_tb.AutoRoundedCorners = true;
            this.adminEditSecurityAnswer_tb.BorderColor = System.Drawing.Color.Black;
            this.adminEditSecurityAnswer_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminEditSecurityAnswer_tb.DefaultText = "";
            this.adminEditSecurityAnswer_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adminEditSecurityAnswer_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adminEditSecurityAnswer_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEditSecurityAnswer_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEditSecurityAnswer_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditSecurityAnswer_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.adminEditSecurityAnswer_tb.ForeColor = System.Drawing.Color.Black;
            this.adminEditSecurityAnswer_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditSecurityAnswer_tb.Location = new System.Drawing.Point(693, 226);
            this.adminEditSecurityAnswer_tb.Name = "adminEditSecurityAnswer_tb";
            this.adminEditSecurityAnswer_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.adminEditSecurityAnswer_tb.PlaceholderText = "Security Answer";
            this.adminEditSecurityAnswer_tb.SelectedText = "";
            this.adminEditSecurityAnswer_tb.Size = new System.Drawing.Size(200, 37);
            this.adminEditSecurityAnswer_tb.TabIndex = 20;
            this.adminEditSecurityAnswer_tb.TextChanged += new System.EventHandler(this.adminEditSecurityAnswer_tb_TextChanged);
            // 
            // adminEditCnic_tb
            // 
            this.adminEditCnic_tb.Animated = true;
            this.adminEditCnic_tb.AutoRoundedCorners = true;
            this.adminEditCnic_tb.BorderColor = System.Drawing.Color.Black;
            this.adminEditCnic_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminEditCnic_tb.DefaultText = "";
            this.adminEditCnic_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adminEditCnic_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adminEditCnic_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEditCnic_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEditCnic_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditCnic_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.adminEditCnic_tb.ForeColor = System.Drawing.Color.Black;
            this.adminEditCnic_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditCnic_tb.Location = new System.Drawing.Point(466, 147);
            this.adminEditCnic_tb.Name = "adminEditCnic_tb";
            this.adminEditCnic_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.adminEditCnic_tb.PlaceholderText = "Cnic";
            this.adminEditCnic_tb.SelectedText = "";
            this.adminEditCnic_tb.Size = new System.Drawing.Size(200, 36);
            this.adminEditCnic_tb.TabIndex = 19;
            this.adminEditCnic_tb.TextChanged += new System.EventHandler(this.adminEditCnic_tb_TextChanged);
            // 
            // adminEditPhone_tb
            // 
            this.adminEditPhone_tb.Animated = true;
            this.adminEditPhone_tb.AutoRoundedCorners = true;
            this.adminEditPhone_tb.BorderColor = System.Drawing.Color.Black;
            this.adminEditPhone_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminEditPhone_tb.DefaultText = "";
            this.adminEditPhone_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adminEditPhone_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adminEditPhone_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEditPhone_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEditPhone_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditPhone_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.adminEditPhone_tb.ForeColor = System.Drawing.Color.Black;
            this.adminEditPhone_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditPhone_tb.Location = new System.Drawing.Point(240, 147);
            this.adminEditPhone_tb.Name = "adminEditPhone_tb";
            this.adminEditPhone_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.adminEditPhone_tb.PlaceholderText = "Phone(+923000000000)";
            this.adminEditPhone_tb.SelectedText = "";
            this.adminEditPhone_tb.Size = new System.Drawing.Size(200, 36);
            this.adminEditPhone_tb.TabIndex = 18;
            this.adminEditPhone_tb.TextChanged += new System.EventHandler(this.adminEditPhone_tb_TextChanged);
            // 
            // adminEditEmail_tb
            // 
            this.adminEditEmail_tb.Animated = true;
            this.adminEditEmail_tb.AutoRoundedCorners = true;
            this.adminEditEmail_tb.BorderColor = System.Drawing.Color.Black;
            this.adminEditEmail_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminEditEmail_tb.DefaultText = "";
            this.adminEditEmail_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adminEditEmail_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adminEditEmail_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEditEmail_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEditEmail_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditEmail_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.adminEditEmail_tb.ForeColor = System.Drawing.Color.Black;
            this.adminEditEmail_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditEmail_tb.Location = new System.Drawing.Point(13, 147);
            this.adminEditEmail_tb.Name = "adminEditEmail_tb";
            this.adminEditEmail_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.adminEditEmail_tb.PlaceholderText = "Email";
            this.adminEditEmail_tb.SelectedText = "";
            this.adminEditEmail_tb.Size = new System.Drawing.Size(201, 36);
            this.adminEditEmail_tb.TabIndex = 17;
            this.adminEditEmail_tb.TextChanged += new System.EventHandler(this.adminEditEmail_tb_TextChanged);
            // 
            // adminEditOccupation_tb
            // 
            this.adminEditOccupation_tb.Animated = true;
            this.adminEditOccupation_tb.AutoRoundedCorners = true;
            this.adminEditOccupation_tb.BorderColor = System.Drawing.Color.Black;
            this.adminEditOccupation_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminEditOccupation_tb.DefaultText = "";
            this.adminEditOccupation_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adminEditOccupation_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adminEditOccupation_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEditOccupation_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEditOccupation_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditOccupation_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.adminEditOccupation_tb.ForeColor = System.Drawing.Color.Black;
            this.adminEditOccupation_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditOccupation_tb.Location = new System.Drawing.Point(693, 64);
            this.adminEditOccupation_tb.Name = "adminEditOccupation_tb";
            this.adminEditOccupation_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.adminEditOccupation_tb.PlaceholderText = "Occupation";
            this.adminEditOccupation_tb.SelectedText = "";
            this.adminEditOccupation_tb.Size = new System.Drawing.Size(200, 39);
            this.adminEditOccupation_tb.TabIndex = 16;
            this.adminEditOccupation_tb.TextChanged += new System.EventHandler(this.adminEditOccupation_tb_TextChanged);
            // 
            // adminEditPassword_tb
            // 
            this.adminEditPassword_tb.Animated = true;
            this.adminEditPassword_tb.AutoRoundedCorners = true;
            this.adminEditPassword_tb.BorderColor = System.Drawing.Color.Black;
            this.adminEditPassword_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminEditPassword_tb.DefaultText = "";
            this.adminEditPassword_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adminEditPassword_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adminEditPassword_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEditPassword_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEditPassword_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditPassword_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.adminEditPassword_tb.ForeColor = System.Drawing.Color.Black;
            this.adminEditPassword_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditPassword_tb.Location = new System.Drawing.Point(466, 65);
            this.adminEditPassword_tb.Name = "adminEditPassword_tb";
            this.adminEditPassword_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.adminEditPassword_tb.PlaceholderText = "Password";
            this.adminEditPassword_tb.SelectedText = "";
            this.adminEditPassword_tb.Size = new System.Drawing.Size(200, 38);
            this.adminEditPassword_tb.TabIndex = 15;
            this.adminEditPassword_tb.TextChanged += new System.EventHandler(this.adminEditPassword_tb_TextChanged);
            // 
            // adminEditUsername_tb
            // 
            this.adminEditUsername_tb.Animated = true;
            this.adminEditUsername_tb.AutoRoundedCorners = true;
            this.adminEditUsername_tb.BorderColor = System.Drawing.Color.Black;
            this.adminEditUsername_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminEditUsername_tb.DefaultText = "";
            this.adminEditUsername_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adminEditUsername_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adminEditUsername_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEditUsername_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEditUsername_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditUsername_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.adminEditUsername_tb.ForeColor = System.Drawing.Color.Black;
            this.adminEditUsername_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditUsername_tb.Location = new System.Drawing.Point(240, 65);
            this.adminEditUsername_tb.Name = "adminEditUsername_tb";
            this.adminEditUsername_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.adminEditUsername_tb.PlaceholderText = "Username";
            this.adminEditUsername_tb.SelectedText = "";
            this.adminEditUsername_tb.Size = new System.Drawing.Size(200, 38);
            this.adminEditUsername_tb.TabIndex = 14;
            this.adminEditUsername_tb.TextChanged += new System.EventHandler(this.adminEditUsername_tb_TextChanged);
            // 
            // adminEditName_tb
            // 
            this.adminEditName_tb.Animated = true;
            this.adminEditName_tb.AutoRoundedCorners = true;
            this.adminEditName_tb.BorderColor = System.Drawing.Color.Black;
            this.adminEditName_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminEditName_tb.DefaultText = "";
            this.adminEditName_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adminEditName_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adminEditName_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEditName_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEditName_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditName_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.adminEditName_tb.ForeColor = System.Drawing.Color.Black;
            this.adminEditName_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEditName_tb.Location = new System.Drawing.Point(13, 65);
            this.adminEditName_tb.Name = "adminEditName_tb";
            this.adminEditName_tb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.adminEditName_tb.PlaceholderText = "Name";
            this.adminEditName_tb.SelectedText = "";
            this.adminEditName_tb.Size = new System.Drawing.Size(201, 38);
            this.adminEditName_tb.TabIndex = 13;
            this.adminEditName_tb.TextChanged += new System.EventHandler(this.adminEditName_tb_TextChanged);
            // 
            // admin_userEditDone_btn
            // 
            this.admin_userEditDone_btn.Animated = true;
            this.admin_userEditDone_btn.AutoRoundedCorners = true;
            this.admin_userEditDone_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_userEditDone_btn.BorderColor = System.Drawing.Color.White;
            this.admin_userEditDone_btn.BorderThickness = 1;
            this.admin_userEditDone_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_userEditDone_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_userEditDone_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_userEditDone_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_userEditDone_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.admin_userEditDone_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.admin_userEditDone_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_userEditDone_btn.Location = new System.Drawing.Point(379, 358);
            this.admin_userEditDone_btn.Name = "admin_userEditDone_btn";
            this.admin_userEditDone_btn.Size = new System.Drawing.Size(183, 37);
            this.admin_userEditDone_btn.TabIndex = 12;
            this.admin_userEditDone_btn.Text = "Done";
            this.admin_userEditDone_btn.UseTransparentBackground = true;
            this.admin_userEditDone_btn.Click += new System.EventHandler(this.admin_userEditDone_btn_Click);
            // 
            // admin_userEditBack_btn
            // 
            this.admin_userEditBack_btn.AutoRoundedCorners = true;
            this.admin_userEditBack_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_userEditBack_btn.BorderColor = System.Drawing.Color.White;
            this.admin_userEditBack_btn.BorderThickness = 1;
            this.admin_userEditBack_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_userEditBack_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_userEditBack_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_userEditBack_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_userEditBack_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.admin_userEditBack_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.admin_userEditBack_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_userEditBack_btn.Location = new System.Drawing.Point(379, 412);
            this.admin_userEditBack_btn.Name = "admin_userEditBack_btn";
            this.admin_userEditBack_btn.Size = new System.Drawing.Size(183, 34);
            this.admin_userEditBack_btn.TabIndex = 1;
            this.admin_userEditBack_btn.Text = "Back";
            this.admin_userEditBack_btn.UseTransparentBackground = true;
            this.admin_userEditBack_btn.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // admin_userManageOtherUsers_btn
            // 
            this.admin_userManageOtherUsers_btn.Animated = true;
            this.admin_userManageOtherUsers_btn.AutoRoundedCorners = true;
            this.admin_userManageOtherUsers_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_userManageOtherUsers_btn.BorderColor = System.Drawing.Color.White;
            this.admin_userManageOtherUsers_btn.BorderThickness = 1;
            this.admin_userManageOtherUsers_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_userManageOtherUsers_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_userManageOtherUsers_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_userManageOtherUsers_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_userManageOtherUsers_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.admin_userManageOtherUsers_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.admin_userManageOtherUsers_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_userManageOtherUsers_btn.Location = new System.Drawing.Point(406, 608);
            this.admin_userManageOtherUsers_btn.Name = "admin_userManageOtherUsers_btn";
            this.admin_userManageOtherUsers_btn.Size = new System.Drawing.Size(250, 45);
            this.admin_userManageOtherUsers_btn.TabIndex = 11;
            this.admin_userManageOtherUsers_btn.Text = "Manage Other Users";
            this.admin_userManageOtherUsers_btn.UseTransparentBackground = true;
            this.admin_userManageOtherUsers_btn.Click += new System.EventHandler(this.admin_userManageOtherUsers_btn_Click);
            // 
            // admin_userEdit_btn
            // 
            this.admin_userEdit_btn.Animated = true;
            this.admin_userEdit_btn.AutoRoundedCorners = true;
            this.admin_userEdit_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_userEdit_btn.BorderColor = System.Drawing.Color.White;
            this.admin_userEdit_btn.BorderThickness = 1;
            this.admin_userEdit_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_userEdit_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_userEdit_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_userEdit_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_userEdit_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.admin_userEdit_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_userEdit_btn.ForeColor = System.Drawing.Color.Black;
            this.admin_userEdit_btn.Location = new System.Drawing.Point(445, 550);
            this.admin_userEdit_btn.Name = "admin_userEdit_btn";
            this.admin_userEdit_btn.Size = new System.Drawing.Size(180, 45);
            this.admin_userEdit_btn.TabIndex = 10;
            this.admin_userEdit_btn.Text = "Edit";
            this.admin_userEdit_btn.UseTransparentBackground = true;
            this.admin_userEdit_btn.Click += new System.EventHandler(this.admin_userEdit_btn_Click);
            // 
            // admin_userOccupation_lbl
            // 
            this.admin_userOccupation_lbl.AutoSize = true;
            this.admin_userOccupation_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_userOccupation_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_userOccupation_lbl.Location = new System.Drawing.Point(579, 252);
            this.admin_userOccupation_lbl.Name = "admin_userOccupation_lbl";
            this.admin_userOccupation_lbl.Size = new System.Drawing.Size(35, 20);
            this.admin_userOccupation_lbl.TabIndex = 9;
            this.admin_userOccupation_lbl.Text = "N/A";
            this.admin_userOccupation_lbl.Click += new System.EventHandler(this.admin_userOccupation_lbl_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label38.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label38.Location = new System.Drawing.Point(401, 248);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(138, 25);
            this.label38.TabIndex = 8;
            this.label38.Text = "Occupation:";
            this.label38.Click += new System.EventHandler(this.label38_Click);
            // 
            // admin_userPassword_lbl
            // 
            this.admin_userPassword_lbl.AutoSize = true;
            this.admin_userPassword_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_userPassword_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_userPassword_lbl.Location = new System.Drawing.Point(579, 202);
            this.admin_userPassword_lbl.Name = "admin_userPassword_lbl";
            this.admin_userPassword_lbl.Size = new System.Drawing.Size(35, 20);
            this.admin_userPassword_lbl.TabIndex = 7;
            this.admin_userPassword_lbl.Text = "N/A";
            this.admin_userPassword_lbl.Click += new System.EventHandler(this.admin_userPassword_lbl_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label37.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label37.Location = new System.Drawing.Point(418, 197);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(121, 25);
            this.label37.TabIndex = 6;
            this.label37.Text = "Password:";
            this.label37.Click += new System.EventHandler(this.label37_Click);
            // 
            // admin_userUsername_lbl
            // 
            this.admin_userUsername_lbl.AutoSize = true;
            this.admin_userUsername_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_userUsername_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_userUsername_lbl.Location = new System.Drawing.Point(579, 152);
            this.admin_userUsername_lbl.Name = "admin_userUsername_lbl";
            this.admin_userUsername_lbl.Size = new System.Drawing.Size(35, 20);
            this.admin_userUsername_lbl.TabIndex = 5;
            this.admin_userUsername_lbl.Text = "N/A";
            this.admin_userUsername_lbl.Click += new System.EventHandler(this.admin_userUsername_lbl_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label35.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label35.Location = new System.Drawing.Point(414, 148);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(125, 25);
            this.label35.TabIndex = 4;
            this.label35.Text = "Username:";
            this.label35.Click += new System.EventHandler(this.label35_Click);
            // 
            // admin_user_Name_lbl
            // 
            this.admin_user_Name_lbl.AutoSize = true;
            this.admin_user_Name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_user_Name_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_user_Name_lbl.Location = new System.Drawing.Point(579, 106);
            this.admin_user_Name_lbl.Name = "admin_user_Name_lbl";
            this.admin_user_Name_lbl.Size = new System.Drawing.Size(35, 20);
            this.admin_user_Name_lbl.TabIndex = 3;
            this.admin_user_Name_lbl.Text = "N/A";
            this.admin_user_Name_lbl.Click += new System.EventHandler(this.admin_user_Name_lbl_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label36.Location = new System.Drawing.Point(460, 98);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(79, 25);
            this.label36.TabIndex = 2;
            this.label36.Text = "Name:";
            this.label36.Click += new System.EventHandler(this.label36_Click);
            // 
            // admin_userAccountType_lbl
            // 
            this.admin_userAccountType_lbl.AutoSize = true;
            this.admin_userAccountType_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_userAccountType_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_userAccountType_lbl.Location = new System.Drawing.Point(579, 54);
            this.admin_userAccountType_lbl.Name = "admin_userAccountType_lbl";
            this.admin_userAccountType_lbl.Size = new System.Drawing.Size(35, 20);
            this.admin_userAccountType_lbl.TabIndex = 1;
            this.admin_userAccountType_lbl.Text = "N/A";
            this.admin_userAccountType_lbl.Click += new System.EventHandler(this.admin_userAccountType_lbl_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label34.Location = new System.Drawing.Point(376, 49);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(163, 25);
            this.label34.TabIndex = 0;
            this.label34.Text = "Account Type:";
            this.label34.Click += new System.EventHandler(this.label34_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1038, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.admin_appointment_pnl);
            this.Controls.Add(this.admin_user_pnl);
            this.Controls.Add(this.admin_financialReport_pnl);
            this.Controls.Add(this.admin_schedule_pnl);
            this.Controls.Add(this.admin_clients_pnl);
            this.Controls.Add(this.admin_service_pnl);
            this.Controls.Add(this.admin_employee_pnl);
            this.Controls.Add(this.admin_search_pnl);
            this.Controls.Add(this.admin_dashboard_pnl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.admin_menu_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "admin";
            this.Text = "admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admin_Load);
            this.admin_menu_pnl.ResumeLayout(false);
            this.admin_menu_pnl.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.admin_dashboard_pnl.ResumeLayout(false);
            this.admin_dashboard_pnl.PerformLayout();
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel3.PerformLayout();
            this.admin_search_pnl.ResumeLayout(false);
            this.admin_search_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_searchCarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_searchGridView)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.admin_employee_pnl.ResumeLayout(false);
            this.admin_employee_pnl.PerformLayout();
            this.employeeUpdate_pnl.ResumeLayout(false);
            this.employeeUpdate_pnl.PerformLayout();
            this.employeeAdd_pnl.ResumeLayout(false);
            this.employeeAdd_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_employee_gridView)).EndInit();
            this.admin_service_pnl.ResumeLayout(false);
            this.admin_service_pnl.PerformLayout();
            this.addService_pnl.ResumeLayout(false);
            this.updateService_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.admin_service_gridView)).EndInit();
            this.admin_clients_pnl.ResumeLayout(false);
            this.admin_clients_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_client_gridView)).EndInit();
            this.admin_schedule_pnl.ResumeLayout(false);
            this.admin_schedule_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_schedule_gridView)).EndInit();
            this.guna2CustomGradientPanel5.ResumeLayout(false);
            this.guna2CustomGradientPanel5.PerformLayout();
            this.admin_financialReport_pnl.ResumeLayout(false);
            this.admin_financialReport_pnl.PerformLayout();
            this.addExpennse_pnl.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_financialReportExpenses_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_financialReportIncome_gridView)).EndInit();
            this.admin_appointment_pnl.ResumeLayout(false);
            this.admin_appointment_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_appointmentCompletedToday_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_appointmentThisMonth_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_appointmentTodayAppointment_gridView)).EndInit();
            this.admin_user_pnl.ResumeLayout(false);
            this.admin_user_pnl.PerformLayout();
            this.manageOtherUserEdit_pnl.ResumeLayout(false);
            this.manageOtherUserEdit_pnl.PerformLayout();
            this.admin_userManagerOtherUsers_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.admin_editOtherUsers_gridView)).EndInit();
            this.admin_userEdit_pnl.ResumeLayout(false);
            this.admin_userEdit_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel admin_menu_pnl;
        private Guna.UI2.WinForms.Guna2Button admin_closeApplication_btn;
        private Guna.UI2.WinForms.Guna2Button admin_dashboard_btn;
        private Guna.UI2.WinForms.Guna2Button admin_logOut_btn;
        private Guna.UI2.WinForms.Guna2Button admin_search_btn;
        private Guna.UI2.WinForms.Guna2Button admin_user_btn;
        private Guna.UI2.WinForms.Guna2Button admin_employees_btn;
        private Guna.UI2.WinForms.Guna2Button admin_appointment_btn;
        private Guna.UI2.WinForms.Guna2Button admin_service_btn;
        private Guna.UI2.WinForms.Guna2Button admin_financialReport_btn;
        private Guna.UI2.WinForms.Guna2Button admin_client_btn;
        private Guna.UI2.WinForms.Guna2Button admin_schedule_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel admin_dashboard_pnl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label admin_monthIncome_lbl;
        private System.Windows.Forms.Label admin_yearIncome_lbl;
        private System.Windows.Forms.Label admin_totalEmployees_lbl;
        private System.Windows.Forms.Label admin_totalServiceDone_lbl;
        private System.Windows.Forms.Panel admin_search_pnl;
        private System.Windows.Forms.Panel admin_employee_pnl;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2DataGridView admin_employee_gridView;
        private Guna.UI2.WinForms.Guna2Button employeeDelete_btn;
        private Guna.UI2.WinForms.Guna2Button employeeUpdate_btn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button admin_welcomePage_btn;
        private System.Windows.Forms.Panel admin_service_pnl;
        private Guna.UI2.WinForms.Guna2DataGridView admin_service_gridView;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2Button admin_serviceDelete_btn;
        private Guna.UI2.WinForms.Guna2Button admin_serviceUpdate_btn;
        private Guna.UI2.WinForms.Guna2Button admin_serviceAdd_btn;
        private System.Windows.Forms.Panel admin_clients_pnl;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2DataGridView admin_client_gridView;
        private System.Windows.Forms.Panel admin_schedule_pnl;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel5;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2DataGridView admin_schedule_gridView;
        private Guna.UI2.WinForms.Guna2Button admin_scheduleTurnOffAlert;
        private Guna.UI2.WinForms.Guna2Button admin_scheduleSendAlert_btn;
        private System.Windows.Forms.Label admin_scheduleDueService_lbl;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel admin_financialReport_pnl;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private Guna.UI2.WinForms.Guna2DataGridView admin_financialReportExpenses_gridView;
        private Guna.UI2.WinForms.Guna2DataGridView admin_financialReportIncome_gridView;
        private Guna.UI2.WinForms.Guna2Button admin_financialReportExpenses_btn;
        private System.Windows.Forms.Panel admin_appointment_pnl;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private Guna.UI2.WinForms.Guna2DataGridView admin_appointmentThisMonth_gridview;
        private System.Windows.Forms.Label label32;
        private Guna.UI2.WinForms.Guna2DataGridView admin_appointmentTodayAppointment_gridView;
        private Guna.UI2.WinForms.Guna2DataGridView admin_appointmentCompletedToday_gridView;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel admin_user_pnl;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label admin_userAccountType_lbl;
        private System.Windows.Forms.Label admin_user_Name_lbl;
        private System.Windows.Forms.Label admin_userUsername_lbl;
        private System.Windows.Forms.Label label35;
        private Guna.UI2.WinForms.Guna2Button admin_userEdit_btn;
        private System.Windows.Forms.Label admin_userOccupation_lbl;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label admin_userPassword_lbl;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Panel admin_userEdit_pnl;
        private Guna.UI2.WinForms.Guna2Button admin_userManageOtherUsers_btn;
        private Guna.UI2.WinForms.Guna2Button admin_userEditBack_btn;
        private System.Windows.Forms.Panel admin_userManagerOtherUsers_pnl;
        private Guna.UI2.WinForms.Guna2DataGridView admin_editOtherUsers_gridView;
        private Guna.UI2.WinForms.Guna2Button admin_userManageOtherUsersBack_btn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label admin_designation_lbl;
        private System.Windows.Forms.Label admin_name_lbl;
        private System.Windows.Forms.Label admin_accountType_lbl;
        private System.Windows.Forms.Label admin_userSecurityAnswer_lbl;
        private System.Windows.Forms.Label admin_userSecurityQuestion_lbl;
        private System.Windows.Forms.Label admin_userEmail_lbl;
        private System.Windows.Forms.Label admin_userCnic_lbl;
        private System.Windows.Forms.Label admin_userPhone_lbl;
        private System.Windows.Forms.Label cnic_lbl;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.Label securityA_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label securityQ_lbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label admin_financialReportProfit_lbl;
        private System.Windows.Forms.Label label41;
        private Guna.UI2.WinForms.Guna2ComboBox admin_financialReportMonthSelection_cb;
        private Guna.UI2.WinForms.Guna2Button admin_financialReportPrint_btn;
        private Guna.UI2.WinForms.Guna2Panel addExpennse_pnl;
        private Guna.UI2.WinForms.Guna2Button addExpenseBack_btn;
        private Guna.UI2.WinForms.Guna2TextBox expenseDiscription_tb;
        private Guna.UI2.WinForms.Guna2TextBox expenseAmount_tb;
        private Guna.UI2.WinForms.Guna2Panel addService_pnl;
        private Guna.UI2.WinForms.Guna2Button addServiceDone_btn;
        private Guna.UI2.WinForms.Guna2TextBox addServicePrice_tb;
        private Guna.UI2.WinForms.Guna2TextBox addServiceDiscription_tb;
        private Guna.UI2.WinForms.Guna2TextBox addServiceName_tb;
        private Guna.UI2.WinForms.Guna2Button addServiceBack_btn;
        private Guna.UI2.WinForms.Guna2Panel updateService_pnl;
        private Guna.UI2.WinForms.Guna2Button updateServiceDone_btn;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2TextBox updateServicePrice_tb;
        private Guna.UI2.WinForms.Guna2TextBox updateServiceDiscription_tb;
        private Guna.UI2.WinForms.Guna2TextBox updateServiceName_tb;
        private Guna.UI2.WinForms.Guna2Panel employeeAdd_pnl;
        private Guna.UI2.WinForms.Guna2TextBox addEmployeeAddress_tb;
        private Guna.UI2.WinForms.Guna2TextBox addEmployeeSalary_tb;
        private Guna.UI2.WinForms.Guna2TextBox addEmployeeEmail_tb;
        private Guna.UI2.WinForms.Guna2TextBox addEmployeeCnic_tb;
        private Guna.UI2.WinForms.Guna2TextBox addEmployeeRole_tb;
        private Guna.UI2.WinForms.Guna2TextBox addEmployeeNumber_tb;
        private Guna.UI2.WinForms.Guna2TextBox addEmployeeName_tb;
        private Guna.UI2.WinForms.Guna2Button addEmployeeDone_btn;
        private Guna.UI2.WinForms.Guna2Button addEmployeeBack_btn;
        private System.Windows.Forms.Label label42;
        private Guna.UI2.WinForms.Guna2Panel employeeUpdate_pnl;
        private System.Windows.Forms.Label label43;
        private Guna.UI2.WinForms.Guna2Button updateEmployeeDone_btn;
        private Guna.UI2.WinForms.Guna2Button updateEmployeeBack_btn;
        private Guna.UI2.WinForms.Guna2TextBox updateEmployeeAddress_tb;
        private Guna.UI2.WinForms.Guna2TextBox updateEmployeeSalary_tb;
        private Guna.UI2.WinForms.Guna2TextBox updateEmployeeEmail_tb;
        private Guna.UI2.WinForms.Guna2TextBox updateEmployeeCnic_tb;
        private Guna.UI2.WinForms.Guna2TextBox updateEmployeeRole_tb;
        private Guna.UI2.WinForms.Guna2TextBox updateEmployeeNumber_tb;
        private Guna.UI2.WinForms.Guna2TextBox updateEmployeeName_tb;
        private Guna.UI2.WinForms.Guna2Button search_clear_btn;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DataGridView employee_searchGridView;
        private System.Windows.Forms.Label employee_lastServiceDate_lbl;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label employee_servicesDone_lbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label44;
        private Guna.UI2.WinForms.Guna2Button employee_searchBar_btn;
        private Guna.UI2.WinForms.Guna2TextBox employee_search_tb;
        private Guna.UI2.WinForms.Guna2Button admin_userEditDone_btn;
        private Guna.UI2.WinForms.Guna2TextBox adminEditSecurityAnswer_tb;
        private Guna.UI2.WinForms.Guna2TextBox adminEditCnic_tb;
        private Guna.UI2.WinForms.Guna2TextBox adminEditPhone_tb;
        private Guna.UI2.WinForms.Guna2TextBox adminEditEmail_tb;
        private Guna.UI2.WinForms.Guna2TextBox adminEditOccupation_tb;
        private Guna.UI2.WinForms.Guna2TextBox adminEditPassword_tb;
        private Guna.UI2.WinForms.Guna2TextBox adminEditUsername_tb;
        private Guna.UI2.WinForms.Guna2TextBox adminEditName_tb;
        private Guna.UI2.WinForms.Guna2ComboBox adminEditSecurityQuestion_cb;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label39;
        private Guna.UI2.WinForms.Guna2Button admin_userManageOtherUsersEdit_btn;
        private Guna.UI2.WinForms.Guna2Panel manageOtherUserEdit_pnl;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private Guna.UI2.WinForms.Guna2ComboBox editUserSecurityQuestion_cb;
        private Guna.UI2.WinForms.Guna2TextBox editUserSecurityAnswer_tb;
        private Guna.UI2.WinForms.Guna2TextBox editUserCnic_tb;
        private Guna.UI2.WinForms.Guna2TextBox editUserPhone_tb;
        private Guna.UI2.WinForms.Guna2TextBox editUserEmail_tb;
        private Guna.UI2.WinForms.Guna2TextBox editUserOccupation_tb;
        private Guna.UI2.WinForms.Guna2TextBox editUserPassword_tb;
        private Guna.UI2.WinForms.Guna2TextBox editUserUsername_tb;
        private Guna.UI2.WinForms.Guna2TextBox editUserName_tb;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2TextBox editUserAccountType_tb;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2DataGridView employee_searchCarDataGridView;
        private Guna.Charts.WinForms.GunaChart gunaChart1;
        private Guna.Charts.WinForms.GunaChart gunaChart2;
        private Guna.Charts.WinForms.GunaChart gunaChart3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.Charts.WinForms.GunaChart gunaChart4;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label admin_totalProfit_lbl;
        private System.Windows.Forms.Label label7;
    }
}