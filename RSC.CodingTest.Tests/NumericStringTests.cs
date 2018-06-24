using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RSC.CodingTest.Tests
{
    [TestClass]
    public class NumericStringTests
        
    {

        NumericString m_UnitUnderTest = null;
        [TestInitialize]
        public void Setup()
        {
            m_UnitUnderTest = new NumericString();
        }



        [TestMethod]
        public void Add_ShouldReturnSum()
        {
            Assert.AreEqual<string>(m_UnitUnderTest.Add("3","7"), "10");
        }

    }
}
