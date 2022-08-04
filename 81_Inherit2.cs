using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _81_Inherit2
    {
        static void Main(string[] args)
        {
            //상속 생성 순서
            // 부모를 상속받으면 파생클래스는 부모의 변수와 함수를 가진다.
            // 부모클래스의 변수와 함수를 가지게 되는 이유는
            // 컴파일러가 변수와 함수를 자식클래스에게 넣어주기 때문
            // 즉, 자식이 만들어지면 부모도 같이 만들어진다.

            // 생성 순서 : 부모 → 자식
            // 소멸 순서 : 자식 → 부모

            Sword sword = new Sword(); //sword라는 객체 생성 
            // Sword 의 부모클래스인 Weapon 클래스가 먼저생성 
            // 이후 소멸 될때는 Sword클래스가 먼저소멸




        }
        class Weapon
        {
            public Weapon() { Console.WriteLine("무기 생성!"); } //생성자

            ~Weapon() { Console.WriteLine("무기 소멸!"); } //소멸자
        }

        class Sword : Weapon //Weapon 에게 상속받는 Sword 클래스
        {
            public Sword() { Console.WriteLine("소드 생성!"); }
            ~Sword() { Console.WriteLine("소드 소멸!"); }
        }

    }
}
