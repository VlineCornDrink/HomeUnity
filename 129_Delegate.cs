//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeUnity
//{
//    class _129_Delegate
//    {
//        static void Main(string[] args)
//        {
//            // Delegate(대리자)
//            // 함수를 대신하는 역할(함수를 참조)
//            // 함수를 변수처럼 사용 가능
//            // 함수포인터(함수의 변수)의 역할을 하게 됨

//            MyDelegate del; //델리게이트 변수 선언
//            del = new MyDelegate(MethodA); //MethodA함수 참조
//            del("AAA");

//        }

//        public delegate void MyDelegate(string msg);
//        //델리게이트 정의(기능을 만듦)

//        public static void MethodA(string msg)
//        {
//            Console.WriteLine("MethodA : "+msg);
//        }
//    }
//}
