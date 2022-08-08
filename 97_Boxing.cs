using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _97_Boxing
    {
        static void Main(string[] args)
        {
            // Reference와 value
            // 메모리에는 4영역이 있음
            // Reference 타입은 메모리 영역 중 Heap 영역에 저장
            // value 타입은 메모리 영역 중 stack 영역에 저장
            // 두 영역은 데이터 저장방식이 다름
            // 타입을 변환하기 위해서는 시간이 많이 걸리게 됨

            // Boxing
            // value타입을 reference 타입으로 변환

            // UnBoxing
            // reference타입을 value 타입으로 변환

            // 단순저장보다 Boxing은 약 20배, UnBoxing은 약 4배 시간 소요(오래 걸린다)

            // value 타입 : int float bool 구조체
            // reference 타입 : string, object , class , delegate

            // string형은 문자열을 생성해서 참조하므로 복사처럼 보이게 됨

            int a = 1; //value타입
            object boxing = a;
            // 이때 boxing과정을 거쳐 저장이 됨

            object unboxing = 1; //reference 타입
            int b = (int)unboxing;
            //이때 unboxing과정을 거쳐 저장이 됨

        }
    }
}
