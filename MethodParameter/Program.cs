using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "복사"; Console.WriteLine($"{title}");
            var car = new Car(); car.Map(ref title);
            Console.WriteLine($"{title}");
        }
    }
}
