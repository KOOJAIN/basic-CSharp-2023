using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs27_delgatechain
{  
    delegate void ThereIsAFire(string location); // 불났을 때 대신해주는 대리자

    delegate int Calc(int a, int b);

    delegate string Concatenate(string[] args);
    
    class Sample
    {
        private int valueA; // 맴버변수 - 외부에서 접근불가

        //public int ValueA // 프로퍼티
        //{
        //    //get { return valueA; }
        //    //set { valueA = value; }
        //    get => valueA;      // 람다람다!
        //    set => valueA = value;  //람다식이다.!!
        //}
        public int ValueA // 프로퍼티
        {
            get => ValueA; // get은 람다식
            set { ValueA = value; } // set은 일반식 default
            // 일반 default값이랑 람다식 값이랑 병행해서 쓰기도 함
        }
    }
        

    // delegate int Calc(int a, int b); //
    internal class Program
    {
        #region <축소>
        static void Call119(string location)
        {
            Console.WriteLine("소방서죠? {0}에 불 낫어요ㅕ!!", location);
        }

        static void Shoutout(string location)
        {
            Console.WriteLine("여기{0}에 불났어요!!!", location);

        }
        static void Escape(string location)
        {
            Console.WriteLine("여기{0}에서 탈출합니다!!!", location);

        }
        #endregion
        static string ProcConcate(string[] args)
        {
            string result = string.Empty; // == ""; 똑같은 거임
            foreach (string s in args)
            {
                result += s + "/";
            }
            return result;
        }
        // 이 코드를 줄이고자하는게 람다함수입니다
        static void Main(string[] args)
        {
            #region < 대리자체인 영역>
            var loc = "우리집";
            Call119(loc);
            Shoutout(loc);
            Escape(loc);

            //불이 날 수도 있으니 미리 준비하는 것
            var otherloc = "경찰서"; //대리자
            ThereIsAFire fire = new ThereIsAFire(Call119);  //call119 메소드호출
            fire += new ThereIsAFire(Shoutout);// shoutout 추가
            fire += new ThereIsAFire(Escape);// escape 추가 , 대리자에 메서드 추가

            fire(otherloc);

            fire -= new ThereIsAFire(Shoutout); // 대리자에서 메서드를 삭제

            fire("다른집");

            // 익명함수
            Calc plus = delegate (int a, int b) 
            {
                return a + b;
            };

            Console.WriteLine(plus(6, 7));

            Calc minus = delegate (int a, int b) 
            {
                return a - b; // Calc minus = (a, b) => { return a - b; }; 
            };  //람다식으로 한줄로 줄일 수도 있습ㄷㄷ
            Console.WriteLine(minus(67, 9));

            Calc simpleMinus = (a, b)   => a - b;
            //익명함수를 간견하게 쓰겠다는게 람다함수임.
            // -라는 익명함수가 simple한 일을함. 위랑 대조됨.
            #endregion
            Concatenate concat = new Concatenate(ProcConcate);
            var result = concat(args);

            Console.WriteLine(result);

            Console.WriteLine("람다식으로");
            Concatenate concat2 = (arr) =>
            {
                string res = string.Empty; // == ""; 똑같은 거임
                foreach (string s in args)
                {
                    result += s + "/";
                }
                return result;

            };
            Console.WriteLine(concat2(args));
        }
        
    }
}
// 대리자 사용하는 내용은 wf을 위해서 배움. wf을 이벤트를 사용하는 eventeven? 이라고 불리는 이유이다.
// 