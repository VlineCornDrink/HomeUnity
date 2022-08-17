//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeUnity
//{
//    class _128_indexer
//    {
//        static void Main(string[] args)
//        {
//            // 인덱서(indexer)
//            // 배열의 특징을 가진 프로퍼티
//            // 클래스, 구조체, 인터페이스 멤버에 접근 가능
//            // 클래스 외부에서는 객체를 배열처럼 이용 가능

//            MyList list = new MyList();
//            list[3] = 5;

//            for (int i = 0; i < list.Length; i++)
//            {
//                list[i] = i;
//            }

//            for (int i = 0; i < list.Length; i++)
//            {
//                Console.WriteLine("array : "+list[i]);
//            }


//            // 실습
//            // 클래스를 새로 하나 만들어서
//            // float형 배열을 접근하는 인덱서 만들기

//            List list2 = new List();
//            for (int i = 0; i < list2.Length; i++)
//            {
//                list2[i] = i + 0.3f;
//                Console.WriteLine(list2[i]);
//            }
//        }
//        class List
//        {
//            private float[] array;

//            public List() { array = new float[3]; }

//            public float this[int index]
//            {
//                get 
//                { 
//                    return array[index];
//                }
//                set 
//                {
//                    array[index] = value; 
//                }
//            }
//            public int Length
//            {
//                get 
//                {
//                    return array.Length;
//                }
//            }
//        }

//        class MyList
//        {
//            private int[] array; 

//            public MyList() { array = new int[5]; }

            
//            // 인덱서
//            public int this[int index]
//            {
//                get  //getter
//                {
//                    return array[index];
//                }
//                set //setter
//                {
//                    array[index] = value;
//                }
//            }

//            public int Length
//            {
//                get
//                {
//                    return array.Length;
//                }
//            }
//        }
//    }
//}
