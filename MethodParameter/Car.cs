using System;

namespace MethodParameter
{
    class Car
    {
        public void Map(ref string title) => Console.WriteLine($"{title}"); // ref = 참조
    }
}
