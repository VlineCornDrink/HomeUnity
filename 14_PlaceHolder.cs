using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _14_PlaceHolder
    {
        static void Main(string[] args)
        {
            // 자리표시자
            // 출력 서식을 지정하는 역할
            // {n} 형태로 {0}, {1}, {2} 순서로 자리를 만듬
            // 각 번호에 맞는 값을 차례로 넘겨받아서 출력

            Console.WriteLine("{0}", 10);

            int num = 25;
            Console.WriteLine("num의 값은 {0} 입니다.", num);

            Console.WriteLine("{0} / {1} / {2}", 1, 2, 3);

        }
    }
}