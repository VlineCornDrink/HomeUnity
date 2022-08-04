using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _78_Inherit
    {
        class Unit //모험가
        {
            public Unit()
            {
                Console.WriteLine("유닛 생성!");
            }
            public string name;
            public int atk; //공격력
            public int defence; //방어력

            public void Attack()
            {
                Console.WriteLine("이름 : " + name + " 공격력 : " + atk + " 방어력 : " + defence);
            }
        }

        class Warrior : Unit//구조 : <class 자식 : 부모>
        {
            public int strenth;

            public Warrior()
            {
                name = "전사";
                atk = 5;
                defence = 7;
                //   부모에 있는 변수들이 복사되어 온다.
                //   보이진 않지만 변수와 함수들이 선언되어 있다.
                strenth = 15;
            }
            public void MeleeAttack()
            {
                Console.WriteLine("근접공격 : " + (atk + strenth));
            }
        }

        class Archer : Unit
        {
            public int dex;
            public Archer()
            {
                dex = 10;
            }
            public void LongAttack()
            {
                Console.WriteLine(name + "원거리공격 : " + (atk + dex));
            }
        }
        class BowMaster : Archer
        {
            public int a;
            public BowMaster()
            {
                a = dex + 1;

            }
            public void Skill()
            {
                Console.WriteLine(name + "스킬 : " + (atk + a));
            }
        }
        static void Main(string[] args)
        {
            // 상속
            // 클래스 사이에서 부모 자식관계를 정의하는 작업
            // 부모클래스에 있는 멤버변수와 멤버함수를 자식클래스에게 물려줌
            // 코드의 반복을 줄일 수 있다.

            // public class 자식클래스 : 부모클래스

            // 부모클래스 : base(기반)이 되는 클래스, Super클래스 라고도 불림
            // 자식클래스 : 파생클래스 라고도 불림 
            // └ 부모클래스의 멤버변수,멤버함수를 물려받은 클래스

            Warrior warrior = new Warrior(); // Warrior : Unit
            //자식 객체를 만들면 부모객체도 같이 만들어진다.
            warrior.Attack();
            warrior.MeleeAttack();
            Archer archer = new Archer();  // Archer : Unit
            archer.Attack();
            archer.LongAttack();
            BowMaster bowMaster = new BowMaster();  // BowMaster : Archer
            bowMaster.Attack();
            bowMaster.LongAttack();
            bowMaster.Skill();


            //실습 
            //Unit클래스를 상속받는 Archer클래스 만들기
            // Archer클래스는 특별히 dex스탯이 존재
            //LongAttack()스킬도 존재
            //LongAttack 함수에서는 원거리공격 출력 

            //Archer클래스를 상속받는 BowMaster 클래스 만들기
            //BowMaster의 기능 자유롭게 추가해주기
        }

    }
}
