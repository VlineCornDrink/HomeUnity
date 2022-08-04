using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _84_Sealed
    {
        static void Main(string[] args)
        {
            // Sealed(봉인) Class
            // 클래스가 다른 클래스에 상속되는 것을 원하지 않는 경우
            // 컴파일러가 가상함수 검사를 생략
            // 성능이 조금 향상
        }

        sealed class Test //봉인(다른데에서 상속하는것을 막아줌)
        {
            //sealed키워드가 붙은 클래스는 부모가 될 수 없다.
            // 성능이 쪼금 좋아짐


        }

    }
}
