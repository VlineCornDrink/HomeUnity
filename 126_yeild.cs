//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeUnity
//{
//    class _126_yeild
//    {
//        static void Main(string[] args)
//        {
//            // yield
//            // 호출자에게 컬렉션 데이터를 하나씩 반환할떄 사용
//            // Enumerator(iterator)라 불리는 기능
//            // 집합적인 데이터 셋으로부터 데이터를 하나씩 호출자에게 보내는 역할
//            // yield return :  컬렉션 데이터를 하나씩 반환하는데 사용
//            // yield break : 반환을 중지하고 iteration루프를 빠져나올때 사용

//            // 데이터 양이 커서 모든 데이터를 한꺼번에 반환하는 것보다
//            // 조금씩 반환하는 것이 효율적인 경우 사용

//            foreach (int item in GetNumber())
//            {
//                Console.WriteLine(item);
//            }


//        }

//        static IEnumerable<int> GetNumber()
//        {
//            // 반환자료형이 IEnumerable<int>형인 GetNumber 함수

//            // IEnumerable
//            // 컬렉션에 반복이 필요한 경우 사용되는 인터페이스
//            // 컬렉션은 기본적으로 이미 IEnumerable인터페이스를 가짐
//            // foreach문을 사용하여 컬렉션 요소들을 반복적으로 접근 가능
//            // IEnumerable 인터페이스는 객체를 반환하는
//            // GetEnumerator() 메서드를 가지고 있음
//            // GetEnumerator() 메서드는 컬렉션 요소를 반복적으로 접근할 수 있도록
//            // 해주는 IEnumerable 객체를 반환

//            yield return 10; //첫번쨰 호출시 반환
//            yield return 20; //두번쨰 호출시 반환
//            yield return 30; //3번쨰 호출시 반환
//        }
//    }
//}
