//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace HomeUnity
//{
//    class _134_Action
//    {
//        static void Main(string[] args)
//        {
//            // Action
//            // 반환자료형이 없는(void형) 델리게이트
//            // using.System;이 필요함

//            Action action;

//            action = ActionTest;
//            action += ActionTest2; //체인 가능
//            action();
//            action -= ActionTest; //뺴기 가능
//            action();
//        }

//        static void ActionTest()
//        {
//            Console.WriteLine("액션!");
//        }

//        static void ActionTest2()
//        {
//            Console.WriteLine("테스트!");
//        }
//    }
//}
