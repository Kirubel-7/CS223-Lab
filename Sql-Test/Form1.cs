using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sql_Test
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

        private void button1_Click(object sender, EventArgs e)
        {
            String cs = "data source=.\\SQLSERVER ; database=test0; integrated security=true";
            using (SqlConnection con = new SqlConnection(cs))
            {
                string q = "select * from Customers";
                con.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter(q,con);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                dgv.DataSource = dt;
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String cs = "data source=.\\SQLSERVER ; database=test0; integrated security=true";
            using (SqlConnection con = new SqlConnection(cs))
            {
                string q = "insert into Customers values('Henok','Bekele','1994-04-26',100000)";
                //string b = "select * from Customers";
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(q,con);
                var result = sqlCommand.ExecuteNonQuery();
                var read = sqlCommand.ExecuteReader();
                while (read.Read()) 
                {
                    string name = read[1].ToString();
                    MessageBox.Show(name);
                }
                //MessageBox.Show(result.ToString()+" Rows Affected!");
            }

            }
    }
}
