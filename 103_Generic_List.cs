//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace dddd
//{
//    class _103_Generic_List
//    {
//        // 제네릭 컬렉션(Generic Collection)
//        // using System.Collections.Generic; 이게 포함되어있어야함
//        // 컬렉션은 Object타입이므로 boxing, unboxing과정이 일어남
//        // 제네릭 컬렉션은 자료형을 정해주어 boxing, unboxing이 일어나지 않음

//        // 리스트(List)
//        // ArrayList의 제네릭 컬렉션

//        static void Main(string[] args)
//        {
//            List<int> list = new List<int>();
//            list.Add(10);
//            list.Add(20);
//            list.Add(30);
//            list.Add(40);
//            list.Add(50);

//            int result = list[0] + list[1] + list[2] + list[3] + list[4];
//            Console.WriteLine(result);

//            list.Insert(2, 99); //2번째 인덱스에 99의 값 추가
//            //기존에 있던 2번째 인덱스는 하나씩 밀리게 됨
//            //즉 기존에 있던 2번째 인덱스는 3번쨱인덱스로 가게됨

//            list.RemoveAt(1); //1번째 인덱스 값 제거

//            list.Reverse(); //반대로 뒤집음
//            // 첫번째게 마지막으로 가고 두번쨰게 마지막에서 두번쨰로 그런식

//            list.Sort(); //오름차순 정렬

//            foreach (var item in list)
//            {
//                Console.WriteLine(item);
//            }


//            //실습
//            // float형으로 리스트 사용해보기
//            // 내림차순 정렬 해보기
//            List<float> li = new List<float>();

//            li.Add(1.2f);
//            li.Add(2.3f);
//            li.Add(4.5f);
//            li.Add(5.6f);
//            li.Add(3.4f);

//            li.Sort();
//            li.Reverse();
//            foreach (var item in li)
//            {
//                Console.WriteLine(item);
//            }


//        }

//    }
//}
