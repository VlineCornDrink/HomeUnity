using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _23_Enum
    {
        //int SUN = 0;
        //int MON = 1;
        //int TUE = 5;
        //int WED = 10;
        //int FRI = 11;

        // 위에 있는 변수들을 DAYS라는 이름으로 묶어주었다.
        enum DAYS
        {
            //열거형 안의 상수는 0부터 시작된다.
            //열거형은 값이 1씩 증가
            SUN, //0
            MON, //1
            TUE = 5,  //5
            WED = 10, //10
            FRI, //11
        } // 열거형을 정의 했다.

        //정의: 기능을 컴파일러에게 알려줌 // 기능을 컴파일러에게 알려줬을때 정의했다?
        enum EnemyState
        {
            IDLE = 2,
            MOVE = 5,
            ATTACK = 10,
            DEATH = 1
        }
        // enum위치 MAIN밖에 있기만하면 되는듯 MAIN위아래 상관업승ㅁ.


        static void Main(string[] args)
        {
            // 열거형
            // 상수형 변수를 열거해놓은 사용자 정의 자료형
            // 오류를 줄이고 가독성을 높힐 수 있다
            // 의미를 쉽게 파악할 수 있다.

            Console.WriteLine(DAYS.FRI.GetType());

            DAYS days; // 열거형 변수 선언
                       //선언: 컴파일러(컴퓨터)에게 사용하겠다고 알려줌
            days = DAYS.SUN; // 일요일을 넣어줌
            Console.WriteLine(days);
            days = DAYS.FRI; //금요일을 넣어줌
            Console.WriteLine(days);
            // 열거형 내부에 접근할 때는 '.'연산자를 사용

            // 열거형 int형으로 변환
            int daysValue = (int)days;
            Console.WriteLine(daysValue);

            // 실습
            // 대기(IDLE), 이동(MOVE), 공격(ATTACK), 죽음(DEATH) 를 열겨형으로 만들기
            //열거형 이름은 EnemyState

            EnemyState enemy = EnemyState.IDLE;
            int enemyValue = (int)enemy;
            Console.WriteLine(enemy);
            Console.WriteLine(enemyValue);

            enemy = EnemyState.MOVE;
            enemyValue = (int)enemy;
            Console.WriteLine(enemy);
            Console.WriteLine(enemyValue);

            enemy = EnemyState.ATTACK;
            enemyValue = (int)enemy;
            Console.WriteLine(enemy);
            Console.WriteLine(enemyValue);

            enemy = EnemyState.DEATH;
            enemyValue = (int)enemy;
            Console.WriteLine(enemy);
            Console.WriteLine(enemyValue);

            string example = enemy.ToString("f"); // ?
            Console.WriteLine("The value of myColor is {0}.", example);
            Console.WriteLine(enemy);

        }

    }
}
