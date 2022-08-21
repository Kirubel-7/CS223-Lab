using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Registration_8.Add;
namespace Student_Registration_8
{
    public partial class dgv : Form
    {
        private int lab1;
        private string lab2;
        private string lab3;
        private string lab4;
        private DateTime lab5;
        private char lab6;
        public  int _lab1
        {
            get { return lab1; }
            set { lab1 = value; }
        }

        public string _lab2
        {
            get { return lab2; }
            set { lab2 = value; }
        }

        public string _lab3
        {
            get { return lab3; }
            set { lab3 = value; }
        }

        public string _lab4
        {
            get { return lab4; }
            set { lab4 = value; }
        }

        public DateTime _lab5
        {
            get { return lab5; }
            set { lab5 = value; }
        }

        public char _lab6
        {
            get { return lab6; }
            set { lab6 = value; }
        }
        public dgv()
        {
            InitializeComponent();
            dgvstu.DataSource = AddStu.get();

            setValues();
           
        }

        private void dgv_Load(object sender, EventArgs e)
        {
            //AddStu.get();
            dgvstu.DataSource = null;
            dgvstu.DataSource = AddStu.get();

        }

        private void dgvstu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void setValues() 
        {
            int x = dgvstu.RowCount;
            for (int i=0;i<dgvstu.RowCount;i++) {
                _lab1 = Convert.ToInt32(dgvstu[0, i].Value);
                _lab2 = Convert.ToString(dgvstu[1, i].Value);
                _lab3 = Convert.ToString(dgvstu[2, i].Value);
                _lab4 = Convert.ToString(dgvstu[3, i].Value);
                _lab5 = Convert.ToDateTime(dgvstu[4, i].Value);
                _lab6 = Convert.ToChar(dgvstu[5, i].Value);
             Display display = new Display(_lab1, _lab2, _lab3, _lab4, _lab5, _lab6,x);
            }
            
        }//pass button in dgv then it will pass all the values to custom card
    }
}
