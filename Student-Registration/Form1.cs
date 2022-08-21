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
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rb_Click(object sender, EventArgs e)
        {
            AddStu add = new AddStu();
            AddCard card = new AddCard();
            add.id = Convert.ToInt32(id1.Text);
            add.Fname = fname.Text;
            add.Lname = lname.Text;
            add.Address = address1.Text;
            add.Schoolyear = Convert.ToDateTime(dtp1.Text);
            
            if (rb1.Checked)
                add.gender = 'M';
            else
                add.gender = 'F';


            if (id1.Text.Length < 5)
            {
                errorp1.SetError(id1, "Id digit must be 5!");
            }
            else if (string.IsNullOrEmpty(fname.Text))
            {
                errorp1.SetError(fname, "First Name is required!");
            }
            else if (string.IsNullOrEmpty(lname.Text))
            {
                errorp1.SetError(lname, "Last Name is required!");
            }
            else if (string.IsNullOrEmpty(address1.Text))
            {
                errorp1.SetError(address1, "Object Name is required!");
            }
            //else if (!(regex.IsMatch(objname.Text)))
            //{
            //    errorp1.SetError(objname, "Object Name must start with Letters");

            //}
            //else if (string.IsNullOrEmpty(rb1.Checked?))
            //{
            //    errorp1.SetError(objname, "Count is required!");
            //}
            else
            {
                errorp1.Clear();
                MessageBox.Show(add.save());
                dgv d = new dgv();
                //MessageBox.Show(d._lab1.ToString());

                //card.card();

                }
        }
    }
}
