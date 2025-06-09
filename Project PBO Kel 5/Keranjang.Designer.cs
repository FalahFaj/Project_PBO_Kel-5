namespace Project_PBO_Kel_5
{
    partial class Keranjang
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
            dataGridView1 = new DataGridView();
            Nama_Produk = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nama_Produk, Status, Harga });
            dataGridView1.Location = new Point(154, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(510, 225);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nama_Produk
            // 
            Nama_Produk.HeaderText = "Nama Produk";
            Nama_Produk.MinimumWidth = 8;
            Nama_Produk.Name = "Nama_Produk";
            Nama_Produk.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // Harga
            // 
            Harga.HeaderText = "Harga";
            Harga.MinimumWidth = 8;
            Harga.Name = "Harga";
            Harga.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 85);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 1;
            label1.Text = "Keranjang Saya";
            // 
            // Keranjang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Keranjang";
            Text = "Keranjang";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nama_Produk;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Harga;
        private Label label1;
    }
}