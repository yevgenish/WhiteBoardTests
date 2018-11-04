using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyLinkedList_Test1();
            //MyOrderedLinkedList_Test1();
            MyOrderedLinkedList_Test2();

            Console.ReadLine();
        }

        private static void MyLinkedList_Test1()
        {
            MyLinkedList list = new MyLinkedList();
            list.Populate(10);
            list.Print();
            Console.WriteLine("---------------------");

            list.Reverse();
            list.Print();            
        }

        private static void MyOrderedLinkedList_Test1()
        {
            MyOrderedLinkedList list = new MyOrderedLinkedList();
            list.Add(3);
            list.Add(2);
            list.Add(1);

            list.Add(4);
            list.Add(1);
            list.Add(2);
            list.Add(2);
            list.Add(2);
            list.Add(2);     

            list.Print();
        }


        private static void MyOrderedLinkedList_Test2()
        {
            MyOrderedLinkedList list = new MyOrderedLinkedList();

            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                int rndInt = rnd.Next(0, 100);
                list.Add(rndInt);
            }

            list.Print();
        }
    }
}
