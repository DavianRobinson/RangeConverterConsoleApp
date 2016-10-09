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
        public void ConvertASingleItemRangeToSequenceTest()
        {

            // Example: sequence(“1”)=[1]          
            var testString = "1";
            IEnumerable<int> expected = new List<int> { 1 } as IEnumerable<int>;
            var actual = RangeConverterConsoleApp.Program.ConvertRangesToSequence(testString);
            Assert.AreEqual(actual.First(), expected.First());
        }

        [TestMethod()]
        public void ConvertATwoItemRangeToSequenceTest()
        {
            // Example: sequence(“1,2”)=[1,2]
            var testString = "1,2";
            IEnumerable<int> expected = new List<int> { 1, 2 } as IEnumerable<int>;
            var actual = RangeConverterConsoleApp.Program.ConvertRangesToSequence(testString);

            Assert.AreEqual(actual.Count(), expected.Count());
        }

        [TestMethod()]
        public void ConvertMultipleItemsRangesToSequenceTest()
        {


            // Example: sequence(“1:3,5”)=[1,2,3,5]
            var testString = "1:3,5";
            IEnumerable<int> expected = new List<int> { 1, 2, 3, 5 } as IEnumerable<int>;

            var actual = RangeConverterConsoleApp.Program.ConvertRangesToSequence(testString);

            Assert.AreEqual(actual.Count(), expected.Count());
        }

        [TestMethod()]
        public void ConvertSinlgleItemSequenceToRangesTest()
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