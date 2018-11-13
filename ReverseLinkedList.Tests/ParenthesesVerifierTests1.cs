using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList.Tests
{
    //[TestClass()]
    //this class supports testing of multiple implementations of Perentheses Verifier
    //Generics using implementation

    public class ParenthesesVerifierTests1<TParenthesesVerifier>
                where TParenthesesVerifier: IParenthesesVerifier, new()
    {
        [TestMethod()]
        public void IsValidEmpty()
        {
            //arrange
            string toCheck = "";
            bool expected = true;
            IParenthesesVerifier pv = new TParenthesesVerifier();

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
            IParenthesesVerifier pv = new TParenthesesVerifier();

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
            IParenthesesVerifier pv = new TParenthesesVerifier();

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
            IParenthesesVerifier pv = new TParenthesesVerifier();

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
            IParenthesesVerifier pv = new TParenthesesVerifier();

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
            IParenthesesVerifier pv = new TParenthesesVerifier();

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
            IParenthesesVerifier pv = new TParenthesesVerifier();

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
            IParenthesesVerifier pv = new TParenthesesVerifier();

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
            IParenthesesVerifier pv = new TParenthesesVerifier();

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
            IParenthesesVerifier pv = new TParenthesesVerifier();

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
            IParenthesesVerifier pv = new TParenthesesVerifier();

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
            IParenthesesVerifier pv = new TParenthesesVerifier();

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
            IParenthesesVerifier pv = new TParenthesesVerifier();

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
            IParenthesesVerifier pv = new TParenthesesVerifier();

            //act
            bool actual = pv.IsValid(toCheck);

            //assert
            Assert.AreEqual<bool>(expected, actual);
        }
    }

    [TestClass]
    public class ParenthesesVerifierTests1_1 : ParenthesesVerifierTests1<ParenthesesVerifier>
    {

    }

    [TestClass]
    public class ParenthesesVerifierTests1_2 : ParenthesesVerifierTests1<ParenthesesVerifier2>
    {

    }
}