using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _53_Var
    {
        static void Main(string[] args)
        {
            //var
            //컴파일러가 자동으로 자료형을 파악하여 변수의 자료형을 지정
            //함수에서만 사용가능
            //선언과 동시에 초기값을 지정해야만함

            var numA = 5;
            //var이라는 키워드는 자동으로 자료형을 파악해준다.
            Console.WriteLine(numA.GetType());
            var numB = 12.34f;
            Console.WriteLine(numB.GetType());

            var numC = "유니티";
            Console.WriteLine(numC.GetType());
            //var 키워드는 한번 자료형이 지정되면 자료형이 바뀌지 않는다.
            // numA = "유니티"; → 안된다.

            //주의사항
            // var에 숫자를 넣을 경우 숫자 뒤에 
            //기호를 붙여 자료형을 명시하는것이 좋다.

            var w = 100;//int형
            var x = 100L;//long형
            var y = 100.0;//double형
            var z = 100.0f;//float형


        }
    }
}
