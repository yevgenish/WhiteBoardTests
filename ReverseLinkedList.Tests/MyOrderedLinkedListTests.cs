using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList.Tests
{
    [TestClass()]
    public class MyOrderedLinkedListTests
    {
        [TestMethod()]
        public void AmountAfterPopulate()
        {
            //arrange
            int expected = 10;
            MyOrderedLinkedList list = new MyOrderedLinkedList();

            //act
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            int actual = list.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsOrdered()
        {
            //arrange
            MyOrderedLinkedList myList = new MyOrderedLinkedList();
            List<int> list = new List<int>();

            //act
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int rndInt = rnd.Next(0, 100);
                myList.Add(rndInt);
                list.Add(rndInt);
            }
            string expected = ConvertListToSortedString(list);
            string actual = myList.ConvertToString();

            //assert
            Assert.AreEqual<string>(expected, actual);
        }

        private string ConvertListToSortedString(List<int> list)
        {
            StringBuilder sb = new StringBuilder();

            list.Sort();

            list.ForEach(el => sb.AppendLine(el.ToString()));
            return sb.ToString();
        }
  
    }
}