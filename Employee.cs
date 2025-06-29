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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();

            employee_search_pnl.Visible = false;
           aiDetection_pnl.Visible=false;
            employee_schedule_pnl.Visible=false;
            employee_appointment_pnl.Visible=false;
            employee_appointmentDetails_pnl.Visible=false;
            employee_appointmentPayment_pnl.Visible=false;
            employee_appointmentPaymentSummry_pnl.Visible=false;
            SetActiveButton(employee_welcomePage_btn);
        }
        //for animation and active state of button

        private Dictionary<Guna.UI2.WinForms.Guna2Button, float> buttonFontSizes = new Dictionary<Guna.UI2.WinForms.Guna2Button, float>();
        private Guna.UI2.WinForms.Guna2Button currentActiveButton = null;
        private Timer fontAnimationTimer;
        private float animationStep = 0.5f;
        private void SetActiveButton(Guna.UI2.WinForms.Guna2Button activeBtn)
        {
            foreach (Control ctrl in employee_menu_pnl.Controls)
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

        }

        private void employee_welcomePage_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            employee_search_pnl.Hide();
            aiDetection_pnl.Hide();
            employee_appointment_pnl.Hide();
            employee_schedule_pnl.Hide();
        }

        private void employee_search_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            employee_search_pnl.Show();
            aiDetection_pnl.Hide();
            employee_schedule_pnl.Hide();
            employee_appointment_pnl.Hide();
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void aiDetection_UploadImage_btn_Click(object sender, EventArgs e)
        {


        }

        private void employee_aiDetection_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            aiDetection_pnl.Show();
            employee_search_pnl.Hide();
            employee_appointment_pnl.Hide();
            employee_schedule_pnl.Hide();

        }

        private void employee_schedule_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            employee_schedule_pnl.Show();
            aiDetection_pnl.Hide();
            employee_appointment_pnl.Hide();
        }

        private void employee_appointment_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
            employee_schedule_pnl.Hide();
            aiDetection_pnl.Hide();
            employee_search_pnl.Hide();
            employee_appointment_pnl.Show();
            employee_appointmentDetails_pnl.Show();
        }

        private void employee_user_btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Guna.UI2.WinForms.Guna2Button)sender);
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
            employee_appointmentPayment_pnl.Show();
            employee_appointmentDetails_pnl.Hide();
        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {


        }

        private void employee_appointmentDone_btn_Click(object sender, EventArgs e)
        {

            //fields to lbl of summary
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


            // Total, discount, grand total
            employee_appointmentSummaryTotal_lbl.Text = "Total: " + employee_appointmentTotal_tb.Text;
            employee_appointmentSummaryDiscount_lbl.Text = "Discount: " + employee_appointmentDiscount_tb.Text;
            employee_appointmentSummaryGrandTotal_lbl.Text = "Grand Total: " + employee_appointment_GrandTotal_tb.Text;

            // Payment method (single selection)
            if (employee_appointmentPaymentMethod_listBox.SelectedItem != null)
                employee_appointmentSummaryPaymentMethod_lbl.Text = employee_appointmentPaymentMethod_listBox.SelectedItem.ToString();
            else
                employee_appointmentSummaryPaymentMethod_lbl.Text = "N/A";

            //Booked By from login details
            if (employee_appointmentEmployeeName_listBox.SelectedItem != null)
                employee_appointmentSummaryBookedBy_lbl.Text = employee_name_lbl.Text;
            else
                employee_appointmentSummaryBookedBy_lbl.Text = "N/A";
            // Assigned employee (single selection)
            if (employee_appointmentEmployeeName_listBox.SelectedItem != null)
                employee_appointmentSummaryAssignedPerson_lbl.Text = employee_appointmentEmployeeName_listBox.SelectedItem.ToString();
            else
                employee_appointmentSummaryAssignedPerson_lbl.Text = "N/A";

            employee_appointmentSummaryService_lbl.Text = string.Join("\n",
            employee_appointmentServices_checkListBox.CheckedItems.Cast<string>());
            employee_appointmentPaymentSummry_pnl.Show();
            employee_appointmentPayment_pnl.Hide();

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

          

            //clearing fields for a fresh booking
            employee_appointmentCnic_tb.Clear();
            employee_appointmentCarModel_tb.Clear();
            employee_appointmentAddress_tb.Clear();
            employee_appointmentYear_tb.Clear();
            employee_appointmentOwnerName_tb.Clear();
            employee_appointmentPaymentMethod_listBox.ClearSelected();
            employee_appointmentMake_tb.Clear();
            employee_appointmentPhone_tb.Clear();
            employee_appointmentCarNumber_tb.Clear();
            employee_appointmentColor_tb.Clear();
            employee_appointmentServices_checkListBox.ClearSelected();
            employee_appointmentEmployeeName_listBox.ClearSelected();
            employee_appointmentTotal_tb.Clear();
            employee_appointment_GrandTotal_tb.Clear();
            employee_appointmentDiscount_tb.Clear();
            employee_appointmentPayment_pnl.Hide();
            employee_appointmentPaymentSummry_pnl.Hide();
            employee_appointmentDetails_pnl.Show();
        }
    }
}
