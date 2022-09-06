using System;


// 일정시간동안 키보드를 이용해 탱크를 움직이게하고 회전해가면서('TAB') 총을 통해 랜덤하게 나온 먹이를 죽이는 프로그램
// 단, 총은 스페이스 누르면 탱크 앞부분에서 총이 발사하는 프로그램

// 1. 탱크 생성 및 움직이기 -완-
// 2. 총알 생성 및 움직이기(spacebar) 한쪽 방향으로 -완-
// 3. 여러방향 총알 발사 -완-
// 4. 탱크 회전 및 발사 -완-
// 5. 먹이 생성 및 죽이기 -완-
// 6. score -완-
// 7. 코드 정리  -완- 
// 8. 탱크 모양 그리기  -완-
// 9. 꾸미기  -완-

// 문제점 : 다음 키 입력받기 전까지 입력받은 키 계속 적용
// (EX) 제자리에서 TAB을 누르면 다음키 입력받기전까지 계속 회전
// (EX) SPACEBAR 공격 이벤트를 누르면 다음키 입력받기 전까지 계속 총알 발사
// 해결방법 : 입력받는 키를 배열로 전환하고 배열을 초기화해주는 함수를 만들어줌
// 해결완료 : 총알 1발만 발사하거나 TAB키 한번만 회전이 가능해짐

// 문제점2 : 먹이가 문자로 되어있어 잘 안먹어짐
// 해결방법 : 먹이의 범위를 크게 만들어 맞히는 범위를 늘려줌

// 문제점3 : 게임을 한번더 했을떄 새로운 게임이 시작되어야하는데
// 그렇지않고 반복을 계속하게끔 짜서 이전이벤트가 새로운게임에 영향을 미침

// 문제점4 : 코드 정리 ( 접근제한자라든지 아니면 여러 클래스로 구분할 수 있는지확인)


class Game
{

    ConsoleKeyInfo[] SuminputKey; // 입력받은 키 집합
    int keyNum = 0; // 입력받은 키 개수

    int[] tankPos; //탱크 좌표

    int[] bulletPos; // 총알 발사되는 위치 좌표
    int[][] SumbulletPos; // 모든 총알 좌표 집합
    int bulletNum = 0; // 발사된 총알 개수
    int bulletmagazine = 50; //총알 탄창
    bool isBullet = false; // 총알 발사 여부

    int score = 0; // 게임 점수

    Random random = new Random();
    int[] food = new int[2]; //먹이 변수
    bool isEat = false; // 탱크에 먹혔는지 여부

    int timer = 0; // 게임 제한시간

    // 게임창 좌표 : (1,1)~ (40,1)
    //                 |      |
    //               (1,20)~(40,20)
    const int STARTX = 1; // 게임 구역 시작지점 X좌표
    const int STARTY = 1; // 게임 구역 시작지접 Y좌표
    const int WIDE = 40;  // 게임 구역 종료지점 X좌표
    const int HEIGHT = 20; // 게임 구역 종료지접 Y좌표

    enum Vector { UP, RIGHT, DOWN, LEFT, X }
    Vector vector; // 탱크 방향
    Vector[] SumVector; // (총알이 발사될 때의) 탱크 방향 집합

    




    public Game()
    {
        tankPos = new int[] { 5, 5 }; // 탱크 초기 위치
        bulletPos = new int[2]; //bulletPos[0] : 발사 총알 위치의 X좌표 , bulletPos[1] : 발사 총알 위치의 Y좌표
        SumbulletPos = new int[bulletmagazine][]; //총알 탄창 개수만큼의 모든 총알 좌표 집합
        SumVector = new Vector[bulletmagazine]; // 총알 탄창 개수만큼의 (총알이 발사될 때의) 탱크 방향 집합
        food = new int[] { 10, 10 }; //먹이 초기 위치
        SuminputKey = new ConsoleKeyInfo[50]; 

        Console.CursorVisible = false; // 깜빡이는 커서 안보이게
    }
    /*---------------------------------------------------------------------------------*/  // 꾸미기 관련 함수

