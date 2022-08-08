//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace practice
//{
//    class _93_GenericClass
//    {
//        static void Main(string[] args)
//        {
//            // 제네릭 클래스
//            // 클래스 내부의 멤버변수의 데이터 타입을 일반화 한 클래스
//            // 타입에 국한되지 않고 모든 타입을 멤버변수의 타입으로 설정 가능
//            // 제네릭 메서드와 다르게 타입(자료형)을 반드시 지정해야함

//            GenericClass<int> A = new GenericClass<int>();
//            GenericClass<float> B = new GenericClass<float>();
//            GenericClass<string> C = new GenericClass<string>();

//            A.member = 125;
//            B.member = 12.34f;
//            C.member = "유니티";

//            //실습
//            // 제네릭을 이용하여 타입 3개를 사용하는 클래스 만들기

//            Practice<int, int, int> practice = new Practice<int, int, int>();
//            practice.t1 = 3;
//            practice.t2 = 4;
//            practice.t3 = 5;
//            practice.Print();
//        }
//         class Practice<T1, T2, T3>
//        {
//            public T1 t1;
//            public T2 t2;
//            public T3 t3;
//            public void Print()
//            { 
//                Console.WriteLine(t1);
//                Console.WriteLine(t2);
//                Console.WriteLine(t3);
//            }
//        }

//        // 일반 클래스
//        class IntClass
//        {
//            int num;

//        }
//        class FloatClass
//        {
//            float num;
//        }
//        class StringClass
//        {
//            string num;
//        }


//        // 제네릭 클래스
//        public class GenericClass<T>
//        {
//            //T는 클래스 내부 어디서든 사용할 수 있다.
//            public T member;

//            public GenericClass() { }
//            public GenericClass(T t) { }

//        }

//        //타입 2개 제네릭 클래스
//        public class GenericClass2<T1, T2>
//        {
//            public T1 numA;
//            public T2 numB;

//        }
//    }
//}
