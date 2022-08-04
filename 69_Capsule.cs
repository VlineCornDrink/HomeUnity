using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _69_Capsule
    {
        static void Main(string[] args)
        {
            // 캡슐화
            //  필드(변수)와 메서드를 하나로 묶는 과정
            // 변수를 private선언해서 클래스 외부에서 접근할 수 없도록 해줌
            // public으로 선언된 메서드(Getter , Setter)를 통해 클래스 필드(변수)에 접근

            //필드(변수)를 private선언을 하는 이유는 클래스 외부에서 접근을 할 수 없게 해주기 위함
            // Getter와 Setter메서드를 public하는 이유는 <**유효성 검사**>를 통해서 
            // 클래스 외부에서 private으로 선언된 필드로 접근하기 위함

            Box box = new Box();
            //box.width = 10000; //private이라 팀원이 접근할 수 없음
            Console.WriteLine(box.GetWidth());
            //width의 값을 읽을 수 있다.

            box.SetWidth(999999);
            Console.WriteLine(box.GetWidth());

            // 실습
            // GameManager 클래스를 만들어서
            // int money; 변수 만들기
            // money의 getter와 setter를 만들어서 캡슐화 하기

            GameManager gamemanager = new GameManager();
            Console.WriteLine(gamemanager.GetMoney());

            Console.Write("얼마가 있는지 입력하시오 : ");
            int money = Convert.ToInt32(Console.ReadLine());
            gamemanager.SetMoney(money);
            Console.WriteLine("현재 금액 : "+ gamemanager.GetMoney());

            //실습2
            //money의 값이 뺄수는 없고 증가만 할 수 있게 하기
        }
        class GameManager
        {
            private int money = 20_000;
            public int GetMoney()
            {
                return money;
            }
            public void SetMoney(int value)
            {
                if (money <= value)
                {
                    Console.WriteLine(value-money + "원이 추가되었습니다. ");
                    money = value;
                }
                else
                {
                    Console.WriteLine("가방이 가득 찼습니다!");
                }
            }

        }

        class Box
        {
            private int width = 10;
            public int GetWidth() //Getter 앞에 Get을 붙인다.
            { //값을 읽을수만 있는 함수
                return width;
            }
            public void SetWidth(int value) //Setter 앞에 Set을 붙인다.
            { //값을 수정할 수만 있는 함수
                if (value < 200 && value >= 0) //유효성 검사
                { // 0부터 199사이에 값만 width에 넣어줌
                    // 값을 변경하기 전에 데이터의 유효성 검사함
                    width = value;
                }
                else
                {
                    Console.WriteLine("정상 수치를 벗어남");
                }
                
            }
            

        }
    }
}
