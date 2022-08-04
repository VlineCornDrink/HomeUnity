using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _65_Constructor4
    {
        class Box
        {
            int num;
            //public Box() { }
        }
        class Sphere
        {
            public int radius;
            public Sphere(int _radius)
            {
                radius = _radius;
            }
        }

        static void Main(string[] args)
        {
            //디폴트 생성자
            // 매개변수가 없는 생성자
            // 생성자가 없다면 컴파일러는 자동으로 디폴트 생성자를 만든다.
            // 단, 매개변수가 있는 생성자가 있다면 디폴트 생성자를 만들어야 한다.

            Box box = new Box(); //디폴트 생성자를 만들어서 호출
                                 //Sphere sphere = new Sphere();
                                 //매개변수가 있는 생성자가 있으면 디폴트 생성자를 만들어야함


        }
    }
}
