using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace FYP_PROJECT.Helpers.CommonHelpers
{
    public class ButtonAnimationHelper
    {
        private readonly Panel _menuPanel;
        private readonly Dictionary<Guna2Button, float> _buttonFontSizes = new Dictionary<Guna2Button, float>();
        private Guna2Button _currentActiveButton = null;
        private Timer _fontAnimationTimer;
        private readonly float _animationStep = 0.5f;

        public ButtonAnimationHelper(Panel menuPanel)
        {
            _menuPanel = menuPanel ?? throw new ArgumentNullException(nameof(menuPanel));
        }

        public void SetActiveButton(Guna2Button activeBtn)
        {
            if (activeBtn == null) return;

            foreach (Control ctrl in _menuPanel.Controls)
            {
                if (ctrl is Guna2Button btn)
                {
                    if (!_buttonFontSizes.ContainsKey(btn))
                        _buttonFontSizes[btn] = btn.Font.Size;

                    // ❗ Skip resetting the currently active button to avoid double-click flicker
                    if (btn == activeBtn)
                        continue;

                    // Reset style for all non-active buttons
                    btn.FillColor = Color.FromArgb(20, 20, 30);
                    btn.ForeColor = Color.Gainsboro;
                    btn.BorderRadius = 8;
                    btn.TextAlign = HorizontalAlignment.Left;
                    btn.Padding = new Padding(15, 0, 0, 0);
                    btn.Font = new Font("Segoe UI", _buttonFontSizes[btn], FontStyle.Regular);
                    btn.HoverState.FillColor = Color.FromArgb(50, 50, 100);
                    btn.HoverState.ForeColor = Color.White;
                    btn.HoverState.BorderColor = Color.FromArgb(128, 128, 255);
                }
            }

            // Animate only if switching buttons
            if (_currentActiveButton != activeBtn)
            {
                AnimateFontSizeTransition(_currentActiveButton, activeBtn);
                _currentActiveButton = activeBtn;
            }

            // Always apply active styling
            activeBtn.FillColor = Color.FromArgb(128, 128, 255);
            activeBtn.ForeColor = Color.White;
            activeBtn.Font = new Font("Segoe UI", activeBtn.Font.Size, FontStyle.Bold);
        }

        private void AnimateFontSizeTransition(Guna2Button oldBtn, Guna2Button newBtn)
        {
            float baseOld = oldBtn != null && _buttonFontSizes.ContainsKey(oldBtn) ? _buttonFontSizes[oldBtn] : 10f;
            float baseNew = newBtn != null && _buttonFontSizes.ContainsKey(newBtn) ? _buttonFontSizes[newBtn] : 10f;

            float targetOld = baseOld;
            float targetNew = baseNew + 2f;

            _fontAnimationTimer?.Stop();
            _fontAnimationTimer = new Timer { Interval = 15 };

            _fontAnimationTimer.Tick += (s, e) =>
            {
                bool done = true;

                if (oldBtn != null && oldBtn.Font.Size > targetOld)
                {
                    float newSize = oldBtn.Font.Size - _animationStep;
                    oldBtn.Font = new Font("Segoe UI", Math.Max(newSize, targetOld), FontStyle.Regular);
                    if (newSize > targetOld) done = false;
                }

                if (newBtn != null && newBtn.Font.Size < targetNew)
                {
                    float newSize = newBtn.Font.Size + _animationStep;
                    newBtn.Font = new Font("Segoe UI", Math.Min(newSize, targetNew), FontStyle.Bold);
                    if (newSize < targetNew) done = false;
                }

                if (done)
                    _fontAnimationTimer.Stop();
            };

            _fontAnimationTimer.Start();
        }
    }
}
