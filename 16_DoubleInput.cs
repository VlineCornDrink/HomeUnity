using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _16_DoubleInput
    {
        static void Main(string[] args)
        {
            /*string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            Console.WriteLine(input1 + " ," + input2);*/

            //실습 및 과제
            //숫자 2개를 입력받아서 두 수를 곱한 값 출력(int float)

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);
            Console.WriteLine("입력 받은 값 두 수를 곱 한 값은 = " + num1 * num2);


            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();

            float num3 = float.Parse(input3);
            float num4 = float.Parse(input4);
            Console.WriteLine("입력 받은 값 두 수를 곱 한 값은 = " + num3 * num4);



        }
    }
}
