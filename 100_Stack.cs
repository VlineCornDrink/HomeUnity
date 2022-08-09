//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;
//namespace dddd
//{
//    class _100_Stack
//    {
//        static void Main(string[] args)
//        {
//            // 스택(Stack)
//            // LIFO(Last In First Out)
//            // 마지막에 들어온 데이터를 먼저 내보내는 구조
//            // 컬렉션은 어떤 자료형이든 담을 수 있다.

//            Stack stack = new Stack();

//            stack.Push("Weapon"); //데이터 추가
//            stack.Push(50); // 데이터 추가
//            stack.Push(12.34f); // 데이터 추가
//            stack.Push(true);

//            Console.WriteLine(stack.Peek());
//            //Peek() : 다음에 빠져나갈 데이터를 반환
//            stack.Pop(); //데이터 제거
//            Console.WriteLine(stack.Peek());
//            stack.Pop();
//            Console.WriteLine(stack.Peek());
//            stack.Pop();
//            Console.WriteLine(stack.Peek());
//            stack.Pop();

//        }
//    }
//}
