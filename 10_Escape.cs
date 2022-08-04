using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _10_Escape
    {
        static void Main(string[] args)
        {
            //이스케이프 시퀀스
            //이스케이프(\) 문자로 시작되는 문자열
            //이 문자열은 프로그램 사이에서 특정 명령어를 수행하는 제어문자

            // \n : 한줄 내리기(개행)
            Console.Write("일 \n이 \n삼 \n");
            // \t : 들여쓰기(tap크기만큼 띄어줌)
            Console.WriteLine("일\t이\t삼\t");
            // \' : 작은 따옴표 출력
            Console.WriteLine("일\'이\'삼\'");
            // \" : 큰 따옴표 출력
            Console.WriteLine("일\"이\"삼\"");




        }
    }
}
