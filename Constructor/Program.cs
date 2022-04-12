using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Car
    {
        private string _name; // 3. 필드를 통해 정의
        public Car()
        {
            // 2. 기본 생성자, 생성자 메서드
            Console.WriteLine("자동차 개체를 생성합니다. 조립, 시동걸기");
        }
        public void Go() => Console.WriteLine("달리다.");

        public Car(string name)
        {
            _name = name; // 2. 필드 = 매개변수
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(); // 1. 생성자를 통해서 Car 클래스의 인스턴스를 만들어줌.
            Car my = new Car("좋은 자동차"); // 3. 좋은 자동차가 _name 에 담긴다.
        }
    }
}
