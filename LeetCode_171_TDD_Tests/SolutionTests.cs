using System;
using LeetCode_171_TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_171_TDD_Tests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void Input_A_Should_Return_1()
        {
            // arrange
            var source = "A";
            var expected = 1;
            var sut = new Solution();

            // act
            var actual = sut.TitleToNumber(source);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}