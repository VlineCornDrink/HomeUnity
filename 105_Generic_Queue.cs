//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;

//namespace practice
//{
//    class _105_Generic_Queue
//    {
//        static void Main(string[] args)
//        {
//            Queue<int> queue = new Queue<int>();

//            queue.Enqueue(10); //10의 값 추가
//            queue.Enqueue(20);
//            queue.Enqueue(30);

//            Console.WriteLine(queue.Peek());
//            queue.Dequeue(); //먼저 들어온 데이터 제거
//            Console.WriteLine(queue.Dequeue()); //출력과 제거를 동시에
//            Console.WriteLine(queue.Dequeue());

//            // 실습
//            // float형으로 Queue를 만들고 사용해보기

//            Queue<float> qu = new Queue<float>();

//            qu.Enqueue(1.2f);
//            qu.Enqueue(2.3f);
//            qu.Enqueue(3.4f);

//            Console.WriteLine(qu.Dequeue());
//            Console.WriteLine(qu.Peek());
//            qu.Dequeue();
//            Console.WriteLine(qu.Dequeue());
            

//        }
//    }
//}
