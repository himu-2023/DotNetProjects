using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMgtLibrary
{
    public class StudentSortedList
    {
        SortedList list = new SortedList();
        public StudentSortedList()
        {
            list.Add(1, "Anita");
            list.Add(2, "Mahi");
            list.Add(3, "Soni");
            list.Add(4, "Bina");
            list.Add(5, "Mira");


        }
        public void AddStudent(int k,string v)
        {
            list.Add(k, v);
        }
        public void AddData(int k, string v)
        {
            list.Add(k, v);
        }
        public void display()
        {

        }
    }
}
