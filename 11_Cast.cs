using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _11_Cast
    {
        static void Main(string[] args)
        {
            // 형 변환(Cast)
            // 자료형끼리 서로 변환시켜주는 역할

            int a = 100;
            string str = a.ToString();
            // a라는 변수의 자료형을 string으로 형변환

            //자동형변환
            float b = a;
            //이때 a는 int형이고 b는 float형이다.
            //컴파일러는 자동으로 a변수를 float형으로 형변화 하게됨.
            //자동형변환 보다는 강제형변환을 해주는 것이 좋다.

            //강제형변환
            float num = 12.34f;
            int test = (int)num;
            // 강제적으로 변수의 값을 형변화 시켜줌
            //자동형변환이 되더라도 강제형변환함으로써 명시하게 되면 가독성이 좋아지기 떄문에 형변화시 강제형변환을 사용해주는 것이 좋음

            Console.WriteLine(test);

            int x = 10;
            float y = (float)x;
            Console.WriteLine(y);
            // 소괄호 이용: 실수 ↔ 정수 
        }
    }
}
