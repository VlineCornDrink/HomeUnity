using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _60_ClassStruct
    {
        static void Main(string[] args)
        {
            // 구조체
            // 구조체는 Value 타입으로 복사방식으로 동작
            // 상속성이 없음


            // 클래스
            // 클래스는 Reference 타입으로 참조방식으로 동작
            // 상속성이 있음


            Mage mageA;
            Mage mageB;

            mageA.hp = 10;
            mageA.atk = 42;
            mageB = mageA;
            //구조체는 value타입으로 복사가 이루어짐.

            mageB.Print();
            mageA.atk = 50;
            mageB.Print();

            Knight knightA = new Knight();
            Knight knightB = knightA;
            //클래스는 reference타입이기 때문에 참조가 이루어짐.
            knightA.hp = 13;
            knightA.atk = 66;
            //A의 값을 바꾸면
            
            knightB.Print();
            //B의 값도 바뀐다.
            knightA.atk = 100;
            knightB.Print();
            knightB.hp = 15;
            knightA.Print();

            //실습
            //Vector라는 구조체를 만들어서
            //float형으로 x,y,z변수를 만들기
            //복사 확인해보기

            //GameObject라는 클래스를 만들어서
            //float형으로 x,y,z변수 만들기
            //참조 확인해보기

            Vector vectorA = new Vector();
            vectorA.x = 1;
            vectorA.y = 2;
            vectorA.z = 3;

            Vector vectorB = vectorA;
            vectorB.x = 4;
            vectorA.Print(); // 1 , 2, 3
            vectorB.Print(); // 4 ,2 ,3

    


        }
        struct Vector
        {
            public float x, y, z;
            public void Print()
            {
                Console.WriteLine($"{x} , {y} , {z} ");
            }
        }
        class GameObject
        {
            public float x, y, z;
            public void Print()
            {
                Console.WriteLine($"{x} , {y} , {z} ");
            }
        }

        struct Mage
        {
            public int hp;
            public int atk;
            public void Print()
            {
                Console.WriteLine("Mage Hp : "+hp);
                Console.WriteLine("Mage Atk : " + atk);

            }
        }

        class Knight
        {
            public int hp;
            public int atk;
            public void Print()
            {
                Console.WriteLine("Knight Hp : " + hp);
                Console.WriteLine("Knight Atk : " + atk);

            }
        }
    }
}
