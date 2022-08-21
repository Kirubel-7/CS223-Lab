using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration_8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void registorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
            Form1 screen = new Form1();
            screen.MdiParent = this;
            screen.Show();
        }

        private void displayAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
            dgv screen = new dgv();
            screen.MdiParent = this;
            screen.Show();
        }

        private void customCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
            Display screen = new Display();
            screen.MdiParent = this;
            screen.Show();
        }
    }
}
