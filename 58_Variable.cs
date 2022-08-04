using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _58_Variable
    {
        //필드(전역)
        // 클래스 내부 ＆ 함수외부
        //클래스 내부에 변수 선언시 전역변수
        //전역변수는 클래스(객체)가 존재하는 한 계속 존재한다.

        int global; //전역변수 이자 멤버변수
        // 전역변수는 기본값(default)이 들어간다.

        //전역변수는 클래스 범위 안에서 어디든 사용이 가능

        double Filed;
        private int x;

        void A()
        {
            double Area;
        }

        static void Main(string[] args)
        {
            _58_Variable v = new _58_Variable();
            Console.WriteLine(v.global);

            // 함수 내부 = 로컬(지역)
            // 함수내부에 변수 선언시 지역변수(로컬변수)
            // 함수 종료시 지역변수도 소멸된다.

            int local = 10;
            Console.WriteLine(local);

            // 실습
            // 전역변수 Filed만들기
            // 함수를 하나 만들어서
            // 지역 변수 Area 만들기

        }
    }
}
