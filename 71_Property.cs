using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _71_Property
    {
        static void Main(string[] args)
        {
            //프로퍼티(Property)
            //Getter 와 Setter의 역할을 함 → 유니티에서는 프로퍼티가 있기에 getter와 setter를 사용하지 않음 / 오히려 언리얼에서 getter,setter를 쓴다.
            //"속성"이라는 뜻을 가지고 있음
            //속성값을 반환하거나 새로운 값을 할당 가능
            // 프로퍼티의 이름은 대문자로 시작

            Person person = new Person();
            person.Age = 10;
            Console.WriteLine(person.Age);

            //실습
            // HandPhone이라는 클래스를 만들기
            // int password 변수 만들기
            // password 변수의 값을 수정하고 읽는 프로퍼티 만들기
            // float price 변수 제작
            // price 변수의 값을 수정하고 읽는 프로퍼티 만들기
            // string name 변수 제작
            // name변수의 값을 수정하고 읽는 프로퍼티 만들기
            //HandPhone 을 객체로 만들어서
            //password, price , name의 값 프로퍼티를 이요하여 변경 및 출력

            HandPhone handphone = new HandPhone();
            handphone.Password = 1234;
            handphone.Price = 12.34f;
            handphone.Name = "김준원";
            Console.WriteLine($"{handphone.Name}의 패스워드 : {handphone.Password} & 가격 : {handphone.Price}");

        }

        class HandPhone
        {
            private int password;
            private float price = 0;
            private string name = "홍길동";

            public int Password
            {
                get { return password; }
                set
                { //이렇게 유효성 검사도 가능
                    if (password >= 0)
                    {
                        password = value;
                    }
                }
            }
            public float Price
            {
                get { return price; }
                set { price = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }

        class Person
        {
            private int age = 15;//Person클래스에서만 읽고 수정 가능 
            public int Age//propery완성 //getter setter를 간단하게
            {
                get { return age; } //property를 이용해 getter 만들기
                set { age = value; }//property를 이용해 setter 만들기
                //value라는 키워드
                //Age를 통해 값이 들어오면
                //그 값이 value에 저장됨
            }
        }
    }
}
