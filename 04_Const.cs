using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _04_Const
    {

        static void Main(string[] args)
        {
            // 
            int num = 10;
            Console.WriteLine(num);
            num = -44;
            Console.WriteLine(num);

            //변수는 언제든지 변경할 수 있다.
            // 상수(Const)
            const int con = 10;
            //변수의 값을 변경하지 못하게 해준다.
            // 자료형 앞에 const 키워드를 붙이면 상수가 된다.
            // 상수: 변하지 않는 값
            // con = 30;

            const float gravity = 9.81f;
            const float PI = 3.14f;

            // int float string bool 자료형 1개씩 const 키워드 사용하기

            const int ID = 3;
            const float hello = 0.1f;
            const string book = "Hello";
            const bool Really = true;

            Console.WriteLine("\n");
            Console.WriteLine("int: " + ID);
            Console.WriteLine("float " + hello);
            Console.WriteLine("string: " + book);
            Console.WriteLine("bool: " + Really);



        }
    }
}
