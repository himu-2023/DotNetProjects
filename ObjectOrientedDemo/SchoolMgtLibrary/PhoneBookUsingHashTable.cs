using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMgtLibrary
{
    public class PhoneBookUsingHashTable
    {
        Hashtable ht = new Hashtable();
        public void PopulateEntries()
        {

            ht.Add(12345, "Anita");
            ht.Add(12346, "MAhi");
            ht.Add(12354, "Anuja");
            ht.Add(23454, "Mayur");
            ht.Add(13452, "Nisha");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
        public string FindName(string key)
        {
            string name = (string)ht[key];
            return name;
        }

        public string FindName(int k)
        {
            throw new NotImplementedException();
        }
    }
}