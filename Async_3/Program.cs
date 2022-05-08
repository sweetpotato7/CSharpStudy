using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 응용프로그램이 시작됨
            // 시간이 좀 걸리는 작업을 시작
            // 작업이 진행중이라는 메세지를 표시
            // 작업이 끝나면 반환값을 출력

            Console.WriteLine("응용 프로그램이 시작됨"); // 1. 실행

            var task = new Task(DoTasking); // 2. 새로운 Task 실행하겠다 선언만 하고 DoTasking 메서드가 시작되지는 않음.
            task.Start(); // 3. DoTasking 메서드에 진입
            task.Wait(); // 4. DoTasking 메서드를 시작할 즈음에 Wait가 실행됨
            // Wait는 DoTasking 메서드가 끝나기 전에 다음으로 넘어가지 못하게 해줌.

            Console.ReadLine();
        }

        static async void DoTasking()
        {
            var task = Task.Run(() => DelayedTask()); // 5. 시작

            Console.WriteLine("작업이 진행중입니다."); // 7. 비동기 이기 때문에 위 메서드가 끝나기 전에 실행 됨.

            var res = await task; // 8. 5번에서 task 변수에 DelayedTask() 메서드의 반환값이 담길 때 까지 기다려준다.
            Console.WriteLine($"반환값: {res}"); // 11. 값을 반환 받았기 때문에 실행
        }

        static string DelayedTask()
        { // 6. 진입
            var a = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                a += "a";
                Console.WriteLine("a working"); // 9. for문으로 인해 a working이 10번 표시
                System.Threading.Thread.Sleep(100);
            }

            return a; // 10. a값이 반환
        }
    }
}
