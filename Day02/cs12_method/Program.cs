using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cs12_method
{
    class calc
    {
        public static int plus(int a, int b)
        {
            return a + b;
        }

        public int minus(int a, int b)
        {
            return a - b;
        }
    }
    internal class Program
    {
        /// <summary>
        /// 실행시 메모리에 최초 올라가야 하기 때문에 static이 되어야 하고
        /// 메서드 이름이 Main이면 실행 될 때 알아서 제일 처음에 시작한다
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region <static 메서드>

            #region<call by reference cs call by value 비교>
            int result = calc.plus(1, 2); 
                // static은 최초 실행 때 메모리에 바로 올라가기 때문에
                // 클래스를 객체를 만들 필요가 없음 like new calc();

                //calc.minus(3,2); // minus는 static이 아니기 때문에 접근불가(객체 생성해야 접근 가능)
                result = new calc().minus(1, 2);
                Console.WriteLine(result);
            #endregion
            #endregion

            int x = 5; int y = 4;
            // ref가 없으면 call by value
            swap(x,y);

            Console.WriteLine("x = {0}, y = {1}", x, y);

            #region<out 매개변수>

            int divid = 30;
            int divor = 2;
            int rem;
            Divide(divid, divor,out result,out rem);
            Console.WriteLine("나누기값{0}, 나머지{1}",result,rem);

            (result, rem) = Divide(20, 6);
            Console.WriteLine("나누기값{0}, 나머지{1}", result, rem);
            //result = Divide(divid,divor);
            //Console.WriteLine(result);

            #endregion


            #region<매개변수>
            Console.WriteLine(sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
            #endregion
        }
        #region<함수 연결해서 하나 처럼>
        static int Divide0(int x, int y)
        {
            return x / y;
        }
        static int Reminder(int x,int y)
        {
            return x % y;
        }

        static void Divide(int x, int y, out int val, out int rem)
        {
            val = x / y;
            rem = x % y;
        }

        static (int result, int rem) Divide(int x,int y)
        {
            return (x / y, x % y);
        }
        #endregion


        public static void swap(int a, int b) {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
        }

        static int val = 100;

        public static ref int GetNumber()
        {
            return ref val; //static 메서드에 접근할 수 있는 변수는 static밖에 없음
        }

        public static int sum(params int[] args) // python 가변길이 매개변수랑 비교
        {
            int sum = 0;

            foreach(var item in args)
            {
                sum += item;
            }
            return sum;
        }
    }
}
