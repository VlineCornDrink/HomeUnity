using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _41_Method2
    {
        static void Print()
        {
            Console.WriteLine("Hello");

        }
        //Method 정의: 기능을 만들었을 때
        //함수(메소드)를 정의했다.

        static void Main(string[] args)
        {
            Print(); //함수 호출
                     //호출 : 사용했을 떄 

            //실습
            //World를 출력하는 함수 제작
            World();
        }
        static void World()
        {
            Console.WriteLine("World");
        }
    }
}
