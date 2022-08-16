//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeUnity
//{
//    class _121_Params
//    {
//        static void Main(string[] args)
//        {
//            // params(가변인자 매개변수)
//            // 갯수가 변하는 인자들을 넘길 수 있는 매개변수
//            // 함수의 매개변수의 값을 여러개 넣어줄 때 사용
//            // 인자의 갯수에 제한이 없음
//            // 1차원 배열만 사용 가능
//            // 선언부터 params키워드를 맨 앞에 넣어주어야 함

//            PrintParams(4, 5);
//            PrintParams(1, 2, 3, 4, 5);
//            PrintParams(10, 20, 30, 40, 50, 60, 70);

//            Console.WriteLine();
//            Console.WriteLine();

//            //실습
//            //float형으로 가변인자를 받아 모두 더하는 함수 제작

//            PrintParams2(1.2f, 3.4f);
//            PrintParams2(2, 3f, 3, 4f, 4, 5f);
//            PrintParams2(3, 4f, 4.5f, 5.6f, 6.7f, 7.8f);

//        }

//        static void PrintParams(params int[] item)
//        {
//            int result = 0;
//            for (int i = 0; i < item.Length; i++)
//            {
//                result += item[i];
//            }
//            Console.WriteLine(result);
//        }
//        static void PrintParams2(params float[] item)
//        {
//            float result = 0;
//            for (int i = 0; i < item.Length; i++)
//            {
//                result += item[i];
//            }
//            Console.WriteLine(result);
//        }
//    }
//}
