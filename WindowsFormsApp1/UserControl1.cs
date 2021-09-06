using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Transactions_UserControl : UserControl
    {
        private static Transactions_UserControl _instance;

        public static Transactions_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Transactions_UserControl();
                }
                return _instance;
            }
        }

        public Transactions_UserControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        public string Book1, Book2, Borrower;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataReader dr;
        private void searchBorrower_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string syntax = "SELECT Book1 FROM Borrowers where brId = ' " + BorrowersTextField.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            Book1label.Text = Book1 = dr[0].ToString();
            con.Close();

            con.Open();
            syntax = "SELECT Book2 FROM Borrowers where brId = ' " + BorrowersTextField.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            Book2label.Text = Book2 = dr[0].ToString();
            con.Close();
        }

        private void SearchBooksINborrowers_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string syntax = "SELECT borrower FROM books where AccNo = ' " + AccNoTextField.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            LabelB.Text = Borrower = dr[0].ToString();
            con.Close();
        }

        private void clearAll_button_Click(object sender, EventArgs e)
        {

        }

        private void Issue_button_Click(object sender, EventArgs e)
        {
            SearchBooksINborrowers_button.PerformClick();
            if (Borrower != "")
            {
                MessageBox.Show("book is borrowed by borrower id: \n" + Borrower);
                return;
            }
            searchBorrower_button.PerformClick();
            if ((Book1 != "") && (Book2 != ""))
            {
                MessageBox.Show("borrower have already borrowed maximum no.of books.");
                return;
            }

            try
            {
                if (Book1 == "")
                {
                    cmd = new SqlCommand("TransactUpdateBook1_SP", con);
                }
                else
                {
                    cmd = new SqlCommand("TransactUpdateBook2_SP", con);
                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccNo", AccNoTextField.Text);
                cmd.Parameters.AddWithValue("@brId", BorrowersTextField.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("            <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            //Insert the issue details into transaction table
            cmd = new SqlCommand("TransactUpdateBook1_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@AccNo", AccNoTextField.Text);
            cmd.Parameters.AddWithValue("@brId", BorrowersTextField.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("            <<<INVALID SQL OPERATION>>>: \n" + ex);
            }
            con.Close();

                cmd = new SqlCommand("Transactions_insert_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@bkid", AccNoTextField.Text);
                cmd.Parameters.AddWithValue("@brId", BorrowersTextField.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("            <<<INVALID SQL OPERATION>>>: \n" + ex);
            }
            con.Close();

            SearchBooksINborrowers_button.PerformClick();
            searchBorrower_button.PerformClick();
            MessageBox.Show("Successfully Issued");
        }

        private void ReturnBook_button_Click(object sender, EventArgs e)
        {
            SearchBooksINborrowers_button.PerformClick();
            searchBorrower_button.PerformClick();
            if ((AccNoTextField.Text != Book1) && (AccNoTextField.Text != Book2))
            {
                MessageBox.Show("The inputted borrower has not borrowed the book input.");
                return;
            }
            try
            {
                if (Book1 == AccNoTextField.Text)
                {
                    cmd = new SqlCommand("TransactUpdateBook1_SP", con);
                }
                else
                {
                    cmd = new SqlCommand("TransactUpdateBook2_SP", con);
                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccNo", (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@brId", BorrowersTextField.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("            <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            cmd = new SqlCommand("TransactUpdateBook1_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@AccNo", AccNoTextField.Text);
            cmd.Parameters.AddWithValue("@brId", (object)DBNull.Value);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("            <<<INVALID SQL OPERATION>>>: \n" + ex);
            }
            con.Close();

            cmd = new SqlCommand("Transactions_delete_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bkid", AccNoTextField.Text);
            cmd.Parameters.AddWithValue("@brId", BorrowersTextField.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("            <<<INVALID SQL OPERATION>>>: \n" + ex);
            }
            con.Close();

            SearchBooksINborrowers_button.PerformClick();
            searchBorrower_button.PerformClick();
            MessageBox.Show("Successfully Returned");
        }

        private void ShowTransactionLog_button_Click(object sender, EventArgs e)
        {

        }

        private void Book1_label_Click(object sender, EventArgs e)
        {

        }

       

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
