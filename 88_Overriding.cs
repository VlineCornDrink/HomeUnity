//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//        //https://see-ro-e.tistory.com/132?category=782427
//namespace practice
//{
//    class _88_Overriding
//    {
//        static void Main(string[] args)
//        {
//            // 오버라이딩(오버라이드)
//            // 함수 재정의
//            // 부모클래스에 있는 함수를 같은 이름으로 자식클래스에서 
//            // 새롭게 다시 만드는 것

//            var unit = new Unit();
//            unit.Attack();

//            Ninja ninja = new Ninja();
//            ninja.Attack();

//            Archer archer = new Archer();
//            archer.Attack();
//            //함수 재정의를 하면 부모함수는 무시되고
//            // 자식 클래스의 함수가 호출된다(우선시)
//        }

//        class Unit
//        {
//            public void Attack()
//            {
//                Console.WriteLine("기본 공격!");
//            }
//        }

//        class Ninja : Unit
//        {
            
//            public void Attack() //똑같은 이름으로 함수 재정의(부모클래스에 있는 Attack 함수가 존재는 하지만 무시하고 자식클래스에 있는 Attack함수 우선시)
//            {
//                Console.WriteLine("표창 공격!");
//            }
//        }
//        class Archer : Ninja
//        {
            
//            public void Attack()
//            {
//                Console.WriteLine("화살 공격!");
//            }
//        }
//    }
//}
