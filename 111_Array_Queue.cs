//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace practice
//{
//    class _111_Array_Queue
//    {
//        static void Main(string[] args)
//        {
//            // 원형 큐
//            // 처음 값이 배열의 끝에 도달하면 다음 증가값은 처음값
//            // 처음과 끝이 연결되어 있는 형태
//            CircularQueue queue = new CircularQueue();

//            for (int i = 0; i < 10; i++)
//            {
//                queue.Enqueue(i);
//            }
//            queue.Print();
//            queue.Dequeue();
//            queue.Dequeue();
//            queue.Dequeue();
//            queue.Print();

//        }
//    }
//    //원형 큐
//    class CircularQueue
//    {
//        int front; //요소의 첫번째 위치
//        int rear; //요소의 마지막 위치
//        int[] data = new int[20]; //요소의 배열
//        public CircularQueue() { front = rear = 0; }

//        bool isEmpty() { return front == rear; }
//        bool isFull() { return (rear + 1) % data.Length == front; }
//        //마지막위치에 1을 더한 후 나머지가 처음이라면(마지막 위치라면)
//        void Error(string message) { Console.WriteLine(message); }

//        public void Enqueue(int value)
//        { //데이터를 추가하는 함수
//            if (isFull())
//            {
//                Error("Queue is Full");
//            }
//            else
//            {
//                rear = (rear + 1) % data.Length;
//                //다음칸(초과하지 않도록 나머지 연산 사용)
//                data[rear] = value; //마지막 위치에 값을 넣어줌
//            }
//        }
//        public int Dequeue()
//        { //요소를 제거하는 함수
//            if (isEmpty())
//            {
//                Error("Queue is empty");
//                return 0;
//            }
//            else
//            {
//                front = (front + 1) % data.Length;
//                //front의 값을 원형으로 증가시킴
//                return data[front];
//            }
//        }
//        public int Peek()
//        {
//            if (isEmpty())
//            {
//                Error("Queue is Empty");
//                return 0;
//            }
//            else
//            {
//                return data[(front + 1) % data.Length];
//            }
//        }

//        public void Print()
//        {
//            int max = (front < rear) ? rear - front : (rear + data.Length) - front;
//            Console.WriteLine("큐의 갯수 : " + max);
//            for (int i = front + 1; i <= rear; i++)
//            {
//                Console.Write(" <" + data[i % data.Length] + "> ");
//            }
//            Console.WriteLine(""); //개행


//        }
//    }
//}
