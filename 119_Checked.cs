//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeUnity
//{
//    class _119_Checked
//    {
//        static void Main(string[] args)
//        {
//            // OverFlow(오버플로우)
//            // 데이터 타입이 표현할 수 있는 최대값을 넘어서 최소값이 되는 현상

//            // UnderFlow(언더플로우)
//            // 데이터 타입이 표현할 수 있는 최소값을 넘어서 최대값이 되는 현상

//            byte a=255; //byte 자료형의 표현범위 : 0~255
//            a += 1; //256이 되서 표현할 수 있는 최대값을 넘어서게 된다.
//            Console.WriteLine("a : "+a); //오버플로우

//            a = 0;
//            a -= 1; //-1이 되서 표현할 수 있는 최소값보다 작아지게 된다.
//            Console.WriteLine("a : "+a); //언더플로우

//            // checked
//            // 오버플로우, 언더플로우를 검사하는 키워드
//            // 현상이 일어난 경우 오류 발생

//            byte b;
//            b = 255;
//            //checked
//            //{
//            //    b++;
//            //}
//            b = 0;
//            //checked
//            //{
//            //    b--;
//            //}

//            // unchecked
//            // 오버플로우, 언더플로우가 일어나도 무시하도록 지시하는 키워드

//            byte c = 255;
//            unchecked
//            {
//                c++;
//            }
//            Console.WriteLine("c : "+c);
//            c = 0;
//            unchecked
//            {
//                c--;
//            }
//            Console.WriteLine("c : "+c);

//        }
//    }
//}
