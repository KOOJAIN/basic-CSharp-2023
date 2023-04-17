using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_5_app
{
    class Boiler
    {
        private int temp;   // 맴버변수

        public int Temperature // 프로퍼티(속성)
        {
            get { return temp; }
            set
            {
                if (value <= 10 || value >= 70)         //value를 언제쓰느냐.
                {
                    temp = 10; // 제일 낮은 온도로 설정\변경
                }
                else
                {
                    temp = value;
                }
            }

        }
        //public void Temperature(int temp)       // get set 메서드 . 한계범위를 지정해준다. public의 단점. 데이터가 오염된다..
        //{
        //    if (temp <= 10 || temp >= 70)
        //    {
        //        this.temp = 10;
        //    }
        //    this.temp = temp;
        //}
        //public int Temperature() { return this.temp; }


        public int Voltage
        {
            get { return Voltage; }
            set
            {
                if (value <= 200 || value >= 300)         //value를 언제쓰느냐.
                {
                    Voltage = 200; // 제일 낮은 온도로 설정\변경
                }
                else
                {
                    Voltage = value;
                }
            }

        }


        public string Brand { get; set; }

        internal void PrintAll()
        {
            Console.WriteLine(kitturami.Brand)
        } 
    }

       

    internal class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 220, Temperature = 45 };
            kitturami.PrintAll();
        }
    }
}
