//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Reflection;


//namespace UnityPractice
//{
//    class _142_Reflection
//    {
//        static void Main(string[] args)
//        {
//            // 리플렉션(Reflection) 시스템
//            // C++에는 없고 C#에는 있다.
//            // Tip : 언리얼에서는 리펠렉션 시스템을 억지로 만들었다.
//            // 유니티에서는 많은 기능들이 리플렉션 시스템을 활용한다.
//            // 프로그램 실행 도중(런타임) 객체의 정보를 조사하는 시스템
//            // 클래스 타입, 메서드, 프로퍼티 등을 런타임 중 알아낼 수 있음
//            // 이런 정보를 얻어 메서드 호출, 프로퍼티 변경이 가능
//            // 리플렉션을 사용하면 객체의 모든 정보를 런타임중에 분석하고 사용이 가능
//            // using System.Reflection; 추가해야함

//            Monster enemy = new Monster("고블린", 10); //객체 생성

//            Console.WriteLine(enemy.GetType());
//            // 몬스터 클래스의 타입을 조사

//            Type type = enemy.GetType();

//            //생성자 조사
//            ConstructorInfo[] con_info = type.GetConstructors();
//            foreach (ConstructorInfo item in con_info)
//            {
//                Console.WriteLine("생성자 : "+item);
//            }

//            // 멤버 조사
//            MemberInfo[] mem_info = type.GetMembers();
//            foreach (MemberInfo item in mem_info)
//            {
//                Console.WriteLine("멤버 : "+item);
//            }

//            // 알고싶은 정보
//            BindingFlags fieldType;
//            fieldType = System.Reflection.BindingFlags.Public;
//            fieldType |= System.Reflection.BindingFlags.NonPublic;
//            fieldType |= System.Reflection.BindingFlags.Static;
//            fieldType |= System.Reflection.BindingFlags.Instance;

//            FieldInfo[] field_info = type.GetFields(fieldType);
//            foreach (FieldInfo item in field_info)
//            {
//                Console.WriteLine("필드 : "+item);
//            }
            
//        }

//        class Monster
//        {
//            public Monster(string _name,int _atk)
//            {
//                name = _name;
//                atk = _atk;
//            }
//            public string name;
//            public int hp;
//            protected int atk;
//            private float speed;

//            void Attack() { Console.WriteLine("공격!"); }

//        }
//    }
//}
