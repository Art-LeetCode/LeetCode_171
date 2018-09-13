using System;
using LeetCode_171_TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_171_TDD_Tests
{
    [TestClass]
    public class SolutionTests
    {
        private Solution _sut;

        [TestInitialize]
        public void TestInit()
        {
            _sut = new Solution();
        }

        [TestMethod]
        public void Input_A_Should_Return_1()
        {
            // arrange
            var source = "A";
            var expected = 1;

            // act
            var actual = _sut.TitleToNumber(source);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_AB_Should_Return_28()
        {
            // arrange
            var source = "AB";
            var expected = 28;

            // act
            var actual = _sut.TitleToNumber(source);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_ZY_Should_Return_701()
        {
            // arrange
            var source = "ZY";
            var expected = 701;

            // act
            var actual = _sut.TitleToNumber(source);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_ABC_Should_Return_731()
        {
            // arrange
            var source = "ABC";
            var expected = 731;

            // act
            var actual = _sut.TitleToNumber(source);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}