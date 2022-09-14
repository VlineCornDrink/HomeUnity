using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeUnity
{
    class Plus_Attribute
    {
        // * 어트리뷰트(Attribute)
        // 코드에 대한 부가 정보를 기록하고 읽을 수 있는 기능
        // 주석과 유사해보이지만 주석과 달리
        // 컴퓨터도 읽을 수 있음

        // 예를 들어 컴파일러가 경고를 내도록 만들수도 있다.

        // 메타데이터(MetaData)
        // 데이터의 데이터
        // C#코드도 데이터지만, 이 코드에 대한 정보 데이터를 의미
        // 어트리뷰트나 리플렉션을 통해 얻는 정보들도 C#코드의 메타데이터라 할수있다.

        // 사용방법 : [ 어트리뷰트 이름(어트리뷰트 매개변수) ]
        // Obsolete : .Net framework 에서 기본적으로 제공하는 어트리뷰트
        [Obsolete("OldMethod는 오래되었습니다. NewMethod()를 이용하십시오")]
        public static void OldMethod()
        {
            Console.WriteLine("old version...dd");
        }
        public static void NewMethod()
        {
            Console.WriteLine("new version...");
        }
        // Machine()를 사용하는 코드를 둔채 컴파일 하게 된다면
        // "Machine은 동물이 아닙니다. Animal이 동물입니다."라는 경고메시지를 보게끔 설정
        static void Main(string[] args)
        {
            OldMethod();
        }

    }
}
