using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// key 와 value 는 딕셔너리
namespace number_4_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> rainbows = new Dictionary<string,string>();

            rainbows["Red"] = "빨간색";
            rainbows["Orange"] = "주황색";
            rainbows["Yellow"] = "노란색";
            rainbows["Green"] = "초록색";
            rainbows["Blue"] = "파란색";
            rainbows["Indigo"] = "남색";
            rainbows["Purple"] = "보라색";

            Console.Write("무지개색은 ");
            foreach(var key in rainbows.Keys)
            {
                Console.WriteLine($"{rainbows[key]}");
            }
            Console.WriteLine("입니다");
            Console.WriteLine("Key와 Value 확인");
            Console.WriteLine($"Purple은 {rainbows["Purple"]}입니다");
        }
    }
}
