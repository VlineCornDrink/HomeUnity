using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _34_for100
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 0; i <= 100; i++)
            {
                total += i;
                //반복할 때마다 total에 i 값을 더해주겠다
                // i의 값이 누적

            }
            Console.WriteLine("Total : " + total);

        }
    }
}
