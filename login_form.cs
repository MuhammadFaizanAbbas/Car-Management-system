using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Xml;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FYP_PROJECT.Helpers.LoginHelpers;


namespace FYP_PROJECT
{
    public partial class Login_form : Form
    {
        private Timer loginSlideTimer;  // Timer for smooth login panel animation
        private Timer signupSlideTimer;  // Timer for smooth signup panel animation
        private int loginTargetPosition;  // Target position for login panel (fully visible)
        private int signupTargetPosition;  // Target position for signup panel (fully visible)
        private int slideSpeed = 15;  // Speed of the animation (larger value = faster)
        private string verifiedUsername = null;
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
            employee_signup_pnl.Visible = false;
            admin_login_btn.Visible = false;
            employee_login_btn.Visible = false;
            main_gif_pb.SendToBack();
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
            string enteredUsername = employe_username_tb.Text.Trim();
            string enteredPassword = employe_password_tb.Text.Trim();

            if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT * 
                FROM users 
                WHERE User_UserName = @username 
                  AND User_Password = @password 
                  AND User_Account_Type = 'Employee'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", enteredUsername);
                        cmd.Parameters.AddWithValue("@password", enteredPassword);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // ✅ Store data into Session class
                                Session.UserId = Convert.ToInt32(reader["User_Id"]);
                                Session.AccountType = reader["User_Account_Type"].ToString();
                                Session.Name = reader["User_Name"].ToString();
                                Session.Username = reader["User_UserName"].ToString();
                                Session.Password = reader["User_Password"].ToString();
                                Session.Occupation = reader["User_Occupation"].ToString();
                                Session.PhoneNumber = reader["User_PhoneNumber"].ToString();
                                Session.Cnic = reader["User_Cnic"].ToString();
                                Session.Email = reader["User_Email"].ToString();
                                Session.SecurityQuestion = reader["User_SecurityQuestions"].ToString();
                                Session.SecurityAnswer = reader["User_SecurityAnswer"].ToString();

                                // ✅ Pass values if needed and show main employee form
                                Employee emp = new Employee();
                                emp.EmployeeName = Session.Name;
                                emp.EmployeeDesignation = Session.Occupation;

