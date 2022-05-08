using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Async_2
{
    class Program
    {
        // MS에서 더이상 스레드 개념을 쓰지 않고, Task를 사용하는 이유
        static void Main(string[] args)
        {
            var t1 = new Thread(PrintNumber); // 비동기 코드
            t1.Start();

            var t2 = new Thread(PrintStar); // 비동기 코드
            t2.Start();

            // 비동기로 각각 다른 스레드로 실행되기 때문에 번갈아가며 값이 호출된다.
            // 그렇다면 MS는 왜 스레드를 사용하지 않고 Task를 사용하는가?
            // 스레드 클래스는 취소할 수 없다.
            

            PrintNumber();
            PrintStar();

            Console.ReadKey();
        }

        private static void PrintNumber()
        {
            for ( int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void PrintStar()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
