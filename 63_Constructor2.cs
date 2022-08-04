using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _63_Constructor2
    {

        static void Main(string[] args)
        {
            Product productA = new Product(); //기본 생성자가 호출됨(매개변수에 아무값도 안넣어줬기 떄문에)
            productA.Print();

            Product productB = new Product("음", 3); //매개변수가 2개인 생성자가 호출됨
            //괄호가 생성자 호출을 역할(어떤 종류의 생성자를 고를지 선택)
            productB.Print();

            //실습
            // 이름만 값을 넣는 매개변수가 1개인 생성자 1개 만들기
            // Product클래스를 이용하여
            // "컴퓨터",5000 객체 만들기
            // "포도" 객체 만들기
            Product productC = new Product("컴퓨터", 5000);
            Product productD = new Product("포도");

            productC.Print();
            productD.Print();



        }
        class Product
        {
            public string name = "X";
            public int price = 0;
            public Product(string name)
            {
                this.name = name;
            }
            public Product()
            {
                name = "과일";
                price = 10;
            }

            public Product(string _name, int _price)
            {
                //생성자도 오버로딩이 가능
                name = _name;
                price = _price;
            }

            public void Print()
            {
                Console.WriteLine("제품명 : " + name);
                Console.WriteLine("가격 : " + price);
            }

        }
    }
}