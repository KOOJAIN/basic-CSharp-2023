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
                if (value <= 5)         //value를 언제쓰느냐.
                {
                    temp = 5; // 제일 낮은 온도로 설정\변경
                }
                else if (value >= 70)         //value를 언제쓰느냐.
                {
                    temp = 70;
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

        private int volt;
        public int Voltage
        {
            get { return volt; }
            set
            {
                if (value == 110 || value == 220)         //value를 언제쓰느냐.
                {
                    volt = value;
                }

            }
        }


        public string Brand { get; set; }

        internal void PrintAll()
        {
            Console.WriteLine(Brand);
            Console.WriteLine(Voltage);
            Console.WriteLine(Temperature);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 220, Temperature = 90 };
            kitturami.PrintAll();
        }
    }
}
