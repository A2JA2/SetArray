using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_set_example
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and initialise each set
            HashSet<string> admin = new HashSet<string>() { "John", "Ahmed", "JoJo" };
            HashSet<string> finance = new HashSet<string>() { "JoJo", "Claire", "Niamh", "Phil" };

            //display the admin set
            Console.WriteLine("\nAdmin set contains {0} member(s): ", admin.Count);
            foreach (string member in admin)
            {
                Console.WriteLine("{0}", member);
            }

            //display the finance set
            Console.WriteLine("\nFinance set contains {0} member(s): ", finance.Count);
            foreach (string member in admin)
            {
                Console.WriteLine("{0}", member);
            }

            //create a new empty HashSet for everyone
            HashSet<string> everyone = new HashSet<string>(admin);

            //perform a union operation
            everyone.UnionWith(finance);

            // display the union
            Console.WriteLine("\nBoth sets contain {0} member(s): ", everyone.Count);
            foreach (string member in everyone)
            {
                Console.WriteLine("{0}", member);
            }

            //create a new enpty HashSet for just aeabers belong to both groups
            HashSet<string> both = new HashSet<string>(admin);

            //perform a intersect operation
            both.IntersectWith(finance);

            //display the intersect
            Console.WriteLine("\nMembers that occur in both sets: {0}", both.Count);
            foreach (string member in both)
            {
                Console.WriteLine("{0}", member);
            }

            Console.ReadKey();



        }
    }
}
