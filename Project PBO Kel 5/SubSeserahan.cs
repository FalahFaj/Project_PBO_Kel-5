using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PBO_Kel_5
{
    public partial class SubSeserahan : Form
    {
        public SubSeserahan()
        {
            InitializeComponent();

        }
        private void SubSeserahan_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pindahpanel (Form Pembayaran, Panel panel)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }
            Pembayaran uc = panel;
            uc.TopLevel = false;
            uc.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(uc);
            this.panel1.Tag = uc;
            uc.Show();
        }
    }
}
