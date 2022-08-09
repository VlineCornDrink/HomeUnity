//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;

//namespace dddd
//{
//    class _99_ArrayList
//    {
//        static void Main(string[] args)
//        {
//            // 컬렉션
//            // 자료구조를 구현한 클래스

//            // ArrayList
//            // 연결리스트
//            // 크기가 유연함
//            // 어디든 데이터를 넣고 빼는게 가능
//            // 빈 공간 없이 유지됨
//            // 컬렉션은 어떤 데이터 형식이든 담을 수 있음
//            // 윗부분에 using System.Collections; 를 적어주어야 함

//            ArrayList list = new ArrayList();

//            // 인덱스에 값 추가
//            list.Add(10); //0번 인덱스
//            list.Add("유니티"); //1번 인덱스
//            list.Add(12.34f); // 2번 인덱스
//            list.Add("아이폰"); // 3번 인덱스
//            list.Add(523); // 4번 인덱스


//            //인덱스 번호의 값 제거\
//            // 제거되면 뒤에 있던 값들은 하나씩 땡겨져서 인덱스 번호가 1씩 줄어든다.
//            list.RemoveAt(1); //"유니티" 제거

//            Console.WriteLine(list[1]); //12.34f

//            Console.WriteLine(list.Count); // list.Count : 요소의 갯수

//            foreach (var item in list)
//            {
//                Console.WriteLine(item);
//            }


//        }
//    }
//}
