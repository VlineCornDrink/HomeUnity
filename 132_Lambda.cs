//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeUnity
//{
//    class _132_Lambda
//    {
//        static void Main(string[] args)
//        {
//            // 람다식
//            // 익명메소드를 간편하게 표현한 식
//            // 익명메소드를 표현하는데 사용 된다.

//            MyDelegate del;
//            del = () => Console.WriteLine("Print!");

//            del();
//            del += () => { Console.WriteLine("Test"); };
//            del();
//            del += () => Console.WriteLine("hell0");

//            del();
//            del += () =>
//            {
//                Console.WriteLine("1");
//                 Console.WriteLine("2");
//                Console.WriteLine("3");
//            };
//            del();
//        }

//        delegate void MyDelegate();

//    }
//}
