using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace FYP_PROJECT
{
    public partial class Login_form : Form
    {
        private Timer loginSlideTimer;  // Timer for smooth login panel animation
        private Timer signupSlideTimer;  // Timer for smooth signup panel animation
        private int loginTargetPosition;  // Target position for login panel (fully visible)
        private int signupTargetPosition;  // Target position for signup panel (fully visible)
        private int slideSpeed = 15;  // Speed of the animation (larger value = faster)
        private string generatedOTP;
        private int otpResendCount = 0;
        private const int maxOtpResend = 3;
        private Timer resendTimer;
        private int resendCooldown = 30;
        public Login_form()
        {


            InitializeComponent();
            admin_login_pnl.Visible = false;
            employe_login_pnl.Visible = false;
            forgotPassword_btn.Visible = false;
            forgotPassword_pnl.Visible = false;
            signup_admin_pnl.Visible = false;
            login_forgotPasswordPhoneCode_pnl.Visible = false;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            /* eliminate repaint flicker */
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);

            // Subscribe to the Resize event to handle resizing logic
            this.Resize += Form1_Resize;

            // Initialize the slideTimers
            loginSlideTimer = new Timer();
            signupSlideTimer = new Timer();

            // Set the interval and event handlers for the timers
            loginSlideTimer.Interval = 10;  // Adjust the speed of the animation
            loginSlideTimer.Tick += LoginSlideTimer_Tick;

            signupSlideTimer.Interval = 10;  // Adjust the speed of the animation
            signupSlideTimer.Tick += SignupSlideTimer_Tick;

            // Set initial positions for panels
            login_pnl.Left = -login_pnl.Width;  // Login panel starts off-screen to the left
            signup_pnl.Left = this.ClientSize.Width;  // Signup panel starts off-screen to the right
        }
        private async Task SlideAsync(Control ctl, int fromX, int toX, int durationMs = 300)
        {
            int dx = toX - fromX;
            if (dx == 0) return;

            const int frameTime = 10;                 // ~66 fps
            int frames = durationMs / frameTime;
            double t = 0;

            var sw = System.Diagnostics.Stopwatch.StartNew();

            while (t < 1.0)
            {
                t = Math.Min(1.0, sw.ElapsedMilliseconds / (double)durationMs); // 0-1
                                                                                // simple easing (ease-in-out quad)
                double ease = t < 0.5 ? 2 * t * t : -1 + (4 - 2 * t) * t;

                ctl.Left = fromX + (int)(dx * ease);
                await Task.Delay(frameTime);
            }

            ctl.Left = toX;   // snap exactly
        }


        private async void signup_btn_Click(object sender, EventArgs e)
        {
            signup_pnl.Visible = true;

            int loginFrom = login_pnl.Left;  // Use its current position
            int loginTo = -login_pnl.Width;

            int signupFrom = this.ClientSize.Width;
            int signupTo = this.ClientSize.Width - signup_pnl.Width;

            Task t1 = SlideAsync(login_pnl, loginFrom, loginTo);
            Task t2 = SlideAsync(signup_pnl, signupFrom, signupTo);

            await Task.WhenAll(t1, t2);
            login_pnl.Visible = false;
            Employee emp = new Employee();
            emp.Hide();
            admin adm = new admin();
            adm.Hide();
        }



        private void LoginSlideTimer_Tick(object sender, EventArgs e)
        {
            // Move login panel to its target position
            if (login_pnl.Left < loginTargetPosition)
            {
                login_pnl.Left += slideSpeed;  // Move the login panel towards its target position
            }
            else
            {
                loginSlideTimer.Stop();  // Stop the timer when the login panel reaches its target position

                // If the login panel has been moved off-screen, hide it
                if (loginTargetPosition == -login_pnl.Width)
                {
                    login_pnl.Visible = false;  // Hide login panel when it's off-screen
                }
            }
        }

        private void SignupSlideTimer_Tick(object sender, EventArgs e)
        {
            // Move signup panel to its target position
            if (signup_pnl.Left > signupTargetPosition)
            {
                signup_pnl.Left -= slideSpeed;  // Move the signup panel towards its target position
            }
            else
            {
                signupSlideTimer.Stop();  // Stop the timer when the signup panel reaches its target position

                // If the signup panel has been moved off-screen, hide it
                if (signupTargetPosition == this.ClientSize.Width)
                {
                    signup_pnl.Visible = false;  // Hide signup panel when it's off-screen
                }
            }
        }
        private void signup_pnl_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 70;
            GraphicsPath path = new GraphicsPath();

            // Rounded edges logic for signup panel
            path.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90);
            path.AddLine(borderRadius, 0, signup_pnl.Width, 0);
            path.AddLine(signup_pnl.Width, 0, signup_pnl.Width, signup_pnl.Height);
            path.AddLine(signup_pnl.Width, signup_pnl.Height, 0, signup_pnl.Height);
            path.AddArc(0, signup_pnl.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
            path.AddLine(0, signup_pnl.Height - borderRadius, 0, borderRadius);
            path.CloseFigure();

            signup_pnl.Region = new Region(path);
            e.Graphics.FillPath(new SolidBrush(signup_pnl.BackColor), path);
        }

        private void login_pnl_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 70;
            GraphicsPath path = new GraphicsPath();

            path.AddLine(0, 0, login_pnl.Width - borderRadius, 0);
            path.AddArc(login_pnl.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90);
            path.AddLine(login_pnl.Width, 0, login_pnl.Width, login_pnl.Height - borderRadius);
            path.AddArc(login_pnl.Width - borderRadius * 2, login_pnl.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
            path.AddLine(login_pnl.Width - borderRadius, login_pnl.Height, 0, login_pnl.Height);
            path.AddLine(0, login_pnl.Height, 0, 0);
            path.CloseFigure();

            login_pnl.Region = new Region(path);
            e.Graphics.FillPath(new SolidBrush(login_pnl.BackColor), path);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Ensure panels remain correctly positioned after resizing
            if (login_pnl.Left < 0)
            {
                login_pnl.Left = -login_pnl.Width;  // Reset position if the login panel is off-screen
            }
            else if (login_pnl.Left > 0 && login_pnl.Left < loginTargetPosition)
            {
                loginTargetPosition = 0;  // Reset the target position to the left edge of the form
            }

            if (signup_pnl.Left > this.ClientSize.Width)
            {
                signup_pnl.Left = this.ClientSize.Width;  // Reset position if the signup panel is off-screen to the right
            }
            else if (signup_pnl.Left < this.ClientSize.Width && signup_pnl.Left > signupTargetPosition)
            {
                signupTargetPosition = this.ClientSize.Width - signup_pnl.Width;  // Adjust signup panel to the right edge of the form
            }
        }







        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            ShowFormWithFade(emp);


        }


        private void Login_form_Load(object sender, EventArgs e)
        {
            employe_username_tb.MaxLength = 40;
            admin_userName_tb.MaxLength = 40;
            FadeInSelf();

        }




        private void admin_proceed_btn_Click(object sender, EventArgs e)
        {

            admin admin_Page = new admin();
            ShowFormWithFade(admin_Page); ;
            forgotPassword_btn.Hide();
        }

        private void admin_back_btn_Click(object sender, EventArgs e)
        {
            admin_login_pnl.Hide();
            admin_login_btn.Show();
            employee_login_btn.Show();
            forgotPassword_btn.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admin_login_btn_Click_1(object sender, EventArgs e)
        {
            employee_login_btn.Hide();
            admin_login_btn.Hide();
            admin_login_pnl.Show();
            forgotPassword_btn.Show();
        }

        private void employee_login_btn_Click(object sender, EventArgs e)
        {
            employe_login_pnl.Show();
            admin_login_btn.Hide();
            employee_login_btn.Hide();
            forgotPassword_btn.Show();
        }

        private void employe_back_btn_Click_1(object sender, EventArgs e)
        {
            employe_login_pnl.Hide();
            admin_login_btn.Show();
            employee_login_btn.Show();
            forgotPassword_btn.Hide();
        }

        private async void login_btn_Click_1(object sender, EventArgs e)
        {
            login_pnl.Visible = true;  // We're bringing login panel into view
                                       // ❌ No need to set signup_pnl.Visible = true here again

            int loginFrom = login_pnl.Left;  // Get its current position
            int loginTo = 0;                 // Move into view

            int signupFrom = signup_pnl.Left;  // Could already be off-screen or on-screen
            int signupTo = this.ClientSize.Width;  // Move it fully off-screen

            Task t1 = SlideAsync(login_pnl, loginFrom, loginTo);
            Task t2 = SlideAsync(signup_pnl, signupFrom, signupTo);

            await Task.WhenAll(t1, t2);
            signup_pnl.Visible = false;
            Employee emp = new Employee();
            emp.Hide();
            admin adm = new admin();
            adm.Hide();
        }

        private async void signup_btn_Click_1(object sender, EventArgs e)
        {
            signup_pnl.Visible = true;

            int loginFrom = login_pnl.Left;  // Use its current position
            int loginTo = -login_pnl.Width;

            int signupFrom = this.ClientSize.Width;
            int signupTo = this.ClientSize.Width - signup_pnl.Width;

            Task t1 = SlideAsync(login_pnl, loginFrom, loginTo);
            Task t2 = SlideAsync(signup_pnl, signupFrom, signupTo);

            await Task.WhenAll(t1, t2);
            login_pnl.Visible = false;
            Employee emp = new Employee();
            emp.Hide();
            admin adm = new admin();
            adm.Hide();
        }

        private void closeApplication_btn_Click(object sender, EventArgs e)
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

        private void employe_username_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void forgotPassword_btn_Click(object sender, EventArgs e)
        {
            signup_btn.Hide();
            login_pnl.Hide();
            login_btn.Hide();
            signup_pnl.Hide();
            forgotPassword_pnl.Show();
            forgotPassword_btn.Hide();
        }

        private void forgotPasswordSecurity_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            signup_btn.Show(); ;
            login_btn.Show();
            login_pnl.Show();
            forgotPassword_pnl.Hide();
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

        private void signup_admin_btn_Click(object sender, EventArgs e)
        {
            signup_employe_btn.Hide();
            signup_admin_btn.Hide();
            signup_admin_pnl.Show();

        }
      
       



        private void signup_adminBack_btn_Click(object sender, EventArgs e)
        {
            signup_admin_btn.Show();
            signup_employe_btn.Show();
            signup_admin_pnl.Hide();

        }

        private void FadeInSelf()
        {
            this.Opacity = 0;

            Timer fadeIn = new Timer();
            fadeIn.Interval = 10; // Very smooth

            fadeIn.Tick += (s, e) =>
            {
                if (this.Opacity >= 1)
                {
                    fadeIn.Stop();
                    fadeIn.Dispose();
                }
                else
                {
                    this.Opacity += 0.05; // Fast fade
                }
            };

            fadeIn.Start();
        }

        private void login_forgotPasswordProceed_btn_Click(object sender, EventArgs e)
        {
            string phoneNumber = forgotPasswordPhoneNumber_tb.Text.Trim();

            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }

            generatedOTP = new Random().Next(100000, 999999).ToString();
            string message = $"Your password reset code is: {generatedOTP}";
            string error;

            if (SendSms(phoneNumber, message, out error))
            {
                login_forgotPasswordPhone_lbl.Text = phoneNumber;
                login_otpStatus_lbl.Text = $"OTP sent to {phoneNumber}";
                login_otpStatus_lbl.Visible = true;
                login_forgotPasswordPhoneCode_pnl.Show();
                forgotPassword_pnl.Hide();
                otpResendCount = 0; // reset count for fresh start
            }
            else
            {
                MessageBox.Show("Failed to send OTP: " + error);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            login_forgotPasswordPhoneCode_pnl.Hide();
            forgotPassword_pnl.Show();
        }

        private void login_forgotPasswordPhone_lbl_Click(object sender, EventArgs e)
        {

        }

        private void login_forgotPasswordPhoneCode_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_forgotPasswordSendCodeAgain_btn_Click(object sender, EventArgs e)
        {
            string phoneNumber = login_forgotPasswordPhone_lbl.Text.Trim();

            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Phone number is missing.");
                return;
            }

            if (otpResendCount >= maxOtpResend)
            {
                MessageBox.Show("Maximum resend attempts reached. Please try again later.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            otpResendCount++;
            generatedOTP = new Random().Next(100000, 999999).ToString();
            string message = $"Your new OTP code is: {generatedOTP}";
            string error;

            if (SendSms(phoneNumber, message, out error))
            {
                login_otpStatus_lbl.Text = $"New OTP sent to {phoneNumber}";
                login_otpStatus_lbl.Visible = true;

                // Start cooldown
                login_forgotPasswordSendCodeAgain_btn.Enabled = false;
                resendCooldown = 30;
                login_forgotPasswordSendCodeAgain_btn.Text = $"Send Again ({resendCooldown}s)";

                resendTimer = new Timer();
                resendTimer.Interval = 1000;
                resendTimer.Tick += (s, ev) =>
                {
                    resendCooldown--;
                    login_forgotPasswordSendCodeAgain_btn.Text = $"Send Again ({resendCooldown}s)";

                    if (resendCooldown <= 0)
                    {
                        resendTimer.Stop();
                        login_forgotPasswordSendCodeAgain_btn.Enabled = true;
                        login_forgotPasswordSendCodeAgain_btn.Text = "Send Again";
                    }
                };
                resendTimer.Start();
            }
            else
            {
                MessageBox.Show("Failed to resend OTP: " + error);
            }
        }

        private void login_forgotPasswordChangePass_btn_Click(object sender, EventArgs e)
        {
            string enteredOTP = login_forgotPasswordPhoneCode_tb.Text.Trim();
            string phoneNumber = login_forgotPasswordPhone_lbl.Text.Trim();

            if (string.IsNullOrEmpty(enteredOTP))
            {
                MessageBox.Show("Please enter the OTP.", "Missing OTP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enteredOTP == generatedOTP)
            {
                MessageBox.Show("OTP verified successfully!\nYour password has been changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string message = "Your password has been successfully changed.";
                string error;

                if (!SendSms(phoneNumber, message, out error))
                {
                    MessageBox.Show("Failed to send confirmation SMS:\n" + error, "SMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Reset
                login_forgotPasswordPhoneCode_tb.Clear();
                login_otpStatus_lbl.Visible = false;
                login_forgotPasswordPhoneCode_pnl.Hide();
                generatedOTP = null;
                otpResendCount = 0;
                signup_btn.Show();
                login_btn.Show();
            }
            else
            {
                MessageBox.Show("Incorrect OTP. Please try again.", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SendSms(string toNumber, string messageBody, out string errorMessage)
        {
            errorMessage = "";
            try
            {
                string accountSid = "ACce0ef485c010ab783ced9d8400821263";
                string authToken = "d6767dd9bc2a67642487d71a0177a17c";
                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: messageBody,
                    from: new PhoneNumber("+12678132211"),
                    to: new PhoneNumber(toNumber)
                );

                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

    }

}