namespace Project_PBO_Kel_5
{
    partial class Kelola_Product
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kelola_Product));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNama = new TextBox();
            txtStok = new TextBox();
            txtHarga = new TextBox();
            txtDeskripsi = new TextBox();
            btnTambah = new Button();
            btnUpdate = new Button();
            btnHapus = new Button();
            label6 = new Label();
            txtID = new TextBox();
            BtnExportPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Enabled = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(77, 333);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(920, 250);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(433, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 27);
            label1.TabIndex = 0;
            label1.Text = "MANAJEMENT PRODUCT";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(395, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(95, 75);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 3;
            label2.Text = "ID_Produk       :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(92, 163);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 4;
            label3.Text = "Stok                 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(93, 212);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 5;
            label4.Text = "Harga              :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(92, 265);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 6;
            label5.Text = "Deskripsi        :";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(200, 115);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(797, 27);
            txtNama.TabIndex = 7;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(199, 163);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(798, 27);
            txtStok.TabIndex = 8;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(200, 212);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(797, 27);
            txtHarga.TabIndex = 9;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(197, 265);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(800, 27);
            txtDeskripsi.TabIndex = 10;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.SeaGreen;
            btnTambah.Location = new Point(265, 298);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 11;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkCyan;
            btnUpdate.ForeColor = SystemColors.ControlText;
            btnUpdate.Location = new Point(401, 298);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(255, 52, 52);
            btnHapus.Location = new Point(538, 298);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 13;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(93, 115);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 14;
            label6.Text = "Nama Produk :";
            // 
            // txtID
            // 
            txtID.Location = new Point(200, 75);
            txtID.Name = "txtID";
            txtID.Size = new Size(797, 27);
            txtID.TabIndex = 15;
            // 
            // BtnExportPDF
            // 
            BtnExportPDF.BackColor = Color.WhiteSmoke;
            BtnExportPDF.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnExportPDF.Location = new Point(869, 589);
            BtnExportPDF.Name = "BtnExportPDF";
            BtnExportPDF.Size = new Size(128, 29);
            BtnExportPDF.TabIndex = 16;
            BtnExportPDF.Text = "Convert Ke PDF";
            BtnExportPDF.UseVisualStyleBackColor = false;
            // 
            // Kelola_Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 102);
            ClientSize = new Size(1082, 627);
            Controls.Add(BtnExportPDF);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(btnHapus);
            Controls.Add(btnUpdate);
            Controls.Add(btnTambah);
            Controls.Add(txtDeskripsi);
            Controls.Add(txtHarga);
            Controls.Add(txtStok);
            Controls.Add(txtNama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Kelola_Product";
            Text = "Kelola_Product";
            Load += Kelola_Product_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNama;
        private TextBox txtStok;
        private TextBox txtHarga;
        private TextBox txtDeskripsi;
        private Button btnTambah;
        private Button btnUpdate;
        private Button btnHapus;
        private Label label6;
        private TextBox txtID;
        private Button BtnExportPDF;
    }
}
