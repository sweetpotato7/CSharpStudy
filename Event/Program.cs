using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Event
{
    // 3, 이벤트 구독자
    class EventAndDelegate
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.FuelEmptyReached += Car_FuelEmptyReached; // 6. 출력값은 FuelEmptyReached에 왼쪽과 같이 등록된게 있다.
            car.FuelEmptyReached -= Car_FuelEmptyReached;
            car.FuelEmptyReached += () =>
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("연료부족!!!");
                Console.ResetColor();
            };
            car.Go();
            //car.OnFuelEmptyReached();
            car.Go();
        }

        // 4. 이벤트 처리기(핸들러): Handler
        private static void Car_FuelEmptyReached()
        {
            Console.WriteLine("연료 부족");
        }
    }
}

// 이는 폼, 이벤트기반 환경에서 사용됨.
// 어떤 이벤트의 어떤 처리(클릭, 로드 등)

