using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _92_GenericMethod
    {
        static void Main(string[] args)
        {
            // 일반화
            // 연관성 있는 2개 이상의 개체 집합을 묶어내는 것

            // 제네릭 메서드
            // 데이터 타입(자료형)을 일반화 한 메서드
            // 특정 타입(자료형)에 국한되지 않는다.
            // 모든 타입(자료형)을 매개변수 및 반환형식으로 설정 가능
            // 불필요한 메서드를 반복구현할 필요가 없어짐
            // 코드의 재사용성 증대
            // 타입을 안전하게 처리 가능
            // C++의 템플릿과 유사

            GenericPrint<int>(5);
            GenericPrint<float>(1.11f);
            GenericPrint<string>("테스트!");
            GenericPrint(5);
            GenericPrint(1.11f);
            GenericPrint("테스트!");
            //생략 가능

            GenericPrint2(10, 20);
            GenericPrint2("테스트", "20");
            GenericPrint3(10, 12.34f);
            GenericPrint3("!23", 12.34f);


            //실습
            // Generic을 이용하여 어떤 자료형이든 매개변수 1개로 받아서
            // 그 값을 출력하는 함수 제작

            Print2(123);
        }
        static void Print2<T>(T value)
        {
            Console.WriteLine("입력한 값 : " + value);
        }

        // 일반 메서드의 문제점
        // 자료형을 매개변수로 받는 함수를 여려개 제작
        // 오버로딩을 이용 가능
        // 코드상 문제는 없음
        // 효율성이 낮음
        static void Print(int value)
        {
            Console.WriteLine(value.GetType());
        }
        static void Print(float value)
        {
            Console.WriteLine(value.GetType());
        }
        static void Print(bool value)
        {
            Console.WriteLine(value.GetType());
        }

        // 제네릭 메서드
        static void GenericPrint<T>(T value)
        {
            Console.WriteLine(value.GetType());
            // <T>란?
            // 제네릭 메서드의 데이터 유형을 표시하는 기호
            // 일반적으로 Type의 약자인 T로 작성하며 키워드만 아니면 됨
        }

        static void GenericPrint2<T>(T value1, T value2)
        {
            //T는 자료형 1개의 역할만 한다. 그래서 매개변수 2개모두 같은 자료형으로 사용
            Console.WriteLine(value1.ToString() + value2.ToString());

        }

        static void GenericPrint3<T1, T2>(T1 value1, T2 value2)
        {
            //T1과 T2는 각각 다른 자료형의 역할을 한다. (매개변수 2개 서로다른 자료형으로 사용)
            //몇개든 사용 가능
            Console.WriteLine(value1.ToString() + value2.ToString());
        }

        static Test GenericPrint4<Test>(Test value)
        {
            Test test = value;

            return test;
        } // 반환자료형으로 쓸수도 있다.


    }
}
