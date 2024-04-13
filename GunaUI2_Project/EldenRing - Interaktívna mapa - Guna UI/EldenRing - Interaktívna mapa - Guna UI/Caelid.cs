using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace EldenRing___Interaktívna_mapa___Guna_UI
{
    public partial class Caelid : Form
    {
        private Guna2TabControl guna2TabControl1;

        public Caelid()
        {
            InitializeComponent();
            InitializeSearchTab();
        }

        private void InitializeSearchTab()
        {
            // Create Guna2TabControl
            guna2TabControl1 = new Guna2TabControl();
            guna2TabControl1.Dock = DockStyle.Fill;
            this.Controls.Add(guna2TabControl1);

            // Create Search tab
            /*Guna2TabPage searchTab = new Guna2TabPage(); // Corrected mistake here
            searchTab.Text = "Search";
            guna2TabControl1.TabPages.Add(searchTab);

            // Create Guna2TextBox for search input
            Guna2TextBox searchTextBox = new Guna2TextBox();
            searchTextBox.PlaceholderText = "Enter search query...";
            searchTextBox.Size = new System.Drawing.Size(300, 30);
            searchTextBox.Location = new System.Drawing.Point(50, 50);
            searchTab.Controls.Add(searchTextBox);

            // Create Guna2Button for search
            Guna2Button searchButton = new Guna2Button();
            searchButton.Text = "Search";
            searchButton.Size = new System.Drawing.Size(100, 30);
            searchButton.Location = new System.Drawing.Point(360, 50);
            searchTab.Controls.Add(searchButton);

            // Attach Click event handler for search button
            searchButton.Click += SearchButton_Click;*/
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Handle search functionality here
            MessageBox.Show("Search button clicked!");
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
