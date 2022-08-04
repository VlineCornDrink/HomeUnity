using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _77_StaticClass
    {
        static class MyClass //static class
        {
            static MyClass()
            {
                // static 생성자(정적 생성자)
                // 접근제한자 사용 불가
                // static클래스는 static생성자만 가질 수 있다.
                Console.WriteLine("객체 생성");
            }
            /*int num;*///일반 변수 사용 불가
            public static int num; //정적변수만 사용 가능

            //void Test(); //일반 함수 사용 불가
            public static void Test()
            {
                Console.WriteLine("정적 메서드");
            } // 정적 메서드만 사용 가능
        }

        static void Main(string[] args)
        {
            // static 클래스
            // 모든 멤버를 static멤버로 구성해야 함
            // 생성자에 접근제한자를 사용할 수 없다.
            // 객체를 생성할 수 없다.
            // 생성자에 매개변수를 넣을 수 없다.

            //MyClass myClass = new MyClass(); //정적클래스는 객체 생성 불가

            MyClass.Test(); //객체 생성과 동시에 출력
            MyClass.num = 10; // 
            MyClass.Test(); //객체가 생성되어 있으므로 생성자에 있는 내용이 처음에 한번 출력됨
        }
    }
}
