using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _55_instance
    {
        static void Main(string[] args)
        {
            // 인스턴스(객체)
            // 하나의 클래스에서 생성된 객체를 뜻한다.
            // 클래스에서 실제 객체를 생성하는 것을 인스턴스화 라고 한다.
            // 클래스를 정의하고 객체(인스턴스) 생성을 통해 사용할 수 있다.
            // 클래스 변수명; //클래스 타입 변수 선언
            // 클래스 변수명 = new 클래스(); // 클래스의 인스턴스를 생성 및 변수가 참조

            // 인스턴스화: 클래스로부터 객체를 만들어내는 과정을 의미

            Player player = new Player();
            Console.WriteLine(player.x);

            Player playerA; //기본적으로 null값이 들어가진다.그래서 밑 코드 실행x

            //실습
            //Enemy 클래스를 만들어서 Main 함수에서 인스턴스화 해보기
            Enemy enemy = new Enemy();
            Console.WriteLine(enemy.Return());
            Console.WriteLine(enemy.hp);
        }

        class Enemy
        {
            public int hp = 20;
            public int attack = 30;
            public int attack_speed = 10;
            public int Return() => hp + attack;

        }

        class Player // 클래스 정의
        {
            public int x = 10;//멤버 변수
            public void Method() //멤버 함수
            {
                Console.WriteLine("Player!");
            }
        }
    }
}
