using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _21_Increment
    {
        //Incerment
        //:증감 연산자
        static void Main(string[] args)
        {
            int num = 5;
            num++;//num += 1;
            //num의 값을 1증가시킨다.
            Console.WriteLine(num);

            num--;
            //num의 값을 1감소시킨다.
            Console.WriteLine(num);

            //전위 증가
            int a = 10;
            Console.WriteLine("a : " + (++a)); //11
            Console.WriteLine("a : " + a); //11
                                           //++기호를 변수 앞에다 붙이면 선 증가 후 연산
                                           //값을 1증가시킨 후 코드를 연산

            //후위 증가
            int b = 10;
            Console.WriteLine("a : " + (b++)); //10
            Console.WriteLine("a : " + b); //11
            //++기호를 변수 뒤에다 붙이면 선 연산 후 증가
            // 코드를 연산(실행)후 값을 1증가

            //전위감소
            int c = 10;
            Console.WriteLine("c : " + (--c)); //9
            Console.WriteLine("c : " + c); //9
                                           //선 감소 후 연산
                                           //값을 1 감소시킨 후 코드를 연산(실행)

            //후위감소
            int d = 10;
            Console.WriteLine("c : " + (d--)); //10
            Console.WriteLine("c : " + d); //9
            //선 연산 후 감소
            //코드를 연산(실행) 후 값을 1 감소

            // 실습
            int num1 = 10;
            //증감연산자를 이용하여 num을 13으로 만들기

            num1++;
            num1++;
            num1++;
            Console.WriteLine("num : " + num1);

        }
    }
}
