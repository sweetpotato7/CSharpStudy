using System;

namespace Event
{
    // 2. 이벤트 게시자
    class Car
    {
        private int _fuelGauge;
        public int FuelGauge
        {
            get { return _fuelGauge; }
            set 
            {
                _fuelGauge = value;
                OnFuelEmptyReached();
            }
        }
        public Car()
        {
            _fuelGauge = 25; // 25%
        }

        public void Go()
        {
            Console.WriteLine("운전");
            FuelGauge -= 5; // 5%
        }

        // 이벤트 만들기
        //public delegate void FuelEmptyNotification();
        //public event FuelEmptyNotification FuelEmptyReached ; // 1. 자동차 클래스에 연료부족 이벤트가 만들어짐.
        public event Action FuelEmptyReached; 
        public void OnFuelEmptyReached()
        {
            Console.WriteLine($"연료 상태: {_fuelGauge}%");
            if (_fuelGauge < 20)
            {
                if (FuelEmptyReached != null)
                {
                    FuelEmptyReached?.Invoke(); // 5. null이 아니면 FuelEmptyReached에 있는 모든 함수를 실행

                } 
            }
        }

    }
}
