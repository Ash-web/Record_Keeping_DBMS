
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.Login_Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.logoff = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SlidingPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.SettingsTabButton = new System.Windows.Forms.Button();
            this.BooksTab = new System.Windows.Forms.Button();
            this.BorrowersTabButton = new System.Windows.Forms.Button();
            this.AboutTabButton = new System.Windows.Forms.Button();
            this.TransactionsTabButton = new System.Windows.Forms.Button();
            this.Sliderpanel_togglebutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_Timer
            // 
            this.Login_Timer.Interval = 50;
            this.Login_Timer.Tick += new System.EventHandler(this.Login_Timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.logoff);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1477, 37);
            this.panel1.TabIndex = 0;
            // 
            // minimize
            // 
            this.minimize.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_minimize_window_30;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.minimize.Location = new System.Drawing.Point(1404, 4);
            this.minimize.Margin = new System.Windows.Forms.Padding(4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(31, 28);
            this.minimize.TabIndex = 3;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // logoff
            // 
            this.logoff.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_power_off_button_50;
            this.logoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoff.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.logoff.Location = new System.Drawing.Point(1365, 4);
            this.logoff.Margin = new System.Windows.Forms.Padding(4);
            this.logoff.Name = "logoff";
            this.logoff.Size = new System.Drawing.Size(31, 28);
            this.logoff.TabIndex = 2;
            this.logoff.UseVisualStyleBackColor = true;
            this.logoff.Click += new System.EventHandler(this.logoff_Click);
            // 
            // close
            // 
            this.close.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_close_window_48;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.close.Location = new System.Drawing.Point(1443, 4);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(31, 28);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // SlidingPanelTimer
            // 
            this.SlidingPanelTimer.Interval = 1;
            this.SlidingPanelTimer.Tick += new System.EventHandler(this.SlidingPanelTimer_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(406, 37);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1071, 653);
            this.ContentPanel.TabIndex = 2;
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.Color.Transparent;
            this.SlidingPanel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pexels_johannes_plenio_1103970;
            this.SlidingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlidingPanel.Controls.Add(this.SettingsTabButton);
            this.SlidingPanel.Controls.Add(this.BooksTab);
            this.SlidingPanel.Controls.Add(this.BorrowersTabButton);
            this.SlidingPanel.Controls.Add(this.AboutTabButton);
            this.SlidingPanel.Controls.Add(this.TransactionsTabButton);
            this.SlidingPanel.Controls.Add(this.Sliderpanel_togglebutton);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.ForeColor = System.Drawing.Color.Navy;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 37);
            this.SlidingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(403, 653);
            this.SlidingPanel.TabIndex = 1;
            this.SlidingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SlidingPanel_Paint);
            // 
            // SettingsTabButton
            // 
            this.SettingsTabButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTabButton.ForeColor = System.Drawing.Color.Navy;
            this.SettingsTabButton.Image = global::WindowsFormsApp1.Properties.Resources._3669250_settings_ic_icon;
            this.SettingsTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsTabButton.Location = new System.Drawing.Point(-1, 295);
            this.SettingsTabButton.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsTabButton.Name = "SettingsTabButton";
            this.SettingsTabButton.Size = new System.Drawing.Size(400, 65);
            this.SettingsTabButton.TabIndex = 2;
            this.SettingsTabButton.Text = "Settings";
            this.SettingsTabButton.UseVisualStyleBackColor = false;
            this.SettingsTabButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BooksTab
            // 
            this.BooksTab.BackColor = System.Drawing.Color.Transparent;
            this.BooksTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BooksTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BooksTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksTab.ForeColor = System.Drawing.Color.Navy;
            this.BooksTab.Image = global::WindowsFormsApp1.Properties.Resources._809571_books_documents_office_work_icon__1_;
            this.BooksTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BooksTab.Location = new System.Drawing.Point(0, 73);
            this.BooksTab.Margin = new System.Windows.Forms.Padding(4);
            this.BooksTab.Name = "BooksTab";
            this.BooksTab.Size = new System.Drawing.Size(400, 70);
            this.BooksTab.TabIndex = 6;
            this.BooksTab.Text = "Books";
            this.BooksTab.UseVisualStyleBackColor = false;
            this.BooksTab.Click += new System.EventHandler(this.BooksTab_Click);
            // 
            // BorrowersTabButton
            // 
            this.BorrowersTabButton.BackColor = System.Drawing.Color.Transparent;
            this.BorrowersTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowersTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowersTabButton.ForeColor = System.Drawing.Color.Navy;
            this.BorrowersTabButton.Image = global::WindowsFormsApp1.Properties.Resources.borrowers;
            this.BorrowersTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrowersTabButton.Location = new System.Drawing.Point(-1, 150);
            this.BorrowersTabButton.Margin = new System.Windows.Forms.Padding(4);
            this.BorrowersTabButton.Name = "BorrowersTabButton";
            this.BorrowersTabButton.Size = new System.Drawing.Size(400, 65);
            this.BorrowersTabButton.TabIndex = 5;
            this.BorrowersTabButton.Text = "Borrowers";
            this.BorrowersTabButton.UseVisualStyleBackColor = false;
            this.BorrowersTabButton.Click += new System.EventHandler(this.BorrowersTabButton_Click);
            // 
            // AboutTabButton
            // 
            this.AboutTabButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTabButton.ForeColor = System.Drawing.Color.Navy;
            this.AboutTabButton.Image = global::WindowsFormsApp1.Properties.Resources._7628371_about_information_info_help_icon;
            this.AboutTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutTabButton.Location = new System.Drawing.Point(-1, 368);
            this.AboutTabButton.Margin = new System.Windows.Forms.Padding(4);
            this.AboutTabButton.Name = "AboutTabButton";
            this.AboutTabButton.Size = new System.Drawing.Size(400, 65);
            this.AboutTabButton.TabIndex = 4;
            this.AboutTabButton.Text = "About";
            this.AboutTabButton.UseVisualStyleBackColor = false;
            this.AboutTabButton.Click += new System.EventHandler(this.AboutTabButton_Click);
            // 
            // TransactionsTabButton
            // 
            this.TransactionsTabButton.BackColor = System.Drawing.Color.Transparent;
            this.TransactionsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionsTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsTabButton.ForeColor = System.Drawing.Color.Navy;
            this.TransactionsTabButton.Image = global::WindowsFormsApp1.Properties.Resources._4177548_ecommerce_shop_transaction_icon__1_;
            this.TransactionsTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionsTabButton.Location = new System.Drawing.Point(-1, 223);
            this.TransactionsTabButton.Margin = new System.Windows.Forms.Padding(4);
            this.TransactionsTabButton.Name = "TransactionsTabButton";
            this.TransactionsTabButton.Size = new System.Drawing.Size(400, 65);
            this.TransactionsTabButton.TabIndex = 3;
            this.TransactionsTabButton.Text = "Transactions";
            this.TransactionsTabButton.UseVisualStyleBackColor = false;
            this.TransactionsTabButton.Click += new System.EventHandler(this.TransactionsTabButton_Click);
            // 
            // Sliderpanel_togglebutton
            // 
            this.Sliderpanel_togglebutton.BackColor = System.Drawing.Color.Transparent;
            this.Sliderpanel_togglebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sliderpanel_togglebutton.Location = new System.Drawing.Point(0, 0);
            this.Sliderpanel_togglebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Sliderpanel_togglebutton.Name = "Sliderpanel_togglebutton";
            this.Sliderpanel_togglebutton.Size = new System.Drawing.Size(400, 65);
            this.Sliderpanel_togglebutton.TabIndex = 2;
            this.Sliderpanel_togglebutton.UseVisualStyleBackColor = false;
            this.Sliderpanel_togglebutton.Click += new System.EventHandler(this.Sliderpanel_togglebutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 690);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.SlidingPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Login_Timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button logoff;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button Sliderpanel_togglebutton;
        private System.Windows.Forms.Timer SlidingPanelTimer;
        private System.Windows.Forms.Button BooksTab;
        private System.Windows.Forms.Button BorrowersTabButton;
        private System.Windows.Forms.Button AboutTabButton;
        private System.Windows.Forms.Button TransactionsTabButton;
        private System.Windows.Forms.Button SettingsTabButton;
        private System.Windows.Forms.Panel ContentPanel;
    }
}