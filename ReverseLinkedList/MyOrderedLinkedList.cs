using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    public class MyOrderedLinkedList
    {
        public MLLElement Root { get; set; }

        public int Count
        {
            get
            {
                int count = 0;
                MLLElement current = Root;
                while (current != null)
                {
                    current = current.Next;
                    count++;
                }

                return count;
            }
        }

        public void Add(int value)
        {
            MLLElement newEl = new MLLElement();
            newEl.Value = value;
            if (Root == null)
            {
                Root = newEl;
            }
            else
            {
                MLLElement current = Root;
                MLLElement previous = null;

                while (true)
                {
                    if (newEl.Value <= current.Value)
                    {
                        if (current == Root)
                        {
                            newEl.Next = Root;
                            Root = newEl;
                            break;
                        }
                        else
                        {
                            newEl.Next = current;
                            previous.Next = newEl;
                            break;
                        }
                    }
                    else
                    {
                        if (current.Next == null)
                        {
                            current.Next = newEl;
                            break;
                        }
                    }

                    previous = current;
                    current = current.Next;
                }
            }
        }

        public void Print()
        {
            MLLElement current = Root;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        public string ConvertToString()
        {
            StringBuilder sb = new StringBuilder();
            MLLElement current = Root;
            while (current != null)
            {
                sb.AppendLine(current.Value.ToString());
                current = current.Next;
            }

            return sb.ToString();
        }
    }
}
