//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using practice;

//namespace hello //네임스페이스와 어셈블리에 대한 이해 필요
//{
//    class A
//    {
//        ArrayStack asd = new ArrayStack();

//    }
//}

//namespace practice
//{
//    class _110_Array_Stack
//    {
//        static void Main(string[] args)
//        {
//            ArrayStack stack = new ArrayStack(); //ArrayStack클래스가 public이 아닌데 쓸수있다? 뭐지
//            for (int i = 0; i < 20; i++)
//            {
//                stack.Push(i); //0~9까지의 값을 넣어줌
//            }
//            stack.Print();
//            stack.Pop();
//            stack.Pop();
//            stack.Pop();
//            stack.Print();
//        }
//    }
//    class ArrayStack
//    {
//        int top; //요소의 갯수
//        int[] data = new int[20]; //요소의 배열
//        public ArrayStack() { top = -1; }
//        // -1을 넣어주는 이유는 배열값을 전위증가를 이용하여
//        // 0번째 인덱스부터 접근하기 위함

//        bool isEmpty() { return top == -1; }
//        // 스택에 요소가 없는지 여부
//        bool isFull() { return top == data.Length; }
//        // 요소의 갯수가 top과 같다면 꽉 차있다는 뜻
//        void Error(string message) { Console.WriteLine(message); }

//        public void Push(int value)
//        { //데이터를 추가하는 함수
//            if (isFull())
//            {
//                Error("Stack is full");
//                return;
//            }
//            data[++top] = value;
//            //top의 값을 1증가후 해당 인덱스에 값을 넣어줌
//        }
//        public int Pop()
//        { //데이터를 제거하는 함수
//            if (isEmpty())
//            {
//                Error("Stack is Empty");
//            }
//            return data[top--];
//        }

//        public int Peek()
//        {
//            if (isEmpty())
//            {
//                Error("Stack is Empty");
//            }
//            return data[top];
//        }

//        public void Print()
//        {
//            Console.WriteLine("스택 갯수 : " + (top + 1));
//            for (int i = 0; i <= top; i++)
//            {
//                Console.Write(" <" + data[i] + "> ");
//            }
//            Console.WriteLine("");//개행
//        }
//    }
//}
