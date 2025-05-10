using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Project_PBO_Kel_5
{
    public class ThemeManager
    {
        private Form _targetForm;

        public ThemeManager(Form form)
        {
            _targetForm = form ?? throw new ArgumentNullException(nameof(form));
        }

        public void ApplyGradientBackground()
        {
            ApplyGradientBackground(Color.FromArgb(255, 29, 93, 155), Color.FromArgb(255, 198, 231, 255));
        }

        public void ApplyGradientBackground(Color startColor, Color endColor)
        {
            _targetForm.Paint += (sender, e) =>
            {
                using (LinearGradientBrush gradBrush = new LinearGradientBrush(
                    _targetForm.ClientRectangle,
                    startColor,
                    endColor,
                    LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(gradBrush, _targetForm.ClientRectangle);
                }
            };
            _targetForm.Invalidate();
        }
    }
}