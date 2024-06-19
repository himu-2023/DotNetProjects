using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMgtLibrary
{
    public class ArrayListDemo
    {
        ArrayList arrayList = new ArrayList();
        public ArrayListDemo()
        {
            arrayList.Add(123);
            arrayList.Add(1.34f);
            arrayList.Add(123.345d);
            arrayList.Add(new DateTime(2024, 12, 13));
            arrayList.Add("hello");

        }
        public ArrayList GetTheArrayList()
        {
            return arrayList;

        }
        public void AddElements(object obj)
        {
            arrayList.Add(obj);
            arrayList.Insert(4, obj);
            ArrayList a1 = new ArrayList();
            a1.Add(11);
            a1.Add(22);
            a1.Add(33);
            a1.Add(44);
            a1.Add(55);

            arrayList.AddRange(a1);
            arrayList.InsertRange(3, a1);

        }

    }
}