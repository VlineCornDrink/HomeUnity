using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _46_Overloading
    {
        static void Main(string[] args)
        {
            //오버로딩(오버로드)
            // 같은 함수이름을 여러개를 정의하는 방법
            // 함수의 매개변수의 갯수 혹은 자료형이 다르면 다른함수 취급`    

            Print();
            Print(5); 
            Print(2.34f);
            Print(3,2);
            //4개는 다른함수


            Console.WriteLine();
            Console.WriteLine();
            //실습
            // 오버로딩을 이용해서
            // float 형 값 2개를 곱하고 출력하는함수
            // float 형 값 3개를 곱하고 출력하는 함수
            //float형 값 4개를 곱하고 출력하는 함수

            Multiply(2, 3);
            Multiply(3, 3, 3);
            Multiply(2, 3, 4, 5);


        }
        static void Print()
        {
            Console.WriteLine("Print");
        }
        static void Print(int num)
        {
            Console.WriteLine(num);
        }
        static void Print(float num)
        {
            Console.WriteLine(num);
        }
        static void Print(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        static void Multiply(int x, int y) // 매개변수 2개의 곱
        {
            Console.WriteLine(x*y); 
        }
        static void Multiply(int x, int y, int z) // 매개변수 3개의 곱
        {
            Console.WriteLine(x * y*z);
        }
        static void Multiply(int x, int y,int z , int h) // 매개변수 3개의 곱
        {
            Console.WriteLine(x * y*z*h);
        }
    }
}
