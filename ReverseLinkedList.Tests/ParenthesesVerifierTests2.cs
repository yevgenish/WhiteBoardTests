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
    //Abstract class using implementation

    public abstract class ParenthesesVerifierTests2
    {
        protected abstract IParenthesesVerifier CreateInstance();

        [TestMethod()]
        public void IsValidEmpty()
        {
            //arrange
            string toCheck = "";
            bool expected = true;
            IParenthesesVerifier pv = CreateInstance();

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
            IParenthesesVerifier pv = CreateInstance();

            //act
            bool actual = pv.IsValid(toCheck);

            //assert
            Assert.AreEqual<bool>(expected, actual);
        }
    }

    [TestClass]
    public class ParenthesesVerifierTests2_1 : ParenthesesVerifierTests2
    {
        protected override IParenthesesVerifier CreateInstance()
        {
            return new ParenthesesVerifier();
        }
    }

    [TestClass]
    public class ParenthesesVerifierTests2_2 : ParenthesesVerifierTests2
    {
        protected override IParenthesesVerifier CreateInstance()
        {
            return new ParenthesesVerifier2();
        }
    }
}
