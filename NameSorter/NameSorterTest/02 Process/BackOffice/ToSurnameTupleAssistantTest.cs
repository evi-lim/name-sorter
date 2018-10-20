using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Process;
using System;
using System.Collections.Generic;

namespace NameSorterTest
{
    /// <summary>
    /// Unit Test for <code>To Surname Tuple Assistant</code> class.
    /// </summary>
    [TestClass]
    public class ToSurnameTupleAssistantTest
    {
        public ToSurnameTupleAssistant _testObj;

        /// <summary>
        /// Constructor.
        /// </summary>
        public ToSurnameTupleAssistantTest()
        {
            _testObj = new ToSurnameTupleAssistant(new BackOffice());
        }

        #region Method: ToSurnameTuple(data)

        /// <summary>
        /// Method: ToSurnameTuple(List(string) data).
        /// Input: Valid list.
        /// Output: Valid pair of names.
        /// </summary>
        [TestMethod]
        public void ToSurnameTuple_ValidData()
        {
            List<string> input = new List<string>();
            input.Add("Orson Milka Iddins");
            input.Add("Erna Dorey Battelle");
            input.Add("Flori Chaunce Franzel");

            List<Tuple<string, string>> actualOutput = _testObj.ToSurnameTuple(input);

            string expectedItem1_Output = "Iddins";
            string expectedItem2_Output = "Orson Milka";
            Assert.IsNotNull(actualOutput);
            Assert.AreEqual(expectedItem1_Output, actualOutput[0].Item1);
            Assert.AreEqual(expectedItem2_Output, actualOutput[0].Item2);
        }

        /// <summary>
        /// Method: ToSurnameTuple(List(string) data).
        /// Input: NULL.
        /// Output: Empty list.
        /// </summary>
        [TestMethod]
        public void ToSurnameTuple_NullInput_ReturnEmptyList()
        {
            List<string> input = null;

            List<Tuple<string, string>> actualOutput = _testObj.ToSurnameTuple(input);

            Assert.IsTrue(actualOutput.Count == 0);
        }

        /// <summary>
        /// Method: ToSurnameTuple(List(string) data).
        /// Input: Valid list.
        /// Output: Valid pair of names.
        /// </summary>
        [TestMethod]
        public void ToSurnameTuple_ValidDataWithNoSurname_ValidOutput()
        {
            List<string> input = new List<string>();
            input.Add("Duarte");
            input.Add("Erna Dorey Battelle");
            input.Add("Flori Chaunce Franzel");

            List<Tuple<string, string>> actualOutput = _testObj.ToSurnameTuple(input);

            string expectedItem1_Output = string.Empty;
            string expectedItem2_Output = "Duarte";
            Assert.IsNotNull(actualOutput);
            Assert.AreEqual(expectedItem1_Output, actualOutput[0].Item1);
            Assert.AreEqual(expectedItem2_Output, actualOutput[0].Item2);
        }

        #endregion
    }
}
