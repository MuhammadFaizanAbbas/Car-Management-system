using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace FYP_PROJECT.Helpers.LoginHelpers
{
    public static class FadeHelper
    {
        private const int DefaultSteps = 50;       // More steps = smoother
        private const int DefaultInterval = 5;     // Less = faster animation

        // ========== LABEL ==========
        public static async Task FadeInLabel(Label label, int steps = DefaultSteps, int interval = DefaultInterval)
        {
            if (label == null) return;

            label.Visible = true;
            label.Enabled = false;
            Color baseColor = Color.Black;

            for (int i = 0; i <= steps; i++)
            {
                int alpha = Math.Min(255, (int)(255f * i / steps));
                label.ForeColor = Color.FromArgb(alpha, baseColor.R, baseColor.G, baseColor.B);
                await Task.Delay(interval);
            }

            label.Enabled = true;
        }

        public static async Task FadeOutLabel(Label label, int steps = DefaultSteps, int interval = DefaultInterval)
        {
            if (label == null) return;

            label.Enabled = false;
            Color original = label.ForeColor;

            for (int i = steps; i >= 0; i--)
            {
                int alpha = Math.Max(0, (int)(255f * i / steps));
                label.ForeColor = Color.FromArgb(alpha, original.R, original.G, original.B);
                await Task.Delay(interval);
            }

            label.Visible = false;
        }

        // ========== GUNA2 BUTTON ==========
        public static async Task FadeInButton(Guna2Button btn, int steps = DefaultSteps, int interval = DefaultInterval)
        {
            if (btn == null) return;

            btn.Visible = true;
            btn.Enabled = false;

            Color baseFill = Color.LightGray;
            Color baseFore = Color.Black;

            for (int i = 0; i <= steps; i++)
            {
                int alpha = Math.Min(255, (int)(255f * i / steps));
                btn.FillColor = Color.FromArgb(alpha, baseFill.R, baseFill.G, baseFill.B);
                btn.ForeColor = Color.FromArgb(alpha, baseFore.R, baseFore.G, baseFore.B);
                btn.BorderColor = Color.FromArgb(alpha, baseFore.R, baseFore.G, baseFore.B);
                await Task.Delay(interval);
            }

            btn.Enabled = true;
        }

        public static async Task FadeOutButton(Guna2Button btn, int steps = DefaultSteps, int interval = DefaultInterval)
        {
            if (btn == null) return;

            btn.Enabled = false;
            Color baseFill = btn.FillColor;
            Color baseFore = btn.ForeColor;

            for (int i = steps; i >= 0; i--)
            {
                int alpha = Math.Max(0, (int)(255f * i / steps));
                btn.FillColor = Color.FromArgb(alpha, baseFill.R, baseFill.G, baseFill.B);
                btn.ForeColor = Color.FromArgb(alpha, baseFore.R, baseFore.G, baseFore.B);
                btn.BorderColor = Color.FromArgb(alpha, baseFore.R, baseFore.G, baseFore.B);
                await Task.Delay(interval);
            }

            btn.Visible = false;
        }

        // ========== GENERIC CONTROL FADEOUT ==========
        public static async Task FadeOutControl(Control ctrl, int steps = DefaultSteps, int interval = DefaultInterval)
        {
            if (ctrl == null) return;

            ctrl.Enabled = false;
            Color original = ctrl.ForeColor;

            for (int i = steps; i >= 0; i--)
            {
                int alpha = Math.Max(0, (int)(255f * i / steps));
                ctrl.ForeColor = Color.FromArgb(alpha, original.R, original.G, original.B);
                await Task.Delay(interval);
            }

            ctrl.Visible = false;
        }
    }
}
