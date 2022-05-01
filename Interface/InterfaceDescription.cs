using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface // 인터페이스는 최상위 설계목적
{
    public interface ICarStandard // 인터페이스는 I로 시작하는 이름을 해야함.(전세계 표준)
    {
        void left(); // ICarStandard를 상속하는 모든 메서드들은 반드시 left 기능이 있어야 한다.
    }
    abstract class KS
    {
        public abstract void Back(); // back 메서드를 반드시 구현하게 함
    }

    partial class MyCar : KS
    {
        public override void Back() => Console.WriteLine("후진");
        // 반드시 override 표시
    }

    partial class MyCar : KS // partial: 같은 클래스를 나누어서 구현
    {
        public void Right() => Console.WriteLine("우회전");
    }
    sealed class Car : MyCar, ICarStandard
    {
        public void left() => Console.WriteLine("좌회전"); // 강제성이 있는 메서드

        public void Run() => Console.WriteLine("직진");
    }

    //class SpyCar : Car { }

    class InterfaceDescription
    {
        static void Main()
        {
            Car car = new Car();
            car.Run();
            car.Right();
            car.Back();
            //SpyCar spy = new SpyCar(); spy.Run();
        }
    }
}
