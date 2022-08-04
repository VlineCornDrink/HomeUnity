using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _05_Uint
    {
        static void Main(string[] args)
        {
            //양의 정수형
            //음수가 아닌 양수만 넣을 수 있는 자료형
            // 넣을 수 있는 범위가 일반변수에 비해 양수로 더 많은 범위를 가진다.
            short A = short.MaxValue;
            Console.WriteLine("short 최대: " + A);

            ushort B = ushort.MaxValue;
            Console.WriteLine("ushort 최대: " + B);
            //정수형 자료형 앞에 u가 부틍면 양의 정수형이 된다.

            ushort C = ushort.MinValue;
            Console.WriteLine("ushort 최소: " + C);
            Console.WriteLine("");

            uint D = uint.MaxValue;
            Console.WriteLine("uint 최대: " + D);

            uint E = uint.MinValue;
            Console.WriteLine("uint 최소: " + E);
            //uint: int형의 양의 정수 자료형
        }
    }
}
