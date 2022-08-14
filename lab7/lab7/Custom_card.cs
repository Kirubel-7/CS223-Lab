using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Custom_card : UserControl
    {
        private string _title=" ";
        private string _desc=" ";
        private double _price;
        public string Title 
        {
            get { return _title; }
            set { _title = value; label1.Text = value; label2.Text = value; label3.Text = value; }
        }
        
        public string Desc
        {
            get { return _desc; }
            set { _desc = value; label2.Text = value; }
        }
        
        public double Price
        {
            get { return _price; }
            set { _price = value; label3.Text = Convert.ToString(value);}
        }
        public Custom_card()
        {
            InitializeComponent();
        }
    }
}
