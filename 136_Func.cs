//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeUnity
//{
//    class _136_Func
//    {
//        static void Main(string[] args)
//        {
//            // Func
//            // 반환형이 있는 메서드를 참조하는 델리게이트

//            Func<int> func;
//            func = One;
//            Console.WriteLine(func());

//            func += Two;
//            Console.WriteLine(func());
//            //체인을 하면 마지막에 넣은 함수만 반환 된다.
//            // 반환은 무시되도 함수는 정상 작동

//        }

//        static int One()
//        {
//            Console.WriteLine("One");
//            return 1;
//        }
//        static int Two()
//        {
//            Console.WriteLine("Two");
//            return 2;
//        }
//    }
//}
