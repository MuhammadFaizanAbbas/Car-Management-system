using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FYP_PROJECT.Helpers.LoginHelpers
{
    public class PasswordToggleHelper
    {
        private readonly Guna2TextBox passwordTextBox;
        private readonly Guna2Button toggleButton;
        private bool isVisible;

        public PasswordToggleHelper(Guna2TextBox textBox, Guna2Button button)
        {
            passwordTextBox = textBox;
            toggleButton = button;
            isVisible = false;

            passwordTextBox.UseSystemPasswordChar = true;
            toggleButton.Image = Properties.Resources.eyeShow;
            toggleButton.FillColor = Color.Transparent;
            toggleButton.BorderThickness = 0;
            toggleButton.ImageSize = new Size(20, 20);

            var parentControl = passwordTextBox.Parent;
            if (parentControl == null)
                throw new Exception("TextBox has no parent!");

            if (toggleButton.Parent != parentControl)
                parentControl.Controls.Add(toggleButton);

            toggleButton.Location = new Point(passwordTextBox.Right - toggleButton.Width - 5, passwordTextBox.Top + (passwordTextBox.Height - toggleButton.Height) / 2);
            toggleButton.BringToFront();

            // Attach the internal click handler here
            toggleButton.Click += ToggleButton_Click;

            // Optional: if you want to reposition the button when textbox moves or resizes,
            // you can add event handlers for SizeChanged and LocationChanged here
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            isVisible = !isVisible;
            passwordTextBox.UseSystemPasswordChar = !isVisible;
            toggleButton.Image = isVisible ? Properties.Resources.eyeHide : Properties.Resources.eyeShow;
        }
    }
}
