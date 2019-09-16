using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class ArrayList
    {
        private object[] _List;

        public ArrayList()
        {
            _List = new object[0];
        }

        public virtual void Add(object value)
        {
            //Create a new array of Length + 1
            object[] _newList = new object[_List.Length +1];
            //Put the values of the old array into the new array
            for (int i=0; i < _List.Length; i++)
            {
                _newList[i] = _List[i];
            }
            //put the new value at the end of the new array
            _newList[_newList.Length - 1] = value;

            _List = _newList;

           
        }


        public virtual void Clear()
        {
            //set the current array to a new empty array
            _List = new object[0];
        }

        public virtual object this[int index]
        {
            set
            {
                _List[index] = value;
            }

            get
            {
                return _List[index];
            }
        }

        public int length
        {
            get
            {
                return _List.Length;
            }
        }
    }
}


//_List.Add(~);

//_List[0] = 1;

//_List.Clear();
