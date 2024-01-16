using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("upisi neku recenicu:");
            string s1 = Console.ReadLine();
            string[]rijeci = s1.Split(' ');
            string prvarijec = rijeci[0];
            string zadnjarijec = rijeci[rijeci.Length - 1];
            
            Console.WriteLine("prva rijec" + prvarijec);
            Console.WriteLine("druga rijec" + zadnjarijec);
            Console.ReadKey();
        }
    }
}
