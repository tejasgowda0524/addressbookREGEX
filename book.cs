using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac
{
    public class book 
    {
        public string name {  get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string phonenumber { get; set; }
        public string email { get; set; }



        public book(string name,string lastname,string address,string city,string zip,string phonenumber,string email)
        {
            this.name = name;   
            this.lastname = lastname;
            this.address = address;
            this.city = city; 
            this.zip = zip;
            this.phonenumber = phonenumber;
            this.email = email;
                
        }


        public void display()
        {
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"lastname :{lastname}");
            Console.WriteLine($"address :{address}");
            Console.WriteLine($"city: {city}");
            Console.WriteLine($"zip :{zip}");
            Console.WriteLine($"phonenumber :{phonenumber}");
            Console.WriteLine($"email: {email}");
        }


    }

}
