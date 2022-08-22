//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace UnityPractice
//{
//    class _148_Move
//    {
//        static void Main(string[] args)
//        {
//            // 실습
//            // "@"가 오른쪽으로 이동하도록 문자애니메이션 구현
//            // "#"이 x축좌표는 50부터 시작해서 왼쪽으로 이동
//            // "*"은 대각선으로 이동 구현
//            // 이동은 동시에 해도 무관, 순차적으로 해도 무관

//            int x = 1;

//            while (x < 10)
//            {
//                Console.Clear();
//                Console.SetCursorPosition(x, 3);
//                Console.Write("@");
//                Console.SetCursorPosition(10 - x, 3);
//                Console.Write("#");
//                Console.SetCursorPosition(x, 10-x);
//                Console.Write("*");
//                Thread.Sleep(1000);
//                x++;
                
//            }

//            // 순차적 방법
//            //int x = 1, y = 1;
//            //for (int i = 0; i < 10; i++)
//            //{
//            //    Console.Clear();
//            //    Console.SetCursorPosition(x, y);
//            //    Console.Write("@");
//            //    x++;
//            //    Thread.Sleep(300);         
//            //}
//            //x = 50;
//            //y = 3;
//            //for (int i = 0; i < 10; i++)
//            //{
//            //    Console.Clear();
//            //    Console.SetCursorPosition(x, y);
//            //    Console.Write("#");
//            //    x--;
//            //    Thread.Sleep(300);         
//            //}  
//            //x = 3;
//            //y = 3;
//            //for (int i = 0; i < 10; i++)
//            //{
//            //    Console.Clear();
//            //    Console.SetCursorPosition(x, y);
//            //    Console.Write("*");
//            //    x++;
//            //    y++;
//            //    Thread.Sleep(300);         
//            //}
          



//        }
//    }
//}
