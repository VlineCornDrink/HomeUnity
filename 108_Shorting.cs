//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace practice
//{
//    class _108_Shorting //사용자 정의 자료구조 만들기전 두번쨰 알고리즘 //https://coding-groot.tistory.com/ 
//    {
//        static void Main(string[] args)
//        {
//            // 정렬

//            int[] data = { 3, 2, 1, 5, 4 };//정렬할 데이터
//            int length = data.Length;//데이터의 갯수

//            //오름차순 정렬
//            for (int i = 0; i < length-1; i++) // 최대 갯수-1만큼 반복
//            {
//                for (int j = i+1; j < length; j++)
//                { //j는 i+1(i의 다음)부터 마지막까지 반복
//                    if (data[i] > data[j])
//                    { //현재 값이 다음값보다 크다면
//                        int temp = data[i]; //임시변수에 현재값 넣음
//                        data[i] = data[j]; //현재값에는 다음값을 넣음
//                        data[j] = temp;
//                    }
//                }
//            }

//            for (int i = 0; i < data.Length; i++)
//            {
//                Console.WriteLine(data[i]);
//            }
//            Console.WriteLine();
//            Console.WriteLine();


//            // 실습
//            // 정렬할 데이터 값 float형으로 자유롭게 만들기
//            // 내림차순 정렬

//            float[] dt = { 1.2f, 4.5f, 3.22f, 5.312f, 2.32f };
//            int dtl = dt.Length;
//            for (int i = 0; i < dtl-1; i++)
//            {
//                for (int j = i+1; j < dtl; j++)
//                {
//                    if (dt[i] < dt[j])
//                    {
//                        float temp = dt[i];
//                        dt[i] = dt[j];
//                        dt[j] = temp;
//                    }
//                }
//            }
//            foreach (var item in dt)
//            {
//                Console.WriteLine(item);
//            }







//        }
//    }
//}
