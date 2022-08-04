using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _27_Even
    {
        static void Main(string[] args)
        {
            //값에 나누기 2를 해서 나머지가 0이면 "짝수"
            //값에 나누기 2를 해서 나머지가 1이면 "홀수"

            //숫자를 입력받아서 짝수인지 홀수인지 출력

            Console.Write("숫자를 입력하시오 : ");
            int input = int.Parse(Console.ReadLine());

            int result = input % 2;
            if (result == 0)  // 처음 작성한 코드 : result == 1 || result ==-1 → 예외적인거(경우의 수가 적은거)를 적으면 코드가 간단해짐
            {
                Console.WriteLine("해당 수는 짝수입니다.");
            }
            else
            {
                Console.WriteLine("해당 수는 홀수입니다.");
            }
            //위와 동일한 코드
            //if(input%2 == 0)
            //{
            //    Console.WriteLine("해당 수는 짝수입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("해당 수는 홀수입니다.");
            //}



        }
    }
}
