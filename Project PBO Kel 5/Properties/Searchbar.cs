using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_PBO_Kel_5
{
    public class SearchBar : Panel
    {
        private TextBox textBox;
        private PictureBox searchIcon;

        public event EventHandler SearchClicked;

        public string SearchText
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public SearchBar()
        {
            this.Size = new Size(300, 30);
            this.BackColor = Color.FromArgb(100, 66, 139, 202);
            this.BorderStyle = BorderStyle.FixedSingle;

            // TextBox untuk input pencarian
            textBox = new TextBox();
            textBox.BorderStyle = BorderStyle.None;
            textBox.BackColor = Color.FromArgb(66, 139, 202); 

            textBox.ForeColor = Color.White;
            textBox.Font = new Font("Segoe UI", 10);
            textBox.Location = new Point(10, 5);
            textBox.Width = 240;

            // PictureBox untuk ikon pencarian
            searchIcon = new PictureBox();
            searchIcon.Image = Image.FromFile("search-icon.png"); // Ganti dengan path yang benar
            searchIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            searchIcon.Size = new Size(20, 20);
            searchIcon.Location = new Point(270, 5);
            searchIcon.Cursor = Cursors.Hand;
            searchIcon.Click += SearchIcon_Click;

            // Tambahkan komponen ke panel
            this.Controls.Add(textBox);
            this.Controls.Add(searchIcon);
        }

        private void SearchIcon_Click(object sender, EventArgs e)
        {
            SearchClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
