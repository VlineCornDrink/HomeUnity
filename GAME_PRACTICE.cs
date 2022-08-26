using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnityPractice
{
    // 키보드를 이용해 졸라맨을 움직이면서 마우스로 랜덤하게 나온 먹이를 죽이는 프로그램
    // 단, 총은 마우스를 이용하며 해당 클릭한 부분으로 총이 발사하는 프로그램
    // 총 → 파이어 (무기변경 키는  'Q')

    // 졸라맨 생성 / 졸라맨 이동   //Class Character 
    // 기본 무기 : 총 // 무기 클래스 / 총 ＆ 파피어  // Class Weapon ,Gun, Fire
    // 키보드 키 : W A  S D (이동) , 무기변경(Q) 발사(마우스)  
    // 먹이 랜덤 생성 / 먹이 죽이면 점수↑ / 정해진 수의 먹이 다 먹으면 Game Over  // Class Food


    //일단 캐릭터 전에 사각형 좌표를 만들어서 움직여보기 -성공-
    // 



    class Character
    {
        ConsoleKeyInfo inputKey; //입력받을 키
        char key = 'a'; //내가 누를 키(w, s, a, d)를 문자열로 변환할 변수

        int[] X; //캐릭터 X좌표
        int[] Y; //캐릭터 Y좌표

        int XYnumber; //좌표 개수

        Character() // 캐릭터 좌표 할당(그려주기)
        {
            X = new int[] 
            {       
                        10,11,12,
                        10,11,12, 
                           11,
                6,7,8,     11,      14,15,16,
                    8,9,10,11,12,13,14,
                    8,     11,      14,
                           11,
                        10,   12,
                      9,         13,
            };

            Y = new int[]
            {
                          3,3,3,
                          4,4,4,
                          5,5,5,
                            6,
                  7,7,7,    7,    7,7,7, //17 16
                      8,8,8,8,8,8,8,
                      9,    9,    9,
                           10,
                        11,   11,
                      12,        12,

            };

            XYnumber = 32; // (주의) X배열과 Y배열의 개수는 같다.



            

            Console.CursorVisible = false; // 깜빡이는 커서 안보이게
        }


        //키를 입력받아 문자열로 변환하는 함수
        public void Input() 
        {
            if (Console.KeyAvailable)  //키 누름을 사용할 수 있으면
            {
                inputKey = Console.ReadKey(true); //키를 입력받아서
                key = inputKey.KeyChar; // 문자열(key)로 저장
            }
        }

        // 좌표를 받아 해당 좌표에 가서 #을 찍는 함수
        public void WritePoint(int x, int y) 
        {
            Console.SetCursorPosition(x, y); // x,y 로 가서 
            Console.WriteLine("@"); // '#'을 그린다.
        }


        // 움직이면서 #을 찍는 함수
        public void Logic() 
        {
            
            Console.Clear();
         
            switch (key) //키를 입력받아 좌표 변경
            {
                case 'W': //W를 누르면 위로 올라가기
                case 'w':
                    for (int i = 0; i < XYnumber; i++)
                    {
                        Y[i]--;
                    }

                    break;
                case 'S':  //S를 누르면 밑으로 내려가기
                case 's':
                    for (int i = 0; i < XYnumber; i++)
                    {
                        Y[i]++;
                    }
                    break;
                case 'A':  //A를 누르면 왼쪽으로 가기
                case 'a':
                    for (int i = 0; i < XYnumber; i++)
                    {
                        X[i]--;
                    }
                    break;
                case 'D': //D를 누르면 오른쪽으로 가기
                case 'd':
                    for (int i = 0; i < XYnumber; i++)
                    {
                        X[i]++;
                    }
                    break;
            }

          
            for (int i = 0; i < XYnumber; i++)  // 키보드를 통해 입력받거나 받지 않은 뒤 해당 좌표로 가서 좌표개수만큼 #찍기
            {
                WritePoint(X[i], Y[i]);
            }

            System.Threading.Thread.Sleep(100); //루프 돌기전 0.1초 대기
        }

        static void Main(string[] args)
        {
            Character character = new Character(); // Character 객체1 생성(character 변수가 가리키고 있음)
            // 객체 생성과 동시에 콘솔에 총 모양 생성

            while (true)//무한 루프
            {
                character.Input(); // 입력받고
                character.Logic(); // 입력받은 걸 경우에 따라 좌표 이동 및 해당좌표에 #찍기
            }
            Console.ReadKey();
        }
    }
}
