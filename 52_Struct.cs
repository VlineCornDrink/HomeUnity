using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _52_Struct
    {
        struct Person //구조체 정의(기능을 만들어준다.)
        {
            // public : 변수와 함수를 어디서든 사용하겠다는 뜻
            public string name;
            public int age;
            public string hobby;

            public void Print()
            {
                Console.WriteLine("이름 : " + name);
                Console.WriteLine("나이 : " + age);
                Console.WriteLine("취미 : " + hobby);

            }
        }
        struct Vector
        {
            public float x;
            public float y;
            public float z;


        }
        static void Main(string[] args)
        {
            //구조체
            //변수와 함수의 모음
            //value타입
            //주로 간단한 데이터를 저장하는 용도로 사용

            Person personA; // 구조체 변수 선언(사용하겠다!)
            personA.name = "홍길동";
            personA.age = 20;
            personA.hobby = "Unity";
            personA.Print();

            Person personB;
            personB.name = "알라딘";
            personB.age = 30;
            personB.hobby = "Unreal";
            personB.Print();

            //실습
            //Person 구조체를 이용하여
            // 이름 : 유희왕
            //나이: 15
            //취미: 카드게임
            //인적정보를 저장하고 출력
            //변수명은 personC

            Person personC;
            personC.name = "유희왕";
            personC.age = 15;
            personC.hobby = "카드 게임";
            personC.Print();

            //실습2
            //Vector 라는 구조체를 만들어 float 형 x,y,z 변수 선언
            // Main 함수에서 x,y,z에 값을 넣어보고 출력
            Vector vector;
            vector.x = 1.2f;
            vector.y = 2.3f;
            vector.z = 4.5f;
            Console.WriteLine(vector.x);
            Console.WriteLine(vector.y);
            Console.WriteLine(vector.z);

        }
    }
}
