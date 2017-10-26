using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayBits
{
    public class ShowBits
    {
        int numBits;

        public ShowBits(int n)
        {
            numBits = n;
        }

        public void Show(long value)
        {
            long mask = 1;

            // left-shift a 1 into the proper position
            mask <<= numBits - 1;

            int spacer = 0;

            for(; mask != 0; mask >>=1)
            {
                if((value & mask) != 0)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
                spacer++;
                if((spacer%8)==0)
                {
                    Console.Write(" ");
                    spacer = 0;
                }
            }
            Console.WriteLine();
        }
    }
}
