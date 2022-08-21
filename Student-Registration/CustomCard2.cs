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
    public partial class CustomCard2 : UserControl
    {
        private int lab1;
        private string lab2;
        private string lab3;
        private string lab4;
        private DateTime lab5;
        private char lab6;
        public int _lab1
        {
            get { return lab1; }
            set { lab1 = value; label1.Text = value.ToString();}
        }

        public string _lab2
        {
            get { return lab2; }
            set { lab2 = value; label2.Text = value; }
        }
        public string _lab3
        {
            get { return lab3; }
            set { lab3 = value; label3.Text = value; }
        }
        public string _lab4
        {
            get { return lab4; }
            set { lab4 = value; label4.Text = value; }
        }
        public DateTime _lab5
        {
            get { return lab5; }
            set { lab5 = value; label5.Text = value.ToString(); }
        }
        public char _lab6
        {
            get { return lab6; }
            set { lab6 = value; label6.Text = value.ToString(); }
        }

        public CustomCard2()
        {
            InitializeComponent();
        }

        private void CustomCard2_Load(object sender, EventArgs e)
        {

        }
    }
}
