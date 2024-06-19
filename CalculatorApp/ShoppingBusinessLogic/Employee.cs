using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBusinessLogic
{
    public class Employee
    {
        static int cnt = 0;
        public Employee()
        {

        }
       
        private int g()
        {
            cnt = cnt + 1;
            return cnt;
        }

    }
}
