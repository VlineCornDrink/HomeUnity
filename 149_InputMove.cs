//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace UnityPractice
//{
//    class _149_InputMove
//    {
//        static void Main(string[] args)
//        {
//            int x = 10, y = 10; //초기 위치 및 좌표
//            Console.SetCursorPosition(x, y);

//            while (true) //무한 반복
//            {
//                ConsoleKeyInfo input = Console.ReadKey();
//                // 키 입력을 받아서 input 변수에 입력한 키의 정보를 저장
//                // 키를 입력받기 위해 프로그램을 잠시 멈추게 됨
//                switch (input.Key) // 키의 정보에 따라 case를 실행
//                {
//                    case ConsoleKey.UpArrow: // 키가 위방향키면
//                        Console.Clear(); // 화면 전체 지움
//                        Console.SetCursorPosition(x, --y); // 좌표 이동
//                        Console.WriteLine("@"); // 출력
//                        break;
//                    case ConsoleKey.DownArrow:
//                        Console.Clear();
//                        Console.SetCursorPosition(x, ++y);
//                        Console.WriteLine("@");
//                        break;   
//                    case ConsoleKey.LeftArrow:
//                        Console.Clear();
//                        Console.SetCursorPosition(--x, y);
//                        Console.WriteLine("@");
//                        break; 
//                    case ConsoleKey.RightArrow:
//                        Console.Clear();
//                        Console.SetCursorPosition(++x, y);
//                        Console.WriteLine("@");
//                        break;
                        
//                }
               

//            }
//        }
//    }
//}
