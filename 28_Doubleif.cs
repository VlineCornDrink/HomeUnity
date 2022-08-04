using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _28_Doubleif
    {
        static void Main(string[] args)
        {
            //2중 if문
            int a = 10;
            int b = 20;

            if (a == 10)
            {
                if (b == 20)
                {
                    // if문 안에 if문이 들어가면 첫번쨰 if안에 들어와서
                    // 두번쨰 if조건까지 만족해야함
                    // &&(AND)연산자와 조건이 같음
                    Console.WriteLine("a : 10 , b : 20 ");
                }
            }

            if (a == 10 && b == 20)
            {
                Console.WriteLine("a : 10 , b : 20 ");
            }
            //위와 동일한 코드

            // 문제
            // 숫자를 입력받아서 2중 if문을 활용해서 값이 음수인지 양수인지 판별
            // 값이 홀수인지 짝수인지 출력
            //음수/홀수 , 음수/짝수, 양수/홀수, 양수/짝수

            Console.Write("입력해봐 : ");
            int input = int.Parse(Console.ReadLine());

            if (input >= 0)
            {
                if (input % 2 == 0)
                {
                    Console.WriteLine("양수/나머지: 짝수");
                }
                else
                {
                    Console.WriteLine("양수/나머지: 홀수");
                }
            }
            else
            {
                if (input % 2 == 0)
                {
                    Console.WriteLine("음수/나머지: 짝수");
                }
                else
                {
                    Console.WriteLine("음수/나머지: 홀수");
                }
            }
        }
    }
}
