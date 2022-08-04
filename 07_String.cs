using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _07_String
    {
        static void Main(string[] args)
        {
            // 문자열(string)
            // 문자열(string)자료형 데이터는 큰따옴표("")로 묶음
            // 단일문자(char)자료형 데이터는 작은따옴표('')로 묶음

            // string
            // 문자열을 담는 역할
            // string은 클래스이다.
            // 문자열을 사용할 때 유용하고 다양한 속성과 메서드들을 지원

            // 단일 문자 변수
            char c1 = 'A';
            // 작은 따옴표에는 문자 1개만 들어갈 수 있다.

            // 문자열 변수
            string str1 = "Unity";
            string str2 = "입니다.";
            //큰 따옴표에는 문자가 여러개 들어갈 수 있다.(문자열)

            //문자열 결합
            string str3 = str1 + str2;
            //+연산자를 사용하면 문자열 결합 가능
            Console.WriteLine(str3);
            // 문자열 길이(Length)
            Console.WriteLine(str3.Length);
            // 문자열 공백 추가
            str3 = str1 + " " + str2;
            Console.WriteLine(str3);
            //문자열과 정수형
            int num = 5;
            string str5 = num.ToString();
            //.ToString() : 변수를 string형으로 변환
            Console.WriteLine(str5);
            //문자열과 실수형
            float num2 = 12.34f;
            string str6 = num2.ToString();
            Console.WriteLine(str6);
            // 실습
            int gold = 100;
            // 골드변수를 스트링으로 변환후 출력
            string result = gold.ToString();
            Console.WriteLine(result);
            string str8 = " 골드 : " + gold;

            int asdf = 100;
            string result2 = " d" + asdf;
            Console.WriteLine(result2);
            // 문자열과 결합시 tostring을 안써줘도 된다.(써줘도 되고 안써도 되고)
            Console.WriteLine(str8);



        }
    }
}
