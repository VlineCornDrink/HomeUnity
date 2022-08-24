using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnityPractice
{
    // 한 캐릭터가 키보드를 이용해 움직이는 프로그램
    // 처음 루프가 돌면 네모가 그려져야하고
    // 키를 입력받으면
    // 사각형의 모든 좌표가 이동해야한다.


    class Character
    {

        int[,] XY; //내가 그릴 캐릭터의 좌표들

        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo(); //입력받을 키
        char key = 's'; //내가 누를 키(w, s, a, d)를 문자열로 변환할 변수
        Character()
        {
            // 도형 그림 좌표(사각형)
             XY= new int[8,2]
            {
                {5,5},{5,6},{5,7}, //x = 0 , 1, 2
                {6,5 },{6,7}, // x = 3 ,4
                {7,5 },{7,6},{7,7} //x = 5,6,7
            };
            Console.CursorVisible = false; // 깜빡이는 커서 안보이게
        }



 

        public void Input() //키를 입력받아 문자열로 변환하는 함수
        {
            if (Console.KeyAvailable)  //키 누름을 사용할 수 있으면
            {
                keyInfo = Console.ReadKey(true); //키를 입력받아서
                key = keyInfo.KeyChar; // 문자열(key)로 저장
            }
        }

        public void WritePoint(int x, int y) // 좌표를 입력받아 캐릭터 그리는 함수
        {
            Console.SetCursorPosition(x, y); // x,y 로 가서 
            Console.WriteLine("#"); // '#'을 그린다.
        }


        public void Logic()
        {

            // 이전 좌표 지우는 과정 필요 → 변수의 특성 이용 (좌표 변경)
            for (int i = XY.GetLength(0); i>1; i--)
            {
                XY[i - 1, 0] = XY[i - 2, 0];
                XY[i - 1, 1] = XY[i - 2, 1];
            }
            
            
            switch (key) // 키를 입력받으면
            {
                case 'W': //W를 누르면 위로 올라가기
                case 'w':
                    for (int i = 0; i < XY.GetLength(0); i++)
                    {
                        XY[i, 1]--;
                    }
                    break;
                case 'S':  //S를 누르면 밑으로 내려가기
                case 's':
                    for (int i = 0; i < XY.GetLength(0); i++)
                    {
                        XY[i, 1]++;
                    }
                    break;
                case 'A':  //A를 누르면 왼쪽으로 가기
                case 'a':
                    for (int i = 0; i < XY.GetLength(0); i++)
                    {
                        XY[i, 0]--;
                    }
                    break;
                case 'D': //D를 누르면 오른쪽으로 가기
                case 'd':
                    for (int i = 0; i < XY.GetLength(0); i++)
                    {
                        XY[i, 0]++;
                    }
                    break;
            }

            for (int i = 0; i < XY.GetLength(0); i++)
            {
                WritePoint(XY[i, 0], XY[i, 1]); // 네모 좌표로 가서 그려라
            }

            System.Threading.Thread.Sleep(100); //루프 돌기전 0.1초 대기
        }

        static void Main(string[] args)
        {
            Character character = new Character();

          
                character.Input();
                character.Logic();
            
            Console.ReadKey();
        }
    }
}

