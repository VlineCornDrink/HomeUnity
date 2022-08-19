//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace UnityPractice
//{
//    class _141_Task
//    {
//        static void Main(string[] args)
//        {
//            // Task 클래스
//            // 일반적으로 1개의 프로세스는 1개의 쓰레드를 가지고 작업을 수행
//            // 멀티쓰레드는 하나의 프로세서에서 둘 이상의 쓰레드가 작업을 수행
//            // Task 클래스는 멀티 쓰레드에서 비동기 작업을 수행

//            // Task와 Thread의 차이
//            // Task와 Thread 모두 병렬 프로그래밍에 사용 됨
//            // Thread는 하위 수준 구현
//            // Task는 상위 수준 구현
//            // Thread는 Task보다 더 많은 제어를 제공
//            // 장기 실행 작업에는 Thread를 선호
//            // 그 외에는 Task를 선호


//            //Task.Factory.StartNew(() => { Console.WriteLine("L"); });
//            // 스레드 생성 및 시작

//            Task workerA = new Task(new Action(Hello));
//            // Action 델리게이트를 이용하여 쓰레드 생성 및 할일을 넣어줌
//            workerA.Start(); // 일 시작
//            workerA.Wait(); // 일이 끝날떄까지 대기


//            Task workerB = new Task(Hello);
//            workerB.Start(); // 일 시작
//            workerB.Wait(); //일이 끝날때까지 대기
//        }

//        static void Hello()
//        {
//            Console.WriteLine("Hello");
//        }
//    }
//}
