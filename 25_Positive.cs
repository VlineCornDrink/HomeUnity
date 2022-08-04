using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _25_Positive
    {
        static void Main(string[] args)
        {
            //실습3
            //숫자 2개를 입력받아 뺀값이 양수가 나오도록
            Console.WriteLine("실습 3 숫자 2개를 입력하시오 : ");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int output1 = int.Parse(input1);
            int output2 = int.Parse(input2);

            int result = output1 - output2; // 밑에 있는 방식보다 훨씬 더 가독성이 좋은것 같다. 변수선언함
            if (result >= 0)
            {
                Console.WriteLine("큰수에서 작은수 뺀값은 : " + result);
            }
            else
            {
                result *= -1;
                Console.WriteLine("큰수에서 작은수 뺀값은 : " + result);
            }
            //방식2(내가 처음에 작성한 방식)
            //if (output1 >= output2)
            //{
            //    Console.WriteLine("큰수에서 작은수 뺀값은 : " + (output1 - output2));
            //}

            //else
            //{
            //    Console.WriteLine("큰수에서 작은수 뺀값은 : " + (output2 - output1));
            //}

            // 좋은 코드의 기준이 있을까?
        }
    }
}
