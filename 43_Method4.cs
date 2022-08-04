using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _43_Method4
    {
        static int Power(int x)
        {
            return x * x;
        }
        static int Multiply(int x, int y)
        {
            //이때 x y 는 매개변수
            return x * y;
        }

        static int Multiply2(int x, int y, int z)
        {
            return x * y * z;

        }
        static void Main(string[] args)
        {
            int num1 = Power(7);
            Console.WriteLine(num1);

            int num2 = Multiply(12, 15);
            //호출할 때 사용하는 값 = 인자
            Console.WriteLine(num2);

            //실습 
            //매개변수 3개를 받아서 전부 곱하는 함수 제작
            // 10,20,30을 곱한 값을 출력
            int num3 = Multiply2(10, 20, 30);
            Console.WriteLine(num3);

        }
    }
}
