using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeUnity
{
    class Plus_new
    {
        // * new 키워드
        // 메모리에 할당하는 키워드
        // 객체 참조형이면 힙 영역에 할당
        // 값형이면 스택 영역에 할당
        // 단, 클래스 안에있는 값형은 힙 영역에 할당

        static void Main(string[] args)
        {
            // ____________new 키워드의 사용1____________

            int x1 = 10; // 변수 선언 이후 10이라는 값을 초기화 해주면서 스택에 메모리 할당 
            int x2 = new int(); // 스택 영역에 int형 자료형크기만큼의 메모리 할당 (값은 들어가 있지 않으므로 기본값 0)
            Console.WriteLine(x2); 
            int x3; // 변수 선언만 ( 메모리에는 할당 되지X → 할당되지 않은 채로 사용하면 에러 발생 )
                    // 나중에 초기화 해줌으로써 스택영역에 메모리 할당을 해주어야함
                    // 따라서 모든 변수에 선언과 동시에 할당해주기!

            // Console.WriteLine(x3);  → 에러




            // * 구조체에서 선언된 변수와 클래스에서 선언된 변수의 차이 *
            // ※ 구조체는 Value Type
            Struct st1; // 선언만 ( 메모리(스택)에는 할당 X)
                        // 따라서 초기화(메모리할당)해주지 않는다면 사용불가
           
            Struct st2 = new Struct(3, 2);
            // 구조체에서 new 키워드를 이용해 메모리에 할당 해줄수 있다.
            // 이때 생성자를 이용하여야 하는데
            // 기본생성자는 만들 수 없으며
            // 구조체 내에 있는 모든 변수를 초기화 해주어야한다.
            // 단, 이때 주의해야할 점이 Class내부에서 선언된 구조체는 힙영역에 메모리가 할당된다.


            // ※ 클라스는 Reference Type
            Class cl1; // 선언만 ( 메모르(힙)에는 할당X) , 참조하지도 X
            Class cl2 = new Class();
            // 클래스를 사용하기 위해서는 메모리에 할당해주어야 하는데 이때 사용하는 키워드가 new 키워드
            // 그래서 Class를 메모리에 할당해두었기 때문에
            // 클래스 내부에 있는 전역 변수는 초기화(메모리 할당)해주지 않아도 이미 메모리상에 올라가 있기 떄문에
            // 기본값(default값)이 들어가게 된다.



            // ____________new 키워드의 사용2____________
            Class cL = new Class();
            Class cL2 = new BabyClass();
            cL.Print(); // 출력결과 : 부모 함수
            cl2.Print(); // 출력결과 : 부모 함수

            // 정적바인딩 개념과 똑같으나
            // 경고메시지가 뜸 ( new 키워드를 사용하라고 )
            // 의도적으로 숨겼다는 걸 나타내는 수단
            // 이미 메모리에는 올라가있으므로 new 키워드를 통해 의식적으로 숨겨진 메소드라고 나타내는 용도

        }

        struct Struct2
        {
            public int x;
            public int y;
        }

        struct Struct
        {
            public int x; 
            public int y;
            public Struct(int _x, int _y)
            {
                this.x = _x;
                this.y = _y;
            }
        }

        class Class 
        {
            public int x = 10; 
            public int y = 20;
            public Struct st;  // (값)스택 영역에 올라가는 것이 아니라 클라스와 함께 힙영역에 올라간다.
            public Class()
            {
                st.x = 120;
                st.y = 30;
            }
            public void Print()
            {
                Console.WriteLine("부모 함수");
            }

        }
        class BabyClass : Class
        {
            public new int x = 30;
            public new void Print()
            {
                Console.WriteLine("메소드 숨기기");
            }
        }
    }
}
