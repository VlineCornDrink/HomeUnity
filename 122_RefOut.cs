//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeUnity
//{
//    class _122_RefOut
//    {
//        static void Main(string[] args)
//        {
//            int testA = 10;
//            Plus(testA); //값을 1더해줌
//            Console.WriteLine(testA);
  
//            int testB = 10;
//            PlusRef(ref testB);
//            Console.WriteLine(testB);

//            int testC; //초기화X
//            //PlusRef(ref testC); //오류
//            PlusOut(out testC);
//            Console.WriteLine(testC);
//        }
//        static void Plus(int num)
//        {
//            num++;
//            // 매개변수로 들어온 값을 복사하게 된다.
//            // 매개변수를 통해 들어온 변수값은 변경되지 않는다.
//        }
//        static void PlusRef(ref int num)
//        {
//            num++;

//            // ref
//            // 메서드의 매개변수로 들어온 변수를 참조하는 역할
//            // 변수의 값을 미리 초기화 해두어야 한다.

//        }
//        static void PlusOut(out int num)
//        {
//            // out
//            // ref와 같이 매개변수를 통해 들어온 변수를 참조
//            // ref는 변수를 초기화 해야 함
//            // out은 변수를 초기화 하지 않아도 된다.

//            num = 50;
//        }
//    }
//}
