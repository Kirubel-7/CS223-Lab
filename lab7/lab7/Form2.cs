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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>
            {
             "item 1", "item 2" ,"item 3","item 4", "item 5" ,"item 6"
            };

            foreach (var item in list)
            { 
              Custom_card card = new Custom_card();
                card.Title = item;
                flp1.Controls.Add(card);    
            }
        }
    }
}
