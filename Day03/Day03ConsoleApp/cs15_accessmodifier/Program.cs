using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs15_accessmodifier
{
    class WaterHeater   // class에 기본 접근한정자 internal
    {
        protected int temp;// protected는 외부에서 접근 불가능 그래서 내부에서 접근할 수 있는데, 상속받은 자식에서 접근 가능함. 그외는 불가능

        public void SetTemp(int temp)       //public 아무데서나 접근가능
        {
            if (temp < -5 || temp > 40)
            {
                Console.WriteLine("범위 이탈");
                return;
            }

            this.temp = temp;
        }

        public int GetTemp()
        {
            return this.temp;
        }

        internal void TurnOnHeater()
        {
            Console.WriteLine("보일러 켭니다 : {0}", temp);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WaterHeater boiler = new WaterHeater();
            boiler.SetTemp(30);
            Console.WriteLine(boiler.GetTemp());
            boiler.TurnOnHeater();
            //boiler.Temp = 39; 보호수준때문에 실행 불가능
        }
    }
}

