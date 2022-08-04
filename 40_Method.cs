using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _40_Method
    {
        static void Main(string[] args)
        {
            //메서드(메소드)
            //메서드(Method)는  객체지향 프로그래밍 언어의 함수
            // C C++에서는 함수, C#에서는 메서드라 불린다.
            // 특정용도의 코드들을 한곳에 모아놓은 것
            //메서드의 이름으로 묶어놓은 코드를 편리하게 사용가능
            // Console.WriteLine도 메서드
            // 반환자료형 함수이름()
            // { 코드; }
            // 함수(메서드)안에 함수를 만들 수 없다.
            // 코드를 묶어서 관리?

            //반환자료형
            // void int float string 등등...
            // void : 반환값이 없다는 뜻, return을 사용하지 않는다
            // int float 등등 .. : 해당 자료형의 값을 반환해야 한다.

            // 매개변수
            // 함수 정의시 마지막에 붙는 괄호()안에 
            // 실행 코드에 사용될 특정한 데이터를 받을 수 있다.
            // 매개변수는 없을수도있고 여러개일수도 있다.
            // 호출시 괄호()안에 넣어주는 값을 "인자"라고 한다.

            // 메서드 표기법
            // 메서드의 이름은 파스칼 표기법으로 작성한다
            // 단어의 앞글자를 대문자로 작성하여 단어를 구분한다
            // ex) EnemySpawn( ), GetLocation( ) , SetScale( )

            // static
            // 정적메서드 혹은 정적 변수로 만들어주는 역할
            // Main 함수가 정적메서드로 선언되어 있다.
            // 프로그램 실행될 때 메모리에 자동적으로 생성됨
            // static 메서드 안에는 static메서드만 호출할 수 있다.
            // ex) Main 에서 사용하기 위해서는 static을 붙여줌
            // 멤버함수는 static이 아니어도 사용 가능
            // --추 후 설명 예정--
            Hello();
            Hello();
            Hello();
            Console.WriteLine();
            UnReal();
        }

        static void Hello() // c#에서는 static을 붙여줘야한다.
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Hello!");
            Console.WriteLine("Hello!");
            Console.WriteLine("Hello!");
            Console.WriteLine("Hello!");
            Print("유니티"); //←Print(인자)
        }

        static void Print(string message) //←매개변수
        {
            Console.WriteLine(message);
        }

        // 실습
        // "언리얼"을 출력하는 함수 만들기
        // Main함수에서 호출
        static void UnReal()
        {
            Console.WriteLine("언리얼");
        }

        
    }
}
