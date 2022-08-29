using System;
using System.Diagnostics;

namespace UnityPractice
{
    // 키보드를 이용해 탱크를 움직이게하고 돌려가면서('E') 총을 통해 랜덤하게 나온 먹이를 죽이는 프로그램
    // 단, 총은 스페이스 누르면 탱크 앞부분에서 총이 발사하는 프로그램
    // 총 → 파이어 (무기변경 키는  'Q')

    // 탱크 생성 / 탱크 이동   //Class Character -완-
    // 키보드 키 : W A  S D (이동) , 무기변경(Q) 발사(마우스)  
    // 먹이 랜덤 생성 / 먹이 죽이면 점수↑ / 정해진 수의 먹이 다 먹으면 Game Over  // Class Food

    // 1. 탱크 생성 및 움직이기 -완-
    // 2. 총알 생성 및 움직이기(spacebar) 한쪽 방향으로 -완-
    // 3. 여러방향 총알 발사
    // 4. 탱크 회전 및 발사
    // 5. 먹이 생성 및 죽이기
    // 6. score
    // 7. 코드 정리
    // 8. 탱크 모양 그리기
    // 9. 꾸미기


    class Game
    {

        ConsoleKeyInfo inputKey; //입력받을 키

        int[] tankPos; //탱크 좌표

        int[] bulletPos; // 총알 좌표
        int[][] tempbulletPos; // 모든 총알 좌표 집합
        int bulletNum = 0; // 현재 총알 개수
        int bulletmagazine = 50; //총알 탄창
        bool isBullet = false; // 총알 있는지 없는지

        bool isFinish= false; // 게임 끝났는지 여부
        int score = 0;



        // 게임창 좌표 : (1,1)~ (40,1)
        //                 |      |
        //               (1,20)~(40,20)
        const int STARTX = 1; // 게임 구역 시작지점 X좌표
        const int STARTY = 1; // 게임 구역 시작지접 Y좌표
        const int WIDE = 40;  // 게임 구역 종료지점 X좌표
        const int HEIGHT = 20; // 게임 구역 종료지접 Y좌표

        enum Vector {UP, RIGHT,DOWN, LEFT,X}
        Vector vector = Vector.UP;
        public Game()
        {
            tankPos = new int[] { 5, 5 }; // 탱크 초기 위치
            bulletPos = new int[] { 5, 5 }; // 탱크 총알 초기 위치
            tempbulletPos = new int[bulletmagazine][];
            tempbulletPos[0] = new int[2] { 0, 0 };

            Console.CursorVisible = false; // 깜빡이는 커서 안보이게
        }


        // 콘솔 게임 화면 설정하는 함수
        public void ConsoleSetting()
        {
            Console.Title = "Tank Shooting";
            Console.SetWindowSize(WIDE, HEIGHT);
            Console.BackgroundColor = ConsoleColor.Black;
        }


        /*---------------------------------------------------------------------------------*/  // 키 입력 관련 함수
        //키를 입력받는 함수
        public void Input()
        {
            if (Console.KeyAvailable)  //키 누름을 사용할 수 있으면
            {
                inputKey = Console.ReadKey(true); //키를 입력아서 받은 키를 inputKey에 할당
            }
        }

        public void ReturnVector()
        {
            if (vector == Vector.X)
            {
                vector = Vector.UP;
            }
        }
        /*---------------------------------------------------------------------------------*/   // 총알 관련 함수

        // spacebar를 누른 시점에서의 총알 발사위치 받아서 총알 좌표집합 변수에 추가하는 함수
        public void SumBulletPos(int[] _bulletPos)
        {
            bulletNum++; // 쏜 총알의 개수 1증가
            if (bulletNum > bulletmagazine-1) // 총알이 탄창에 들어갈 수 있는 총알 개수보다 많아지면
            {
                bulletNum = 0; //자동 장전(총알 초기화)
            }
            tempbulletPos[bulletNum] = new int[] { _bulletPos[0], _bulletPos[1] }; //총알 좌표 추가
            // tempbulletPos[총알 개수][0] : (총알개수)번쨰의 총알의 X좌표
            // tempbulletPos[총알 개수][1] : (총알개수)번쨰의 총알의 Y좌표
            // (EX) 총알 3번쨰에 쏜 총알의 X 좌표 : tempbulletPos[3][0] 
       


        }
        // 총알 발사 위치 탱크 앞부분으로 초기화하는 함수
        public void ResetBulletPos()
        {
            
            bulletPos[0] = tankPos[0] - 1; // bulletPos X좌표 >= STARTX  / tankPos X좌표 >= STARTX
            bulletPos[1] = tankPos[1] - 1; //  bulletPos Y좌표 >= STARTY  / tankPos Y좌표 >= STARTY
        }


        // 총알을 그리기 위해 좌표를 받아 해당 좌표에 가서 ▲을 찍는 함수
        public void WriteBullet(int x, int y)
        {
            Console.SetCursorPosition(x, y); // x,y 로 가서 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("▲"); // '▲'을 그린다.

        }

