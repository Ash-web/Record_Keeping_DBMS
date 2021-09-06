
namespace WindowsFormsApp1
{
    partial class Transactions_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchBorrower_button = new System.Windows.Forms.Button();
            this.clearAll_button = new System.Windows.Forms.Button();
            this.SearchBooksINborrowers_button = new System.Windows.Forms.Button();
            this.ReturnBook_button = new System.Windows.Forms.Button();
            this.Issue_button = new System.Windows.Forms.Button();
            this.BorrowersTextField = new System.Windows.Forms.TextBox();
            this.AccNoTextField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Book2_label = new System.Windows.Forms.Label();
            this.Book1_label = new System.Windows.Forms.Label();
            this.Book1label = new System.Windows.Forms.Label();
            this.Book2label = new System.Windows.Forms.Label();
            this.BorrowedByLabel = new System.Windows.Forms.Label();
            this.LabelB = new System.Windows.Forms.Label();
            this.ShowTransactionLog_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBorrower_button
            // 
            this.searchBorrower_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.searchBorrower_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBorrower_button.ForeColor = System.Drawing.Color.Black;
            this.searchBorrower_button.Location = new System.Drawing.Point(391, 162);
            this.searchBorrower_button.Name = "searchBorrower_button";
            this.searchBorrower_button.Size = new System.Drawing.Size(276, 60);
            this.searchBorrower_button.TabIndex = 0;
            this.searchBorrower_button.Text = "Search Borrowers";
            this.searchBorrower_button.UseVisualStyleBackColor = false;
            this.searchBorrower_button.Click += new System.EventHandler(this.searchBorrower_button_Click);
            // 
            // clearAll_button
            // 
            this.clearAll_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.clearAll_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAll_button.ForeColor = System.Drawing.Color.Black;
            this.clearAll_button.Location = new System.Drawing.Point(266, 430);
            this.clearAll_button.Name = "clearAll_button";
            this.clearAll_button.Size = new System.Drawing.Size(276, 60);
            this.clearAll_button.TabIndex = 1;
            this.clearAll_button.Text = "Clear All";
            this.clearAll_button.UseVisualStyleBackColor = false;
            this.clearAll_button.Click += new System.EventHandler(this.clearAll_button_Click);
            // 
            // SearchBooksINborrowers_button
            // 
            this.SearchBooksINborrowers_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SearchBooksINborrowers_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBooksINborrowers_button.ForeColor = System.Drawing.Color.Black;
            this.SearchBooksINborrowers_button.Location = new System.Drawing.Point(391, 334);
            this.SearchBooksINborrowers_button.Name = "SearchBooksINborrowers_button";
            this.SearchBooksINborrowers_button.Size = new System.Drawing.Size(276, 60);
            this.SearchBooksINborrowers_button.TabIndex = 2;
            this.SearchBooksINborrowers_button.Text = "Search Books";
            this.SearchBooksINborrowers_button.UseVisualStyleBackColor = false;
            this.SearchBooksINborrowers_button.Click += new System.EventHandler(this.SearchBooksINborrowers_button_Click);
            // 
            // ReturnBook_button
            // 
            this.ReturnBook_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ReturnBook_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnBook_button.ForeColor = System.Drawing.Color.Black;
            this.ReturnBook_button.Location = new System.Drawing.Point(811, 430);
            this.ReturnBook_button.Name = "ReturnBook_button";
            this.ReturnBook_button.Size = new System.Drawing.Size(254, 60);
            this.ReturnBook_button.TabIndex = 3;
            this.ReturnBook_button.Text = "Return Book";
            this.ReturnBook_button.UseVisualStyleBackColor = false;
            this.ReturnBook_button.Click += new System.EventHandler(this.ReturnBook_button_Click);
            // 
            // Issue_button
            // 
            this.Issue_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Issue_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Issue_button.ForeColor = System.Drawing.Color.Black;
            this.Issue_button.Location = new System.Drawing.Point(5, 430);
            this.Issue_button.Name = "Issue_button";
            this.Issue_button.Size = new System.Drawing.Size(255, 60);
            this.Issue_button.TabIndex = 4;
            this.Issue_button.Text = "Issue Book";
            this.Issue_button.UseVisualStyleBackColor = false;
            this.Issue_button.Click += new System.EventHandler(this.Issue_button_Click);
            // 
            // BorrowersTextField
            // 
            this.BorrowersTextField.Location = new System.Drawing.Point(328, 104);
            this.BorrowersTextField.Name = "BorrowersTextField";
            this.BorrowersTextField.Size = new System.Drawing.Size(393, 22);
            this.BorrowersTextField.TabIndex = 6;
            // 
            // AccNoTextField
            // 
            this.AccNoTextField.Location = new System.Drawing.Point(328, 286);
            this.AccNoTextField.Name = "AccNoTextField";
            this.AccNoTextField.Size = new System.Drawing.Size(393, 22);
            this.AccNoTextField.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "AccNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Borrower\'s Id";
            // 
            // Book2_label
            // 
            this.Book2_label.AutoSize = true;
            this.Book2_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Book2_label.Location = new System.Drawing.Point(786, 141);
            this.Book2_label.Name = "Book2_label";
            this.Book2_label.Size = new System.Drawing.Size(48, 17);
            this.Book2_label.TabIndex = 12;
            this.Book2_label.Text = "Book2";
            this.Book2_label.Click += new System.EventHandler(this.label5_Click);
            // 
            // Book1_label
            // 
            this.Book1_label.AutoSize = true;
            this.Book1_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Book1_label.Location = new System.Drawing.Point(786, 83);
            this.Book1_label.Name = "Book1_label";
            this.Book1_label.Size = new System.Drawing.Size(48, 17);
            this.Book1_label.TabIndex = 13;
            this.Book1_label.Text = "Book1";
            this.Book1_label.Click += new System.EventHandler(this.Book1_label_Click);
            // 
            // Book1label
            // 
            this.Book1label.AutoSize = true;
            this.Book1label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Book1label.Location = new System.Drawing.Point(880, 83);
            this.Book1label.Name = "Book1label";
            this.Book1label.Size = new System.Drawing.Size(87, 17);
            this.Book1label.TabIndex = 14;
            this.Book1label.Text = "Borrowed by";
            // 
            // Book2label
            // 
            this.Book2label.AutoSize = true;
            this.Book2label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Book2label.Location = new System.Drawing.Point(880, 141);
            this.Book2label.Name = "Book2label";
            this.Book2label.Size = new System.Drawing.Size(87, 17);
            this.Book2label.TabIndex = 15;
            this.Book2label.Text = "Borrowed by";
            // 
            // BorrowedByLabel
            // 
            this.BorrowedByLabel.AutoSize = true;
            this.BorrowedByLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BorrowedByLabel.Location = new System.Drawing.Point(880, 291);
            this.BorrowedByLabel.Name = "BorrowedByLabel";
            this.BorrowedByLabel.Size = new System.Drawing.Size(68, 17);
            this.BorrowedByLabel.TabIndex = 16;
            this.BorrowedByLabel.Text = "Borrowed";
            // 
            // LabelB
            // 
            this.LabelB.AutoSize = true;
            this.LabelB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelB.Location = new System.Drawing.Point(747, 291);
            this.LabelB.Name = "LabelB";
            this.LabelB.Size = new System.Drawing.Size(87, 17);
            this.LabelB.TabIndex = 17;
            this.LabelB.Text = "Borrowed by";
            // 
            // ShowTransactionLog_button
            // 
            this.ShowTransactionLog_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ShowTransactionLog_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowTransactionLog_button.ForeColor = System.Drawing.Color.Black;
            this.ShowTransactionLog_button.Location = new System.Drawing.Point(548, 430);
            this.ShowTransactionLog_button.Name = "ShowTransactionLog_button";
            this.ShowTransactionLog_button.Size = new System.Drawing.Size(257, 60);
            this.ShowTransactionLog_button.TabIndex = 18;
            this.ShowTransactionLog_button.Text = "Show Transaction Log";
            this.ShowTransactionLog_button.UseVisualStyleBackColor = false;
            this.ShowTransactionLog_button.Click += new System.EventHandler(this.ShowTransactionLog_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 496);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 155);
            this.dataGridView1.TabIndex = 19;
            // 
            // Transactions_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowTransactionLog_button);
            this.Controls.Add(this.LabelB);
            this.Controls.Add(this.BorrowedByLabel);
            this.Controls.Add(this.Book2label);
            this.Controls.Add(this.Book1label);
            this.Controls.Add(this.Book1_label);
            this.Controls.Add(this.Book2_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccNoTextField);
            this.Controls.Add(this.BorrowersTextField);
            this.Controls.Add(this.Issue_button);
            this.Controls.Add(this.ReturnBook_button);
            this.Controls.Add(this.SearchBooksINborrowers_button);
            this.Controls.Add(this.clearAll_button);
            this.Controls.Add(this.searchBorrower_button);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Transactions_UserControl";
            this.Size = new System.Drawing.Size(1071, 654);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBorrower_button;
        private System.Windows.Forms.Button clearAll_button;
        private System.Windows.Forms.Button SearchBooksINborrowers_button;
        private System.Windows.Forms.Button ReturnBook_button;
        private System.Windows.Forms.Button Issue_button;
        private System.Windows.Forms.TextBox BorrowersTextField;
        private System.Windows.Forms.TextBox AccNoTextField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Book2_label;
        private System.Windows.Forms.Label Book1_label;
        private System.Windows.Forms.Label Book1label;
        private System.Windows.Forms.Label Book2label;
        private System.Windows.Forms.Label BorrowedByLabel;
        private System.Windows.Forms.Label LabelB;
        private System.Windows.Forms.Button ShowTransactionLog_button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
