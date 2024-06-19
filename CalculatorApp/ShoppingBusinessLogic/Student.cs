using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBusinessLogic
{
    public class Student
    {

        private string FirstName{ get; set; }
        private string LastName { get; set; }
        private string City { get; set; }
        public Student()
        {
            Console.WriteLine("===");
        }
        public Student(string fname, string sname)
        {
            this.FirstName = fname;
            this.LastName = sname;
        }
        public Student(string fname, string sname,string city):this(fname,sname)
        {
            this.City = city;
        }


    }
}
