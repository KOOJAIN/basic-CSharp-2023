using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs15_accessmodifier
{
    class waterheater // class에 기본 접근한정자 internal
    {
        public int temp;

        public void SetTemp(int temp)
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
        public waterheater() { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            waterheater boiler = new waterheater();
            boiler.SetTemp(30);
            Console.WriteLine(boiler.GetTemp()); // .했을 때 안 나오면 public이나 internal이 아니다
            boiler.TurnOnHeater();
        }
    }
}
