namespace Property
{
    partial class Program
    {
        class Car
        {
            public string Name { get; set; } // 이를 통해 public한 Name 속성으로 외부에 공개됨
            public string Age { get; private set; } = "28"; // 읽는 건 허용되지만 쓰는건 불가(읽기전용)
        }
    }
}
