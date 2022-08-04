using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _51_Split
    {
        static void Main(string[] args)
        {
            string inputA = "Unity Unreal";
            Console.WriteLine(inputA.ToUpper()); // 대문자화
            Console.WriteLine(inputA.ToLower()); // 소문자화

            //문자열 자르기
            string inputB = "공격력 방어력 이동속도";
            string[] result = inputB.Split(new char[] { ' ' });
            //Split : 문자열에 있는 특정 문자를 기준으로 문자를 자름
            //자른 문자열은 배열로 반환
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }

            //실습
            //문자열변수를 만들어서 문자열을 넣어줌
            //문자열들 사이에 "/"를 넣어줌
            //"/"를 기준으로 문자열을 자르고
            // 자른 문자열을 for문을 이용하여 모두 출력

            string inputC = "안녕/하세요/호호호";
            string[] result2 = inputC.Split(new char[] { '/' });
            for (int i = 0; i < result2.Length; i++)
            {
                Console.WriteLine(result2[i]);
            }

            //2차원배열을 선언
            //값을 자유롭게 넣기
            //2중 for문을 이용하여 모든 값출력

            int[,] inputD = new int[2, 3]
            {
                {1,2,3 },
                {4,5,6 }
            };

            for (int i = 0; i <2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("inputD[{0}, {1}] = {2}",i,j,inputD[i,j]);
                }
                Console.WriteLine();
            }

        }
    }
}
