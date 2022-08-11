using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _86_Interface
    {
        static void Main(string[] args)
        {
            // 인터페이스(interface)
            // C++ 은 다중상속이 가능(부모클래스 2개 이상)
            // C#은 다중상속이 불가능(부모클래스 1개만)
            // C#에서 다중상속을 하기 위해서는 interface를 사용해야 함
            // 인터페이스는 추상클래스와 유사
            // 클래스명과 구별할 수 있도록 이름 앞에 I를 붙인다.
            // 모든 멤버는 추상화만 가능(선언만 가능)
            // 인스턴스(객체)를 만들 수 없다.

            // 실습
            // Archer클래스 만들기
            // Bow인터페이스, Gun인터페이스를 상속 받는다.
            // 해당 내용을 구현
            Archer archer = new Archer();

            archer.bowWho();
            archer.gunWho();
        }
        interface IBow
        {
            int bowdamage { get; set; }
            void bowWho();
        }
        interface IGun
        {
            int gundamage { get; set; }
            void gunWho();
        }
        class Archer : Bow, Gun
        {
            public int bowdamage { get; set; } = 10;
            public int gundamage { get; set; } = 12;

            string name = "Enemy1";
            string name2 = "Enemy2";

            public void bowWho()
            {
                Console.WriteLine(name + "에게 Bow로 " + bowdamage + "만큼 가한다!");
            }

            public void gunWho()
            {
                Console.WriteLine(name2 + "에게 gun으로 " + gundamage + "만큼 가한다!");
            }
        }

        interface ISword
        {
            //int num; //일반 변수 사용 불가
            int atk { get; set; } //프로프티는 사용 가능
            void Attack(); //함수 선언 가능
        }
        interface IShield
        {
            int defence { get; set; }
            void Defence();
        }

        class Player : ISword, IShield //ctrl + '.'을 이용하면 인터페이스 빠르게 구현 가능
        {
            public int atk { get; set; }
            public int defence { get; set; }

            public void Attack()
            {

            }

            public void Defence()
            {

            }
        }
    }
}
