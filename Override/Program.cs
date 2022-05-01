using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    class Parent
    {
        public void Say() => Console.WriteLine("부모_안녕하세요.");
        protected void Run() => Console.WriteLine("부모_달리다.");
        protected virtual void Work() => Console.WriteLine("부모_프로그래머");
    }

    class Child : Parent
    {
        public void Say() => Console.WriteLine("자식_안녕하세요");
        public void Run() => Console.WriteLine("자식_달리다.");
        protected override void Work()
        {
            base.Work();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Say();
            //child.Run(); // 부모의 멤버에서 protected이면 자식멤버에서만 사용할 수 있다.
            //child.Work();
        }
    }
}
