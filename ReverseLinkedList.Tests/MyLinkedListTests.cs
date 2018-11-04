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
    public class MyLinkedListTests
    {
        [TestMethod()]
        public void AmountAfterPopulate()
        {
            //arrange
            var amount_of_elements = 10;
            int expected = amount_of_elements;
            MyLinkedList list = new MyLinkedList();            

            //act
            list.Populate(amount_of_elements);
            int actual = list.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AmountAfterReverse()
        {
            //arrange
            var amount_of_elements = 10;
            int expected = amount_of_elements;
            MyLinkedList list = new MyLinkedList();
            list.Populate(amount_of_elements);

            //act
            list.Reverse();
            int actual = list.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AmountAfterPopulateEmpty()
        {
            //arrange
            var amount_of_elements = 0;
            int expected = 1;
            MyLinkedList list = new MyLinkedList();

            //act
            list.Populate(amount_of_elements);
            int actual = list.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AmountAfterReverseEmpty()
        {
            //arrange
            var amount_of_elements = 0;
            int expected = 1;
            MyLinkedList list = new MyLinkedList();
            list.Populate(amount_of_elements);

            //act
            list.Reverse();
            int actual = list.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckHasLoopV1_01_Does()
        {
            //arrange
            MyLinkedList list = new MyLinkedList();
            MLLElement current = list.Root;
            MLLElement mLLElement3rd = null;
            for (int i = 0; i < 10; i++)
            {
                MLLElement mLLElement = new MLLElement() { Value = i + 1 };
                current.Next = mLLElement;
                current = mLLElement;

                if(i == 3)
                {
                    mLLElement3rd = current;
                }
            }

            current.Next = mLLElement3rd;

            //act
            bool hasLoops = list.HasLoop();

            //assert
            Assert.AreEqual(true, hasLoops);
        }

        [TestMethod]
        public void CheckHasLoopV1_02_Does()
        {
            //arrange
            MyLinkedList list = new MyLinkedList();
            MLLElement root = list.Root;
            MLLElement next = new MLLElement() { Value = 1, Next = root };
            root.Next = next;

            //act
            bool hasLoops = list.HasLoop();

            //assert
            Assert.AreEqual(true, hasLoops);
        }

        [TestMethod]
        public void CheckHasLoopV1_03_Not()
        {
            //arrange
            MyLinkedList list = new MyLinkedList();
            list.Populate(20);

            //act
            bool hasLoops = list.HasLoop();

            //assert
            Assert.AreEqual(false, hasLoops);
        }

        [TestMethod]
        public void CheckHasLoopV2_01_Does()
        {
            //arrange
            MyLinkedList list = new MyLinkedList();
            MLLElement current = list.Root;
            MLLElement mLLElement3rd = null;
            for (int i = 0; i < 10; i++)
            {
                MLLElement mLLElement = new MLLElement() { Value = i + 1 };
                current.Next = mLLElement;
                current = mLLElement;

                if (i == 3)
                {
                    mLLElement3rd = current;
                }
            }

            current.Next = mLLElement3rd;

            //act
            bool hasLoops = list.HasLoop2();

            //assert
            Assert.AreEqual(true, hasLoops);
        }

        [TestMethod]
        public void CheckHasLoopV2_02_Does()
        {
            //arrange
            MyLinkedList list = new MyLinkedList();
            MLLElement root = list.Root;
            MLLElement next = new MLLElement() { Value = 1, Next = root };
            root.Next = next;

            //act
            bool hasLoops = list.HasLoop2();

            //assert
            Assert.AreEqual(true, hasLoops);
        }

        [TestMethod]
        public void CheckHasLoopV2_03_Not()
        {
            //arrange
            MyLinkedList list = new MyLinkedList();
            list.Populate(20);

            //act
            bool hasLoops = list.HasLoop2();

            //assert
            Assert.AreEqual(false, hasLoops);
        }

    }
}