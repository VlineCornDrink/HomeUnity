//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;

//namespace dddd
//{
//    class _102_HashTable
//    {
//        static void Main(string[] args)
//        {
//            // 해시(Hash)
//            // 데이터값을 다른 값으로 1:1대응시키는 것
//            // 1:1대응이란 Key1을 value1에 연결
//            // Key2를 value2에 연결
//            // 키와 데이터를 매핑(연결)

//            // HashTable
//            // 배열, 리스트는 요소에 접근할때 인덱스를 사용
//            // HashTable은 요소에 접근할 때 지정된 키를 사용

//            Hashtable hash = new Hashtable();

//            hash.Add("Apple", 50);
//            // Apple이라는 키(key)로 50의 값(value) 저장
//            Console.WriteLine(hash["Apple"]);
//            // Apple이라는 키에 저장된 값 출력
//            hash.Add(30, "Unity");
//            // 30이라는 키로 Unity라는 값 저장
//            Console.WriteLine(hash[30]);
//            hash.Add("Attack", 30.42f);
//            //Attack이라는 키로 30.42의 값 저장
//            Console.WriteLine(hash["Attack"]);     
//        }
//    }
//}
