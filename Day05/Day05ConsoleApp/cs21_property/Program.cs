using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace cs21_property
{
    class Boiler
    {
        private int temp; // 멤버변수
        public int Temp // 프로퍼티(속성)
        {
            get { return temp; }
            set
            {
                if (value <= 10 || value >= 70)         //value를 언제쓰느냐.
                {
                    temp = 10; // 제일 낮은 온도로 설정\변경
                }
                else { 
                temp = value;
                }
            }
            
        }

        // 위의 get; set과 비교  // 아래의 Get메서드와 Set메서드는 Java에서만 사용, c#은 거의 안씀
        public void SetTemp(int temp)       // get set 메서드 . 한계범위를 지정해준다. public의 단점. 데이터가 오염된다..
        {
            if(temp <= 10 || temp >= 70) 
            {
                //Console.WriteLine("수온설정값이 너무 낮거나 높습니다. 10~70도 사이로 지정해주세요");
                //return;
                this.temp = 10;
            }
            this.temp = temp;
        }

        public int GetTemp() { return this.temp;}
        //public int temp; // 4어? publci를 쓰니 도ㅓㅣ네?
        //int temp;       // 2엓세스 모디파이 안쓰면 private이다.
    }
    class Car
    {
        string name;
        string color;
        int year;
        string fuel;
        int door;
        //string tiretype;
        //string compoany;
        int price;
        string carIdNumber;
        string carPlateNumber;

        // name부터 carPlateNumber까지 드레그 alt enter 그리고 '필드 캡슐화 속성을 사용' 을 누르면 밑에가 나타남
       
        // 여기 아래서부터는 get set property이다.  줄여서 겟셋 집어넣어라~ 는식으로 많이 말한다. property는 개발자들의 일을 덜어주기 위해 사용한다.
        public string Name { get; set; }    // 필터링이 필요없으면 멤버변수 없이 프로퍼티로 대체
        public string Color { get; set; }

        // 들어오는 데이터를 필터링할때는 private 멤버변수와 public 프로퍼티를 둘다 사용
        public int Year
        {
            get => year;        // get { return year;} 람다식?
            set
            {
                if (value <= 1990 || value >= 2023)
                {
                    value = 2023;
                }
                year = value;

            }
        }
            
        public string Fuel { get; set; }
        
        public int Door
        {
            get { return door; }
            set
            {
                if (value != 2 || value != 4)
                {
                }
                door = value;
            }
        }

        public string Tiretype { get; set; }
        public string Compoany { get; set; } = "현대자동차";
        public int Price { get => price; set => price = value; }
        public string CarIdNumber { get; set; }
        public string CarPlateNumber { get; set; }
    }

    interface IProduct
    {
        string PrductName { get; set; }
        void Produce();
    }

 
    internal class Program
    {
        static void Main(string[] args)
        {
            Boiler hot = new Boiler();
            //hot.temp = 60;    //1어? temp가 안되;; 왜지? int temp 접근이 안되네? 3위에가서 public를 써봏ㄹ까?>

            //// ...
            //hot.temp = 300000; // 보일러 온도가 30만도? ㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋ
            //hot.temp = -120;  // 위랑 이줄이랑 부르기를 데이터 오염이라 부른다. 이때 필요한게 get set 메서드다
            hot.SetTemp(50);    
            Console.WriteLine(hot.GetTemp());   // 옛날 방식

            Boiler warm = new Boiler();
            warm.Temp = 5000;
            Console.WriteLine(warm.GetTemp());

            Car ionic = new Car();
            ionic.Name = "아이오닉";        // 위 property에 get;set;이 set이 빠지면 가져오기가 안되고 
            Console.WriteLine(ionic.Name);

            // 생성할 때 프로퍼티로 초기화
            
        }
    }
}
