using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs14_class_copy
{
    /// <summary>
    /// 객체 지향의 4가지 특징
    /// 1.캡슐화
    ///     - 감추고 싶은 것은 감추고 보여주고 싶은 것만 보여준다
    /// protected 클래스 외부에서는 접근 할 수 없지만, 파생 클래스에서는 접근이 가능
    /// private 클래스 내부에서만 접근 가능
    /// </summary>
    class employ
    {
        private string name;

        public void setname(string name)
        {
            this.name = name; // 매개변수(속성)과 메서드의 매개변수이름이 대소문자까지 완전히 똑같을 때
        }
    }

    class ThisClass
    {
        int a, b, c;

        public ThisClass()
        {
            this.a = 1;
        }
        public ThisClass(int b) : this() // 오버로딩 - 같은 메서드를 여러 개 만드는 것
        {
            this.b = b;
        }

        public ThisClass(int b, int c)
        {
            this.c = c;
        }
    }
    class SomeClass
    {
        public int SomeField1;
        public int SomeField2;


        public SomeClass Deepcopy()
        {
            SomeClass newCopy = new SomeClass();

            newCopy.SomeField1 = this.SomeField1;
            newCopy.SomeField2 = this.SomeField2;

            return newCopy;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("얕은 복사 시작"); // source 랑 target이 쉐어
            //reference를 넘기기 때문에

            SomeClass source = new SomeClass();
            source.SomeField1 = 100;
            source.SomeField2 = 200;

            SomeClass target = source; // source의 내용을 target에 집어 넣는다
            target.SomeField2 = 300;

            Console.WriteLine("s.somefield1 => {0}, s.somefield2 => {1}",
                               source.SomeField1, source.SomeField2);
            Console.WriteLine("t.somefield1 => {0}, t.somefield2 => {1}",
                   target.SomeField1, target.SomeField2);

            Console.WriteLine("깊은 복사");

            SomeClass s = new SomeClass();
            s.SomeField1 = 100;
            s.SomeField2 = 200;

            SomeClass t = s.Deepcopy(); // 깊은 복사
            t.SomeField2 = 300;

            Console.WriteLine("s.somefield1 => {0}, s.somefield2 => {1}",
                   s.SomeField1, s.SomeField2);
            Console.WriteLine("t.somefield1 => {0}, t.somefield2 => {1}",
                   t.SomeField1, t.SomeField2);

        }
    }
}
