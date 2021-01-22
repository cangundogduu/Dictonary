using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class MyDictonary<T1,T2>
    {
        T1[] _keys;
        T2[] _values;
        public MyDictonary()
        {
            _keys = new T1[0];
            _values = new T2[0];
        }
        public void Add (T1 key,T2 value)
        {
            T1[] tempKeys = _keys;
            T2[] tempValues = _values;

            _keys = new T1[tempKeys.Length + 1];
            _values = new T2[_values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                _keys[i] = tempKeys[i];
                _values[i] = tempValues[i];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }
        public T1[] Keys
        {
            get { return _keys; }
        }

        public T2[] Values
        {
            get { return _values; }
        }

    }
}
