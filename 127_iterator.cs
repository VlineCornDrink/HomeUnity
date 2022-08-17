//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeUnity
//{
//    class _127_iterator
//    {
//        static void Main(string[] args)
//        {
//            // 반복기(iterator)
//            // 배열과 컬렉션 형태의 데이터를 단계별로 실행하는데 사용
//            // 반복기를 구현하는 경우 IEnumerable(인터페이스)와 yield 키워드 사용

//            foreach (var item in Data())
//            {
//                Console.WriteLine(item);
//            }
//        }

//        static IEnumerable<string> Data()
//        {
//            yield return "Hello";
//            yield return "World";
//            yield return "!!";
//        }
//    }
//}
