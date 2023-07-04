using System;
using Xunit;
using DiamondDemo;

namespace Tests
{
    public class DiamondTests
    {

        [Fact]
        public void CalledWithA()
        {
            Assert.Equal("A", Diamond.PrintDiamond("A"));
        }

        

        [Fact]
        public void CalledWithBWithFakes()
        {
            var fake = new Fake<Diamond>();
            fake.CallsTo(x => x.PrintUpper("B")).Returns("_A_");
            fake.CallsTo(x => x.PrintMiddle("B")).Returns("B_B");
            fake.CallsTo(x => x.PrintLower("B")).Returns("_A_");

            var current = fake.PrintDiamond("B");
            
            // same as:
            // var current = 
            // @"_A_
            //   B_B
            //   _A_";
         
            Assert.Equal(expected, current);
        }

        public void PrintFirstLineForA()
        {
            Assert.Equal("A", Diamond.PrintFirstLine("A"));
        }
        public void PrintFirstLineForB()
        {
            Assert.Equal("_A_", Diamond.PrintFirstLine("B"));
        }
    }
}
