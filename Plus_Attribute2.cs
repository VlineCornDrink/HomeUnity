using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeUnity
{
    class Plus_Attribute2
    {
        // *호출자 정보 어트리뷰트
        // C# 5.0버전 이상부터 가능
        // 호출자 정보를 매개변수로 받는다.
        // 호출자 이름, 호출자 메소드가 정의되어 있는 소스 파일 경로, 소스코드 행번호를 알수있다.
       
        
        public static void WriteLine(string message,
            [CallerFilePath] string file = "",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = "")
        {
            Console.WriteLine($"{file}(Line : {line}) {member} : {message}");
        }

        static void Main(string[] args)
        {
            WriteLine("C#은 정말 재밌다!");
            // * 결과 *
            // 파일경로 생략(Line : 22) Main : C#은 정말 재밌다!
        }


    }
}
