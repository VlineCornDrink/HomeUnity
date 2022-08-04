using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _75_Static
    {
        //캐릭터가 생성될때마다 캐릭터의 갯수를 세고 싶다.
        class CharacterA
        {
            public int cnt = 0;
            //cnt변수는 객체가 생성될때마다 개별적으로 할당 된다.
            public CharacterA() { cnt++; }
        }

        class CharacterB
        {
            public static int cnt = 0; //정적변수
            //정적변수 : 프로그램상에 단 1개만 존재하는 변수
            public CharacterB() { cnt++; }

        }

        static void Main(string[] args)
        {
            // static
            // 변수, 메서드에 사용됨
            // static 키워드를 사용한 변수는 클래스가 메모리에 올라갈 때 자동으로 생성
            // static으로 선언한 멤버는 객체와 관계없이 클래스 자체의 고정 멤버가 된다.
            // 인스턴스(객체)생성 없이 객체 안에 있는 변수와 함수를 사용할 수 있다.
            // 객체를 생성하지 않아도 되므로 편리하고 속도도 빠르다.
            // 클래스명과 함께 호출해야 하며 인스턴스를 생성해 호출 할 수 없게 됨
            // 생성과 함께 프로그램 종료시 소멸된다.

            CharacterA soserise = new CharacterA();
            CharacterA babarian = new CharacterA();
            CharacterA amazon = new CharacterA();

            Console.WriteLine("생성 횟수 : " + soserise.cnt); // 1
            Console.WriteLine("생성 횟수 : " + babarian.cnt); // 1
            Console.WriteLine("생성 횟수 : " + amazon.cnt); // 1
            //cnt 변수는 객체마다 각각 할당되며 생성자도 개별적으로 이루어짐
            //따라서 캐릭터 생성 횟수를 알 수 없다.

            CharacterB assasin = new CharacterB();
            CharacterB druid = new CharacterB();
            CharacterB necromanser = new CharacterB();
            CharacterB Paladin = new CharacterB();
            //캐릭터 클래스의 생성자가 불릴때마다 cnt 의 값이 1씩 늘어난다.

            // 정적변수는 객체에서 접근할 수 없다.
            //Console.WriteLine(druid.cnt);
            Console.WriteLine(CharacterB.cnt);
            // 정적변수는 모든 객체가 공유한다.
            CharacterB.cnt = 10;
            Console.WriteLine(CharacterB.cnt);
            // 정적변수는 모든 객체가 공유하는 변수





        }
    }
}
