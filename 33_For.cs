using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace practice
{
    class _33_For
    {
        static void Main(string[] args)
        {
            //for문(반복문)
            // for (초기식; 조건식; 증감식)
            //초기식: 변수선언 및 초기값 지정
            // 조건식: 조건이 True라면 반복, False라면 반복 종료
            // 증감식: 반복할때마다 변수의 값을 증가 혹은 감소
            // TIP: 보통 변수는 i, j, k를 사용
            // 3중 for문은 사용을 자제하는 것이 좋다.

            for (int i = 0; i < 3; i++)
            {
                //for문의 초기식에 선언된 변수는
                //for문 코드블럭 안에서 사용되며
                //for문 종료시 소멸
                Console.WriteLine("Hello" + i);
            }

            //실습
            //for문을 사용하여 "유니티"를 5번 출력

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("유니티");
            }
            //---------------------------------------------
            // for문에서 증감식에 전위연산자나 후위연산자는 상관이 없다.
            //차이가 있다면 전위연산자가 후위연산자보다 컴퓨터가읽는속도가 빠르다는것이다.
            //전위연산자: 값을 올리고 바로 반환
            // 후위 연산자: 일단 반환하고 나중에 값을 반환(나중에 반환하므로 저장할 공간필요)
            //for문 감소식
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("UnitySub" + i);
            }
            //실습
            //for문 감소식을 이용하여 Hello를 5번 출력
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine("Hello");
            }

            //값을 2씩 증가
            for (int i = 0; i < 100; i += 2)
            {
                Console.WriteLine("짝수 : " + i);
            }

            //값을 2씩 감소시켜서 홀수만 출력되도록

            for (int i = 99; i > 0; i -= 2)
            {
                Console.WriteLine("홀수 : " + i);
            }

            //조건식이 없는 경우
            //무한 반복
            //컴퓨터는 매우 빠른속도로 일하기 때문에
            //무한 반복시 종료조건을 만들어주거나
            // 쉴수있는 시간을 만들어 주어야함
            //안만들어 주면 과부하가 오게 됨

            for (int i = 0; ; ++i)
            {
                Console.WriteLine("반복 횟수 : " + i);
                System.Threading.Thread.Sleep(100);//0.1초간 대기
                if (i > 100)
                    break;
                
                //반복문을 종료시키는 명령어

                //2중 for문
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write("< {0} x {1} >", i, j);
                    }
                    Console.WriteLine();
                } // i*j만큼 반복 100번 반복
                //for입력하고 tab2번입력하면 자동완성



            }
        }
    }
