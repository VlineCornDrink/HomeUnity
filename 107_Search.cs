//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace practice
//{
//    class _107_Search //사용자 정의 자료구조 만들기전 첫번쨰 알고리즘
//    {
//        static void Main(string[] args)
//        {
//            // 검색 알고리즘(탐색)
//            // 원하는 값을 찾는 방법
//            // 순차적으로 값을 검색

//            int[] data = { 1, 3, 5, 7, 9 };
//            Console.Write("검색할 값 : ");
//            int search = int.Parse(Console.ReadLine());
//            bool isFlag = false; //찾았다면 true
//            int index = -1; // 찾은 위치

//            for (int i = 0; i < data.Length; i++)
//            {
//                if (search == data[i])
//                {
//                    isFlag = true;
//                    index = i;
//                    if (isFlag)
//                        break;
//                }
//            }

//            if (isFlag)
//            {
//                Console.WriteLine("찾은 값 : " + search);
//                Console.WriteLine("인덱스 : "+index);
//            }
//            else
//            {
//                Console.WriteLine("찾지 못했습니다.");
//            }

//            Console.WriteLine("\n\n\n");
//            //실습
//            //역순으로 검색하는 알고리즘 작성

//            Console.Write("검색할 값 : ");
//            int search2 = int.Parse(Console.ReadLine());
//            bool isFlag2 = false;
//            int index2 = 0;

//            for (int i = data.Length-1; i >=0  ; i--)
//            {
//                if (search2 == data[i])
//                {
//                    isFlag2 = true;
//                    index2 = i;
                   

//                    if (isFlag2)
//                    {
//                        break;
//                    }
                    
//                }

//            }
//            if (isFlag2)
//            {
//                Console.WriteLine("찾은 값 : " + search2);
//                Console.WriteLine("인덱스 : " + index2); //맨 위에서 index2를 할당하지 않으면 왜 실행이 안될까
//            }
//            else
//            {
//                Console.WriteLine("찾지 못했습니다.");
//            }


//        }
//    }
//}
