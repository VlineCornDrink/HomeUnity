//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeUnity
//{
//    class _118_Nullable
//    {
//        static void Main(string[] args)
//        {
//            // null
//            // 값이 없다는 뜻
//            // 정의되어 있지 않은 값

//            string str1 = "";
//            string str2 = null;
//            // str1은 비어있는 문자열을 가지고 있다.
//            // str2는 값이 없다.
//            Console.WriteLine(str1==str2);
//            // 둘은 같지 않다.

//            // Nullable
//            // int, float, bool인 value타입은 null을 가질수 없다.
//            // nullable 타입으로 변환하면 null을 가질 수 있다.

//            Nullable<int> num2 = null;
//            num2 = 5;
//            num2 = 10;
//            num2 = null;

//            // Nullable 기호
//            int? num = null; //Nullable<int>를 기호로 간단하게 표현한 것
//            bool? isNum = null; //true, false, null
//            isNum = true;
//            isNum = false;
//            isNum = null;

//            float? num3 = null;
//            num3 = 12.34f;
//            num3 = null;

//        }
//    }
//}
