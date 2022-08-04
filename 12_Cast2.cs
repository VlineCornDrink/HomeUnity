using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _12_Cast2
    {
        static void Main(string[] args)
        {
            // string → 정수  or 실수 형변환
            string input = "123";

            //string → int 형변환1 
            int num1 = int.Parse(input);
            Console.WriteLine(num1 + " " + (num1 + 1));

            //string → int 형변환2
            int num2 = Convert.ToInt32(input);
            Console.WriteLine(num2 + " " + (num2 + 1));

            //string → float 형변환1
            float num3 = float.Parse(input);
            Console.WriteLine(num3 + " " + (num3 + 1.5));

            //string → float 형변환2
            float num4 = Convert.ToSingle(input);
            Console.WriteLine(num4 + " " + (num4 + 1.5));

            //Parse와 Convert의 차이
            // string에 null이 입력될 경우 Parse는 에러처리, Convert는 0을 반환

            string str = null;
            int test = Convert.ToInt32(str);
            Console.WriteLine(test);  // 0반환

            //int test2 = int.Parse(str);
            //Console.WriteLine(test); // 에러 발생



            int number = 10;
            string abc = Convert.ToSingle(number);
            Console.WriteLine(abc);
            Console.WriteLine(abc.GetType());





            // 정수 실수 문자형
            //정수 ↔ 실수, 정수 ↔ 정수, 실수 ↔ 실수: 1. 소괄호 이용, 자동형변환(암시적형변환), Convert함수 이용
            // 숫자형 → 문자형: 1. Convert.ToString(변수) 2 ToString 메소드 3. String.Format()메소드 4. + 연산자이용
            // 문자형 → 숫자형: 1. (바꿀려하는 자료형).Parse(변수) 2. Convert 이용
        }
    }
}