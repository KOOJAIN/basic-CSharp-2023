using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs26_delegate
{
    // 대리자 사용하겠다는 선언
    delegate int CalcDelegate(int a, int b);

    delegate int Compare(int a, int b); // a, b중 머가 큰지(작은지) 비교 대리자

    #region <대리자 기본>
    class Calc
    {
        public int Plus(int a, int b) // 메서드가 결과를 보여줌
        {
            return a + b;   
        }
        // static 이 붙으면 무조건 실행될때 최초 메모리에 올라감
        // 프로그램 싫생중에는 언제든디 접근가능 // 대신 public만 됨 private 안됨.
        public static int Minus(int a, int b)   // 정적으로 프로그램상에 올라가면 항상 있습
        {
            return a - b;
        }
    }
    #endregion
    internal class Program
    {
        static int AscendCompare(int a, int b)           // Ascend = 오름차순
        {
            if (a > b) return 1;
            else if ( a ==b ) return 0;
            else return -1;
        }

        // 내림차순 비교
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1;
            else if (a ==b ) return 0;
            else return -1;
        }
        
        static void BubbleSort(int[] DataSet, Compare comparer)        // 버블형태 바로 뒤엣거랑 비교? 선택정렬, 픽정렬
            // 버블정렬이든 뭐든간 값을 바꾸는건 똑같음. // 오름차순이 트류면, 폴스면 위 로직이 들어가야함
            // 일이 많아진다  //이전의 코드를 사용하지않고 해당 코드를 바로사용하는법을 알아보자
            // 오름차순 내림차순이 하나의 메소드에서 동작함
                
        {
            int i = 0, j = 0, temp = 0;

            for (i = 0; i < DataSet.Length -1; i++)
            {
                for (j = 0; j < DataSet.Length - (i+1); j++)
                {
                    if (comparer(DataSet[j], DataSet[j+1]) > 0)// 대리자 사용 // (DataSet[j] > DataSet[j + 1]) // 오름차순 
                    {
                        temp = DataSet[j + 1];
                        DataSet[j+1] = DataSet[j];
                        DataSet[j] = temp; // Swap
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            #region < 대리자 기본예>


            // 일반적으로 클래스 사용방식 - 직접호출
            Calc normalCalc = new Calc();
            int x = 10, y = 20;
            int res = normalCalc.Plus(x, y);
            Console.WriteLine(res);

            Console.WriteLine(normalCalc.Plus(x, y));

            res = Calc.Minus(x, y); // res 결과를 돌려받음

            // 대리자를 사용하는 방법 - 대리자 대신실행
            x = 30; y = 20;
            Calc delCalc = new Calc();
            CalcDelegate Callback;

            Callback = new CalcDelegate(delCalc.Plus);      //callback 메소드를 호출하면 calc메소드를 대신 실행
            int res2 = Callback(x, y);       // = Calc.Plus() 대신 호출
            Console.WriteLine(res2); //50

            Callback = new CalcDelegate(Calc.Minus);
            res2 = Callback(x, y); 
            Console.WriteLine(res2);    // 10
            #endregion


            int[] origin = { 4, 7, 8, 2, 9, 1 };

            Console.WriteLine("오름차순 버블정렬");
            BubbleSort(origin, new Compare(AscendCompare));
            //BubbleSort(origin);

            foreach (var item in origin)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();

            Console.WriteLine("내림차순 버블정렬");
            BubbleSort(origin, new Compare(AscendCompare));

            foreach (var item in origin)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
// 대리자 그 코드가 가지고 있는 내용을 대신 호출해준다.
// 대리자가 여러가지 메소드를 호출할 수 있다.// 여러개의 콜백을 동시에 호출에 유용
// 만약 직접 호출해야하면 누락될 수도 있다.
// 그래서 대리자 체인을 사용한다.
// 그럴때 사용하는 연산자가 +=연산자이다.(체인연결) or -=연산자.(체인끊기)