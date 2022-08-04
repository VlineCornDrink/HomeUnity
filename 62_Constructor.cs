using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _62_Constructor
    {
        static void Main(string[] args)
        {
            //생성자(Constructor)
            // 객체를 만들때 자동으로 호출되는 메서드
            // 클래스 이름과 같아야 한다.
            // 접근제한자는 public이어야 한다.
            // private생성자는 기능이 다르다
            // 반환자료형을 작성하지 않는다.(void형도 아니다)

            new Creator(); //객체 생성
            // 객체는 클래스를 사용할 수 있도록 메모리에 할당시킨 것을 의미
            // C#은 가비지컬렉션이 자동으로 메모리해제를 해준다.

            Creator creator = new Creator(); //객체 생성

            // 실습
            // Knight라는 클래스를 만들고
            // 생성자 만들기
            // Main 함수에서 객체 만들기
            Knight x = new Knight();

        }
        class Knight
        {
            public Knight()
            {
                //public int x; → 함수내에서는 접근지정자가 필요x 소멸되기떄문에
                Console.WriteLine("Knight");
            }
        }


        class Creator
        {
            public Creator() //생성자
            {
                //객체가 생성될떄 호출된다.
                Console.WriteLine("인스턴스 생성!");
            }
        }
    }
}
