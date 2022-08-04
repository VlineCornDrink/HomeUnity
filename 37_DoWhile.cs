using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _37_DoWhile
    {
        static void Main(string[] args)
        {
            // do while 문
            //조건식이 True인 경우 계속 반복
            // 초기식이 반복문 바깥에 있음
            //조건식이 뒤에있어 종료를 코드가 끝나면 검사

            int i = 0; //초기식

            do
            {
                Console.WriteLine("Hello");
                i++;//증감식
            } while (i < 10); // 조건식
        }
    }
}
