using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _50_Foreach
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);

            //}

            //foreach
            // 배열에서만 사용 가능한 반복문
            // 배열의 크기만큼 반복
            //반복할 떄마다 인덱스 순서대로 값이 변수에 들어감
            //foreach(자료형 변수명 in 배열명)
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            //실습
            //1차원 배열을 선언후 값 자유롭게
            //foreach를 이용해서 배열의 모든 값 출력

            double[] a = { 4, 5, 6 };

            foreach (double item in a)
            {
                Console.WriteLine(item);

            }

            //2차원 배열 foreach
            int[,] arr2 = new int[4, 3]
            {
                {11, 12, 13 },
                {21,22,23 },
                {31,32,33 },
                {41,42,43 },
            };

            int index = 0;
            foreach (int item in arr2)
            {
                Console.WriteLine("arr[" + index + "] : " + item);
                index++;
            }


        }
    }
}
