using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _90_Virtual
    {
        static void Main(string[] args)
        {
            // 가상함수
            // 동적바인딩을 지시
            // 부모클래스에서 자식클래스에게 재정의 할 것을 기대하고 정의한 함수
            // 가상함수를 보면 자식클래스에서 재정의 되어있는 것을 알 수있다.
            // 가상함수는 자식클래스에서 재정의하면 재정의 한 내용으로 교체됨
            
            // Plus : abstract은 재정의가 필수인 반면 virutal은 필수가 아니다.
            //        abstract는 부모클래스에서 추상함수를 정의만 가능, 기능 설정 불가능
            //        virtual은 바인딩 개념과 관련되어 있어 부모클래스에서도 가상함수에 기능을 설정할 수있다.

            Unit newbie = new Unit();
            Ninja ninja = new Ninja();
            Archer archer = new Archer();

            Monster monster = new Monster();

            monster.Attack(newbie);
            monster.Attack(ninja);
            monster.Attack(archer);


        }
        class Unit
        {
            protected int hp = 100;
            public virtual void Hit(int damage)
            {
                hp -= damage;
                Console.WriteLine("체력 : " + hp);
            }
        }
        class Ninja : Unit
        {
            public override void Hit(int damage)
            {
                Random ran = new Random();
                int num = ran.Next(0, 1);
                if (num == 0)
                {
                    Console.WriteLine("회피!");
                }
                else
                {
                    hp -= damage;
                    Console.WriteLine("회피 실패 : " + hp);
                }
            }
        }
        class Archer : Unit
        {
            public override void Hit(int damage)
            {
                hp -= (damage / 2);
                Console.WriteLine("아처체력 : " + hp);
            }
        }
        class Monster
        {
            int power = 10;
            public void Attack(Unit unit)
            {
                unit.Hit(power);
            }
        }
    }
}
