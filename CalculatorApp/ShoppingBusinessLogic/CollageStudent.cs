using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBusinessLogic
{
    public class CollageStudent:Student
    {
        public CollageStudent(string fname, string sname, string city) 
            : base(fname, sname,city)
        {
            Console.WriteLine("Parametrized of child");
        }
    }
}
