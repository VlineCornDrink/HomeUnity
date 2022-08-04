using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _66_Destructor
    {
        class Destructor
        {
            public Destructor()
            {
                Console.WriteLine("객체 생성!");
            }

            ~Destructor() //소멸자
            {
                Console.WriteLine("객체 소멸!");
            }
          
        }
        class Warrior
        {
            public Warrior()
            {
                Console.WriteLine("객체 생성 완료!");
            }
            ~Warrior()
            {
                Console.WriteLine("객체 파괴 완료!");
            }
        }

        static void Main(string[] args)
        {
            //소멸자(파괴자)
            //객체가 소멸될 때 호출되는 메서드
            //c#은 객체가 더이상 사용되지 않을 것이 확실할 때 객체를 소멸시키게 됨


            //소멸자 작성 규칙
            // 클래스 이름앞에 "~"기호가 붙는다.
            // 접근제한자를 사용하지 않는다.
            //반환자료형을 작성하지 않는다.(void형도 아니다.)
            //매개변수를 사용하지 않는다
            //하나의 클래스에는 하나의 소멸자만 가질 수 있다.

            Destructor A = new Destructor();
            //객체 생성
            //객체가 더이상 사용하지 않을 것이
            //확실하지 않기 때문에 소멸자가 호출 안될 수도 있음

            GC.Collect(); //가비지컬렉션을 즉시실행
            //소멸자가 호출 안되면 사용해보기

            // 실습
            // Warrior 라는 클래스를 만들어서
            // 생성자와 소멸자 만들어보기

            Warrior warrior = new Warrior();
         

        }//함수가 끝나면 객체 소멸 (안될수도있다. 가비지컬렉터가  언제 동작할지, 어떤 순서로 객체를 소멸시킬지 모르기때문) 
    }
}
