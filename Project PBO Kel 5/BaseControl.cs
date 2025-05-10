using System.Drawing;
using System.Windows.Forms;

namespace Project_PBO_Kel_5
{
    public abstract class BaseControl : UserControl
    {
        public virtual void ApplyStyle()
        {
            this.BackColor = Color.White;
        }
    }
}