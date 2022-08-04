using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _74_DoubleClass
    {
        static void Main(string[] args)
        {
            // 중첩클래스
            // 클래스 내부에서 클래스를 정의
            // 클래스를 그룹화 할 수 있으며 클래스 사용범위 제한 가능
            // 유지관리 용이
            // 클래스의 구조 단순화
            OutClass outClass = new OutClass();
            outClass.OutDisplay();
            OutClass.InClass inClass = new OutClass.InClass();
            inClass.InDisplay();

        }
        public class OutClass
        {
            public void OutDisplay()
            {
                Console.WriteLine("Out!");
            }

            public class InClass
            {
                public void InDisplay()
                {
                    Console.WriteLine("In!");
                }
            }
        }
    }
}
