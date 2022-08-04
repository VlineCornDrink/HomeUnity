using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _85_Abstract
    {
        static void Main(string[] args)
        {

            //추상클래스
            // 인스턴스(객체)를 만들 수 없는 클래스
            // 추상클래스의 목적은 추상메서드를 만드는 역할
            // 추상메서드는 자식클래스에게 구현을 강제한다.

            // 추상메서드
            // 기능(정의)을 만들 수 없다.
            // 기능(정의)는 자식클래스에서 만들어지는 메서드

            //실습
            // Unit 클래스 만들기
            // Unit에서 파생되는 전사, 아처, 닌자 클래스 만들기
            // Unit에서 파생되는 클래스에게 Attack() 함수 강제하기
            Archer archer = new Archer();
            Knife knife = new Knife();
            Run run = new Run();
            archer.Attack();
            knife.Attack();
            run.Attack();
        }


        abstract class Unit //추상메서드가 있게 되면 추상 클래스가 되어야한다.
        {
            public abstract void Attack();
        }
        class Archer : Unit
        {
            public override void Attack()
            {
                Console.WriteLine("아처 공격!");
            }
        }
        class Knife : Unit
        {
            public override void Attack()
            {
                Console.WriteLine("전사 공격!");
            }
        }
        class Run : Unit
        {
            public override void Attack()
            {
                Console.WriteLine("닌자 공격!");
            }
        }

        abstract class Pet //추상클래스
        {
            public void Eat()
            {
                Console.WriteLine("먹다.");
            }
            public abstract void Howling(); //추상메서드
            //팀원들에게 Pet클래스를 상속받으면 Howling메서드를 무조건 만들어야 함
            // Pet클래스를 상속받으면 Howling메서드 무조건 만들어야함
            // 추상메서드를 만들면 클래스도 추상클래스가 되어야 함
        }
        class Dog : Pet //팀원1은 Dog라는 클래스를만듬
        {
            public override void Howling() //추상메서드 만들때 override키워드
            {
                Console.WriteLine("으르렁");
            }
        }
        class Cat : Pet//팀원2는 Cat이라는 클래스를 만듬
        {
            public override void Howling()
            {
                Console.WriteLine("야옹");
            }
        }
        // Dog와 Cat 은 Pet이지만 서로 다른 울음소리("으르렁" / "야옹")을 내므로 다른기능을 하므로
        // 추상메서드를 이용하여 서로 다른기능을 코딩
    }
}
