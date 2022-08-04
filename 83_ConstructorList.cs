using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _83_ConstructorList
    {
        static void Main(string[] args)
        {
            // 생성자 초기화 리스트
            // 생성자 괄호 뒤에 콜론(:)으로 표기
            // 부모클래스의 생성자를 호출하여 
            // 부모의 멤버변수 초기화

            Kia kia = new Kia("기아");


        }
        class Car
        {
            public string name;

            public Car(string _name)
            {
                name = _name;
            }
        }
        class Kia : Car
        {
            public Kia(string _name) : base(_name)
            {
                Console.WriteLine(name);
            }
        }
    }
}
