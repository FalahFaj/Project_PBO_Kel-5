namespace Project_PBO_Kel_5
{
    partial class Chat_admin
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
            TxtPesan = new TextBox();
            BtnSend = new FontAwesome.Sharp.IconButton();
            LblNamaUser = new Label();
            flpKolomChat = new FlowLayoutPanel();
            flpKolomUser = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // TxtPesan
            // 
            TxtPesan.Location = new Point(265, 399);
            TxtPesan.Name = "TxtPesan";
            TxtPesan.Size = new Size(459, 27);
            TxtPesan.TabIndex = 2;
            // 
            // BtnSend
            // 
            BtnSend.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            BtnSend.IconColor = Color.Green;
            BtnSend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSend.IconSize = 40;
            BtnSend.Location = new Point(729, 392);
            BtnSend.Name = "BtnSend";
            BtnSend.Size = new Size(42, 40);
            BtnSend.TabIndex = 4;
            BtnSend.UseVisualStyleBackColor = true;
            BtnSend.Click += BtnSend_Click;
            // 
            // LblNamaUser
            // 
            LblNamaUser.AutoSize = true;
            LblNamaUser.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNamaUser.Location = new Point(267, 8);
            LblNamaUser.Name = "LblNamaUser";
            LblNamaUser.Size = new Size(98, 24);
            LblNamaUser.TabIndex = 5;
            LblNamaUser.Text = "NamaUser";
            // 
            // flpKolomChat
            // 
            flpKolomChat.AutoScroll = true;
            flpKolomChat.BackColor = SystemColors.ActiveCaption;
            flpKolomChat.FlowDirection = FlowDirection.TopDown;
            flpKolomChat.Location = new Point(253, 39);
            flpKolomChat.Name = "flpKolomChat";
            flpKolomChat.Size = new Size(521, 350);
            flpKolomChat.TabIndex = 6;
            flpKolomChat.WrapContents = false;
            flpKolomChat.Paint += flpKolomChat_Paint;
            // 
            // flpKolomUser
            // 
            flpKolomUser.BackColor = Color.FromArgb(255, 192, 128);
            flpKolomUser.Location = new Point(12, 39);
            flpKolomUser.Name = "flpKolomUser";
            flpKolomUser.Size = new Size(235, 387);
            flpKolomUser.TabIndex = 7;
            // 
            // Chat_admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpKolomUser);
            Controls.Add(LblNamaUser);
            Controls.Add(BtnSend);
            Controls.Add(TxtPesan);
            Controls.Add(flpKolomChat);
            Name = "Chat_admin";
            Text = "Chat_admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtPesan;
        private FontAwesome.Sharp.IconButton BtnSend;
        private Label LblNamaUser;
        private FlowLayoutPanel flpKolomChat;
        private FlowLayoutPanel flpKolomUser;
    }
}