using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _64_Constructor3
    {
        class Hidden
        {
            Hidden h = new Hidden();
            //private생성자는 외부에서 객체 생성을 막고
            //내부에서 객체생성하기 위해서 사용
            private Hidden()
            {
                //private 생성자는 인스턴스 생성 불가
                Console.WriteLine("객체 생성 불가");
            }
            public Hidden(int num)
            {

            }
        }

        static void Main(string[] args)
        {
            //Hidden hidden = new Hidden();
            //private생성자는 객체를 생성할 수 없다
            //private생성자는 외부에서 객체 생성을 막을떄 사용
            Hidden hidden1 = new Hidden(1);
            //public생성자는 객체를 생성할 수 있다.


        }
    }
}
