using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs16_inheritance
{
    internal class Program
    {
        class Base // 기반 또는 부모 클래스
        { // 자식 클래스에서 상속 받으려면 private은 안 쓰는 게 좋다
            protected string Name;
            private string Color; // 만약 상속을 할 거면 private를 protected로 변경
            public int Age;

            public Base(string Name, string Color, int Age)
            {
                this.Name = Name;
                this.Color = Color;
                this.Age = Age;
                Console.WriteLine("{0}.Base()",Name);
            }
            public void BaseMethod()
            {
                Console.WriteLine("{0}.BaseMethod()",Name);
            }

            public void GetColor()
            {
                Console.WriteLine("{0}.Base() {1}",Name,Color);
            }
        }
        class Child:Base 
        // 상속 받은 이후 Base의 Name,Color,Age를 새로 만들거나 하지 않음
        // 자식 클래스에서 부모 클래스의 private 사용 불가
        {
            public Child(string Name,string Color, int Age) : base(Name, Color, Age)
            {
                Console.WriteLine("{0}.Child()",Name);
            }
            public void ChildMethod()
            {
                Console.WriteLine("{0}.ChildMethod()", Name);
            }
        }
        static void Main(string[] args)
        {
            Base b = new Base("NameB","White",1);
            b.BaseMethod();

            Child c = new Child("NameC","Black",2);
            c.BaseMethod();
            c.ChildMethod();
            c.GetColor();   // Base.GetColor Black... C에서 Color에 접근불가!
        }
    }
}
