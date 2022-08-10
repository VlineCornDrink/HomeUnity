//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;

//namespace practice
//{
//    class _106_Generic_Dictionary
//    {
//        static void Main(string[] args)
//        {
//            // 딕셔너리
//            // HashTable의 제네릭 컬렉션
//            // C++의 Map과 유사

//            Dictionary<string, int> dic = new Dictionary<string, int>();

//            dic.Add("Attack", 10);
//            dic.Add("Defence", 20);
//            dic.Add("Str", 5);
//            dic.Add("Dex", 8);
//            Console.WriteLine(dic["Attack"]);
//            Console.WriteLine(dic["Defence"]);
//            Console.WriteLine(dic["Str"]);
//            Console.WriteLine(dic["Dex"]);

//            Console.WriteLine();
//            Console.WriteLine();

//            // 실습
//            // 자유롭게 딕셔너리 사용해보기

//            int[] state = new int[4];

//            Dictionary<string, int> di = new Dictionary<string, int>();
//            di.Add("기본 공격력", 20);
//            di.Add("방어력", 30);
//            di.Add("스킬파워", 500);
//            di.Add("마법파워", 1000);

//            state[0] = di["기본 공격력"];
//            state[1] = di["방어력"];
//            state[2] = di["스킬파워"];
//            state[3] = di["마법파워"];



//            Console.WriteLine("기본 공격력 : "+state[0]);
//            Console.WriteLine("방어력 : " + state[1]);
//            Console.WriteLine("스킬파워 : " + state[2]);
//            Console.WriteLine("마법파워 : " + state[3]);

//        }
//    }
//}
