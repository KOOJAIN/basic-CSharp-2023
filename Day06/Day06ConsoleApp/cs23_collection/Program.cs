using cs23_collection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace cs23_collection
{
    #region <일반화시키기>
    class CustomEnumerator : IEnumerable // foreach 를 쓸 수 있는 객체로 만들래
    {
        int[] list = {1, 3, 5, 7, 9 };

        public IEnumerator GetEnumerator()
        {
            yield return list[0]; // 메서드를 빠져나가지 않음 / 값만 돌려줌. yield return의 특징
            yield return list[1];   // return 과 달리 보내주고 멈춰있ㅡㅅㅂ
            yield return list[2];
            yield return list[3];
            //yield break;
            yield return list[4];
        }
    }
    class MyArrayList : IEnumerator, IEnumerable
    {
        int[] array;    // 배열값 집어넣는곳
        int position = -1; // 인덱스

        public MyArrayList()
        {
            this.array = new int[3]; // 기본크기 3으로 초기화
        }

        // 인덱서 프로포티
        public int this[int index]
        {
            get { return this.array[index]; }
            set
            {
                if (index >= this.array.Length)
                {
                    Array.Resize<int>(ref array, index +1);
                    Console.WriteLine("MyArrayList Resize : {0}", array.Length);
                }
                array[index] = value;
            }
        }


        
        #region < IEnumerable 인터페이스 구현 >
        public IEnumerator GetEnumerator()
        {
            for(var i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
        #endregion

        #region <IEnumerator 인터페이스 구현>
        public object Current 
        {
            get
            {
                return array[position];
            }
        }

        public bool MoveNext()      // 다음 값을 갈 수 있는지 확인
        {
            if (position == array.Length - 1 )
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new CustomEnumerator();

            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            
            var myArrayList = new ArrayList(); 
            for (var i = 0;i <= 5; i++)
            {
            myArrayList[i] = i;
            }
            foreach (var item in myArrayList) // IEnumerable 인터페이스를 구현했기 때문에
            {
            Console.WriteLine(item);
            }
        

        
        }
    }

