using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _80_Protected
    {
        class Parent
        {
            protected int age;

            private void Private() { }
            // 본인클래스만 접근가능
            protected void Protected() { }
            // 본인과 자식클래스만 접근 가능
            public void Public() { }
            // 본인 포함 어디서든 접근 가능

            public void Test()
            {
                Private();
                Protected();
                Public();
                //본인 클래스는 어떤 접근지정자든 사용 가능
            }
        }
        class Child : Parent
        {
            public void TestChild()
            {
                age = 10; //사용 가능
                //Private(); // private은 사용 불가능
                Protected(); // protected는 사용 가능
                Public(); // public 사용 가능
            }
        }

        static void Main(string[] args)
        {
            // protected
            // 접근제한자(접근지정자)
            // 멤버변수 및 멤버함수의 접근 권한을 
            // 본인클래스 및 자식클래스만 허용

            Parent parent = new Parent();
            parent.Public();//Public만 사용 가능

            Child child = new Child();

            child.Public();
            //외부에서는 public 만 사용 가능하고 protected와 private은 사용 불가


        }

    }
}
