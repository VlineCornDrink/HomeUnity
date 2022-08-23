//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace UnityPractice
//{
//    class _152_SlotMachine
//    {
//        static int money = 100; //초기 머니
//        static int score = 0; //점수
//        static char a, b, c; //슬롯에 나올 모양
//        static Random random = new Random();
//        static char CreateCharacter()
//        {
//            System.Threading.Thread.Sleep(50);
//            int ran = random.Next(0, 6); // 0부터 5까지의 난수 발생
//            char shape; //모양
//            switch (ran)
//            {
//                case 0:
//                    shape = 'A';
//                    break;
//                case 1:
//                    shape = '#';
//                    break;
//                case 2:
//                    shape = 'V';
//                    break;
//                case 3:
//                    shape = '%';
//                    break;
//                default:
//                    shape = '%';
//                    break;
//            }
//            return shape;
//        }

//        static void PrintResult()
//        {
//            Console.SetCursorPosition(10, 4);
//            Console.WriteLine("STOP");
//            if (a == b && b == c) //a,b,c가 같다면
//            {
//                score = 30;
//                Console.SetCursorPosition(10, 10);
//                Console.WriteLine("Win! + 30");

//            }
//            else
//            {
//                score = -5;
//                Console.SetCursorPosition(10, 10);
//                Console.WriteLine("Lose! - 5");

//            }

//            money = money + score; //돈을 최신화
//            System.Threading.Thread.Sleep(1000);// 1초 대기
//            Console.SetCursorPosition(10, 4);
//            Console.WriteLine("            "); // 6칸 띄어줌
//            Console.SetCursorPosition(10, 10);
//            Console.WriteLine("             "); //8칸 띄어서 지워줌


//        }


//        static void Play()
//        {
//            while (money > 0)
//            {
//                if (Console.KeyAvailable) //키입력 여부
//                {
//                    PrintResult();
//                    Console.ReadKey(true);
//                }
//                else
//                {
//                    while (Console.KeyAvailable == false)
//                    {
//                        Console.SetCursorPosition(10, 6);
//                        Console.WriteLine("--------- Now Money : "+money + "     ");
//                        a = CreateCharacter();
//                        b = CreateCharacter();
//                        c = CreateCharacter();
//                        Console.SetCursorPosition(10, 8);
//                        Console.WriteLine("---------");          
//                        Console.SetCursorPosition(10, 7);
//                        Console.Write("- ");
//                        Console.Write("{0} {1} {2}",a,b,c);
//                        Console.Write("-");
//                    }
//                }
//            }
//        }
//        static void Main(string[] args)
//        {
//            Play();


//        }
//    }
//}
