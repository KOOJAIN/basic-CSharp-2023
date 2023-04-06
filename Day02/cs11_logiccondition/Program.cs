using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs11_logiccondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #region, #endregion
            #region <If구문>

            int a = 30;

            if (a == 20) { //처리하는 로직이 있으면 무조건 {} 쓰세요!!
                Console.WriteLine("20입니다");
                Console.WriteLine("두 번째 줄 입니다");
            }
            else
            {
                Console.WriteLine("20이 아닙니다");
            }
            // if (a == 30) return; // 메서드를 완전히 빠져나가는 구문은 한 줄로 써도 된다.

            #endregion

            #region<데이터타입 비교 switch 구문>
            // 데이터 타입 비교 스위치 문(C# 7.0부터 .NET framework 4.7/7.8)
            object obj = null; 
            string inputs = Console.ReadLine(); //콘솔에서 입력
            if (int.TryParse(inputs,out int iouput)) // 예외가 발생하면 0
            {
                obj = iouput; // 입력한 값이 정수라서 문자열을 정수로 변환
            }
            else if(float.TryParse(inputs,out float foutput))
            {
                obj = foutput; // 입력값이 실수라서 문자열을 실수 변환
            }
            else
            {
                obj = inputs; // 이도 저도 아니다
            }

            Console.WriteLine(obj);
            switch(obj)
            {
                case int i: //정수
                    Console.WriteLine("{0}는 int형식입니다");
                    break;
                case float f: //실수 
                    Console.WriteLine("{0}는 int형식입니다");
                    break; 
                case string d:
                    Console.WriteLine("{0}는 int형식입니다");
                    break;
                default:
                    Console.WriteLine("몰라요 무슨 타입인지....");
                    break;
            }

            #endregion

            #region <2중 for문>
            for (int x = 1; x <= 10; x++) 
            {
                for (int y= 1; y < 10; y++)
                {
                    Console.WriteLine("{0}x{1}={2}",x,y,x*y);
                }
            }
            #endregion

            #region<Foreach문>
            int[] ary = { 2, 4, 6, 8, 10 }; //배열이나 컬렉션(리스트)
            foreach (int i in ary)
            {
                Console.WriteLine("{0}*2={1}", i, i*2);
            }

            //ex 위에랑 같음
            for (int i=0; i < ary.Length; i++)
            {
                Console.WriteLine("{0}*2={1}", ary[i], ary[i] * 2);
            }
            #endregion
        }
    }
}
