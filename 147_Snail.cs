//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace UnityPractice
//{
//    class _147_Snail
//    {
//        static void Main(string[] args)
//        {
//            int x = 1; //x축 좌표로 사용할 변수

//            while (x < 50) // x가 50보다 작을때까지 반복
//            {
//                Console.Clear(); // 화면 전체를 지움
//                Console.SetCursorPosition(x, 5); // 커서를 (x,5)좌표로 이동

//                if (x % 3 == 0) // x 좌표가 3의 배수라면
//                {
//                    Console.Write("__@");

//                }
//                else if (x % 3 == 1) // x 좌표가 3의 배수+1이라면
//                {
//                    Console.Write("_^@");
//                }
//                else
//                {
//                    Console.Write("^_@");
//                }

//                Thread.Sleep(500); //0.1초 정지
//                x++; //x좌표 1증가
//            }
//        }
//    }
//}
