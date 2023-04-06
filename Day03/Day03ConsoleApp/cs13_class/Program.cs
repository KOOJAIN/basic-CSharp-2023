﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs13_class
{
    class cat       // private 이라도 같은 cs13_class 안에 있기때문에 접근 가능
    {
        #region<생성자>
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public cat()
        {
            Name = "무명이";
            Color = string.Empty;
            Age = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="age"></param>
        public cat(string name, string color = "흰색", sbyte age = 1)
        {
            Name = name;
            Color = color;
            Age = age;
        }


        #endregion
        
        #region < 맵버변수 - 속성 >          
        public string Name; // 고양이 이름
        public string Color; // 색상
        public sbyte Age;  // 고양이 나이  sbyte = 0~255 아마 small byte의 약자인듯하다
        #endregion
        #region < 멤버메서드 - 기능 >
        public void Meow()
        {
            Console.WriteLine("{0} - 야옹~!!", Name);     //Name 맴버변수 
        }

        public void Run()
        {
            Console.WriteLine("{0} 달린다", Name);
        }
        #endregion
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            cat helloKitty = new cat(); // helloKitty 라는 이름의 객체를 생성할게
            helloKitty.Name = "헬로키티";
            helloKitty.Color = "흰색";
            helloKitty.Age = 50;
            helloKitty.Meow();
            helloKitty.Run();

            cat nero = new cat() { 
                Name = "검은고양이 네로",
                Color = "검은색",
                Age = 27, 
            };
            nero.Meow();
            nero.Run();

            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세입니다.",
                                 helloKitty.Name, helloKitty.Color, helloKitty.Age);
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세입니다.",
                                 nero.Name, nero.Color, nero.Age);
            // 기본생성자
            cat yaongi = new cat();
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세입니다.",
                                 yaongi.Name, yaongi.Color, yaongi.Age);
            cat norangi = new cat("노랑이", "노란색");
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세입니다.",
                                 norangi.Name, norangi.Color, norangi.Age);
        }
    }
}
//다음으로 배울 것들
// 종료자 (쓰래기값) c++ 이외 언어들은 garbage collector가 있어서 거의 쓸일이 없습
// static 프로그램 전체에 공유하는 변수. 프로그램 실행되는순간 메모리 영역이 싹다 올라가서, 항상 접근가능


//얕은 복사
//깊은 복사