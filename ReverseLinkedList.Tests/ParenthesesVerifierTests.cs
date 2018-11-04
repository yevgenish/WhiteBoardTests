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
    public class ParenthesesVerifierTests
    {
        [TestMethod()]
        public void IsValidEmpty()
        {
            //arrange
            string toCheck = "";
            bool expected = true;
            ParenthesesVerifier pv = new ParenthesesVerifier();

            //act
            bool actual = pv.IsValid(toCheck);

            //assert
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod()]
        public void IsValidTest1Couple()
        {
            //arrange
            string toCheck = "{}";
            bool expected = true;
            ParenthesesVerifier pv = new ParenthesesVerifier();

            //act
            bool actual = pv.IsValid(toCheck);

            //assert
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod()]
        public void IsValidTest2Couples()
        {
            //arrange
            string toCheck = "({})";
            bool expected = true;
            ParenthesesVerifier pv = new ParenthesesVerifier();

            //act
            bool actual = pv.IsValid(toCheck);

            //assert
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod()]
        public void IsValidTest3Couples()
        {
            //arrange
            string toCheck = "[({})]";
            bool expected = true;
            ParenthesesVerifier pv = new ParenthesesVerifier();

            //act
            bool actual = pv.IsValid(toCheck);

            //assert
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod()]
        public void IsValidTest3CouplesBad()
        {
            //arrange
            string toCheck = "[({})]{";
            bool expected = false;
            ParenthesesVerifier pv = new ParenthesesVerifier();

            //act
            bool actual = pv.IsValid(toCheck);

            //assert
            Assert.AreEqual<bool>(expected, actual);
        }


        [TestMethod()]
        public void IsValidTest3CouplesBad2()
        {
            //arrange
            string toCheck = "}[({})]";
            bool expected = false;
            ParenthesesVerifier pv = new ParenthesesVerifier();

            //act
            bool actual = pv.IsValid(toCheck);

            //assert
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod()]
        public void IsValidTest3CouplesBad3()
        {
            //arrange
            string toCheck = "{{}[({})]";
            bool expected = false;
            ParenthesesVerifier pv = new ParenthesesVerifier();

            //act
            bool actual = pv.IsValid(toCheck);

            //assert
            Assert.AreEqual<bool>(expected, actual);
        }



        [TestMethod()]
        public void IsValidTest3CouplesBad4()
        {
            //arrange
            string toCheck = "{{}}[({})]{)";
            bool expected = false;
            ParenthesesVerifier pv = new ParenthesesVerifier();

            //act
            bool actual = pv.IsValid(toCheck);

            //assert
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod()]
        public void IsValidTest3CouplesBad5()
        {
            //arrange
            string toCheck = "{{}}[({})]{)(}";
            bool expected = false;
            ParenthesesVerifier pv = new ParenthesesVerifier();

            //act
            bool actual = pv.IsValid(toCheck);

            //assert
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod()]
        public void IsValidTest3CouplesBad6()
        {
            //arrange
            string toCheck = "{{}}[({})]{}()[][][}](){}";
            bool expected = false;
            ParenthesesVerifier pv = new ParenthesesVerifier();

            //act
            bool actual = pv.IsValid(toCheck);

            //assert
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod()]
        public void IsValidTest3CouplesBad7()
        {
            //arrange
            string toCheck = "{{}}[({})]{}()[][][}{](){}";
            bool expected = false;
            ParenthesesVerifier pv = new ParenthesesVerifier();

            //act
            bool actual = pv.IsValid(toCheck);

            //assert
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod()]
        public void IsValidTest3CouplesGood1()
        {
            //arrange
            string toCheck = "{{}}[({})]";
            bool expected = true;
            ParenthesesVerifier pv = new ParenthesesVerifier();

            //act
            bool actual = pv.IsValid(toCheck);

            //assert
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod()]
        public void IsValidTest3CouplesGood2()
        {
            //arrange
            string toCheck = "{{}}[({})]{}()[][][](){}";
            bool expected = true;
            ParenthesesVerifier pv = new ParenthesesVerifier();

            //act
            bool actual = pv.IsValid(toCheck);

            //assert
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod()]
        public void IsValidTest3CouplesGood3()
        {
            //arrange
            string toCheck = "{{}}[({})]{}(){[][][](){}}";
            bool expected = true;
            ParenthesesVerifier pv = new ParenthesesVerifier();

            //act
            bool actual = pv.IsValid(toCheck);

            //assert
            Assert.AreEqual<bool>(expected, actual);
        }
    }
}