    // 콘솔 게임 화면 설정하는 함수
    public void ConsoleSetting()
    {
        Console.Title = "Tank Shooting Game"; // 콘솔창 이름
        Console.SetWindowSize(WIDE + 20, HEIGHT + 20); // 콘솔창 크기는 게임구역 크기보다 더 크게
        Console.BackgroundColor = ConsoleColor.Black; // 콘솔창 배경화면 : 검정색
    }
    // 게임 구역 그리기
    public void ConsoleBackGround()
    {
        Console.ForegroundColor = ConsoleColor.White;  // 게임구역 둘레 색깔 : 하얀색
        for (int i = 0; i < WIDE + 1; i++) // 게임 구역 그리기
        {
            Console.SetCursorPosition(i, 0);
            Console.Write("━");
            Console.SetCursorPosition(i, HEIGHT + 1);
            Console.Write("━");
        }
        for (int i = 0; i < HEIGHT + 1; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.Write("┃");
            Console.SetCursorPosition(WIDE + 1, i);
            Console.Write("┃");
        }

    }


    /*---------------------------------------------------------------------------------*/  // 키 입력 관련 함수
    // 키를 입력받는 함수
    public void Input()
    {
        if (Console.KeyAvailable)  //키 누름을 사용할 수 있으면
        {
            SuminputKey[keyNum] = Console.ReadKey(true); //키를 입력아서 받은 키를 SuminputKey 배열에 추가
        }
    }
    // 입력받은 키 개수 초기화 및 배열 초기화하는 함수
    public void ResetKeyNum()
    {
        keyNum++; // 입력받은 키 개수 1 증가
        if (keyNum == 50) // 배열의 범위를 벗어나면
        {
            Array.Clear(SuminputKey, 0, 50); // 배열 비우고
            keyNum = 0; // 개수 초기화
        }
    }
    /*---------------------------------------------------------------------------------*/   // 먹이 관련 함수
    // 먹이 좌표로 가서 먹이 모양 그리는 함수
    public void WriteFood(int x, int y)
    {
        Console.SetCursorPosition(x, y); // x,y 로 가서
        Console.ForegroundColor = ConsoleColor.Red; //먹이 색깔은 빨간색
        Console.WriteLine("W"); // '()'을 그린다.
    }
    //모든 먹이들을 그리는 함수
    public void DrawFood(int[] _food)
    {
        for (int i = 1; i <= bulletNum; i++) // 모든 총알에 대해서
        {
            if ((_food[0] == SumbulletPos[i][0]) && (_food[1] == SumbulletPos[i][1]))  // 먹이랑 부딪혔을 때(충돌)
            {
                isEat = true; // 먹혔으므로
                _food[0] = random.Next(STARTX, WIDE); //먹이변수의 X좌표 다시 랜덤 할당
                _food[1] = random.Next(STARTY, HEIGHT); //먹이변수의 Y좌표 다시 랜덤 할당
                score++; //점수 증가
            }
        }
        if (!isEat) // 먹히지 않았으면
        {
            WriteFood(_food[0], _food[1]); //먹이 그려주기
        }
        isEat = false; // 먹혀서 새로 만든 먹이의 먹힘 여부를 초기화
    }

    /*---------------------------------------------------------------------------------*/   // 총알 관련 함수

    // 총알 발사 위치 탱크 앞부분으로 초기화하는 함수
    public void ResetBulletPos()
    {
        switch (vector)
        {
            case Vector.UP: // 탱크 방향  : UP
                bulletPos[0] = tankPos[0];
                bulletPos[1] = tankPos[1] - 1;
                break;
            case Vector.RIGHT: // 탱크 방향  : RIGHT
                bulletPos[0] = tankPos[0] + 2;
                bulletPos[1] = tankPos[1];
                break;
            case Vector.DOWN: // 탱크 방향  : DOWN
                bulletPos[0] = tankPos[0] + 1;
                bulletPos[1] = tankPos[1] + 2;
                break;
            case Vector.LEFT: // 탱크 방향  : LEFT
                bulletPos[0] = tankPos[0] - 2;
                bulletPos[1] = tankPos[1] + 1;
                break;
        }


    }


