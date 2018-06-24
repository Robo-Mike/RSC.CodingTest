using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RSC.CodingTest.Tests
{
    [TestClass]
    public class PalindromSeriesTests
        
    {

        PalindromeSeries m_UnitUnderTest = null;
        [TestInitialize]
        public void Setup()
        {
            m_UnitUnderTest = new PalindromeSeries();
        }

        [TestMethod]
        public void IsPlaindrome_ShouldReturnFalse_When_NumberNotPalindrome()
        {
            Assert.IsFalse(m_UnitUnderTest.IsPalindrome("123453321"));
        }

        [TestMethod]
        public void IsPlaindrome_ShouldReturnTrue_When_NumberPalindrome()
        {
            Assert.IsTrue(m_UnitUnderTest.IsPalindrome("123454321"));
        }


    }
}
