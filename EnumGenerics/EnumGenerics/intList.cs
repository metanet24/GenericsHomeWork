using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumGenerics
{
    public class intList
    {
        private int[] _ints;

        public intList()
        {
            _ints = new int[0];
        }


        public void Add(int value)
        {
            Array.Resize(ref _ints, _ints.Length + 1);

            _ints[_ints.Length - 1] = value;
        }

        public void GetAll()
        {
            foreach (var item in _ints)
            {
                Console.WriteLine(item);
            }
        }
    }
}
