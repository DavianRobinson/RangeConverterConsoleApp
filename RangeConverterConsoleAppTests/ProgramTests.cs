using Microsoft.VisualStudio.TestTools.UnitTesting;
using RangeConverterConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeConverterConsoleApp.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void ConvertRangesToSequenceTest()
        {

            // Example: sequence(“1”)=[1]
            // Example: sequence(“1,2”)=[1,2]
            // Example: sequence(“1:3,5”)=[1,2,3,5]


            Assert.Fail();
        }

        [TestMethod()]
        public void ConvertSequenceToRangesTest()
        {

            // Example: ranges(1) = “1”
            IEnumerable<int> testnumbers = new int[] { 1 };
            var result = RangeConverterConsoleApp.Program.ConvertSequenceToRanges(testnumbers);
            Assert.AreEqual("1", result);

        }
        [TestMethod()]
        public void ConvertTwoItemSequenceToRangesTest()
        {
            // Example: ranges([1,2]) = “1:2”             

            IEnumerable<int> testnumbers = new int[] { 1, 2 };
            var result = RangeConverterConsoleApp.Program.ConvertSequenceToRanges(testnumbers);
            Assert.AreEqual("1:2", result);

        }

        [TestMethod()]
        public void ConvertMultipleItemsSequenceToRangesTest()
        {

            // Example: ranges([1,2,3,5]) = “1:3,5” 
            IEnumerable<int> testnumbers = new int[] { 1, 2, 3, 5 };
            var result = RangeConverterConsoleApp.Program.ConvertSequenceToRanges(testnumbers);
            Assert.AreEqual("1:3, 5", result);

        }
    }
}