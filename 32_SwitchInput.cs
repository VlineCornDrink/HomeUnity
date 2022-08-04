using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _32_SwitchInput
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo input = Console.ReadKey();
            //ConsoleKeyInfo(자료형) : 입력한 키의 정보를 저장하는 역할
            //Console.ReadKey() : 입력한 키의 정보를 반환

            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼쪽");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("오른쪽");
                    break;
            }
        }
    }
}
