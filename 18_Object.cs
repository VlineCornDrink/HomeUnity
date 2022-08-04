using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _18_Object
    {
        static void Main(string[] args)
        {
            //object
            // 어떤 데이터형식이든 담을 수 있는 자료형
            // C#의 모든 형식은 object를 상속한다.
            // object는 모든 형식의 값을 할당 가능

            object a = 13;
            object b = 12.345f;
            object c = "Unity";
            object d = 'f';

            Monster monster = new Monster();
            Vector vector = new Vector();
            object e = monster; // 클래스도 들어간다.
            object f = vector; // 구조체도 들어간다.

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

        }

        class Monster // 클래스
        {
            int damage;

        }
        struct Vector // 구조체
        {
            int x, y, z;
        }
    }
}
