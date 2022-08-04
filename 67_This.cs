using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _67_This
    {
        //this
        //나(자신)이라는 뜻
        // this가 속한 클래스를 나타내는 역할
        // this가 속한 클래스를 가리킴

        public string x;

        static void Main(string[] args)
        {
            string str = "d";



            Unity unity = new Unity("Unity");
            unity.PrintStr();
        }
        class Unity
        {
            public string str;
            public Unity(string str)
            {
                this.str = str;
                //멤버변수와 매개변수의 이름이 같다.
                //이때 this키워드를 사용하면 멤버변수에 접근할 수있다.
            }

            public void Print()
            {
                string str = "유니티";
                Console.WriteLine(str);
                Console.WriteLine(this.str);

            }
            public void ThisPrint(Unity unity)
            {
                Console.WriteLine("str : " + unity.str);
            }

            public void PrintStr()
            {
                this.ThisPrint(this); //앞에 있는 this 는 생략 가능
                this.str = "aa"; //여기서도 앞에 있는 this는 생략가능(멤버변수이기 때문에)
            }
        }

    }
}
