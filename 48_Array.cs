using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _48_Array
    {
        static void Main(string[] args)
        {
            //배열
            //동일한 데이터 타입으로 구성된 데이터 집합
            // 관련정보를 저장하는 변수 여러개를 하나의 이름으로 모아둔 것
            //배열을 구성하는 개별 변수를 요소라고 부름
            // 각 배열의 공간 번호를 Index(인덱스) 라고 부름
            // 배열의 인덱스는 0번부터 시작


            int[] arr1 = new int[5];
            // new : 동적할당(메모리에 공간을 동적으로 할당시켜줌)

            arr1[0] = 10;
            arr1[1] = 20;
            arr1[2] = 30;
            arr1[3] = 40;
            arr1[4] = 50;
            int result = arr1[0] + arr1[1] + arr1[2] + arr1[3] + arr1[4];

            Console.WriteLine(result);

            int[] arr2 = { 11, 22, 33, 44, 55 };
            // 자동으로 공간이 할당되어 값이 들어감

            //실습
            // 크기가 3개인 int형 변수 선언
            // 크기가 7개인 float형 배열 변수 선언

            int[] bro = new int[3] { 1, 2, 3 };
            float[] bro2 = new float[] { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f, 0.6f, 0.7f };

            Console.WriteLine(bro[2]);
            Console.WriteLine(bro2[3]);

            //2차원 배열
            int[,] arr3 = new int[3, 4];
            arr3[0, 0] = 0;
            arr3[0, 1] = 0;
            arr3[0, 2] = 0;
            arr3[0, 3] = 0;
            //int[,] arr3 = new int[행,열]

            int[,] arr4 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //new int[3,2]

            //가변 배열(래기드배열)
            //ㅁㅁㅁㅁㅁ
            //ㅁㅁㅁ
            //ㅁㅁㅁㅁㅁㅁㅁ
            //ㅁㅁㅁㅁ

            int[][] arr5 = new int[3][]; //1차크기는 명시를 해야한다
            arr5[0] = new int[2];
            //ㅁㅁ
            arr5[1] = new int[4];
            //ㅁㅁㅁㅁ
            arr5[2] = new int[7];
            //ㅁㅁㅁㅁㅁㅁㅁ

            //실습
            //2차원 배열과 가변배열을 자유롭게 만들어보기

            string[,] hello = new string[1, 2] { { "s", "b" } };

            string[][] hello2 = new string[1][];

            hello2[0] = new string[3];
            hello2[1] = new string[4];




        }
    }
}
