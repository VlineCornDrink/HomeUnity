using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityPractice
{
    class rock_scissors_paper
    {

        static void Main(string[] args)
        {
            // 실습
            // 가위바위보 게임 만들어보기
            // int comHand에는 1~3까지의 난수가 들어감
            // int userHand에는 1~3의 숫자를 입력받음
            // comHand와 userHand를 뺸다
            // 그 값이 같다면 "비김"출력
            // 1또는 -2가 나오면 "이김"출력
            // 아니라면 "짐"을 출력
            // 가위 :1/ 바위: 2/ 보 :3

            Random random = new Random();
            int comHand = random.Next(1, 4); //1부터 3까지의 난수가 컴퓨터에 들어감
            Console.Write("1부터 3까지의 수를 입력하시오(1 : 가위 / 2 : 바위 / 3 : 보) : ");
            int userHand = int.Parse(Console.ReadLine()); //사용자로부터 숫자 입력 받음

            int result = comHand - userHand;
            if (result == 0)
            {
                Console.WriteLine("비김!");  
                switch (userHand)
                {
                    case 1:
                        Console.WriteLine("컴퓨터 : 가위 / 사용자 : 가위"); break;     
                    case 2:
                        Console.WriteLine("컴퓨터 : 바위 / 사용자 : 바위"); break;     
                    case 3:
                        Console.WriteLine("컴퓨터 : 보 / 사용자 : 보"); break;
                }
            }
            else if (result == 1 && result == -2)
            {
                Console.WriteLine("이김!");
                switch (userHand)
                {
                    case 1:
                        Console.WriteLine("컴퓨터 : 보 / 사용자 : 가위"); break;
                    case 2:
                        Console.WriteLine("컴퓨터 : 가위 / 사용자 : 바위"); break;
                    case 3:
                        Console.WriteLine("컴퓨터 : 바위 / 사용자 : 보"); break;
                }
            }
            else
            {
                Console.WriteLine("짐!");
                switch (userHand)
                {
                    case 1:
                        Console.WriteLine("컴퓨터 : 바위 / 사용자 : 가위"); break;
                    case 2:
                        Console.WriteLine("컴퓨터 : 보 / 사용자 : 바위"); break;
                    case 3:
                        Console.WriteLine("컴퓨터 : 가위 / 사용자 : 보"); break;
                }
            }




        }
    }
}
