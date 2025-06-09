namespace Project_PBO_Kel_5
{
    partial class Login_Baru
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            boxUsername = new TextBox();
            lblUsername = new Label();
            boxPassword = new TextBox();
            lblPassword = new Label();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // boxUsername
            // 
            boxUsername.Location = new Point(330, 149);
            boxUsername.Name = "boxUsername";
            boxUsername.Size = new Size(125, 27);
            boxUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(354, 116);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // boxPassword
            // 
            boxPassword.Location = new Point(330, 238);
            boxPassword.Name = "boxPassword";
            boxPassword.Size = new Size(125, 27);
            boxPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(354, 215);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(345, 331);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mahar;
            pictureBox1.Location = new Point(526, 332);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 28);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Login_Baru
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(boxPassword);
            Controls.Add(lblUsername);
            Controls.Add(boxUsername);
            Name = "Login_Baru";
            Text = "Login_Baru";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox boxUsername;
        private Label lblUsername;
        private TextBox boxPassword;
        private Label lblPassword;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}