                                ShowFormWithFade(emp);
                                forgotPassword_btn.Hide(); // Optional
                            }
                            else
                            {
                                MessageBox.Show("Invalid employee credentials or access denied.",
                                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void Login_form_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.app_icon;

            employe_username_tb.MaxLength = 40;
            admin_userName_tb.MaxLength = 40;
            FadeInSelf();
            

        }




        private void admin_proceed_btn_Click(object sender, EventArgs e)
        {
            string enteredUsername = admin_userName_tb.Text.Trim();   // Your TextBox for username
            string enteredPassword = admin_password_tb.Text.Trim();   // Your TextBox for password

            if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Add condition to check User_Account_Type = 'Admin'
                    string query = "SELECT * FROM users WHERE User_UserName = @username AND User_Password = @password AND User_Account_Type = 'Admin'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", enteredUsername);
                        cmd.Parameters.AddWithValue("@password", enteredPassword);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // ✅ Use Read() to access fields
                            {
                                // Store admin info in Session
                                Session.UserId = Convert.ToInt32(reader["User_Id"]);
                                Session.AccountType = reader["User_Account_Type"].ToString();
                                Session.Name = reader["User_Name"].ToString();
                                Session.Username = reader["User_UserName"].ToString();
                                Session.Password = reader["User_Password"].ToString();
                                Session.Occupation = reader["User_Occupation"].ToString();
                                Session.PhoneNumber = reader["User_PhoneNumber"].ToString();
                                Session.Cnic = reader["User_Cnic"].ToString();
                                Session.Email = reader["User_Email"].ToString();
                                Session.SecurityQuestion = reader["User_SecurityQuestions"].ToString();
                                Session.SecurityAnswer = reader["User_SecurityAnswer"].ToString();

                                // Open Admin Page
                                admin admin_Page = new admin();
                                ShowFormWithFade(admin_Page);
                                forgotPassword_btn.Hide(); // optional
                            }
                            else
                            {
                                MessageBox.Show("Invalid admin credentials or access denied.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            admin_login_pnl.Hide();
            employe_login_pnl.Hide();
            await Task.WhenAll(
           // Fade out sign-up elements
           FadeHelper.FadeOutControl(signup_lbl),
            FadeHelper.FadeOutControl(signup_admin_btn),
            FadeHelper.FadeOutControl(signup_employe_btn)
                );
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
            await Task.WhenAll(
              FadeHelper.FadeInLabel(label1),
              FadeHelper.FadeInButton(admin_login_btn),
              FadeHelper.FadeInButton(employee_login_btn)
          );

            Employee emp = new Employee();
            emp.Hide();
            admin adm = new admin();
            adm.Hide();
        }

        private async void signup_btn_Click_1(object sender, EventArgs e)
        {
            await Task.WhenAll(
           FadeHelper.FadeOutControl(label1),
            FadeHelper.FadeOutControl(admin_login_btn),
            FadeHelper.FadeOutControl(employee_login_btn)
            );
            signup_pnl.Visible = true;

            int loginFrom = login_pnl.Left;  // Use its current position
            int loginTo = -login_pnl.Width;

            int signupFrom = this.ClientSize.Width;
            int signupTo = this.ClientSize.Width - signup_pnl.Width;

            Task t1 = SlideAsync(login_pnl, loginFrom, loginTo);
            Task t2 = SlideAsync(signup_pnl, signupFrom, signupTo);

            await Task.WhenAll(t1, t2);
          
            login_pnl.Visible = false;
            await Task.WhenAll(
                  FadeHelper.FadeInLabel(signup_lbl),
                  FadeHelper.FadeInButton(signup_admin_btn),
                  FadeHelper.FadeInButton(signup_employe_btn)
            );
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
            admin_login_pnl.Hide();
            employee_signup_pnl.Hide();
            signup_admin_pnl.Hide();
            employe_login_pnl.Hide();
            signup_btn.Show(); ;
            login_btn.Show();
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
            string name = forgotPassword_Name.Text.Trim();
            string email = forgotPassword_email.Text.Trim();
            string phoneNumber = forgotPasswordPhoneNumber_tb.Text.Trim();
            string username = forgotPassword_userName_tb.Text.Trim();
            string securityQuestion = forgotPasswordSecurity_comboBox.SelectedItem?.ToString() ?? "";
            string securityAnswer = forgotPassword_SecurityAnswer.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber) ||
                string.IsNullOrEmpty(securityQuestion) || string.IsNullOrEmpty(securityAnswer) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT * FROM users 
                             WHERE User_UserName = @username AND User_Name = @name AND User_Email = @Email AND User_PhoneNumber = @Phone 
                             AND User_SecurityQuestions = @Question AND User_SecurityAnswer = @Answer";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phoneNumber);
                        cmd.Parameters.AddWithValue("@Question", securityQuestion);
                        cmd.Parameters.AddWithValue("@Answer", securityAnswer);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows && reader.Read())
                            {
                                // ✅ Store verified username for password update
                                verifiedUsername = reader["User_UserName"].ToString();

                                // ✅ Send OTP
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
                                    otpResendCount = 0;
                                }
                                else
                                {
                                    MessageBox.Show("Failed to send OTP: " + error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Entered information does not match our records.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error:\n" + ex.Message);
                }
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
            string phoneNumber = login_forgotPasswordPhone_lbl.Text.Trim(); // only for SMS
            string newPassword = forgotPassword_NewPassword.Text.Trim();

            if (string.IsNullOrEmpty(enteredOTP))
            {
                MessageBox.Show("Please enter the OTP.", "Missing OTP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter a new password.", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enteredOTP == generatedOTP)
            {
                if (string.IsNullOrEmpty(verifiedUsername))
                {
                    MessageBox.Show("User verification data is missing. Please restart the password reset process.");
                    return;
                }

                string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string updateQuery = "UPDATE users SET User_Password = @newPassword WHERE User_UserName = @username";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@newPassword", newPassword);
                            cmd.Parameters.AddWithValue("@username", verifiedUsername);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Send confirmation SMS
                                string message = "Your password has been successfully changed.";
                                string error;
                                SendSms(phoneNumber, message, out error); // ignore if failed

                                // Reset UI
                                login_forgotPasswordPhoneCode_tb.Clear();
                                forgotPassword_NewPassword.Clear();
                                generatedOTP = null;
                                verifiedUsername = null;
                                otpResendCount = 0;
                                login_otpStatus_lbl.Visible = false;
                                login_forgotPasswordPhoneCode_pnl.Hide();

                                // Show login
                                admin_login_pnl.Hide();
                                employe_login_pnl.Hide();
                                signup_admin_pnl.Hide();
                                employee_signup_pnl.Hide();
                                signup_btn.Show();
                                login_btn.Show();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect OTP. Please try again.", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void employe_login_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admin_signupDone_btn_Click(object sender, EventArgs e)
        {
            string name = tb_admin_name.Text.Trim();
            string username = tb_admin_username.Text.Trim();
            string password = tb_admin_password.Text.Trim();
            string email = tb_admin_email.Text.Trim();
            string phone = tb_admin_phone.Text.Trim();
            string cnic = tb_admin_cnic.Text.Trim();
            string question = cb_admin_question.Text.Trim();
            string answer = tb_admin_answer.Text.Trim();

            // Optional: Basic validation
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(cnic) ||
                string.IsNullOrWhiteSpace(question) || string.IsNullOrWhiteSpace(answer))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = AdminSignupHelper.RegisterAdmin(name, username, password, email, phone, cnic, question, answer);

            if (success)
            {
                // Optional: clear fields after successful signup
                tb_admin_name.Clear();
                tb_admin_username.Clear();
                tb_admin_password.Clear();
                tb_admin_email.Clear();
                tb_admin_phone.Clear();
                tb_admin_cnic.Clear();
                cb_admin_question.SelectedIndex = -1;
                tb_admin_answer.Clear();

                
              
            }
        }

        private void signup_employe_btn_Click(object sender, EventArgs e)
        {
            employee_signup_pnl.Show();
        }

        private void employee_signupDone_btn_Click(object sender, EventArgs e)
        {
            string name = tb_emp_name.Text.Trim();
            string username = tb_emp_username.Text.Trim();
            string password = tb_emp_password.Text.Trim();
            string email = tb_emp_email.Text.Trim();
            string phone = tb_emp_phone.Text.Trim();
            string cnic = tb_emp_cnic.Text.Trim();
            string question = cb_emp_question.Text.Trim();
            string answer = tb_emp_answer.Text.Trim();

            bool success = EmployeeSignupHelper.RegisterEmployee(
                name, username, password, email, phone, cnic, question, answer);

            if (success)
            {
                tb_emp_name.Clear();
                tb_emp_username.Clear();
                tb_emp_password.Clear();
                tb_emp_email.Clear();
                tb_emp_phone.Clear();
                tb_emp_cnic.Clear();
                cb_emp_question.SelectedIndex = -1;
                tb_emp_answer.Clear();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            employee_signup_pnl.Hide();
        }

        private void main_gif_pb_Click(object sender, EventArgs e)
        {

        }
    }
}