using System;
using System.Windows.Forms;
using Project_PBO_Kel_5;

namespace Project_PBO_Kel_5
{
    public partial class Dashboard : Form
    {
        private ThemeManager themeManager;
        private SearchBar searchBar;

        public Dashboard()
        {
            InitializeComponent();
            themeManager = new ThemeManager(this);

            // Inisialisasi SearchBar
            searchBar = new SearchBar
            {
                Location = new Point(336, 8)
            };
            tablelayout1.Controls.Add(searchBar, 2, 0);
            tablelayout1.SetRowSpan(searchBar, 2);

            // Hubungkan event
            searchBar.SearchClicked += SearchBar_SearchClicked;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            themeManager.ApplyGradientBackground();
        }

        private void SearchBar_SearchClicked(object sender, EventArgs e)
        {
            if (sender is ISearchable searchable)
            {
                MessageBox.Show("Mencari: " + searchable.SearchText);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tablelayout1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}