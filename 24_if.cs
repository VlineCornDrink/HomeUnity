using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _24_if
    {
        static void Main(string[] args)
        {
            //조건문(if)
            //조건이 참인지 거짓인지에 따라 코드블럭을 실행
            // if (조건)

            int x = 10;
            // 10은 int형 자동형변환이 아닐까..
            //ex)  float a = 0.2f;  , decimal b = 0.3m; f와 mdl라는 접미사를 붙여야 하는이유: 0.2가 기본적으로 더블형이기 때문에
            //  short m = 3; short랑 long은 에러가 안나는데 이유를 잘 모르겠음

            if (x == 10)
            {
                //if옆에 소괄호 안의 조건이 True라면 if문 바로 밑에 있는 중괄호 안에 있는 명령어를 실행
                Console.WriteLine("x는 10입니다. ");
            }

            if (x == 9)
            {
                Console.WriteLine("x는 9입니다. ");
            }

            // 코드블럭(중괄호)가 없는 경우
            int y = 14;
            if (y == 14)
                Console.WriteLine("y는 14입니다.");
            Console.WriteLine("다음줄");
            //if 문 밑에 중괄호가 없다면 if문 밑에 1줄만 if문의 영향을 받게 된다.

            //ㅇㅇ
            if (y == 15) ;
            {
                Console.WriteLine("실행되면 안됨");
            }
            // if문 주의사항
            // if문 조건 옆에 세미콜론(;)을 쓰면 if문이 끝났다는 뜻

            // else if 구문
            // 단독으로 있을 수 없다.
            // 위에 if문이 무조건 있어야 한다.
            // 위에 있는 if문이 거짓일 떄 조건을 만족한다면 코드블럭  실행

            //else 구문
            //단독으로 있을 수 없다
            // 위에 if문 혹은 else if문이 있어야 한다.
            //위에 있는 if문과 else if문이 모두 거짓일 떄 코드블럭 실행

            int a = 10;
            if (a == 12)
            {
                Console.WriteLine("a는 12");
            }
            else if (a == 11) // a는 12가 아니고 a가 11이라면
            {
                //else if문은 위에 있는 if 문이 거짓이어야 조건을 검사함
                Console.WriteLine("a는 11");
            }
            else
            {
                //위에 있는 if문과 else if 문이 모두 거짓인 경우 실행
                Console.WriteLine("a는 11과 12가 아님");
            }

            // 실습1
            // 변수 선언 후 값을 넣어보고 if문을 사용하여 값에 따라 출력문이 나오도록

            float b = 0.1f;

            if (b == 0.1f) // 자료형이 다른 두 수를 비교하면? 실행이 안된다.
            {
                Console.WriteLine("b는 0.1이다.");
            }

            float q = 0.1f;
            bool result = (q == 0.1); // 0.1f 0.1, 0.1d 는 되는데 0.1m은 안됨
            Console.WriteLine(result); // False → 실수형은 float인지 double인지가 비교할 떄 중요 → 접미사 , but deciaml과는 비교 불가능

            long d = 2;
            bool result3 = (d == 2);
            Console.WriteLine(result3); // 정수형과 실수형 비교 가능 // True → 정수형은 기본형 int형이 아니라 short long다 똑같음 

            short e = 3;
            bool result2 = (e == 3);
            Console.WriteLine(result2); // True
            //다른자료형끼리는 비교가 되는건지. 그리고 실수형은 False나오는데 정수형은 true인 이유는? 정수는 int형 실수는 double형이 기본아닌가.
            // 정수형과 실수형은 비교 가능
            //문자형과 숫자형은 비교 불가능 bool형과 숫자형도 비교 불가능. 따라서 각자 형들만 비교 가능하며
            //정수형 실수형은 하나로 숫자형으로 봐야하는거같음

            //실습2
            //정수를 입력받아서 음수인지 양수인지 출력

            Console.Write("정수 입력해: ");
            string input = Console.ReadLine();

            int m = int.Parse(input);
            if (m > 0)
            {
                Console.WriteLine("양수입니다. ");
            }
            else if (m == 0)
            {
                Console.WriteLine("0입니다. ");
            }
            else
            {
                Console.WriteLine("음수입니다. ");
            }





        }
    }
}
