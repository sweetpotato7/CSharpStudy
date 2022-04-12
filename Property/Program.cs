using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = "My Car";

            // car.Age = "21"; // 읽기 전용이므로 불가
        }
    }
}
