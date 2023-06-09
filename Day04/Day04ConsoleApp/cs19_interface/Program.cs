﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs19_interface
{
    interface ILogger       // 인터페이스는 약속이다! 약속 약속. 구현을 안한다! 안한다. 인터페이스는 변수 이런것들(속성)?은 다 가져와 쓸수있다. 
    {
        void WriteLog(string log);  // 메서드 함수의 구현부분이 없습니다. (;으로 끝을내고) 이런 걸 쓸거에요 약속을 합니다.
    }                                   // interface 는 구현! 구현!//// class 는 상속. interface 는 구현

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params object[] args); // args 다중 파라미터
    }
    class ConsolLogger : ILogger        // interface를 상속받는거는 상속이라 안부름. 구현이라 부름. 왜냐하면 새롭개 생성하기에. 구현! 구현!
    {                   // interface를 쓰는 순간 밑줄이 생김 WriteLog를 써야하는데, ConsolLogger에서는 WriteLog를 안씀. 그래서 빨간주ㅡㄹ //
        public void WriteLog(string log)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), log);
        }
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string format, params object[] args)
        {
            string message = string.Format(format, args);
            Console.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
        }

        public void WriteLog(string log)
        {
            Console.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), log);

        }
    }
    class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public void Stop()
        {
            Console.WriteLine("정지");
        }

    }
    interface IHoverable
    {
        void Hover(); // 물에서 달린다
    }

    interface IFlyable
    {
        void Fly(); //날다
    }
    //C#에는 다중상속
    class FlyHoverCar : Car, IFlyable, IHoverable
    {
        public void Fly()
        {
            Console.WriteLine("납니다.");
        }
        public void Hover()
        {
            Console.WriteLine("물에서 달립니다.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsolLogger();        // 변수는 인터페이스를 지정하고 뒤에는 클레스를 ? ....
            logger.WriteLog("안녕~!!!");

            IFormattableLogger logger2 = new ConsoleLogger2();
            logger2.WriteLog("{0} x {1} = {2}", 6, 5, (6 * 5));

        }
    }
}