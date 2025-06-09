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
    public partial class Login_Baru : Form
    {
        public Login_Baru()
        {
            InitializeComponent();
        }
        private bool cekLogin(string username, string password)
        {
            using (var koneksiDB = new KoneksiDB())
            {
                var user = koneksiDB.customer.FirstOrDefault(u => u.username == username && u.password == password);
                return user != null;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = boxUsername.Text;
            string password = boxPassword.Text;
            if (username != "" || password != "")
            {
                if (cekLogin(username, password))
                {
                    MessageBox.Show("Login Berhasil", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    DashboardUser dashbord = new DashboardUser();
                    dashbord.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username dan Password tidak boleh kosong", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
