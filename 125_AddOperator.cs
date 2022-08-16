using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeUnity
{
    class _125_AddOperator
    {
        static void Main(string[] args)
        {
            // 연산자 오버로딩
            // 연산자를 재정의하여 사용자 정의 클래스로 사용하는 것
            // 대부분의 기본제공 연산자는 전역함수 또는 클래스로 재정의 가능
            // 오버로드 된 연산자는 함수로 구현

            // 연산자 오버로딩 규칙
            // 기존에 없는 새로운 연산자는 정의 불가(**, %*, #, @ 등등)
            // 단항 연산자 또는 이항 연산자 오버로드 가능
            // 멤버함수로 오버로드 된 연산자의 첫번째 파라미터는 항상
            // 연산자가 호출되는 객체 클래스

            Vector vec1 = new Vector(1, 2, 3);
            Vector vec2 = new Vector(4, 5, 6);

            //vec1 = vec1 + vec2;
            Console.WriteLine(vec1.StringVector());

            //vec1 = vec1 - vec2;
            Console.WriteLine(vec1.StringVector());

            // 실습 
            // 곱하기 연산자 오버로딩 만들기
            // 나누기 연산자 오버로딩 만들기

            //vec1 = vec1 * vec2;
            Console.WriteLine(vec1.StringVector());

            vec1 = vec1 / vec2;
            Console.WriteLine(vec1.StringVector());
      
        }

        class Vector
        {
            public float x, y, z;
            public Vector(float _x, float _y, float _z)
            {
                x = _x; y = _y; z = _z;
            }

  
            public static Vector operator +(Vector v1, Vector v2)
            {
                return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
            }

            public static Vector operator -(Vector v1, Vector v2)
            {
                float _x = v1.x - v2.x;
                float _y = v1.y - v2.y;
                float _z = v1.z - v2.z;

                return new Vector(_x, _y, _z);

            }
            public static Vector operator *(Vector v1, Vector v2)
            {
                return new Vector(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
            }
            public static Vector operator /(Vector v1, Vector v2)
            {
                return new Vector(v1.x / v2.x, v1.y / v2.y, v1.z / v2.z);
            }
            public String StringVector()
            {
                return "x : " + x + ", y : " + y + ", z : " + z;
            }
        }
    }
}
