//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeUnity
//{
//    class _130_DelegateChain
//    {
//        static void Main(string[] args)
//        {
//            // 델리게이트 체인
//            // 하나의 델리게이트에 여러개의 함수를 등록시키는 방법

//            MyDelegate del; //변수 선언
//            del = new MyDelegate(PrintA);
//            del += new MyDelegate(PrintB);
//            del += new MyDelegate(PrintC);

//            del();


//        }

//        public delegate void MyDelegate();
//        public static void PrintA()
//        {
//            Console.WriteLine("1번");
//        }
//        public static void PrintB()
//        {
//            Console.WriteLine("2번");
//        }
//        public static void PrintC()
//        {
//            Console.WriteLine("3번");
//        }
       
//    }
//}
