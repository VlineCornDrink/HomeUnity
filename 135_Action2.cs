//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeUnity
//{
//    class _135_Action2
//    {
//        static void Main(string[] args)
//        {
//            Action<int> actionA;
//            //int형 매개변수가 1개인 함수를 참조하는 델리게이트

//            actionA = Print;
//            actionA(5);

//            Action<float, float> actionB;
//            //float형 매개변수가 2개인 함수를 참조하는 델리게이트

//            actionB = Add;
//            actionB(1.1f, 2.2f);

//        }

//        static void Print(int num)
//        {
//            Console.WriteLine(num); 
//        }

//        static void Add(float x, float y)
//        {
//            Console.WriteLine(x + y); 
//        }
//    }
//}
