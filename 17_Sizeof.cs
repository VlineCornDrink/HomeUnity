using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _17_Sizeof
    {
        static void Main(string[] args)
        {
            //자료형의 크기
            Console.WriteLine(sizeof(bool));  //1byte
            //bool: struct System.Boolean
            Console.WriteLine(sizeof(int)); //4byte
            //int: struct System.Int32
            Console.WriteLine(sizeof(float)); //4byte
            //float: struct System.Single
            //Console.WriteLine(sizeof(string)); // 사용 불가
            //string : class System.String
            // String은 class이므로 자료형이 다르다.

            //sizeof
            //sizeof연산자는 자료형의 크기를 알 수 있다.
            //string은 자료형이 다르므로 사이즈를 알 수 없다.

            int num = 5;
            Console.WriteLine(sizeof(num)); // 변수도 사용 불가


        }
    }
}
