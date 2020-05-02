using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Списки
{
        class NewList<T>
        {
            ListItem<T> first = null;
            int count = 0;
            ListItem<T> last = null;
            public void AddLast(T value)//в конец
            {
                if (first == null)
                    last = first = new ListItem<T>(value);
                else
                {
                    ListItem<T> newItem = new ListItem<T>(value);
                    last.next = newItem;
                    last = newItem;
                }
                count++;

            }

            public void AddFirst(T value)//В начало
            {
                if (first == null)
                    last = first = new ListItem<T>(value);
                else
                {
                    ListItem<T> newItem = new ListItem<T>(value);
                    newItem.next = first;
                    first = newItem;
                }
                count++;
            }
            public void Add(T value, int pos)//По позиции
            {
                bool flag = false;
                if (first == null)
                    last = first = new ListItem<T>(value);
                else
                {
                    ListItem<T> newItem = new ListItem<T>(value);
                    ListItem<T> tmp = first;
                    for (int i = 0; i < pos - 1; i++)
                    {
                        flag = true;
                        tmp = tmp.next;
                    }
                    if (flag == true)
                    {
                        newItem.next = tmp.next;
                        tmp.next = newItem;
                    }
                    else
                    {
                        AddFirst(value);
                        count--;
                    }
                }
                count++;
            }

            public ListItem<T> Search(int pos)//По индексу
            {


                if (first == null)
                { 
                    throw new Exception("Лист пуст");
                }
                else
                {

                    ListItem<T> tmp = first;
                    for (int i = 0; i < pos; i++)
                    {
                        tmp = tmp.next;
                    }
                    return tmp;
                }

            }
            public int Search(T value)//По значению
            {
                if (first == null)
                { throw new Exception("Лист пуст"); }
                else
                {
                    ListItem<T> tmp = first;
                    for (int i = 0; ; i++)
                    {
                        if (tmp.Value.Equals(value) == true)//i индекс в листе (а +1 это позиция)
                        {
                            return i + 1; 
                        }
                        
                        if (tmp == last)
                        { 
                            break;
                        }
                        tmp = tmp.next;
                    }
                }
                return -1;
            }
            public void DeletePos(int pos)// Удаление с позиции
            {
                ListItem<T> tmp = first;
                ListItem<T> tmp1;
                for (int i = 0; i < pos - 1; i++)
                {
                    tmp = tmp.next;
                }
                tmp1 = tmp.next;
                tmp.next = tmp.next.next;
                tmp1 = null;
                count--;
            }
            public void DeleteFirst()// удаление с начала
            {
                first = first.next;
                count--;
            }
            public void DeleteLast()// удаление с конца
            {
                ListItem<T> tmp = first;
                for (int i = 0; i < count - 1; i++)
                { tmp = tmp.next; }
                last = tmp;
                last.next = null;
                count--;
            }
            public override string ToString()
            {
                string s = "";
                ListItem<T> tmp = first;
                for (int i = 0; i < count; i++)
                {
                    s += tmp.ToString() + " ";
                    tmp = tmp.next;
                }
                return s;
            }
        }
    }
