using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_8.Add
{
    internal class AddStu
    {
        public int id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public DateTime Schoolyear { get; set; }
        public char gender { get; set; }
        public static List<AddStu> Add = new List<AddStu>();

        public string save() 
        {
            Add.Add(this);
            return "Student Registerd!";
        }

        public static List<AddStu> get()
        {
            return Add;
        }
    }
}
