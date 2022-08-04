using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _56_instance2
    {
        class Product //제품
        {
            public string name;
            public int price;


        }

        static void Main(string[] args)
        {
            //new키워드
            // 객체를 생성하는데 사용하는 연산자
            // 메모리 공간에 객체를 생성
            // c++의 new와 같다.
            Product Gamja = new Product();
            //Product라는 클래스를 사용할 수 있도록
            //new 키워드를 이용하여 메모리에 생성
            //Gamja라는 변수가 참조하게 되어서 객체를 사용

            Gamja.name = "감자";
            Gamja.price = 20_000;
            //인스턴스의 변수를 변경

            Console.WriteLine(Gamja.name + " : " + Gamja.price);

            Product Grape = new Product();
            Grape.name = "포도";
            Grape.price = 15_000;
            Console.WriteLine(Grape.name + " : " + Grape.price);

            Product Goguma = new Product() { name = "고구마", price = 2000 };
            Product Computer = new Product() { name = "컴퓨터", price = 1000 };

            // Product 클래스를 이용하여
            // 사과(Apple), 망고(Mango)객체 만들고 값 넣어보기

            Product Apple = new Product() { name = "사과", price = 20000 };
            Product Mango = new Product() { name = "망고", price = 100000 };

        }
    }
}
