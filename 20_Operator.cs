using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _20_Operator
    {
        static void Main(string[] args)
        {
            // operator : 연산자
            int a, b, result;
            Console.WriteLine("두개의 정수 입력: ");
            string input1 = Console.ReadLine();
            a = int.Parse(input1);
            // a = int.Parse(Console.ReadLine()); 이걸로도 코딩 가능

            string input2 = Console.ReadLine();
            b = int.Parse(input2);

            result = a + b;
            Console.WriteLine("더하기: " + result);

            result = a - b;
            Console.WriteLine("빼기: " + result);

            result = a * b;
            Console.WriteLine("곱하기: " + result);

            result = a / b;
            Console.WriteLine("나누기: " + result);

            result = a % b;
            Console.WriteLine("나머지: " + result);

            //할당연산자
            int x = 10;
            x += 5; // x = x + 5;
            Console.WriteLine("x += 5 : " + x); //15

            x -= 5;//x = x - 5;
            Console.WriteLine("x -= 5 : " + x); //10

            x *= 5;//x = x * 5;
            Console.WriteLine("x *= 5 : " + x); //50

            x /= 5;//x = x / 5; 
            Console.WriteLine("x /= 5 : " + x); //10

            //실습 
            //float 형 변수에 임의의 값을 넣고
            //할당 연산자를 사용하여 1.5더해주기
            //할당 연산자를 사용하여 7.5빼주기
            //할당 연산자를 사용하여 12.34곱하기
            //각각의 값을 출력

            float m = 0.2f;

            m += 1.5f;
            Console.WriteLine("m += : " + m);

            m -= 7.5f;
            Console.WriteLine("m -= : " + m);

            m *= 12.34f;
            Console.WriteLine("m *= : " + m);








        }
    }
}
