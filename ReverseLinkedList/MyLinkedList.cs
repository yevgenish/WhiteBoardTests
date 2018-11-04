using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    public class MyLinkedList
    {
        public MyLinkedList()
        {
            Root = new MLLElement() { Value = 0 };
        }

        public MyLinkedList(MyLinkedList myLinkedList)
        {
            Root = myLinkedList.Root;
        }

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

        public void Populate(int amount)
        {
            MLLElement current = Root;
            for (int i = 1; i < amount; i++)
            {
                MLLElement el = new MLLElement() { Value = i };
                current.Next = el;
                current = el;
            }
        }

        public void Reverse()
        {
            MLLElement current = Root;
            MLLElement prev = null;
            MLLElement next = null;
            bool exit = false;
            while (!exit)
            {      
                next = current.Next;

                if(current == Root)
                {                    
                    current.Next = null;                
                }
                else
                {                    
                    current.Next = prev;     
                }

                prev = current;

                if(next != null)
                {
                    current = next;
                }
                else
                {
                    Root = current;
                    exit = true;
                }   
            }
        }

        public bool HasLoop()
        {
            HashSet<MLLElement> hsOccurencies = new HashSet<MLLElement>();

            MLLElement current = Root;
            while (current != null)
            {
                if (hsOccurencies.Contains(current))
                {
                    return true;
                }
                else
                {
                    hsOccurencies.Add(current);
                }
                current = current.Next;
            }

            return false;
        }


        public bool HasLoop2()
        {
            //StringBuilder sb = new StringBuilder();
            MLLElement slow_p = Root, fast_p = Root;
            while (slow_p != null && fast_p != null && fast_p.Next != null)
            {
                slow_p = slow_p.Next;
                fast_p = fast_p.Next.Next;
                //Console.WriteLine(slow_p.Value + " " + fast_p.Value);
                //sb.AppendLine(slow_p.Value + " " + fast_p.Value);
                if (slow_p == fast_p)
                {
                    return true;
                }
            }
            return false;
        }

        public void Print()
        {
            MLLElement current = Root;
            while(current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}
