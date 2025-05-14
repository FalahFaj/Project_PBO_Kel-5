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
    public partial class Regis : Form
    {
        public Regis()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Show();

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void form1_Load(object sender, EventArgs e)
        {
            textBox5.Multiline = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.SelectionStart = textBox5.Text.Length;
            textBox5.ScrollToCaret();
        }
    }

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private Register registerForm;

        public Login(Register register)
        {
            InitializeComponent();
            this.registerForm = register;
        }

        private void btnBackToRegister_Click(object sender, EventArgs e)
        {
            registerForm.Show();
            this.Close();
        }


        private void InitializeComponent()
        {
        
        }
    }
}
