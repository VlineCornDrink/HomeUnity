//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;//추가

//namespace HomeUnity
//{
//    class _139_Thread
//    {
//        static void Main(string[] args)
//        {
//            // 쓰레드(Thread)
//            // 한명의 작업자를 뜻함
//            // 흐름의 단위
//            // 다중 스레드(멀티 쓰레드)는 여러작업자가 동시에 여러작업하는 것을 의미
//            // 쓰레드를 만들때는 ThreadStart 대리자를 사용해야 함

//            // Thread 클래스 주요 멤버
//            // 1. Priority
//            // 쓰레드 우선 순위 결정
//            // ThreadPriority 열거형의 Highest, Normal, Lowest값을 가질 수 있음
//            // 2. Abort()
//            // 쓰레드 종료
//            // 3. Sleep()
//            // 쓰레드를 설정된 밀리초(1000/1초)만큼 중지
//            // 4. Start()
//            // 쓰레드 시작

//            Thread worker = new Thread(new ThreadStart(Hello));
//            worker.Start(); //쓰레드에 담긴 메서드 시작

//        }

//        static void Hello()
//        {
//            Console.WriteLine("Hello!");
//        }
//    }
//}
