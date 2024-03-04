using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac
{
    public class a 
    {
        List<book> ls = new List<book>();


        public void AddContact(book c)
        {
            ls.Add(c);
            Console.WriteLine("Contact added successfully!");
        }

        public void DisplayContacts()
        {
            
            
            foreach (var v in ls)
            {
                Console.WriteLine(v);
            }
        }


    }
}
