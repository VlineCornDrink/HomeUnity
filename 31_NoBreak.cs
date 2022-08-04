using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _31_NoBreak
    {
        static void Main(string[] args)
        {
            Console.Write("1~12 숫자 입력 : ");
            int input = int.Parse(Console.ReadLine());

            // switch문에 break를 쓰지 않은 경우

            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    //case 사이에 break를 입력하지 않았다면 
                    // ||(OR) 의 역할을 하게 된다.
                    Console.WriteLine("겨울");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을");
                    break;
            }

            //실습
            //switch case 문을 이용하여
            // "유니티" "언리얼" 둘중 하나가 입력되면
            // "게임엔진"출력
            // " 김치" "미역국" 둘중 하나가 입력되면
            // "요리"출력

            Console.Write("입력 : ");
            string x = Console.ReadLine();

            switch (x)
            {
                case "유니티":
                case "언리얼":
                    Console.WriteLine("게임 엔진");
                    break;
                case "김치":
                case "미역국":
                    Console.WriteLine("요리");
                    break;

            }
        }
    }
}