        // 총알 그리는 함수
        public void DrawBullet(bool _isBullet)
        {
            if (_isBullet) // 총알이 쏴졌으면(한번이라도 사용자가 spacebar를 눌렀으면)
            {
                for (int i = 1; i <= bulletNum; i++) //모든 총알에 대해서
                {
                    if (tempbulletPos[i][0] >= STARTX-1 && tempbulletPos[i][0] <= WIDE-1) // 총알 좌표 게임창 범위에 있는지 검사
                    {
                        if (tempbulletPos[i][1] >= STARTX-1 && tempbulletPos[i][1] <= HEIGHT-1) // 범위에 있으면
                        {
                            WriteBullet(tempbulletPos[i][0], tempbulletPos[i][1]); //총알 그려주기
                            tempbulletPos[i][1]--; //총알 움직이는 코드
                        }
                        else // 총알 좌표 X는 게임창 범위에 있지만 Y가 해당되지 않는 경우 
                        {
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine(" "); // 0,0으로 간뒤에 총알 지워주기
                        }
                    }
                    else // 총알 좌표 X가 게임창 범위에 있지 않는 경우
                    {
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine(" ");  // 0,0으로 간뒤에 총알 지워주기
                    }
                }

            }
        }

        /*---------------------------------------------------------------------------------*/     //탱크 관련 함수

        // 탱크를 그리기 위해 좌표를 받아 해당 좌표에 가서 ■을 찍는 함수
        public void WriteTank(int x, int y)
        {
            Console.SetCursorPosition(x, y); // x,y 로 가서
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*"); // '*'을 그린다.
        }

        //탱크의 위치를 받아 탱크(사각형) 모양 그리는 함수
        public void DrawTank(int[] _tankPos)
        {
            WriteTank(_tankPos[0], _tankPos[1]);
            WriteTank(_tankPos[0], _tankPos[1] + 1);
            //WriteTank(_tankPos[0] + 1, _tankPos[1]);
            WriteTank(_tankPos[0] + 1, _tankPos[1] + 1);
        }

        // 탱크 좌표 게임창 범위에 있는지 검사 후 끝에 있는 값으로 초기화
        public void InspectTankPos(int[] _tankpos)
        {
            if (_tankpos[0] < STARTX) // 탱크의 X좌표 시작지점보다 작은경우
            {
                _tankpos[0] = STARTX;
            }
            else if (_tankpos[0] >= STARTX && _tankpos[0] <= WIDE) // 탱크의 X좌표는 게임창에 들어있지만 Y좌표는 그렇지 않는 경우
            {
                if (_tankpos[1] < STARTY)
                {
                    _tankpos[1] = STARTY;
                }
                else if (_tankpos[1] > HEIGHT) // 탱크의 X좌표 종료지점보다 큰 경우
                {
                    _tankpos[1] = HEIGHT;
                }
            }
            else
            {
                _tankpos[0] = WIDE;
            }

        }
        /*---------------------------------------------------------------------------------*/  // 게임 돌아가는 로직

        // 키에 따른 기능 함수
        // (W,S,A,D) 탱크 움직임
        // (spacebar) 총알 공격
        public void Logic()
        {
            Console.Clear();  // 콘솔 화면 초기화
            InspectTankPos(tankPos);
            DrawTank(tankPos); // 탱크 그리기

            ResetBulletPos(); // 총알 위치 탱크 위치에 따른 초기화
            DrawBullet(isBullet); // 총알 그리기
 
            switch (inputKey.Key) //키에 따른 작용
            {
                case ConsoleKey.W: //W를 누르면 위로 올라가기
                    tankPos[1]--;
                    break;
                case ConsoleKey.S:  //S를 누르면 밑으로 내려가기
                    tankPos[1]++;
                    break;
                case ConsoleKey.A:  //A를 누르면 왼쪽으로 가기
                    tankPos[0]--;
                    break;
                case ConsoleKey.D: //D를 누르면 오른쪽으로 가기
                    tankPos[0]++;
                    break;
                case ConsoleKey.Spacebar: //Spacerbar를 누르면 총알 공격
                    isBullet = true; //총알이 하나라도 발사되었다는 의미
                    SumBulletPos(bulletPos); //발사된 총알 좌표 추가
                    break;
                case ConsoleKey.Tab: //UP → RIGHT → DOWN → LEFT → X
                    vector++;
                    ReturnVector(); //X라면은 UP으로 바꾸기(LEFT → Up)
                    break;

            }

            System.Threading.Thread.Sleep(200); //루프 돌기전 0.05초 대기
        }




        static void Main(string[] args)
        {
            Game game = new Game(); // Character 객체 생성
            Stopwatch stopwatch = new Stopwatch(); // 게임 제한 시간

            game.ConsoleSetting();
            stopwatch.Start();
            while (true)//무한 루프
            {

                game.Input(); // 입력받고
                game.Logic(); // 입력받은 걸 경우에 따라 좌표 이동 및 해당좌표에 #찍기
                game.score++;
                if (game.score == 100)
                {
                    stopwatch.Stop();
                    Console.Clear();
                    Console.SetCursorPosition(0, HEIGHT / 2);
                    Console.CursorSize = 100;
                    Console.WriteLine("게임 끝");
                    Console.WriteLine("Score : "+game.score);
                    break;
                }
            }
            Console.ReadKey();

        }
    }
}
