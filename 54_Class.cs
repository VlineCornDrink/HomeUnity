using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _54_Class
    {
        static void Main(string[] args)
        {


            Player player = new Player();
            //클래스는 변수선언하면 기본적으로 null값이 들어간다.
            //클래스는 new키워드를 이용해서 클래스를 사용할 수 있는 객체를
            //만들어서 넣어주어야 한다.
            player.name = "유니티";
            player.damage = 10;
            player.defence = 20;
            player.speed = 5;
            player.Print();


            // 실습
            // Monster 라는 클래스를 만든다.
            // Monster에 들어갈 수 있는 인적정보 변수 만들기
            // Main 함수에서 인적정보를 넣고 출력


            Monster monster = new Monster();
            monster.name = "피카츄";
            monster.attack = 11;
            monster.defence = 8;
            monster.speed = 3;
            monster.Print();

        }
        class Monster
        {
            public string name;
            public int attack;
            public int defence;
            public float speed;

            public void Print()
            {
                Console.WriteLine("이름 : " + name);
                Console.WriteLine("공격력 : " + attack);
                Console.WriteLine("방어력 : " + defence);
                Console.WriteLine("이동속도 : " + speed);
            }
        }

        class Player //Class 정의
        {
            public string name;
            public int damage;
            public int defence;
            public float speed;

            public void Print()
            {
                Console.WriteLine("이름 : " + name);
                Console.WriteLine("공격력 : " + damage);
                Console.WriteLine("방어력 : " + defence);
                Console.WriteLine("이동속도 : " + speed);
            }
        }
    }
}

// 절차지향(PP)
// 데이터를 중심으로 함수를 만들어서 사용
// 절차적으로 코드를 구성
// 흐름도 같은 개념

// 절차지향의 장점
// 객체나 클래스를 만들 필요 없이 바로 프로그램 코딩 할 수있다.
// 필요한 기능을 함수로 만들어두기 떄문에 코드를 복사하지 않고 호출하여 사용
// 프로그램 흐름을 쉽게 추적할 수있다.
// 속도가 빠르다

// 절차지향의 단점
// 각 코드의 유기성이 높기 때문에 수정이 어려울 수있다.
// 기존데이터에서 새로운 데이터나 기능을 추가하는게 복잡할 수있다.
// 오류검사가 어렵다
// 코드의 순서가 바뀌면 동일한 결과가 안나올 수 있다.

// 절차지향 언어
// (EX)C언어

// 객체지향(OOP)
// 데이터와 함수들을 묶어서 객체(Class)로 만들어 사용
// 캡슐화, 다형성, 상속성, 추상성 등을 지원
// 데이터 접근 제한 기능

// 객체지향의 장점
// 모듈화,캡슐화로 인하여 유지보수가 용이하다
// 객체지향적이므로 코드를 이해하기 쉽게 만들 수있다.
// 객체는 하나의 프로그램이며 다른 프로그램에서 재사용이 가능하다.

// 객체지향의 단점
// 속도가 느리며 메모리를 많이 사용하는 경향이 있다.
// 이해하기 쉽게 만드는 만큼 설계 과정에서 시간이 소모될 수있다.

// 절차지향과 객체지향
// 객체지향도 절차지향적으로 프로그래밍이 가능
// 객체지향과 절차지향은 프로그래밍 접근방법이 상이할 뿐 정반대 개념은 아님(처음에는 절차지향적으로쓰일수있으나 시간이 지날수록 객체지향적)

// 클래스(Class)
// Reference Type
// 변수와 함수의 묶음
// 클래스 내부에 있는 변수를 멤버변수
// 클래스 내부에 있는 함수를 멤버함수


// 접근지정자
// private : 멤버의 접근 권한을 클래스 내부에서만 허용
// public : 멤버의 접근 권한을 어디서든 사용
// protected : 멤버의 접근 권한을 자식클래스 ,클래스 내부에서만 허용

// 클래스의 4대 속성(외어야 할것)*중요*
// 캡슐화 : 관련있는 데이터와 기능을 묶어서 제공
// 상속성 : 공통된 요소를 자식클래스에게 물려준다.(재사용성 및 생산성 증대)
// 다형성 : 다른 객체가 동일한 메시지를 통해 각기 다른 기능을 수행
// 추상성 : 공통적인 부분, 특정 특성을 분리해 재조합 하는 부분

// 구조체와 클래스의 차이
// 구조체 : value Type / 클래스 : Reference Type