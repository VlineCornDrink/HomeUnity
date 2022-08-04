using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _70_GetterSetter
    {
        static void Main(string[] args)
        {
            //캡슐화
            //변수의 은닉성을 보장하고 변수와 함수를 묶어놓는 것
            // 데이터의 유효성 검사를 할 수 있다.

            Box box = new Box();
            box.SetHeight(20);
            box.SetWidth(-30); // 데이터 유효성검사에서 걸러짐
            box.SetWidth(66);
            Console.WriteLine("박스 넓이 : " + box.Area());
            Console.WriteLine("박스 높이 : " + box.GetHeight());
            Console.WriteLine("박스 가로 : " + box.GetWidth());

            int input;
            Money money = new Money();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("넣을 금액을 적으시오 : ");
                input = int.Parse(Console.ReadLine()); // 반복문에 이렇게 변수를 선언해도되나.?
                money.Setmoney(input);
                Console.WriteLine("당신이 현재 보유한 금액은 : " + money.Getmoney());
            }

        }
        class Money // 현재 얼마 들어있고 돈을 넣으면 돈이 달라지는 클래스
        {
            private int money = 0;
            public int Getmoney() => money; //현재 얼마 있는지 반환 Getter
            public void Setmoney(int value) //사용자가 금액을 적으면 쌓이는 Setter
            {
                money += value;
                if (money < 0) { money = 0; } // 돈 금액이 거덜나는 순간 음수는 X 

            }


        }

        class Box
        {
            private int width = 0;
            private int height = 0;
            //private이기 때문에 외부에서 접근 불가

            public int Area() { return width * height; }
            //박스의 넓이를 구하는 함수

            public int GetWidth() { return width; } // getter
            public int GetHeight() { return height; }
            //getter: 외부에서 private변수의 값을 읽어오는 역할

            public void SetWidth(int _width)
            {
                if (_width >= 0) // 데이터의 유효성 검사
                {
                    width = _width;
                }
                else
                {
                    Console.WriteLine("0보다 큰 값 입력 ");
                }

            }
            public void SetHeight(int _height)
            {
                if (_height > 0)
                {
                    height = _height;
                }
                else
                {
                    Console.WriteLine("0보다 큰 값 입력");
                }
            }
            //setter :  외부에서 private변수의 값을 수정하는 역할

        }
    }

}
