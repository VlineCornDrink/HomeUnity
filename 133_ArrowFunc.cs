using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeUnity
{
    class ArrowFunc
    {
        static void Main(string[] args)
        {
            // 화살표 함수(람다식)
            // 코드의 간결함을 유지 가능

            Print();
            Console.WriteLine(Add(10,20));
        }
        //일반적인 방식
        static void Hello() { Console.WriteLine("Hello"); }

        //화살표 함수
        static void Print() => Console.WriteLine("Print!");

        static int Add(int a, int b) => a + b;
        static float Multy(float x, float y) => x * y;


    }
}
