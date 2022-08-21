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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
            
        }
        private static int[] clab1 = new int[2];
        private static string[] clab2 = new string[2];   
        private static string[] clab3 = new string[2];   
        private static string[] clab4 = new string[2];   
        private static DateTime[] clab5 = new DateTime[2];   
        private static char[] clab6 = new char[2];
        private static int x;
        public Display(int lab1, string lab2, string lab3, string lab4,
                       DateTime lab5, char lab6,int y)
        {
           x = y;
            for (int i=0;i<x;i++) {
                clab1[i] = lab1;
                clab2[i] = lab2;
                clab3[i] = lab3;
                clab4[i] = lab4;
                clab5[i] = lab5;
                clab6[i] = lab6;
            }
            MessageBox.Show(clab1[0].ToString());
            MessageBox.Show(clab1[1].ToString());   
        }

        private void Display_Load(object sender, EventArgs e)
        {
            CustomCard2[] card = new CustomCard2[x];
            //dgv d = new dgv();
            //MessageBox.Show(d._lab1.ToString());
            
            for (int i = 0; i < x; i++) { card[i] = new CustomCard2(); }

            //foreach (var item in AddStu.get())
            //{
                for (int i = 0; i < x; i++)
                {
                    card[i]._lab1 = clab1[i];
                    card[i]._lab2 = clab2[i];
                    card[i]._lab3 = clab3[i];
                    card[i]._lab4 = clab4[i];
                    card[i]._lab5 = clab5[i];
                    card[i]._lab6 = clab6[i];
                    flp1.Controls.Add(card[i]);
                }

            //}
            // AddCard card = new AddCard();

        }
    }
}
