using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        private string getUsername()
        {
            con.Open();
            string syntax = "SELECT value FROM LibTable where Property = 'Username' ";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            return temp;
        }

        private string getPassword()
        {
            con.Open();
            string syntax = "SELECT value FROM LibTable where Property = 'Password' ";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            return temp;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string uname = getUsername(), upass = getPassword(), name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            if (name.Equals(uname) && pass.Equals(upass))
            {
                label4.Hide();
                //MessageBox.Show("Log In Success");
                Form2 obj = new Form2();
                this.Hide();
                obj.Show();

            }
            else
            {
                label4.Show();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
