using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _91_MethodHiding
    {
        static void Main(string[] args)
        {
            // 메서드 숨기기
            // 부모클래스 멤버를 숨기기 위해 new키워드 사용
            // 자식클래스가 부모클래스의 메서드를 다시 구현하기 위해 사용
            // 메서드 재정의와 유사

            // 메서드 재정의(Overriding)
            // 부모클래스의 함수를 가상함수로 선언하여 자식클래스에서 재정의
            // 가상함수를 이용하기 때문에 동적바인딩이 된다.

            // 메서드 숨기기(New)
            // 부모클래스에서 함수가 가상함수로 선언되지 않고 다시 구현
            // 동적바인딩이 안된다.
            // new 키워드를 안쓸수도 있으나 안쓰게 되면 "클래스 멤버를 명시적으로 숨기려면 new키워드를 사용해야한다" 는 컴파일러 경고가 표시된다.

            Child child = new Child();
            child.VirtualMethod();
            child.NewMethod();
            Console.WriteLine();
            Console.WriteLine();


            Parent parent = new Child();
            parent.VirtualMethod();
            parent.NewMethod();
            // 숨기기는 동적바인딩이 안되고 재정의는 동적바인딩이 된다.

            //실습
            // 부모클래스, 자식클래스 만들기
            // 각각 재정의함수(가상함수) 숨기기함수 만들기
            // 부모변수에 부모 객체 만들어서 각각 함수 호출
            // 부모변수에 자식객체 만들어서 각각 함수 호출
            Console.WriteLine();
            Console.WriteLine();

            Parent2 parent2 = new Parent2();
            parent2.VirtualMethod();
            parent2.NewMethod();

            Parent2 child2 = new Child2();
            child2.VirtualMethod();
            child2.NewMethod();
        }
        class Parent2
        {
            public virtual void VirtualMethod()
            {
                Console.WriteLine("부 재");
            }
            public void NewMethod()
            {
                Console.WriteLine("부 숨");
            }
        }
        class Child2 :Parent2
        {
            public override void VirtualMethod()
            {
                Console.WriteLine("아 재");
            }
            public new void NewMethod()
            {
                Console.WriteLine("아 숨");
            }
        }

        class Parent
        {
            public virtual void VirtualMethod() //부모클래스에 있는 재정의함수
            {
                Console.WriteLine("부모 재정의");
            }
            public void NewMethod() //부모클래스에 있는 숨기기함수
            {
                Console.WriteLine("부모 숨기기");
            }
        }

        class Child : Parent
        {
            public override void VirtualMethod()
            {
                base.VirtualMethod(); //부모클래스에 있는 virtualmethod함수 호출
                Console.WriteLine("자식 가상함수");
            }
            public new void NewMethod()
            {
                base.NewMethod();
                Console.WriteLine("자식 숨기기");
            }
        }
    }
}
