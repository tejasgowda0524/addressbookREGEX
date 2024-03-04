using prac;
using System.Text.RegularExpressions;


namespace prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {
               
                a a = new a();
                Console.WriteLine("choose your option \n 1.add data\n 2.display data");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:

                        string namePattern = "[A-Z][a-z]";
                        string LnamePatter = "[A-Z]";
                        string cityPattermn = "[A-Z]{1}[a-z]";
                        string zipPattermn = "[0-9]{3}[-]{1}[0-9]{3}";
                        string pnpattern = "[8,7,6,9]{1}[0-9]{9}";
                        string mailpattern = "[a-z]{2,9}[0-9]{1,9}[@]{1}[a-z]{1,9}[.]{1}[a-z]{2,3}";

                        Console.Write("Enter First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Enter Last Name: ");
                        string lastName = Console.ReadLine();

                        string a1 = null;
                        string a2 = null;
                        Console.Write("Enter Address: ");
                        string address = Console.ReadLine();

                        Console.Write("Enter City: ");
                        string city = Console.ReadLine();
                        Console.Write("Enter Zip: ");
                        string zip = Console.ReadLine();
                        Console.Write("Enter Phone Number: ");
                        string phoneNumber = Console.ReadLine();

                        Console.Write("Enter Email: ");
                        string email = Console.ReadLine();

                        bool isName = Regex.IsMatch(firstName, namePattern);
                        bool isLname = Regex.IsMatch(lastName, LnamePatter);

                        bool isCity = Regex.IsMatch(city, cityPattermn);
                        bool iszip = Regex.IsMatch(zip, zipPattermn);
                        bool ispn = Regex.IsMatch(phoneNumber, pnpattern);
                        bool ismail = Regex.IsMatch(email, mailpattern);

                        //Console.WriteLine(isName);
                        //Console.WriteLine(isLname);
                        //Console.WriteLine(isCity);
                        //Console.WriteLine(iszip);
                        //Console.WriteLine(ispn);
                        //Console.WriteLine(ismail);
                        string b1 = null;
                        string b2 = null;
                        string b3 = null;
                        string b4 = null;

                        try
                        {
                            if (isName==true && isLname==true && isCity==true && iszip==true && ispn==true && ismail==true)
                            {
                                a1=firstName;
                                a2=lastName;
                                b1=city;
                                b2=zip;
                                b3 = phoneNumber;
                                b4 = email;

                            }
                            else
                            {
                                Console.WriteLine("enter valid format (Ex: city = Mumbai , ZIP = 567-549 ,phonenumber = 9812346579, email =bangalore01@gmail.com )");
                                Environment.Exit(0);
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("exception occured " + e.Message);
                        }

                        book bb = new book(a1, a2, address, b1, b2, b3, b4);


                        a.AddContact(bb);
                       

                        break;
                    case 2:

                        a.DisplayContacts();
                        break;

                }
            }


        }
    }
}
