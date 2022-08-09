using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddd
{
    class _104_Generic_Stack
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            // 스택이라는 컬렉션에 자료형을 정해주어 제네릭 컬렉션이 된다.

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine(stack.Peek());
            //Peek() : 다음에 제거될 데이터를 반환
            stack.Pop();//데이터 제거
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
            stack.Pop();


            // 실습
            // float형으로 스택 만들어서 사용해보기

            Stack<float> stack2 = new Stack<float>();

            stack2.Push(1.2f);
            stack2.Push(2.3f);
            stack2.Push(3.4f);


            Console.WriteLine(stack2.Peek());
            stack2.Pop();
            Console.WriteLine(stack2.Peek());
            stack2.Pop();
            Console.WriteLine(stack2.Peek());
            stack2.Pop();

        }
    }
}
