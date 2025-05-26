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
            dataGridView1.Location = new Point(79, 350);
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
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(434, 41);
            label1.Name = "label1";
            label1.Size = new Size(268, 27);
            label1.TabIndex = 0;
            label1.Text = "MANAJEMENT PRODUCT";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(396, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 74);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 3;
            label2.Text = "ID_Produk                      :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 162);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 4;
            label3.Text = "Stok                                :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 211);
            label4.Name = "label4";
            label4.Size = new Size(169, 20);
            label4.TabIndex = 5;
            label4.Text = "Harga                             :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 264);
            label5.Name = "label5";
            label5.Size = new Size(168, 20);
            label5.TabIndex = 6;
            label5.Text = "Deskripsi                        :";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(272, 114);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(714, 27);
            txtNama.TabIndex = 7;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(269, 162);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(714, 27);
            txtStok.TabIndex = 8;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(269, 211);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(714, 27);
            txtHarga.TabIndex = 9;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(269, 264);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(714, 27);
            txtDeskripsi.TabIndex = 10;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(269, 297);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 11;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(405, 297);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(542, 297);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 13;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 114);
            label6.Name = "label6";
            label6.Size = new Size(166, 20);
            label6.TabIndex = 14;
            label6.Text = "Nama Produk                :";
            // 
            // txtID
            // 
            txtID.Location = new Point(272, 74);
            txtID.Name = "txtID";
            txtID.Size = new Size(714, 27);
            txtID.TabIndex = 15;
            // 
            // Kelola_Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 627);
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
    }
}
