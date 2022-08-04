using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _29_Switch
    {
        static void Main(string[] args)
        {
            // Switch문 ( 분기문 )

            string input = Console.ReadLine();
            int num = int.Parse(input);

            //switch(값을 판단할 변수)
            switch (num)
            {
                case 5: // num의 값이 5라면
                    Console.WriteLine("num is 5");
                    break; // switch문 종료
                case 7: //num의 값이 7이라면
                    Console.WriteLine("num is 7");
                    break;
                default: // 위에 있는 모든 케이스문이 일치하지 않다면(else기능과 유사)
                    Console.WriteLine("num is not 5,7");
                    break;
            }

            bool isAttack = false;
            //유니티에서는 bool형 변수 앞에 is를 붙인다.
            //연차가 좀 많으신 분들은 bool형 변수 앞에 b를 붙이기도 함

            switch (isAttack)
            {
                case true:
                    Console.WriteLine("공격중");
                    break;

                case false:
                    Console.WriteLine("대기중");
                    break;

                    // 실습
                    //문자열을 입력받아 switch문을 이용하여 입력 받은 문자열을 출력
                    // default를 사용해서 "전부 아닙니다"를 출력

                    Console.Write("문자열을 입력하시오: ");
                    string str = Console.ReadLine();

                    switch (str)
                    {
                        case "hello":
                            Console.WriteLine(str);
                            break;

                        case "bye":
                            Console.WriteLine(str);
                            break;

                        default:
                            Console.WriteLine("전부 아닙니다. ");
                            break;


                    }
            }
        }
    }
