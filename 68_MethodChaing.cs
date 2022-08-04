using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _68_MethodChaing
    {
        static void Main(string[] args)
        {
            //디자인패턴
            //사람들이 자주 사용하는 프로그래밍 기법

            //메소드 체이닝 패턴
            // 메소드가 객체를 반환하여 메소드 호출을 이어나가는 패턴
            // 장점: 가독성을 향상시킬 수 있다.
            //       코드 줄 수를 단축시킬 수 있다.

            // 단점: 에러 발생 지점을 찾기 어렵다
            //       구조체의 메소드를 체이닝 할 경우 구조체의 복사가 일어난다.(비효율 코드)


            Box box = new Box();
            box.SetHeight(10.0f).SetWidth(15.5f).Print();//어떠한 순서에서 에러가 낫는지 모름

            //실습
            //Test라는 클래스를 만들어서 "시작"출력 함수, " 준비"출력 함수 , "진행"출력 함수 , "종료"출력 함수
            //각각 만들어서 멤버 메소드 체이닝 패턴을 이용하여 함수를 순서대로 호출

            Test test = new Test();

            test.Start().Ready().Go().End();


        }

        class Int
        {
            int x = 10;
            public int InT() //자료형이 서로다른 함수는 함수의 기능(동작)은 똑같으나 반환하는 값의 자료형만 다른거임.
            {
                Console.WriteLine("Hello");
                return x;
            }
        }

        class Test
        {
            public Test Start()
            {
                Console.WriteLine("시작");
                return this;
            }
            public Test Ready()
            {
                Console.WriteLine("준비");
                return this;
            }
            public Test Go()
            {
                Console.WriteLine("진행");
                return this;
            }
            public Test End()
            {
                Console.WriteLine("종료");
                return this;
            }
        }

        //class Test
        //{
        //    public string start;
        //    public string ready;
        //    public string go;
        //    public string end;

        //    public int x = 10;
        //    public int Print2()
        //    {
        //        Console.WriteLine("hello");
        //        return x;
        //    }
        //    public Test Start()
        //    {
        //        this.start = "시작";
        //        Console.WriteLine("hellosssss"); //반환값이 있다고 명령문을 못적는건 아님. 함수를 호출할때 반환값을 원하면 자료형을 적는거지 그렇다고 명령문 
        //        return this;
        //    }
        //    public Test Ready()
        //    {
        //        this.ready = "준비";
        //        return this;
        //    }
        //    public Test Go()
        //    {
        //        this.go = "진행";
        //        return this;
        //    }
        //    public Test End()
        //    {
        //        this.end = "종료";
        //        return this;
        //    }
        //    public void Print()
        //    {
        //        Console.WriteLine(start);
        //        Console.WriteLine(ready);
        //        Console.WriteLine(go);
        //        Console.WriteLine(end);
        //    }
        //}

        class Box
        {
            private float width; //넓이
            private float height; // 높이

            public Box SetWidth(float _width)
            {
                this.width = _width;
                return this;
            }

            public Box SetHeight(float _height)
            {
                this.height = _height;
                return this;
            }

            public void Print()
            {
                Console.WriteLine("width : " + width);
                Console.WriteLine("height : " + height);
            }

        }
    }

}
