//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace practice
//{
//    class _87_ClassCasting
//    {
//        class Weapon //무기
//        {
//            public void Attack()
//            {
//                Console.WriteLine("공격!");
//            }
//        }
//        class Sword : Weapon
//        {
//            public void SwordAttack()
//            {
//                Console.WriteLine("칼 공격!");
//            }
//        }

//        class Bow : Weapon
//        {
//            public void ArrowAttack()
//            {
//                Console.WriteLine("화살 공격!");
//            }
//        }

//        class Character // 무기를 장착할 캐릭터
//        {
//            //Sword sword;
//            //Bow bow;
//            // 캐릭터는 무기를 장착할 수 있다.
//            // 캐릭터는 Bow Sword 지팡이 완드 방패 단검 등등...
//            // 여러가지를 써야하는데 각각 무기마다 변수를 만들면
//            // 메모리를 잡아먹으며 메모리 낭비가 된다.

//            // 캐스팅(Casting)
//            // 형변환
            
//            // 업 캐스팅(UpCasting)
//            // 자식클래스를 부모클래스로 형변환 하는것

//            // 다운 캐스팅(DownCasting)
//            // 부모클래스를 자식클래스로 형변환 하는것
//            // 일반적으로 업캐스팅은 C#에서 허용되지만
//            // 다운캐스팅은 허용되지 않는다.


//            public Weapon weapon;//무기 변수 (부모클래스)
            
//            public Character() //생성자
//            {
//                weapon = new Sword();
//                //부모클래스 변수에 자식클래스를 넣어줌
//                weapon.Attack(); //부모함수 호출 가능
//                //weapon.SwordAttack(); // 자식함수는 호출 불가능

                
               
//            }
//            public void BowAttack()
//            {
//                weapon = new Bow();
//                // 부모클래스 변수이기 때문에 자식클래스를 넣을 수 있다.

//            }
//            public void BowSkillAttack()
//            {
//                //Bow bow = new Weapon(); //다운 캐스팅은 불가
//                weapon = new Bow();
//                //weapon.ArrowAttack();//사용 불가

//                //다운캐스팅
//                ((Bow)weapon).ArrowAttack(); 
//            }

//        }

//        static void Main(string[] args)
//        {
      

//        }

        
//    }
//}
