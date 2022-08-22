using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace UnityPractice
{
    class _150_SnailGame
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const string LINE = "-------------------------------------------";
            // 선
            const int END_LINE = 42; //도착지점
            const int DELAY = 200; //0.2초

            int snailA = 0; //1번 달팽이
            int snailB = 0; //2번 달팽이
            int snailC = 0; //3번 달팽이
            int snailD = 0; //4번 달팽이

            int snailE = 0;
            int snailF = 0;

            while (true)
            {
                ++snailA; // 1번 달팽이 이동
                ++snailB; // 2번 달팽이 이동
                ++snailC; // 3번 달팽이 이동
                ++snailD; // 4번 달팽이 이동

                ++snailE;
                ++snailF;

                int ran = random.Next(0, 6); // 0부터 5까지의 난수

                switch (ran)
                {
                    case 0:
                        ++snailA;
                        break;
                    case 1:
                        ++snailB;
                        break;
                    case 2:
                        ++snailC;
                        break;
                    case 3:
                        ++snailD;
                        break;

                    case 4:
                        ++snailE;
                        break;
                    case 5:
                        ++snailF;
                        break;

                     //랜덤하게 1번씩 더 이동
                }
                Thread.Sleep(DELAY); //0.2초 대기
                Console.Clear(); // 화면 전체 지움

                Console.WriteLine(LINE); //선을 그려줌
                for (int i = 0; i < snailA; i++)
                {
                    Console.Write(" ");
                    // 처음부터 snailA위치 직전까지 전부 지워줌
                }
                Console.Write("1"); // 1번 달팽이 그려줌

                for (int i = (END_LINE - 2) - snailA; i >= 0; i--)
                {
                    Console.Write(" ");// 달팽이 앞으로 도착지점까지 지워줌
                }
                Console.WriteLine("l"); // 도착 지점을 그려줌
                //------------------------------------------------

                for (int i = 0; i < snailB; i++)
                {
                    Console.Write(" ");
                    // 처음부터 snailB위치 직전까지 전부 지워줌
                }
                Console.Write("2"); // 2번 달팽이 그려줌

                for (int i =(END_LINE-2)- snailB; i >= 0; i--)
                {
                    Console.Write(" ");// 달팽이 앞으로 도착지점까지 지워줌
                }
                Console.WriteLine("l"); // 도착 지점을 그려줌
                //------------------------------------------------

                for (int i = 0; i < snailC; i++)
                {
                    Console.Write(" ");
                    // 처음부터 snailC위치 직전까지 전부 지워줌
                }
                Console.Write("3"); // 3번 달팽이 그려줌

                for (int i =(END_LINE-2)- snailC; i >= 0; i--)
                {
                    Console.Write(" ");// 달팽이 앞으로 도착지점까지 지워줌
                }
                Console.WriteLine("l"); // 도착 지점을 그려줌
                //------------------------------------------------

                for (int i = 0; i < snailD; i++)
                {
                    Console.Write(" ");
                    // 처음부터 snailD위치 직전까지 전부 지워줌
                }
                Console.Write("4"); // 4번 달팽이 그려줌

                for (int i = (END_LINE - 2) - snailD; i >= 0; i--)
                {
                    Console.Write(" ");// 달팽이 앞으로 도착지점까지 지워줌
                }
                Console.WriteLine("l"); // 도착 지점을 그려줌
                //------------------------------------------------

                for (int i = 0; i < snailE; i++)
                {
                    Console.Write(" ");
                    // 처음부터 snailE위치 직전까지 전부 지워줌
                }
                Console.Write("5"); // 5번 달팽이 그려줌

                for (int i = (END_LINE - 2) - snailE; i >= 0; i--)
                {
                    Console.Write(" ");// 달팽이 앞으로 도착지점까지 지워줌
                }
                Console.WriteLine("l"); // 도착 지점을 그려줌
                //------------------------------------------------
                for (int i = 0; i < snailF; i++)
                {
                    Console.Write(" ");
                    // 처음부터 snailF위치 직전까지 전부 지워줌
                }
                Console.Write("6"); // 6번 달팽이 그려줌

                for (int i = (END_LINE - 2) - snailF; i >= 0; i--)
                {
                    Console.Write(" ");// 달팽이 앞으로 도착지점까지 지워줌
                }
                Console.WriteLine("l"); // 도착 지점을 그려줌

                Console.WriteLine(LINE);


                if (snailA >= END_LINE || snailB >= END_LINE || snailC >= END_LINE || snailD >= END_LINE) //도착지점
                {
                    int winner = 0;
                    if (snailA >= END_LINE)
                    {
                        winner = 1;
                    }
                    else if(snailB >= END_LINE)
                    {
                        winner = 2;
                    }    
                    else if(snailC >= END_LINE)
                    {
                        winner = 3;
                    }
                    else if (snailD >= END_LINE)
                    {
                        winner = 4;
                    }      
                    else if (snailE >= END_LINE)
                    {
                        winner = 5;
                    }  
                    else if (snailF >= END_LINE)
                    {
                        winner = 6;
                    }
                    Console.WriteLine("게임 종료! 우승자는 : "+winner);
                    Console.WriteLine("다시 하려면 0입력");
                    if (int.Parse(Console.ReadLine()) == 0)
                    {
                        snailA = 0;
                        snailB = 0;
                        snailC = 0;
                        snailD = 0;

                        snailE = 0;
                        snailF = 0;
                    }
                    else
                    {
                        break;
                    }

                    //실습
                    // 달팽이 2개 더 늘려보기

                }


            }
        }
    }
}
