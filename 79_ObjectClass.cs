using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _79_ObjectClass
    {
        static void Main(string[] args)
        {
            // Object 클래스의 상속
            // 자식클래스를 제외한 모든 클래스는
            // 내부적으로 Object라는 클래스를 상속받는다.
            // Object 클래스에 정의된 기능들은 모든 클래스가 물려받아 사용
            // 예시: ( public class MyClass : System.Object )
            // 위의 예시에서 System.Object가 생략이 되어 있다.

        }
        public class MyClass // 아무것도 상속받은 것 같지 않지만 실제로는(내부적으로는) System.Object에게 상속받고 있다.
        {

        }
        public class MYClass : System.Object
        {

        }
    }
}
