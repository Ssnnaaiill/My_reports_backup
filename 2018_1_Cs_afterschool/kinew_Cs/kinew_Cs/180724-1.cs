using System;

namespace kinew_Cs
{
    class _180724_1
    {
        static void BasicRules1(string[] args)
        {
            Console.WriteLine(52);          // 정수
            Console.WriteLine(52 + 273);    // 정수 덧셈 연산자
            Console.WriteLine(5 + 3 * 2);   // 연산자 우선순위

            // 나머지 연산자
            Console.WriteLine(10 % 5);
            Console.WriteLine(7 % 3 + "\n");

            // 음수의 연산
            Console.WriteLine(4 % 3);
            Console.WriteLine(-4 % 3);
            Console.WriteLine(4 % -3);
            Console.WriteLine(-4 % -3 + "\n");

            //실수의 연산
            Console.WriteLine(0);
            Console.WriteLine(0.0);
            Console.WriteLine(5.0 % 2.2 + "\n");   // 실수의 나머지 연산자

            //문자열
            Console.WriteLine("test");
            /*예외
            Console.WriteLine("안녕하세요"[100]);*/

            // 문자 덧셈
            Console.WriteLine('가' + '힣' + "\n");

            //bool
            Console.WriteLine(true);
            Console.WriteLine(false + "\n");

            Console.WriteLine('A');
            Console.WriteLine('가');
            Console.WriteLine('나');
            Console.WriteLine('A' + '가' + "\n");

            Console.WriteLine("한빛아카데미");
            Console.WriteLine("한빛\n아카데미");
        }
    }
}