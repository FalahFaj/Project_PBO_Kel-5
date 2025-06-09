using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_Kel_5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Regis regis = new Regis();
            regis.ShowDialog();
            this.Hide();
        }
        private bool cekLogin(string username, string password)
        {
            using (var koneksiDB = new KoneksiDB())
            {
                var user = koneksiDB.customer.FirstOrDefault(u => u.username == username && u.password == password);
                return user != null;
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string password = textBox3.Text;

            if (username != "" || password != "")
            {
                if (cekLogin(username, password))
                {
                    MessageBox.Show("Login Berhasil", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    DashboardUser dashbord = new DashboardUser();
                    dashbord.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password Salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username atau Password tidak boleh kosong", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}