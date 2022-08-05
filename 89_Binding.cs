//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace practice
//{
//    class _89_Binding
//    {
//        static void Main(string[] args)
//        {
//            // 바인딩
//            // 연결하는것 

//            // 정적바인딩
//            // 컴파일시 클래스와 함수가 연결되는 것

//            // 동적바인딩
//            // 런타임시 클래스와 함수가 연결되는 것

//            Unit newbie = new Unit();
//            Ninja ninja = new Ninja();
//            Archer archer = new Archer();

//            Monster monster = new Monster();
//            monster.Attack(newbie);
//            monster.Attack(ninja);
//            monster.Attack(archer);
//            //업캐스팅을 하면 부모함수만 호출된다. (정적바인딩)
//            // 정적바인딩 되기 때문에 결과는 90 90 90이다.

//        }

//        class Unit
//        {
//            protected int hp = 100;

//            public void Hit(int damage) //데미지를 전달받는 함수
//            {
//                hp -= damage;
//                Console.WriteLine("체력 : " + hp);
//            }

//        }
//        class Ninja : Unit
//        {
//            public void HiT(int damage)
//            {
//                //닌자는 특수효과로 50%확률로 회피한다.
//                Random ran = new Random();
//                int num = ran.Next(0, 2); // 0이상 2미만의 난수
//                if (num == 0)
//                {
//                    hp -= damage;
//                    Console.WriteLine("회피 실패 : " + hp);
//                }
//                else
//                {
//                    Console.WriteLine("회피!");
//                }

//            }
//        }

//        class Archer : Unit
//        {
//            //아처는 특수효과를 데미지를 절반만 받는다.
//            public void Hit(int damage)
//            {
//                hp -= (damage / 2);
//                Console.WriteLine("아처체력 : " + hp);
//            }
//        }

//        class Monster
//        {
//            int power = 10;//몬스터의 공격력

//            public void Attack(Unit unit) //업캐스팅을 이용
//            {
//                // 3개 직업 중 어떤게 올지 모르기에
//                // 업캐스팅을 이용해 받아올 예정
//                unit.Hit(power);
//            }
//        }
//    }
//}
