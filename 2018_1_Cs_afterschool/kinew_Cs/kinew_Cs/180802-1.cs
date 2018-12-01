using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180802_1
    {
        static void ExceptionExample___1(string[] args)
        {
            string[] array = { "가", "나" };
            Console.Write("숫자를 입력하세요 > ");
            /*int input = int.Parse(Console.ReadLine());
            if (input < array.Length) Console.WriteLine("입력한 위치의 값은 " + array[input] + "입니다.");
            else Console.WriteLine("인덱스 범위를 넘었습니다.");*/
            string input = Console.ReadLine();
            try
            {
                int index = int.Parse(input);
                Console.WriteLine("입력 숫자 : " + index);

            }
            catch(Exception exception)
            {
                Console.WriteLine("예외 발생");
                Console.WriteLine(exception.GetType());
                return;
            }
            finally { Console.WriteLine("프로그램이 종료되었습니다."); }
        }
    }
}