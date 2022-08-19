//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace UnityPractice
//{
//    class _143_UpDownGame
//    {
//        static void Main(string[] args)
//        {
//            Random ran = new Random();
//            int computer = ran.Next(1, 100); //1~99까지의 난수
//            int life = 5; //남은 생명

//            while (true) //무한 반복
//            {
//                if (life == 0)
//                {
//                    Console.WriteLine("게임 끝");
//                    Console.WriteLine("재시작 : Y / 종료 : N");
//                    string playAgain = Console.ReadLine().ToLower();
//                    //문자를 입력받는다.
//                    //ToLower : 소문자로 변환
//                    if (playAgain == "y")
//                    {
//                        life = 5;
//                        computer = ran.Next(1, 100);
//                        continue;
//                    }
//                    else
//                    {
//                        break; //무한반복 종료
//                    }
//                }
//                Console.WriteLine("숫자 입력 : ");
//                int user = int.Parse(Console.ReadLine());
//                if (computer == user)
//                {
//                    Console.WriteLine("정답!");
//                    break;
//                }
//                else
//                {
//                    if (computer > user)
//                    {
//                        Console.WriteLine("Up");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Down");
//                    }
//                    life--;
//                    Console.WriteLine("생명 : "+life);
//                }
//            }
//        }


//    }
//}
