using System;


namespace UnityPractice
{
    // 키보드를 이용해 탱크를 움직이게하고 돌려가면서 총을 통해 랜덤하게 나온 먹이를 죽이는 프로그램
    // 단, 총은 스페이스 누르면 탱크 앞부분에서 총이 발사하는 프로그램
    // 총 → 파이어 (무기변경 키는  'Q')

    // 탱크 생성 / 탱크 이동   //Class Character -완-
    // 키보드 키 : W A  S D (이동) , 무기변경(Q) 발사(마우스)  
    // 먹이 랜덤 생성 / 먹이 죽이면 점수↑ / 정해진 수의 먹이 다 먹으면 Game Over  // Class Food





    class Character
    {

        ConsoleKeyInfo inputKey; //입력받을 키

        int[,] X; //캐릭터 X좌표  // 탱크의 모양을(돌리는거) 4개로 하기 위해서 2차원 배열 이용
        int[,] Y; //캐릭터 Y좌표

        int[,] bulletX; // 총알 X좌표 // 마찬가지로 총알 모양 2개로 하기 위해서 2차원 배열 이용
        int[,] bulletY; // 총알 Y좌표

        enum DIR// 총알 방향 열거형
        {
            UP,
            DOWN,
            LEFT,
            RIGHT
        }

        int XYnumber; //캐릭터 모양 좌표 개수
        int bulletNumber; //총알 모양 좌표 개수
        DIR dir; //총알 방향 변수 dir

        // 탱크모양 및 총알 모양(좌표)
        public Character()
        {
            // 탱크 모양
            X = new int[,]
            {
                {
                    5,6,7,
                    5,6,7,
                  4,5,6,7,8,
                  4,5,6,7,8
                },
                {
                    4,5,6,7,8,
                    4,5,6,7,8,
                      5,6,7,
                      5,6,7,
                },
                {
                    4,5,
                    4,5,6,7,
                    4,5,6,7,
                    4,5,6,7,
                    4,5,
                },
                    {
                        4,5,
                    2,3,4,5,
                    2,3,4,5,
                    2,3,4,5,
                        4,5,
                },

            };

            Y = new int[,]
            {
                {
                   3,3,3,
                    4,4,4,
                  5,5,5,5,5,
                  6,6,6,6,6
                  }
            {
                   3,3,3,3,3,
                   4,4,4,4,4,
                     5,5,5,
                  6,6,6,6,6
            },
            {
                3,3,3,
                    4,4,4,
                  5,5,5,5,5,
                  6,6,6,6,6
            }
            }

            // 총알 모양
            bulletX = new int[]
            {
                    6,
                    6,
            };
            bulletY = new int[]
            {
                    2,
                    3
            };


            XYnumber = 16;
            bulletNumber = 2;
            // ↑ (주의) X배열과 Y배열의 개수는 같다.

            Console.CursorVisible = false; // 깜빡이는 커서 안보이게
        }


        //키를 입력받는 함수 (유효성 검사+)
        public void Input()
        {
            if (Console.KeyAvailable)  //키 누름을 사용할 수 있으면
            {
                inputKey = Console.ReadKey(true); //키를 입력받아서
            }
        }

        // 좌표를 받아 해당 좌표에 가서 ■을 찍는 함수
        public void WritePoint(int x, int y)
        {
            Console.SetCursorPosition(x, y); // x,y 로 가서 
            Console.WriteLine("■"); // '#'을 그린다.
        }

        // 총알 발사하는 함수
        private void Bullet(int X, int Y)
        {
            Console.SetCursorPosition(X, Y); //탱크의 앞부분으로 가서
            switch (dir)
            {
                case DIR.UP: // 탱크 방향 : 위
                    for (int i = 0; i < bulletNumber; i++)
                    {
                        bulletY[i]--;
                    }
                    break;
                case DIR.DOWN: // 탱크 방향 : 아래
                    for (int i = 0; i < bulletNumber; i++)
                    {
                        bulletY[i]++;
                    }
                    break;
                case DIR.LEFT: // 탱크 방향 : 왼쪽
                    for (int i = 0; i < bulletNumber; i++)
                    {
                        bulletX[i]--;
                    }
                    break;
                case DIR.RIGHT: // 탱크 방향 : 오른쪽
                    for (int i = 0; i < bulletNumber; i++)
                    {
                        bulletX[i]++;
                    }
                    break;



                    for (int i = 0; i < bulletNumber; i++)  // 키보드를 통해 입력받거나 받지 않은 뒤 해당 좌표로 가서 좌표개수만큼 #찍기
                    {
                        WritePoint(bulletX[i],bulletY[i]);
                    }
            }



        }



        // 움직이면서 #을 찍는 함수
        public void Logic()
        {

            Console.Clear(); // 이전 반복에서 그려진 콘솔을 지우기

            switch (inputKey.Key) //키를 입력받아 좌표 변경
            {
                case ConsoleKey.W: //W를 누르면 위로 올라가기
                    for (int i = 0; i < XYnumber; i++)
                    {
                        Y[i]--;
                        dir = DIR.UP;
                    }

                    break;
                case ConsoleKey.S:  //S를 누르면 밑으로 내려가기
                    for (int i = 0; i < XYnumber; i++)
                    {
                        Y[i]++;
                        dir = DIR.DOWN;
                    }
                    break;
                case ConsoleKey.A:  //A를 누르면 왼쪽으로 가기
                    for (int i = 0; i < XYnumber; i++)
                    {
                        X[i]--;
                        dir = DIR.LEFT;
                    }
                    break;
                case ConsoleKey.D: //D를 누르면 오른쪽으로 가기
                    for (int i = 0; i < XYnumber; i++)
                    {
                        X[i]++;
                        dir = DIR.RIGHT;
                    }
                    break;
                case ConsoleKey.Spacebar: //Spacebar를 누르면 총 발사
                    Bullet(X[1],Y[1]);
                    break;

            }

            for (int i = 0; i < XYnumber; i++)  // 키보드를 통해 입력받거나 받지 않은 뒤 해당 좌표로 가서 좌표개수만큼 #찍기
            {
                WritePoint(X[i], Y[i]);
            }

            System.Threading.Thread.Sleep(200); //루프 돌기전 0.1초 대기
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
