using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            // 2 – Mark Welcome as the active choice
            SetActiveButton(admin_welcomePage_btn);
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

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admin_userEdit_btn_Click(object sender, EventArgs e)
        {
            admin_userEdit_pnl.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            admin_userEdit_pnl.Hide();
            admin_userManagerOtherUsers_pnl.Hide();
        }

        private void admin_userManageOtherUsers_btn_Click(object sender, EventArgs e)
        {
            admin_userEdit_pnl.Hide();
            admin_userManagerOtherUsers_pnl.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
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
       

    
      



    }
}
