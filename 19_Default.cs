using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _19_Default
    {
        static void Main(string[] args)
        {
            //자료형의 기본값
            //컴파일러가 자료형을 유추하여 기본값을 할당하는 default 리터럴
            // reference Type : null
            // 숫자유형(int float 등) : 0
            // bool : false
            //char : '/0'
            //enum : 0
            //struct : value 형식의 변수는 각각 기본값이 들어가고 reference는 null이 들어간다.

            int a = default(int);
            // int a = default; 위 코드와 동일함.
            //default 연산자로 int형의 기본값을 a변수에 넣어줌
            Console.WriteLine(a);

            float b = default(float);
            Console.WriteLine(b);

            char c = default;
            Console.WriteLine(c);
            //공백문자? 출력되서 안보임

            bool d = default;
            Console.WriteLine(d);

            string e = default;
            Console.WriteLine(e); //null값으로 출력되지 않는 것임.








        }
    }
}
