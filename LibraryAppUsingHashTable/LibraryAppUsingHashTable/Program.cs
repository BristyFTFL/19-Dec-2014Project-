using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppUsingHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable aHashtable = new Hashtable(); 
            Book aBook1 = new Book();
            aBook1.isbnNumber = "111";
            aBook1.title = "ASP.NET";

            Book aBook2 = new Book();
            aBook2.isbnNumber = "222";
            aBook2.title = "Java";

            Book aBook3 = new Book();
            aBook3.isbnNumber = "333";
            aBook3.title = "PHP";

            aHashtable.Add(aBook1.isbnNumber, aBook1.title);
            aHashtable.Add(aBook2.isbnNumber, aBook2.title);
            aHashtable.Add(aBook3.isbnNumber, aBook3.title);

            Console.WriteLine(aHashtable[aBook1.isbnNumber]);
            Console.WriteLine(aHashtable[aBook2.isbnNumber]);
            Console.WriteLine(aHashtable[aBook3.isbnNumber]);
            Console.ReadKey();


        }
    }
}
