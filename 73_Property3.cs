using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _73_Property3
    {
        static void Main(string[] args)
        {
            // 자동구현 프로퍼티
            // 프로퍼티는 정보은닉을 좀 더 간결하고 간단하게 구현 가능
            // 자동구현 프로퍼티는 컴파일러가 자동으로 private 필드(변수)를 생성
            MyClass myclass = new MyClass();
            myclass.Name = "유니티";
            Console.WriteLine(myclass.Name);

            //실습
            // Vector라는 클래스를 만들어서
            // float x 자동구현 프로퍼티
            // float y 자동구현 프로퍼티
            // float z 자동구현 프로퍼티 만들기
            Vector vector = new Vector();
            vector.X = 5;
            vector.Y = 5;
            vector.Z = 5;
            Console.WriteLine(vector.Width());


        }
        class Vector
        {
            public float X { get; set; } = 10f;
            public float Y { get; set; } = 10f;
            public float Z { get; set; } = 10f;
            public float Width()
            {
                return X * Y * Z;
            }
        }

        class MyClass
        {
            public string Name { get; set; } //private변수도 만들고 getter setter도 만들어준거
            // 이게 자동구현 프로퍼티 , 선언도 안된 변수를 컴파일러가 자동으로 선언해줌

            public int Age { get; } = 15;
            //getter만 있고(읽을수만 있다.) 초기값을 15로 설정

            //주의사항
            public int Cnt
            {
                get { return Cnt; }
                set { Cnt = value; } //여기 Setter에서 문제 생김
                //이유: value 가 Cnt에 들어가면서 무한루프걸림
                //무한루프에 빠지므로 오류 발생

            }
        }
    }
}
