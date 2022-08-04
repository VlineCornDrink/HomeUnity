using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _45_Method6
    {
        static void Hello(int cnt)
        {
            if (cnt == 0)
            {
                return; //함수 종료
            }
            Console.WriteLine("Hello");
            Hello(--cnt);
            //재귀함수
            // 재귀함수를 사용하는 경우
            // 종료조건 혹은 텀을 주어야함

        }
        static void Unity(int num)
        {
            if (num == 0)
            {
                return;
            }
            Console.WriteLine("Unity");
            Unity(--num);
        }
        static void Print() // 함수들어가면 다시 나온다(F11통해 확인)
        {
            Console.WriteLine("print");
        }
        static void Main(string[] args)
        {
            //재귀함수(재귀메서드)
            // 함수 안에서 자신인 함수를 호출하는 함수

            Hello(5);

            //재귀함수를 이용하여
            //원하는 숫자만큼
            //Unity를 출력시켜주는 함수 제작
            Unity(5);
            Print();
        }
    }
}
