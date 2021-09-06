using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BooksUserControl : UserControl
    {
        private static BooksUserControl _instance;

        public static BooksUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BooksUserControl();
                }
                return _instance;
            }
        }




        public BooksUserControl()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security = True");

        private void BooksUserControl_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchBooks_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AccNo", BookId_textBox.Text);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                
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

                dataGridView1.DataSource = DS.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("            <<<INVALID SQL OPERATION>>>: \n" + ex);
            }
        }

        public void refreshDataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllBooksData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

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

                dataGridView1.DataSource = DS.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("            <<<INVALID SQL OPERATION>>>: \n" + ex);
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("BooksAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AccNo", Accn_textBox.Text);
            cmd.Parameters.AddWithValue("@isbn", Isbn_textBox.Text);
            cmd.Parameters.AddWithValue("@Name", Name_textBox.Text);
            cmd.Parameters.AddWithValue("@author", Author_textBox.Text);
            cmd.Parameters.AddWithValue("@publisher", Publisher_textBox.Text);
            cmd.Parameters.AddWithValue("@did", Department_textBox.Text);

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
            refreshDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Isbn_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BooksDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccNo", Accn_textBox.Text);

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
                refreshDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            BookId_textBox.Text = "";
            Accn_textBox.Text = "";
            Name_textBox.Text = "";
            Department_textBox.Text = "";
            Author_textBox.Text = "";
            Publisher_textBox.Text = "";
            Isbn_textBox.Text = "";
        }
    }
}
