using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 대리자(Delegate): 함수 포인터, 메서드 대신 호출, 대리 운전
namespace Delegate
{
    class Delegate
    {
        static void GoForward() => Console.WriteLine("직진");
        delegate void CarDrivet(); // 대리자 형식 생성
        static void Main(string[] args)
        {
            GoForward(); // [1] 내가 직접 운전
            CarDrivet goHome = new CarDrivet(GoForward); // [2] GoFoward 함수를 대신 호출한다.
            goHome.Invoke(); // [3] 대신 호출
            goHome(); // Invoke는 생략 가능
        }
    }
}
