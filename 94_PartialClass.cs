//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace practice
//{
//    class _94_PartialClass
//    {
//        static void Main(string[] args)
//        {
//            // Partial Class
//            // 클래스를 여러 파일에 정의 가능
//            // 클래스 내용을 분할 가능
//            // 논리적으로는 하나의 클래스
//            // 컴파일러가 분할된 클래스를 하나로 결합

//            // 주의사항
//            // 분할된 클래스는 모두 partial키워드를 사용해야 함
//            // 분할된 클래스는 모두 동일한 접근지정자를 가져야 함
//            // C#은 다중상속을 지원하지 않음
//            // partial Class도 다중상속 불가


//        }

//        partial class Player
//        {
//            private string name;
//            private int age;

//        }
//        partial class Player // : TestB ← 이거 불가능(다중상속)
//        {
//            public string Name
//            {
//                get { return name; }
//                set { name = value; }
//            }
//            public int Age 
//            {
//                get { return age; }
//                set { age = value; }
//            }
//        }

//        partial class Player : TestA //상속은 하나만 가능(다중상속 불가능)
//        {
//            public void Print()
//            {
//                Console.WriteLine("name : "+ Name);
//                Console.WriteLine("age : " + Age);
//            }
//        }

//        class TestA
//        {

//        }
//        class TestB
//        {

//        }
//    }
//}
