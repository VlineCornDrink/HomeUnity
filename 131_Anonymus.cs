//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeUnity
//{
//    class _131_Anonymus
//    {
//        static void Main(string[] args)
//        {
//            // 익명 메소드
//            // 이름이 없는 함수
//            // 1번만 사용할 함수는 익명메소드를 사용
//            // 델리게이트에 간편하게 함수를 등록해야 하는 경우 사용
//            // 익명메소드는 델리게이트를 통해서만 호출 가능

//            MyDelegateA delA;
//            delA = delegate () { Console.WriteLine("Print!"); };
//            delA();

//            MyDelegateB delB;
//            delB = delegate (int x, int y) { return  x+y; };

//            Console.WriteLine("익명메소드 : "+ delB(10,20));
//        }

//        delegate void MyDelegateA();
//        delegate int MyDelegateB(int x, int y);
//    }
//}
