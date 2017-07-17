using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            Array.Sort(ch);
            foreach (char elem in ch)
                Console.Write("{0} ", elem);

            Console.ReadKey();


        }
    }
}
