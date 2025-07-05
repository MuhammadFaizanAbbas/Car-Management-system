using System;
using System.Windows.Forms;

namespace FYP_PROJECT.Helpers.CommonHelpers
{
    public static class UIHelper
    {
        public static void ShowFormWithFade(Form currentForm, Form targetForm, double opacityStep = 0.08, int timerIntervalMs = 1)
        {
            targetForm.Opacity = 0;
            targetForm.Show();

            Timer fadeIn = new Timer();
            fadeIn.Interval = timerIntervalMs;

            fadeIn.Tick += (s, e) =>
            {
                if (targetForm.Opacity >= 1)
                {
                    fadeIn.Stop();
                    currentForm.Hide();  // Hide the current form after new form is fully visible
                }
                else
                {
                    targetForm.Opacity += opacityStep;
                }
            };
            fadeIn.Start();
        }
    }
}
