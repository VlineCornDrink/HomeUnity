using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _76_StaticMethod
    {
        class Paladin
        {
            public void NormalPrint()
            {
                //일반 멤버 함수
                Console.WriteLine("일반 메서드");
            }
            public static void StaticPrint()
            {
                //정적 함수(메서드)
                Console.WriteLine("정적 메서드");
            }


        }

        class Druid
        {
            public void Print()
            {
                Console.WriteLine("Hello Druid!");
            }
            public static void StaticPrint()
            {
                Console.WriteLine("Bye Druid! I'm only one");
            }
        }

        static void Main(string[] args)
        {
            //정적메서드(static Method)
            // 일반 메서드와 다르게 객체를 생성하지 않고 호출 가능
            // 메서드 앞에 static 키워드를 붙여 준다.
            // 메서드 내부에는 클래스의 인스턴스 객체 멤버를 참조할 수 없다.
            // static메서드는 객체로부터 호출될 수 없으며 클래스명과 함께 사용해야 한다.

            Paladin paladin = new Paladin();
            paladin.NormalPrint();//객체에서는 일반 메서드 사용 가능
            //paladin.StaticPrint();//객체에서는 정적 메서드 사용 불가능

            Paladin.StaticPrint();
            //정적 메서드는 객체를 생성하지 않고 사용 가능

            // 실습
            // Druid라는 클래스를 만들고
            // 일반메서드와 정적메서드 만들기
            // Main함수에서 각각 호출
            Druid druid = new Druid();
            druid.Print();
            //druid.StaticPrint();// 객체에서 소환 불가능
            Druid.StaticPrint(); //클래스에서 직접 소환
        }

    }
}
