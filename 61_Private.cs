using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _61_Private
    {
        //접근제한자(접근 지정자)
        // private : 멤버들을 클래스 내부에서만 접근 가능
        // public : 멤버들을 어디에서든 접근 가능
        // protected : 멤버들을 자식클래스에서만 접근 가능
        // 접근제한자를 작성하지 않는다면 기본적으로는 private

        class MyClass
        {
            int a = 1; //private
            private int b = 2;
            public int c = 3;
            protected int d = 4;

            protected class m
            {

            }

            void A() { Console.WriteLine("a : " + a); }
            private void B() { Console.WriteLine("b : " + b); }
            public void C() { Console.WriteLine("c : " + c); }
            protected void D() { Console.WriteLine("d : " + d); }


        }


        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();

            //myclass.a = 10; //접근 불가
            //myclass.b = 20; //접근 불가
            myclass.c = 30; //접근 가능(public이기 떄문에)
            //myclass.d = 40; //접근 불가

            //myclass.A(); //접근 불가
            //myclass.B(); //접근 불가
            myclass.C(); //접근 가능(public이기 떄문에)
            //myclass.D(); //접근불가

            // 실습
            // protected 접근지정자도 변수와 함수를 만들어서 써보기

        }


    }
}
