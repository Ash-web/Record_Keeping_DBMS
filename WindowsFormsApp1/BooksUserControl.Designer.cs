
namespace WindowsFormsApp1
{
    partial class BooksUserControl
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
            this.BookId_textBox = new System.Windows.Forms.TextBox();
            this.Accn_textBox = new System.Windows.Forms.TextBox();
            this.Author_textBox = new System.Windows.Forms.TextBox();
            this.Publisher_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Isbn_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Department_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BookId_textBox
            // 
            this.BookId_textBox.Location = new System.Drawing.Point(349, 89);
            this.BookId_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookId_textBox.Name = "BookId_textBox";
            this.BookId_textBox.Size = new System.Drawing.Size(396, 22);
            this.BookId_textBox.TabIndex = 0;
            // 
            // Accn_textBox
            // 
            this.Accn_textBox.Location = new System.Drawing.Point(151, 492);
            this.Accn_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Accn_textBox.Name = "Accn_textBox";
            this.Accn_textBox.Size = new System.Drawing.Size(244, 22);
            this.Accn_textBox.TabIndex = 1;
            // 
            // Author_textBox
            // 
            this.Author_textBox.Location = new System.Drawing.Point(720, 596);
            this.Author_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Author_textBox.Name = "Author_textBox";
            this.Author_textBox.Size = new System.Drawing.Size(235, 22);
            this.Author_textBox.TabIndex = 2;
            // 
            // Publisher_textBox
            // 
            this.Publisher_textBox.Location = new System.Drawing.Point(151, 596);
            this.Publisher_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Publisher_textBox.Name = "Publisher_textBox";
            this.Publisher_textBox.Size = new System.Drawing.Size(244, 22);
            this.Publisher_textBox.TabIndex = 3;
            // 
            // Name_textBox
            // 
            this.Name_textBox.ForeColor = System.Drawing.Color.Black;
            this.Name_textBox.Location = new System.Drawing.Point(151, 543);
            this.Name_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(244, 22);
            this.Name_textBox.TabIndex = 4;
            // 
            // Isbn_textBox
            // 
            this.Isbn_textBox.Location = new System.Drawing.Point(720, 543);
            this.Isbn_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Isbn_textBox.Name = "Isbn_textBox";
            this.Isbn_textBox.Size = new System.Drawing.Size(235, 22);
            this.Isbn_textBox.TabIndex = 5;
            this.Isbn_textBox.TextChanged += new System.EventHandler(this.Isbn_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 492);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Acc No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 543);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 604);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Publisher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 543);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "ISBN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(665, 604);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Author";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(151, 223);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(772, 156);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button.ForeColor = System.Drawing.Color.White;
            this.Add_button.Image = global::WindowsFormsApp1.Properties.Resources.add;
            this.Add_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_button.Location = new System.Drawing.Point(151, 386);
            this.Add_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(151, 57);
            this.Add_button.TabIndex = 10;
            this.Add_button.Text = "Add New";
            this.Add_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_button.ForeColor = System.Drawing.Color.White;
            this.Update_button.Image = global::WindowsFormsApp1.Properties.Resources.update;
            this.Update_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update_button.Location = new System.Drawing.Point(361, 386);
            this.Update_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(147, 57);
            this.Update_button.TabIndex = 9;
            this.Update_button.Text = "Update";
            this.Update_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Update_button.UseVisualStyleBackColor = false;
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_button.ForeColor = System.Drawing.Color.White;
            this.Clear_button.Image = global::WindowsFormsApp1.Properties.Resources.clear;
            this.Clear_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clear_button.Location = new System.Drawing.Point(769, 386);
            this.Clear_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(153, 57);
            this.Clear_button.TabIndex = 8;
            this.Clear_button.Text = "Clear";
            this.Clear_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.ForeColor = System.Drawing.Color.White;
            this.Delete_button.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.Delete_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_button.Location = new System.Drawing.Point(576, 386);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(139, 57);
            this.Delete_button.TabIndex = 7;
            this.Delete_button.Text = "Delete";
            this.Delete_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.ForeColor = System.Drawing.Color.White;
            this.Search_button.Image = global::WindowsFormsApp1.Properties.Resources.search;
            this.Search_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search_button.Location = new System.Drawing.Point(407, 121);
            this.Search_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(308, 55);
            this.Search_button.TabIndex = 6;
            this.Search_button.Text = "Search Books";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(151, 534);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 1);
            this.panel1.TabIndex = 18;
            // 
            // Department_textBox
            // 
            this.Department_textBox.Location = new System.Drawing.Point(720, 492);
            this.Department_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Department_textBox.Name = "Department_textBox";
            this.Department_textBox.Size = new System.Drawing.Size(235, 22);
            this.Department_textBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(630, 495);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Department";
            // 
            // BooksUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Department_textBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Isbn_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Publisher_textBox);
            this.Controls.Add(this.Author_textBox);
            this.Controls.Add(this.Accn_textBox);
            this.Controls.Add(this.BookId_textBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BooksUserControl";
            this.Size = new System.Drawing.Size(1071, 654);
            this.Load += new System.EventHandler(this.BooksUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookId_textBox;
        private System.Windows.Forms.TextBox Accn_textBox;
        private System.Windows.Forms.TextBox Author_textBox;
        private System.Windows.Forms.TextBox Publisher_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Isbn_textBox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Department_textBox;
        private System.Windows.Forms.Label label7;
    }
}
