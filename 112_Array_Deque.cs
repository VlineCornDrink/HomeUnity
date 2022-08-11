//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace practice
//{
//    class _112_Array_Deque
//    {
//        static void Main(string[] args)
//        {
//            // 덱(Deque)
//            // 큐의 앞(front)과 뒤(Rear)에서 모두 삽입과 삭제가 가능한 큐
//            // 중간에 삽입이나 삭제는 허용하지 않음

//            Deque deque = new Deque();
//            for (int i = 0; i < 5; i++)
//            {
//                deque.AddFront(i); //0~4까지의 값을 앞으로 추가
//            }
//            deque.Print();
//            for (int i = 9; i > 4; i--)
//            {
//                deque.AddRear(i); //9~5까지의 값을 뒤로 추가
//            }
//            deque.Print();
//            deque.DeleteFront();
//            deque.DeleteFront();
//            deque.DeleteFront();
//            deque.Print();

//            deque.DeleteRear();
//            deque.DeleteRear();
//            deque.DeleteRear();
//            deque.Print();
//        }
//    }
//    // 원형 덱
//    class Deque
//    {
//        int front;//요소의 첫번쨰 위치
//        int rear; // 요소의 마지막 위치
//        int[] data = new int[20]; //요소의 배열
//        public Deque() { front = rear = 0; }
       
//        int Size()
//        {
//            // 덱 요소의 갯수를 반환
//            return front <= rear ? rear - front : (rear + data.Length) - front;
//        }

//        bool isEmpty() { return front == rear; }
//        bool isFull() { return (rear + 1) % data.Length == front; }
//        //마지막에 1을 더한 후 나머지가 처음이라면(초과했다면 true)

//        void Error(string message) { Console.WriteLine(message); }

//        public void AddFront(int value)
//        {
//            if (isFull())
//            {
//                Error("Deque is full");
//                Environment.Exit(0); //콘솔창 종료
//            }
//            data[front] = value;
//            front = (front - 1 + data.Length) % data.Length;
//            //front가 0 이하로 떨어지는 경우 배열의 갯수로 순회
//        }
       
//        public void AddRear(int value)
//        {
//            //뒤로 데이터 추가
//            if (isFull())
//            {
//                Error("Deque is full");
//                Environment.Exit(0);
//            }
//            rear = (rear + 1) % data.Length;
//            //rear가 최대치를 벗어났으면 다시 0으로 순회
//            data[rear] = value;
//        }

//        public int DeleteFront()
//        {
//            //앞의 데이터 제거
//            if (isEmpty())
//            {
//                Error("Deque is Empty");
//                Environment.Exit(0);
//            }
//            front = (front + 1) % data.Length;
//            // front가 최대치를 넘어가는 경우 다시 0번째로
//            return data[front];
//        }
        
//        public int DeleteRear()
//        {
//            //뒤의 요소 제거
//            if (isEmpty())
//            {
//                Error("Deque is Empty");
//                Environment.Exit(0); //콘솔창 종료
//            }
//            int temp = data[rear]; //현재 마지막요소를 넣어줌
//            rear = (rear - 1 + data.Length) % data.Length;
//            //rear가 0이하라면 다시 최대갯수로 변경
//            return temp; //제거 한 요소를 반환
//        }

//        public int GetFront()
//        {
//            if (isEmpty())
//            {
//                Error("Deque is Empty");
//                Environment.Exit(0);
//            }
//            return data[(front + 1) % data.Length];
//        }

//        public int GetRear()
//        {
//            if (isEmpty())
//            {
//                Error("Deque is Empty");
//                Environment.Exit(0);
//            }
//            return data[rear];
//        }
        
//        public void Print()
//        {
//            Console.WriteLine("덱 갯수 : "+Size());
//            for (int i = front+1; i <= front+Size(); i++)
//            {
//                Console.Write(" <"+data[i%data.Length]+"> ");
//            }
//            Console.WriteLine("");//개행  
//        }

//    }
//}