    // 좌표를 받아 해당 좌표에 가서 총알그림(▲,▶,▼,◀)을 찍는 함수
    public void WriteBullet(int x, int y)
    {
        Console.ForegroundColor = ConsoleColor.Yellow; // 총알 색깔 : 노란색
        Console.SetCursorPosition(x, y); // x,y 로 가서 
        switch (vector) // 탱크의 방향에 따라 총알 그림 결정
        {
            case Vector.UP:
                Console.WriteLine("▲");
                break;
            case Vector.RIGHT:
                Console.WriteLine("▶");
                break;
            case Vector.DOWN:
                Console.WriteLine("▼");
                break;
            case Vector.LEFT:
                Console.WriteLine("◀");
                break;
        }
    }


    // 발사된 모든 총알 그리는 함수
    public void DrawBullet(bool _isBullet)
    {
        if (_isBullet) // 총알이 쏴졌으면(한번이라도 사용자가 spacebar를 눌렀으면)
        {
            for (int i = 1; i <= bulletNum; i++) //모든 총알에 대해서
            {
                if (SumbulletPos[i][0] >= STARTX - 1 && SumbulletPos[i][0] <= WIDE + 1) // 총알 좌표 게임구역 범위에 있는지 검사
                {
                    if (SumbulletPos[i][1] >= STARTX - 1 && SumbulletPos[i][1] <= HEIGHT + 1) // 범위에 있으면
                    {
                        switch (SumVector[i - 1]) // 모든 총알이 발사된 총알의 방향에 따라서 이동
                        {
                            case Vector.UP: //발사된 총알의 방향이 위라면
                                WriteBullet(SumbulletPos[i][0], SumbulletPos[i][1]); // 총알 그림 찍어주고
                                SumbulletPos[i][1]--; // 위쪽으로 계속 이동
                                break;
                            case Vector.RIGHT: //발사된 총알의 방향이 오른쪽이라면
                                WriteBullet(SumbulletPos[i][0], SumbulletPos[i][1]); // 총알 그림 찍어주고
                                SumbulletPos[i][0]++; // 오른쪽으로 계속 이동
                                break;
                            case Vector.DOWN: //발사된 총알의 방향이 아래라면
                                WriteBullet(SumbulletPos[i][0], SumbulletPos[i][1]); // 총알 그림 찍어주고
                                SumbulletPos[i][1]++; // 아래쪽으로 계속 이동
                                break;
                            case Vector.LEFT: //발사된 총알의 방향이 왼쪽이라면
                                WriteBullet(SumbulletPos[i][0], SumbulletPos[i][1]); // 총알 그림 찍어주고
                                SumbulletPos[i][0]--; // 왼쪽으로 계속 이동
                                break;
                        }
                    }
                    else // 총알의 X좌표가 게임구역 범위에 있지만 Y좌표가 해당되지 않는 경우 
                    {
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine(" "); // 0,0으로 간뒤에 총알 지워주기
                    }
                }
                else // 총알의 X좌표가 게임구역 범위에 아예 있지 않는 경우
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(" ");  // 0,0으로 간뒤에 총알 지워주기
                }
            }

        }
    }

    // 총알 발사위치 받아서 총알 좌표집합 변수에 추가하는 함수
    public void SumBulletPos(int[] _bulletPos)
    {
        bulletNum++; // 쏜 총알의 개수 1증가
        if (bulletNum > bulletmagazine - 1) // 총알이 탄창에 들어갈 수 있는 총알 개수보다 많아지면
        {
            bulletNum = 0; //자동 장전(총알 초기화)
        }
        SumbulletPos[bulletNum] = new int[] { _bulletPos[0], _bulletPos[1] }; //총알 좌표 추가
        SumVector[bulletNum] = vector; // 총알 방향 추가

        // SumbulletPos[총알 개수][0] : (총알개수)번쨰의 총알의 X좌표
        // SumbulletPos[총알 개수][1] : (총알개수)번쨰의 총알의 Y좌표
        // (EX) 총알 3번쨰에 쏜 총알의 X 좌표 : SumbulletPos[3][0] 
    }
    /*---------------------------------------------------------------------------------*/     //탱크 관련 함수

    // 탱크를 그리기 위해 좌표를 받아 해당 좌표에 가서 문자를 찍는 함수
    public void WriteTank(int x, int y)
    {
        Console.SetCursorPosition(x, y); // x,y 로 가서
        Console.ForegroundColor = ConsoleColor.Green; // 탱크 색깔은 초록색
        Console.WriteLine("O"); // '0'을 그린다.
    }
    // 탱크 포를 그리기 위해 좌표를 받아 해당 좌표에 가서 문자를 찍는 함수
    public void WriteTank2(int x, int y)
    {
        Console.SetCursorPosition(x, y); // x,y 로 가서
        Console.ForegroundColor = ConsoleColor.Green; // 탱크 포 색깔은 다크초록색
        Console.WriteLine("X"); // 'X'을 그린다.
    }

    //탱크의 위치를 받아 탱크 모양 그리는 함수
    public void DrawTank(int[] _tankPos)
    {
        switch (vector) // 탱크의 방향에 따라서 모양 다르게 그리기
        {
            case Vector.UP: //탱크 방향 : 위쪽
                WriteTank2(_tankPos[0], _tankPos[1]);
                WriteTank(_tankPos[0] - 1, _tankPos[1] + 1);
                WriteTank(_tankPos[0], _tankPos[1] + 1);
                WriteTank(_tankPos[0] + 1, _tankPos[1] + 1);
                WriteTank(_tankPos[0] - 1, _tankPos[1] + 2);
                WriteTank(_tankPos[0], _tankPos[1] + 2);
                WriteTank(_tankPos[0] + 1, _tankPos[1] + 2);
                break;
            case Vector.RIGHT: //탱크 방향 : 오른쪽
                WriteTank(_tankPos[0]-1, _tankPos[1] - 1);
                WriteTank(_tankPos[0]-1, _tankPos[1]);
                WriteTank(_tankPos[0]-1, _tankPos[1] + 1);
                WriteTank(_tankPos[0], _tankPos[1] - 1);
                WriteTank(_tankPos[0], _tankPos[1]);
                WriteTank(_tankPos[0], _tankPos[1] + 1);
                WriteTank2(_tankPos[0] + 1, _tankPos[1]);
                break;
            case Vector.DOWN: //탱크 방향 : 아래쪽
                WriteTank(_tankPos[0], _tankPos[1]-1);
                WriteTank(_tankPos[0] + 1, _tankPos[1]-1);
                WriteTank(_tankPos[0] + 2, _tankPos[1]-1);
                WriteTank(_tankPos[0], _tankPos[1]);
                WriteTank(_tankPos[0] + 1, _tankPos[1]);
                WriteTank(_tankPos[0] + 2, _tankPos[1]);
                WriteTank2(_tankPos[0] + 1, _tankPos[1] + 1);
                break;
            case Vector.LEFT: //탱크 방향 : 왼쪽
                WriteTank2(_tankPos[0], _tankPos[1] + 1);
                WriteTank(_tankPos[0] + 1, _tankPos[1]);
                WriteTank(_tankPos[0] + 1, _tankPos[1] + 1);
                WriteTank(_tankPos[0] + 1, _tankPos[1] + 2);
                WriteTank(_tankPos[0] + 2, _tankPos[1]);
                WriteTank(_tankPos[0] + 2, _tankPos[1] + 1);
                WriteTank(_tankPos[0] + 2, _tankPos[1] + 2);
                break;
        }
    }
    // 탱크 회전할 때 탱크의 방향을 X를 건너뛰고 LEFT → UP으로 돌아갈려는 함수
    public void ReturnVector()
    {
        if (vector == Vector.X)
        {
            vector = Vector.UP;
        }
    }


    // 탱크 좌표 게임창 범위에 있는지 검사 후 끝에 있는 값으로 초기화(게임구역 벗어나지 못하게) 하는 함수
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

    /*---------------------------------------------------------------------------------*/  // 게임 설명 및 게임 결과

    // 게임 시작전 출력할 내용 함수
    public void GameStart()
    {
        Console.SetCursorPosition(0, HEIGHT / 2);
        Console.ForegroundColor = ConsoleColor.White; // 글씨 하얀색으로 작성
        Console.WriteLine("Tank Shooting Game");
        Console.WriteLine("(탱크 이동 : w,a,s,d / 총알 발사 : spacebar / 탱크 회전 : tab)");
        Console.ForegroundColor = ConsoleColor.Red; // 글씨 빨간색으로 작성
        Console.WriteLine("게임을 시작하실려면 ENTER를 누르시오...");
        Console.ReadLine();
    }
    // 게임이 끝난뒤 콘솔에 출력할 내용 함수
    public void GameOver()
    {
        Console.Clear();
        Console.SetCursorPosition(0, HEIGHT / 2);
        Console.ForegroundColor = ConsoleColor.Yellow; // 글씨 노란색으로 작성
        Console.WriteLine("GAME OVER!");
        Console.WriteLine("Score : " + score);
    }

    // 게임이 끝난 뒤 다시한번 할 건지 여부
    public bool OneMore()
    {
        while (true) // 사용자가 "yes" 또는 "no" 를 입력하기 전까지 반복 계속
        {
            Console.Write("한번 더 하시겠습니까? ( Yes / No )");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "yes") // 대답 yes 이면 게임 다시 시작
            {
                return true;
            }
            else if (answer.ToLower() == "no") // 대답 no 이면 게임 종료
                return false;
        }
    }

    /*---------------------------------------------------------------------------------*/  // 게임 돌아가는 로직

    // 키에 따른 기능 함수
    // (W,S,A,D) 탱크 움직임
    // (spacebar) 총알 공격
    // (TAB) 탱크 회전
    public void Logic()
    {
        Console.Clear();  // 콘솔 화면 지우기
        ConsoleBackGround(); //콘솔 배경 그리기
        InspectTankPos(tankPos); // 탱크 위치 검사
        DrawTank(tankPos); // 탱크 그리기

        ResetBulletPos(); // 탱크 앞부분으로 총알 발사 좌표 초기화
        DrawBullet(isBullet); // 모든 총알 그리기
        DrawFood(food); // 먹이 그리기


        switch (SuminputKey[keyNum].Key) //키에 따른 작용
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
                SumBulletPos(bulletPos); // 발사된 총알 좌표 추가
                break;
            case ConsoleKey.Tab: // Tab을 누르면 탱크 회전
                vector++; // 벡터 방향 전환
                ReturnVector(); //X라면은 UP으로 바꾸기(LEFT → Up)
                break;

        }

        System.Threading.Thread.Sleep(25); //루프 돌기전 0.25초 대기
    }
    /*---------------------------------------------------------------------------------*/  // **메인 함수**
    static void Main(string[] args)
    {
        Game game = new Game(); // Game 객체 생성

        game.GameStart(); // 게임 시작
        game.ConsoleSetting(); // 콘솔창 세팅
        while (true)//무한 루프
        {
            game.Input(); // 입력받고
            game.Logic(); // 게임 돌리기
            game.ResetKeyNum(); // 입력받은 키 개수 점검
            game.timer++; // 시간 +
            if (game.timer == 100) // 시간 100되면(게임 제한 시간)
            {
                game.GameOver(); //게임종료
                if (game.OneMore()) // 다시할거면
                {
                    game.timer = 0; // 시간 초기화
                    game.score = 0; //점수 초기화
                    continue; // 계속 반복
                }
                else
                {
                    break; // 게임 종료
                }
            }
        }

    }
}

