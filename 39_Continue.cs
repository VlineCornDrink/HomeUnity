using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _39_Continue
    {
        static void Main(string[] args)
        {
            //continue
            //반복을 한차례 건너 뜀
            for (int i = 0; i < 10; i++)
            {
                if (i == 2 || i == 5)
                    continue; // 반복을 건너뜀
                Console.WriteLine("i : " + i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i != 2 || i != 5)
                {
                    Console.WriteLine("i : " + i);
                }
            }
        }
    }
}
