//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace UnityPractice
//{
//    class _151_Snake
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("아무거나 누르면 게임 시작");
//            Console.ReadKey(); //키를 입력 받을 떄까지 멈춤

//            char ch = '*'; //문자
//            bool gameLive = true; //게임 진행 여부
//            ConsoleKeyInfo input; //누른 키의 정보를 저장할 변수

//            // 위치정보, 디스플레이
//            int x = 0, y = 2; //y축 2는 맨 위 공백
//            int dx = 1, dy = 0; // 이동할 방향
//            int WidthLimit = 79; //최대 너비
//            int HeightLimit = 24; // 최대 길이

//            Console.Clear(); //콘솔 화면 전부 지워줌
//            const int delay = 50; // 프로젝트 지연 시간

//            while (true)
//            {
//                for (int i = 0; i < HeightLimit; i++)
//                {
//                    Console.SetCursorPosition()
//                }

//            }

//            bool trail = true; //뱀의 꼬리를 보여줄지 여부
            

//            while (gameLive)
//            {
//                ConsoleColor cc = Console.ForegroundColor;
//                // Console.ForegroundColor : 콘솔의 전경색(기본회색)
//                // 콘솔에 출력되는 색상

//                Console.ForegroundColor = ConsoleColor.White;
//                // 콘솔에 출력되는 색상을 흰색을 넣어줌
//                Console.SetCursorPosition(0, 0);
//                Console.WriteLine("이동 : 방향키 / 꼬리 : T / 지우기 : C / 종료 : ESC");
//                Console.SetCursorPosition(x, y);//뱀의초기 시작 위치
//                Console.ForegroundColor = cc; //다시 원래 색상으로 변경

//                if (Console.KeyAvailable) //키를 누르고 있는지 여부
//                {
//                    input = Console.ReadKey(true);
//                    // 입력된 키를 input 변수에 넣어줌

//                    switch (input.Key)
//                    {
//                        case ConsoleKey.T:
//                            trail = !trail;
//                            break;
//                        case ConsoleKey.C:
//                            Console.Clear();
//                            break;
//                        case ConsoleKey.UpArrow:
//                            dx = 0;
//                            dy = -1; //이동방향을 바꿈
//                            Console.ForegroundColor = ConsoleColor.Red; //출력을 빨간색으로
//                            break;
//                        case ConsoleKey.DownArrow:
//                            dx = 0;
//                            dy = 1;
//                            Console.ForegroundColor = ConsoleColor.Cyan;
//                            break;
//                        case ConsoleKey.LeftArrow:
//                            dx = -1;
//                            dy = 0;
//                            Console.ForegroundColor = ConsoleColor.Green;
//                            break;
//                        case ConsoleKey.RightArrow:
//                            dx = 1;
//                            dy = 0;
//                            Console.ForegroundColor = ConsoleColor.Blue;
//                            break;
//                        case ConsoleKey.Escape: // ESC키
//                            gameLive = false; //무한반복 종료
//                            break;
//                    }
//                }

//                Console.SetCursorPosition(x, y); //현재 위치로 커서 이동
//                if (trail == false)
//                {
//                    Console.Write(" "); //지워줌
//                }

//                x += dx;//x축 좌표 이동
//                if (x > WidthLimit) //만약 최대 너비를 벗어났다면
//                {
//                    x = 0;
//                }
//                if (x < 0) // 만약 처음 위치보다 작다면
//                {
//                    x = WidthLimit; // 마지막 위치로 이동
//                }
//                y += dy; //y축 좌표 이동
//                if (y > HeightLimit)
//                {
//                    y = 2;
//                }
//                if (y < 2)
//                {
//                    y = HeightLimit;
//                }

//                Console.SetCursorPosition(x, y);//이동된 좌표
//                Console.Write(ch); //별 출력
//                System.Threading.Thread.Sleep(delay);

//            }


//        }
//    }
//}
