using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            IsSlidingPanelExpanded = true;
        }

        private void Login_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                Login_Timer.Stop();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Login_Timer.Start();

        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logoff_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        public void expandSlidingPanelGUI()
        {
            BooksTab.Text = "BOOKS";
            BorrowersTabButton.Text = "BORROWERS";
            TransactionsTabButton.Text = "TRANSACTIONS";
            SettingsTabButton.Text = "SETTINGS";
            AboutTabButton.Text = "ABOUT";

            BooksTab.Image = null;
            BorrowersTabButton.Image = null;
            TransactionsTabButton.Image = null;
            SettingsTabButton.Image = null;
            AboutTabButton.Image = null;
        }
        public void retractSlidingPanelGUI()
        {
            BooksTab.Text = "";
            BorrowersTabButton.Text = "";
            TransactionsTabButton.Text = "";
            SettingsTabButton.Text = "";
            AboutTabButton.Text = "";

            BooksTab.Image = Properties.Resources._809571_books_documents_office_work_icon__1_;
            BorrowersTabButton.Image = Properties.Resources.borrowers;
            TransactionsTabButton.Image = Properties.Resources._4177548_ecommerce_shop_transaction_icon__1_;
            SettingsTabButton.Image = Properties.Resources._3669250_settings_ic_icon;
            AboutTabButton.Image = Properties.Resources._7628371_about_information_info_help_icon;
        }



        bool IsSlidingPanelExpanded;
        const int maxSliderWidth = 300;
        const int minSliderWidth = 100;
        private void Sliderpanel_togglebutton_Click(object sender, EventArgs e)
        {
            if (IsSlidingPanelExpanded)
            {
                retractSlidingPanelGUI();
            }
            SlidingPanelTimer.Start();
        }

        private void SlidingPanelTimer_Tick(object sender, EventArgs e)
        {
            if (IsSlidingPanelExpanded)
            {
                SlidingPanel.Width -= 30;
                if (SlidingPanel.Width <= minSliderWidth)
                {
                    IsSlidingPanelExpanded = false;
                    SlidingPanelTimer.Stop();

                    this.Refresh();
                }
            }
            else
            {
                SlidingPanel.Width += 30;
                if (SlidingPanel.Width >= maxSliderWidth)
                {
                    IsSlidingPanelExpanded = true;
                    SlidingPanelTimer.Stop();
                    expandSlidingPanelGUI();
                    this.Refresh();
                }
            }
        }

        private void SlidingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BooksTab_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(BooksUserControl.Instance))
            {
                ContentPanel.Controls.Add(BooksUserControl.Instance);
                BooksUserControl.Instance.Dock = DockStyle.Fill;
                BooksUserControl.Instance.BringToFront();
            }
            else
            {
                BooksUserControl.Instance.BringToFront();
            }
        }

        private void BorrowersTabButton_Click(object sender, EventArgs e)
        {

        }

        private void TransactionsTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Transactions_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Transactions_UserControl.Instance);
                Transactions_UserControl.Instance.Dock = DockStyle.Fill;
                Transactions_UserControl.Instance.BringToFront();
            }
            else
            {
                Transactions_UserControl.Instance.BringToFront();
            }
        }

        private void AboutTabButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
