using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _38_Break
    {
        static void Main(string[] args)
        {
            //break
            //반복을 종료시켜주는 역할
            //보통은 반복을 끝까지 진행하는것이 일반적
            //더이상 반복할 이유가 없거나 에러 발생시 사용

            for (int i = 0; i < 10; i++)
            {
                if (i == 3) //3이라면
                    break; // 반복 종료
                Console.WriteLine("i의 값 : " + i);
            }
        }
    }
}
