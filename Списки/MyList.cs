using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Списки
{
    class MyList <T>
    {
        ListItem <T> first = null;
        int count = 0;
        ListItem <T> last = null;
        public void Add(T value)
        {
            if (first == null)
                last = first = new ListItem <T>(value);
            else
            {
                ListItem <T> newItem = new ListItem <T>(value);
                last.next = newItem;
                last = newItem;
            }
            count++;
        }
    }
}
