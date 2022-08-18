using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace HomeUnity
{
    class _140_Thread2
    {
        static void Main(string[] args)
        {
            // 동기 프로그래밍
            //Start();
            //Game();
            //End();

            // 비동기 프로그래밍
            Thread workerA = new Thread(new ThreadStart(Start));
            Thread workerB = new Thread(new ThreadStart(Game));
            Thread workerC = new Thread(new ThreadStart(End))
            {
                Priority = ThreadPriority.Highest //우선순위 높게
                // 컴퓨터마다 쓰레드의 갯수가 다름
                // 위의 쓰레드3개인데 만약 컴퓨터의 쓰레드가
                // 2개면 우선순위 높은거 먼저 작업실행

            };

            workerA.Start();
            workerB.Start();
            workerC.Start();
            // 작업자가 다르므로 실행결과는 매번 다르게 나타난다.

            // 프로세스
            Process.Start("Notepad.exe");
            Process.Start("Chrome.exe");
          


        }
        static void Start()
        {
            Thread.Sleep(3000); //3초대기
            Console.WriteLine("Start!");
        }
        static void Game() 
        {
            Thread.Sleep(3000); //3초 대기
            Console.WriteLine("Game!");
        }
        static void End()
        {
            Thread.Sleep(3000); // 3초 대기
            Console.WriteLine("End");
        }
    }

}
