using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumGenerics
{
    public class DataList<T> where T : class
    {
        private T[] _list;

        public DataList()
        {
            _list = new T[0];
        }

        public void Add(T value)
        {
            Array.Resize(ref _list, _list.Length + 1);
            _list[_list.Length - 1] = value;
        }

        public T[] GetAll()
        {
            return _list;
        }
    }
}
