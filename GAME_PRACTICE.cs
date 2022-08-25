using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnityPractice
{
    // 키보드를 이용해 총을 움직이면서  랜덤하게 나온 먹이를 죽이는 프로그램
    // 단, 총을 뒤집을 수도 있다. 위, 오른쪽, 아래, 왼쪽으로 어디든지

    // 총 생성 / 총 움직임 / 키보드 이용
    // 먹이 생성 로직 / 총 발사하는 로직 / 움직이는 로직 / 총알과 부딪히면 먹이 사라지는 로직 / 뒤집을 수 있는 로직  


    //일단 캐릭터 전에 사각형 좌표를 만들어서 움직여보기 -성공-
    // 



    class Character
    {
        ConsoleKeyInfo inputKey; //입력받을 키
        char key = 'a'; //내가 누를 키(w, s, a, d)를 문자열로 변환할 변수

        int[] X = new int[50]; //캐릭터 X좌표
        int[] Y = new int[50]; //캐릭터 Y좌표

        Random random = new Random();
        int fruitX, fruitY; //먹이의 X,Y좌표

        Character() // 첫 생성 캐릭터 좌표 할당
        {
            
            X[0] = 5; Y[0] = 5;  X[0] = 6; Y[0] = 5;      X[0] = 7; Y[0] = 5;        X[1] = 8; Y[1] = 5;  X[1] = 9; Y[1] = 5;   X[1] = 10; Y[1] = 5; // Y = 5
            // Y = 6
            X[0] = 5; Y[0] = 7;     X[0] = 6; Y[0] = 7;         X[1] = 7; Y[1] = 7; // Y = 7
            X[1] = 7; Y[1] = 9;         X[1] = 8; Y[1] = 9;                         // Y = 8
            
        









            fruitX = random.Next(0, 50);
            fruitY = random.Next(0, 50);

            Console.CursorVisible = false; // 깜빡이는 커서 안보이게
        }


        public void Input() //키를 입력받아 문자열로 변환하는 함수
        {
            if (Console.KeyAvailable)  //키 누름을 사용할 수 있으면
            {
                inputKey = Console.ReadKey(true); //키를 입력받아서
                key = inputKey.KeyChar; // 문자열(key)로 저장
            }
        }

        public void WritePoint(int x, int y) // 좌표를 받아 해당 좌표에 가서 #을 찍는 함수
        {
            Console.SetCursorPosition(x, y); // x,y 로 가서 
            Console.WriteLine("#"); // '#'을 그린다.
        }


        public void Logic() // 움직이면서 #을 찍는 함수
        {

            // 좌표변경을 통해 이전 #은 없어져야한다.

            switch (key) // 키를 입력받으면
            {
                case 'W': //W를 누르면 위로 올라가기
                case 'w':
                    for (int i = 0; i < 4; i++)
                    {
                        Y[i]--;
                    }

                    break;
                case 'S':  //S를 누르면 밑으로 내려가기
                case 's':
                    for (int i = 0; i < 4; i++)
                    {
                        Y[i]++;
                    }
                    break;
                case 'A':  //A를 누르면 왼쪽으로 가기
                case 'a':
                    for (int i = 0; i < 4; i++)
                    {
                        X[i]--;
                    }
                    break;
                case 'D': //D를 누르면 오른쪽으로 가기
                case 'd':
                    for (int i = 0; i < 4; i++)
                    {
                        X[i]++;
                    }
                    break;
            }

            // 그리는 논리
            for (int i = 0; i < 4; i++)
            {
                WritePoint(X[i], Y[i]);
            }

            System.Threading.Thread.Sleep(100); //루프 돌기전 0.1초 대기
        }

        static void Main(string[] args)
        {
            Character character = new Character();
            while (true)
            {
                Console.Clear();
                character.Input();
                character.Logic();
            }
            Console.ReadKey();
        }
    }
}

