using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeUnity
{
    class Plus_Memory
    {
        // 메모리 구조
        // (낮은 주소)코드 영역 → 데이터 영역 → 힙 영역 → 스택 영역(높은 주소)

        // * 코드 영역
        // 실행할 프로그램의 소스코드

        // * 데이터 영역
        // 전역변수, static 변수

        // * 힙 영역
        // 사용자의 동적할당 
        // 런타임 때 크기를 할당
        // 관리가 필요한 공간
        // 힙영역에서 사용되지 않는 메모리를 가비지 컬렉터가 정리 
        // 주의! : 클래스를 메모리에 할당하게 되면 클래스 내부에 있는 전역변수도 같이 힙에 할당된다.
        //         예를 들어서 메인함수의 밖에 있는 멤버변수(전역변수)는 데이터영역에 할당

        // * 스택 영역
        // 지역 변수, 매개변수를 저장
        // 컴파일 시점에 크기를 할당
        // 함수를 빠져나가면 자동으로 메모리 해제 → 관리할 필요 없는 공간




        

    }
}
