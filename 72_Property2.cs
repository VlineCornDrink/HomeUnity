using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _72_Property2
    {
        static void Main(string[] args)
        {
            //프로퍼티 Getter와 Setter 함수의 역할을 수행
            Game game = new Game();
            Console.ForegroundColor = ConsoleColor.Green;
            game.Score = 100;
            game.Score = -309;
            Console.WriteLine(game.Score);

            //실습
            //Monster 클래스 제작
            // int currentHp 변수 제작
            // currentHp 프로퍼티 제작
            // currentHp의 값이 0보다 작다면 "죽음"출력
            //currentHp의 값이 1000보다 크다면 "생명령 초과"출력
            //currentHp의 값이 변경될때마다 남은 체력 출력

            Monster monster = new Monster();
            monster.CurrentHp = 2000;
            monster.CurrentHp = 500;
            monster.CurrentHp = -300;
            monster.CurrentHp = 0;
        }
        class Monster //Monster Hp에 관한 클래스
        {
            private int currentHp;
            public int CurrentHp
            {
                get { return currentHp; }
                set
                {
                    currentHp = value;
                    if (currentHp <= 0)
                    {
                        Console.WriteLine("죽음");
                    }
                    else if (currentHp > 1000)
                    {
                        Console.WriteLine("생명력 초과");
                    }
                    Console.WriteLine("당신의 남은 체력은 : " + currentHp);

                }
            }
        }

        class Game
        {

            private int score = 0; //점수
            public int Score
            {
                get { return score; }
                set
                {
                    if (value >= 0)
                    {//프로퍼티에 들어온 값이 0이상이라면
                        score = value; //값 변경
                    }
                    else //0미만(음수)라면은
                    {
                        score = 0; //score의 값을 0으로 변경
                    }
                    Console.WriteLine("score : " + score);
                }
            }
        }
    }
}
