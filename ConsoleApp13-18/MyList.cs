using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13_18
{
    class MyList<T>
    {
        private ArrayList myList;
        public T this[int index]
        {
            get { return (T)myList[index]; }
            set { myList[index] = value; }
        }

        public MyList()
        {
            this.myList = new ArrayList();
        }

        public MyList(int count)
        {
            this.myList = new ArrayList(count);
        }

        public void Add(T item)
        {
            myList.Add(item);
        }

        public int Capacity
        {
            get { return myList.Capacity; }
            set
            {

                if (value < myList.Count)
                    throw new ArgumentOutOfRangeException();

                myList.Capacity = value;
            }
        }

        public int Count
        {
            get { return myList.Count; }
        }
    }
}
