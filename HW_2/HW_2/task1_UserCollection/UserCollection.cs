using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace HW_2
{
    class UserCollection : IEnumerable
    {
        public  List<string> MyList { get; set; }
        

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }
    }

    class  Iterator : IEnumerator
    {
        List<string> car = new List<string>();

        public Iterator(UserCollection col)
        {
            car = col.MyList;

        }

        
        private int currentPosition=-1;

        public object Current
        {
            get
            {
                return car[currentPosition];
            }
        }

        public bool MoveNext()
        {
            if (currentPosition < car.Count - 1)
            {
                currentPosition++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            currentPosition=-1;
        }
    }
}
