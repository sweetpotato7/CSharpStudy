using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Say
    {
        private string message = "반갑습니다."; // 필드
        public void Hi()
        {
            Console.WriteLine(message); 
        }
    }

    public class Car
    {
        private string color = "Red"; // 4.필드는 무조건 private을 사용
        public string GetColor() // 5.private인 color 필드를 쓰기 위해서는 GetColor 메서드를 통해 color를 리턴 받아야 한다.
        {                        // 6.아직 속성을 배우지 않았기 때문에 위와 같은 방법을 사용함
            return color;
        }
    }
    class Program
    {
        private static string message = "안녕하세요."; // 1.필드, 전역변수: 현재 클래스 내에서의 전역변수, 여기 선언하면 다른 함수에서도 가져다 쓸 수 있다.
        public static void Hi() => Console.WriteLine(message);
        static void Main(string[] args)
        {
            int number = 1_234; // 2.변수, 지역 변수
            Console.WriteLine(number);
            Console.WriteLine(message);
            Hi();

            Say say = new Say(); // 3.클래스를 선언 후 사용가능
            say.Hi();

            Car car = new Car();
            //Console.WriteLine(car.color); // 5.보호수준으로 인해 color 필드에 접근할 수 없다.
            Console.WriteLine(car.GetColor());
        }
    }

    public class Person
    {
        private string name = "이효주"; // 7. 필드는 모든 형태로 쓸 수 있음.
        private const int m_age = 21;  // 8. 그리고 필드는 클래스내에서만 쓰이기 때문에 private 이어야 한다.
        private readonly string NickName = "RedPlus"; // 9. 상수는 반드시 선언과 동시에 초기화 하지만
        private string[] wedsites = { "닷넷코리아", "비주얼아카데미" }; // 10.readonly는 생성자에 의해서 초기화 할 수 있다.
    }
}
