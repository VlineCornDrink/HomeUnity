using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _57_instance_init
    {
        class Warrior
        {
            // 멤버변수의 초기값 설정
            public int atk = 10;
            public float speed = 5.5f;
            public string jop = "Warrior";

        }

        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            //클래스 정의시 멤버변수의 초기값을 넣어주면
            //인스턴스 생성과 동시에 초기값이 할당

            Console.WriteLine(warrior.atk);
            Console.WriteLine(warrior.speed);
            Console.WriteLine(warrior.jop);
        }
    }
}
