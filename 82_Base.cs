using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _82_Base
    {
        static void Main(string[] args)
        {
            // base
            // 자식클래스에서 부모클래스에 접근해야 하는 경우 사용
            // 부모클래스를 가리키는 키워드
            // 메서드 ,프로퍼티 , 생성자에서만 사용 가능
            // static메서드 사용 불가
            // 부모클래스에서 작성한 코드를 복제할 필요성이 없어짐
            // 변수명 혹은 메서드명이 같다면 구분 가능

            Child child = new Child();
            child.ParentMethod(); //이때 부모의 str변수와 ParentMethod()에는 외부에서 접근 불가

        }
        class Parent
        {
            public string str = "Parent";
            public void ParentMethod()
            {
                Console.WriteLine("부모클래스");
            }
        }
        class Child : Parent
        {
            public string str = "Child";
            public void ParentMethod()
            {
                Console.WriteLine(str);
                Console.WriteLine(base.str);
                Console.WriteLine("자식클래스");

                base.ParentMethod();
            }

        }
    }
}
