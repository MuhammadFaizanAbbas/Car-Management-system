using FYP_PROJECT.Helpers.CommonHelpers;
using System.Windows.Forms;
using System.Linq;
namespace FYP_PROJECT.Helpers.AdminHelpers
{
    public static class AdminUIInitializer
    {

        public static void InitializeUI(Form adminForm, ButtonAnimationHelper animationHelper, Guna.UI2.WinForms.Guna2Button welcomeButton)
        {
            // Cast controls using names from adminForm
            Control ctrl = adminForm.Controls.Find("admin_dashboard_pnl", true).FirstOrDefault();
            if (ctrl != null) ctrl.Visible = false;

            string[] panelNames = new string[]
            {
                "admin_dashboard_pnl", "admin_search_pnl", "admin_employee_pnl", "admin_service_pnl",
                "admin_clients_pnl", "admin_schedule_pnl", "admin_financialReport_pnl", "admin_appointment_pnl",
                "admin_user_pnl", "admin_userManagerOtherUsers_pnl", "admin_userEdit_pnl", "addExpennse_pnl",
                "addService_pnl", "updateService_pnl", "employeeAdd_pnl", "employeeUpdate_pnl", "manageOtherUserEdit_pnl"
            };

            foreach (string name in panelNames)
            {
                Control panel = adminForm.Controls.Find(name, true).FirstOrDefault();
                if (panel != null)
                    panel.Visible = false;
            }

            // Set active button
            animationHelper.SetActiveButton(welcomeButton);
        }
    }
}