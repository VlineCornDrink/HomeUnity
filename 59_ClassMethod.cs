using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _59_ClassMethod
    {
        // 클래스의 멤버함수 사용
        public class MyMath
        {
            public int Abs(int input)
            {
                if (input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }
            }
        }

        class TestMath
        {
            public int Add(int x, int y)
            {
                return x + y;
            }
        }

        static void Main(string[] args)
        {
            MyMath math = new MyMath();
            int num = math.Abs(-123);
            //멤버변수, 멤버함수에 접근시 .연산자를 사용
            Console.WriteLine(num);

            Console.WriteLine(math.Abs(-54));

            //실습
            // TestMath라는 클래스 제작
            // Add라는 멤버함수로 인자 2개를 받아서 더하는 함수제작
            //Main함수에서 TestMath를 인스턴스한 후 Add함수 사용
            //여기 밑에 식에 public int붙으면 실행이 안된다.?
            int num1 = 3;
            int num2 = 5;
            TestMath tm = new TestMath();
            Console.WriteLine(tm.Add(2, 3));

            Console.WriteLine(tm.Add(num1, num2));
        }
    }
}
