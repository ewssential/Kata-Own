using System;
using Xunit;
using System.Collections.Generic;
using Isograms;

namespace Tests
{
    public class UnitTest1
    {

        // private static IEnumerable<TestCaseData> testCases
        //     {
        //       get
        //       {
        //         yield return new TestCaseData("Dermatoglyphics").Returns(true);
        //         yield return new TestCaseData("isogram").Returns(true);
        //         yield return new TestCaseData("moose").Returns(false);
        //         yield return new TestCaseData("isIsogram").Returns(false);
        //         yield return new TestCaseData("aba").Returns(false);
        //         yield return new TestCaseData("moOse").Returns(false);
        //         yield return new TestCaseData("thumbscrewjapingly").Returns(true);
        //         yield return new TestCaseData("").Returns(true);
        //       }
        //     }

        [Theory]
        [InlineData("Dermatoglyphics", true)]
        [InlineData("isogram", true)]
        [InlineData("moose", false)]
        [InlineData("moOse", false)]
        [InlineData("isIsogram", false)]
        [InlineData("aba", false)]
        public void Test(string str, bool expected) => Assert.Equal(expected, Class1.IsIsogram(str));

    }
}