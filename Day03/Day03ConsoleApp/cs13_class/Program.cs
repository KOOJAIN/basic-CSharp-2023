using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cs13_class
{
    class cat //private라도 cs13_class 안에 있기 때문에 접근 가능
    {
        #region<생성자>
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public cat()
        {
            Name = string.Empty;
            Color = string.Empty;
            Age = 0;
        }

        public cat(string name, string color, sbyte age)
        {
            Name = name;
            Color = color;
            Age = age;
        }
        
        // static은 메소드나 필드가 클래스 자체에 소속되도록 지정하는 한정자



        #endregion
        #region<멤버 변수 - 속성>
        public string Name;// 고양이 이름
        public string Color; // 고양이 색깔
        public sbyte Age; // 고양이 나이 0-255까지
        #endregion

        #region<멤버 메서드 - 기능>
        public void meow()
        {
            Console.WriteLine("{0} - 야옹!!",Name);
        }


        public void run()
        {
            Console.WriteLine("{0} - 달린다!!", Name);
        }
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //private는 가족끼리만 사용 가능
            cat hellokitty = new cat(); // 헬로키티라는 이름의 객체를 생성
            hellokitty.Name = "헬로키티";
            hellokitty.Color = "흰 색";
            hellokitty.Age = 50;
            hellokitty.meow();
            hellokitty.run();

            // 객체를 생성하면서 속성 초기화
            cat nero = new cat()
            {
                Name = "검은 고양이 네로",
                Color = "검은색",
                Age = 27,
            };
            nero.meow();
            nero.run();

            Console.WriteLine("{0}의 색상은 {1} 나이는 {2}세 입니다", hellokitty.Name, hellokitty.Color,hellokitty.Age); 
            Console.WriteLine("{0}의 색상은 {1} 나이는 {2}세 입니다", nero.Name, nero.Color,nero.Age);
        }   
    }
}


// 얕은 복사 , 깊은 복사