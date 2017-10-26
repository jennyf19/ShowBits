using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayBits
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowBits b = new ShowBits(8);
            ShowBits c = new ShowBits(32);
            ShowBits d = new ShowBits(32);

            Console.WriteLine("123 in binary: ");
            b.Show(123);

            Console.WriteLine("\n87987 in binary: ");
            c.Show(87987);

            Console.WriteLine("\n237658768 in binary: ");
            d.Show(237658768);

            Console.ReadLine();
        }
    }
}
