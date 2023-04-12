using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace cs28_event
{
    // 이벤트를 사용하려면
    // 1. 대리자를 생성
    delegate void EventHandler(string message);
    class CustomNotifier
    {
        // 2. 이벤트를 준비 ( 대리자를 사용한)
        public event EventHandler SomethingChanged; //delegate는 event와 쌍으로 다님
        public void DoSomething(int number) // 숫자를 넣어 doSomething 처리
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0) // 이값이 됐을때만
            {
                // 3. 특별한 이벤트가 발생활 상황이 되면 이벤트를 수행
                SomethingChanged(string.Format("{0} : even", number)); // 이코드를 처리한다.
            }                                   //이 괄호는 하나의 string
        }
    }
    internal class Program
    {
        // 4. 이벤트가 대신 호출할 메서드
        static void CustomHandler(string message) // 이름은 달라도 되지만 같은 타입 이어야한다.
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            CustomNotifier notifier = new CustomNotifier(); 
            //CustomNotifier가 계속 오류가 떳다.
            //왜그런지 class를 찾아보니까 Notifier라고만 선언이 돼 있었다.
            //CustomNotifier로 수정하니 오류가 해결됐다.
            notifier.SomethingChanged += new EventHandler(CustomHandler);
            
            for ( int i = 0; i <= 30; i++ ) 
            {
                notifier.DoSomething(i);          
            }
        }
    }
}
// EventHandler에 대한 내용이었다. 대리자 내용. wf 비교하여 공부해보자. ~~EventHandler 형식으로 나온다.
// 나머지는 자동 완성돼서 나온다.

// 대리자 - 콜백
// 이벤트 - 객체의 상태 변화나 사건의 발생 통지

//윈폼 쉽지않음을 알수있었다.

// wf는 이벤트 기반(Event Driven) 방식이다. 대리자 이벤트를 호출하고 그다음 뭐징
// 선생님 가라사대 3 4년 사이 직접 이밴트를 만들 일은 없어질 것이다.

// 대리자 이벤트 대리자체인(+=) [wf화면깨졌을때지우던코드들 전부 대리자체인이었습!]
// 이벤트가 깨졌다.? 대리자 체인 지우면 된다!

//다음시간 람다식 안하고싶지만 안할 수 없습....
// 식을 엄청 간단하게 바꾸는것