using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{

    class _42_Method3
    {
        static void Test()  //void
        {
            Console.WriteLine("Test");
            //void : 반환자료형이 없다는 뜻

        }
        static int ReturnFive()  // int
        {
            //반환자료형이 int형인 ReturnFive 함수 정의
            //반환자료형이 int형이면 int형 값을 반환해야함
            return 5;
            // return 의 역할
            // 1. 함수를 종료
            // 2. 반환값을 호출한 곳으로 내보냄
        }
        static float ReturnTen() // float
        {
            return 10.0f;
        }

        static string Unity() // string
        {
            return "유니티";
        }
        static bool Practice() // bool
        {
            return true;
        }


        static void Main(string[] args)
        {
            Test(); //void
            int num = ReturnFive(); // int
            Console.WriteLine(num);

            float num2 = ReturnTen(); //float
            Console.WriteLine("{0:f1}", num2);
            Console.WriteLine(ReturnTen());

            //실습
            // 반환 자료형이 string이고
            // "유니티" 문자열을 반환하는 함수 제작
            // 함수를 이용하여 "유니티"출력
            string Un = Unity(); // string
            Console.WriteLine(Un);

            bool Pr = Practice(); // bool
            Console.WriteLine(Pr);
            Console.WriteLine(Practice());
        }

    }
}
