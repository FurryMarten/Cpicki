using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Списки
{
    class ListItem<T>
    {
        public ListItem<T> next;
        T value;

        public ListItem(T value)
        {
            this.value = value;
        }
        public T Value
        {
            get
            { return value; }

        }
        public override string ToString()
        {
            return Convert.ToString(value);
        }
    }
}
