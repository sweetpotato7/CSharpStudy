using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
    class AsyncAwaitDescription
    {
        static void Main()
        {
            Task.Run(() => PrintNumberAsync());
        }

        static void PrintNumber() // 동기 방식
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(i + 1);
            }
        }

        static async Task PrintNumberAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 30; i++)
                {
                    Console.WriteLine(i + 1);
                }
            });
        }
    }
}
