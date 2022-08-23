using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityPractice
{
    class Snake
    {
        int Height = 20;
        int Width = 30;

        int[] X = new int[50]; //뱀의 x축 길이
        int[] Y = new int[50]; // 뱀의 y축 길이

        int fruitX, fruitY; //먹이 좌표

        int parts = 3; //뱀의 길이

        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 's';
        Random rnd = new Random();

        Snake()
        {
            X[0] = 5;
            Y[0] = 5;
            Console.CursorVisible = false;
            //깜빡이는 커서를 보이지 않게 해줌
            fruitX = rnd.Next(2, (Width - 2));
            fruitY = rnd.Next(2, (Height - 2));
            // 먹이의 좌표에 랜덤한 값을 넣어줌
        }

        public void WrieBoard() //게임판 그리는 함수
        {
            Console.Clear();
            for (int i = 1; i <=(Width+2); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("-");
            }
            for (int i = 1; i <= (Width+2); i++)
            {
                Console.SetCursorPosition(i, Height + 2);
                Console.Write("-");
            }
            for (int i = 1; i <= (Height+1); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("I");
            }
            for (int i = 1; i <= (Height+1); i++)
            {
                Console.SetCursorPosition(Width+2, i);
                Console.Write("I");
            }

        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                // 입력한 키
                key = keyInfo.KeyChar;
                // 입력한 문자열

            }
        }
        public void WritePoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("#");
        }

        public void Logic()
        {
            if (X[0] == fruitX && Y[0] == fruitY)
            {// 뱀의머리와 과일의 좌표가 같다면
                parts++; //길이를 늘려줌
                fruitX = rnd.Next(2, Width - 2);
                fruitY = rnd.Next(2, Height - 2);
                //과일의 좌표를 바꿔줌
            }
            for (int i = parts; i>1 ; i--)
            {
                X[i - 1] = X[i - 2];
                Y[i - 1] = Y[i - 2];
                // 좌표 변경
            }
            switch (key) // 키입력에 대한 처리
            {
                case 'W':
                case 'w':
                    Y[0]--;
                    break;    
                case 'S':
                case 's':
                    Y[0]++;
                    break;      
                case 'D':
                case 'd':
                    X[0]++;
                    break;      
                case 'A':
                case 'a':
                    X[0]--;
                    break;
            }

            for (int i = 0; i <= (parts -1) ; i++)
            {
                WritePoint(X[i], Y[i]);
                WritePoint(fruitX, fruitY);
            }

            System.Threading.Thread.Sleep(100); //0.1초 대기

            
        }

        static void Main(string[] args)
        {
            Snake snake = new Snake();

            while (true)
            {
                snake.WrieBoard(); //벽을 그려줌
                snake.Input(); //입력처리
                snake.Logic(); //게임에 대한 로직

            }
            Console.ReadKey(); //프로그램 멈춤
        }

    }
}
