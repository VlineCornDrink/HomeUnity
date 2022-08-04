using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _22_Logical
    {
        static void Main(string[] args)
        {
            //논리연산자 : 참과 거짓을 구분하는 연산자
            //True (참) False(거짓)

            int a = 10, b = 20;
            bool result;

            result = (a == b); // a와 b가 같은지?
            // == : 좌항과 우항의 값이 값다면 True, 다르면 False
            Console.WriteLine("a==b : " + result);

            result = (a != b);
            // != : 좌항과 우항의 값이 다르면 True 같다면 False
            Console.WriteLine("a!=b : " + result);

            result = (a > b);
            // > : 좌항이 우항보다 크다면 True 작거나 같다면 False
            Console.WriteLine("a>b : " + result);

            result = (a < b);
            // > : 우항이 좌항보다 크다면 True 작거나 같다면 False
            Console.WriteLine("a<b : " + result);

            result = (a >= b);
            // >= : 좌항이 우항보다 크거나 같다면 True 작다면 False
            Console.WriteLine("a>=b : " + result);


            result = (a <= b);
            // >= : 우항이 좌항보다 크거나 같다면 True 작다면 False
            Console.WriteLine("a<=b : " + result);

            result = (a == 10 && b != 20);
            // && 그리고(AND)
            // && : 좌항과 우항이 True라면 True
            // 1개라도 False라면 False
            // 2개 모두 False 라면 False
            Console.WriteLine("&& : " + result);

            result = (a < 12 || b > 12);
            // || 또는(OR)
            // || : 좌항과 우항 1개라도 True라면 True
            // 좌항과 우항 모두 False 일때만 False 
            Console.WriteLine("|| : " + result);

            result = !(a == 10); // ! : Not
            // ! : True라면 False를 반환 False라면 True를 반환
            Console.WriteLine(" !(a == 10) : " + result);

            // && : 그리고(AND)
            Console.WriteLine(" true && true : " + (true && true)); //true
            Console.WriteLine(" true && false : " + (true && false)); //false
            Console.WriteLine(" false && true : " + (false && true));//false
            Console.WriteLine(" false && false : " + (false && false));//false

            // || : 또는(OR)
            Console.WriteLine(" true ||  true : " + (true || true)); //true
            Console.WriteLine(" true ||  false : " + (true || false)); //true
            Console.WriteLine(" false ||  true : " + (false || true));//true
            Console.WriteLine(" false || false : " + (false || false));//false

            // ! : Not
            Console.WriteLine("!true : " + !true);//false
            Console.WriteLine("!false : " + !false);//true

        }
    }
}
