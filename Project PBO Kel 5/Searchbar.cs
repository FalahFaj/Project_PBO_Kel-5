using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_PBO_Kel_5
{
    public partial class SearchBar : UserControl
    {
        public event EventHandler SearchClicked;

        private TextBox textBox;

        public string SearchText => textBox.Text;

        public SearchBar()
        {
            InitializeSearchBar();
        }

        private void InitializeSearchBar()
        {
            this.Size = new Size(400, 40);
            this.BackColor = Color.FromArgb(198, 231, 255); 

            textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Font = new Font("Segoe UI", 12),
                Location = new Point(10, 10),
                Width = 340,
                BackColor = Color.FromArgb(198, 231, 255) 
            };

            PictureBox pictureBox = new PictureBox
            {
                Image = Image.FromFile("C:\\Users\\LENOVO\\source\\repos\\Project_PBO_Kel-5\\Project PBO Kel 5\\Asset\\search.png"),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(24, 24),
                Location = new Point(360, 8),
                Cursor = Cursors.Hand
            };
            pictureBox.Click += (s, e) => SearchClicked?.Invoke(this, EventArgs.Empty);

            this.Controls.Add(textBox);
            this.Controls.Add(pictureBox);
            SetupPlaceholder();
            AddEnterKeySupport();
        }

        private void SetupPlaceholder()
        {
            textBox.Text = "Search";
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == "Search")
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = "Cari...";
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void AddEnterKeySupport()
        {
            textBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchClicked?.Invoke(this, EventArgs.Empty);
                }
            };
        }
    }
}