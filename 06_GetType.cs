using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _06_GetType
    {
        static void Main(string[] args)
        {
            //자료형 검사
            // 이미 만들어지 변수의 자료형을 검사해야 하는 경우
            // 가장 쉬운 방법은 변수에 마우스를 대보면 알 수 있다.

            int num = 5;
            Console.WriteLine(num);
            // GetType
            // 자료형의 타입을 반환
            // 변수뿐만이 아니라 숫자 문자열에도 적용 가능

            Console.WriteLine(num.GetType());
            // int32 32bit = 4byte
            Console.WriteLine(("언리얼").GetType());

            //실습
            // float 형 변수 값의 자료형 타입 출력해보기

            Console.WriteLine("");
            float n = 0.2f;
            Console.WriteLine("변수 n의 자료형:  " + n.GetType());
            Console.WriteLine("숫자 0.2f의 자료형:  " + (0.2f).GetType());
            Console.WriteLine("숫자 0.2d의 자료형:  " + (0.2).GetType());





        }
    }
}
