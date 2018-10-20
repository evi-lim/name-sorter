using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Process;
using System;
using System.Collections.Generic;

namespace NameSorterTest
{
    /// <summary>
    /// Unit Test for <code>To Name List Assistant</code> class.
    /// </summary>
    [TestClass]
    public class ToNameListAssistantTest
    {
        public ToNameListAssistant _testObj;

        /// <summary>
        /// Constructor.
        /// </summary>
        public ToNameListAssistantTest()
        {
            _testObj = new ToNameListAssistant(new BackOffice());
        }

        #region Method: ToNameList(data)

        /// <summary>
        /// Method: ToNameList(List(of Tuple(of string, string)) data).
        /// Input: Valid list.
        /// Output: List of names.
        /// </summary>
        [TestMethod]
        public void ToNameList_ValidData()
        {
            List<Tuple<string, string>> input = new List<Tuple<string, string>>();
            input.Add(new Tuple<string, string>("Iddins", "Orson Milka"));
            input.Add(new Tuple<string, string>("Battelle", "Erna Dorey"));
            input.Add(new Tuple<string, string>("Franzel", "Flori Chaunce"));

            List<string> actualOutput = _testObj.ToNameList(input);

            string expectedOutput = "Orson Milka Iddins";
            Assert.IsNotNull(actualOutput);
            Assert.AreEqual(expectedOutput, actualOutput[0]);
        }

        /// <summary>
        /// Method: ToNameList(List(of Tuple(of string, string)) data).
        /// Input: NULL.
        /// Output: Empty list.
        /// </summary>
        [TestMethod]
        public void ToNameList_NULL_ReturnEmpty()
        {
            List<Tuple<string, string>> input = null;
            List<string> actualOutput = _testObj.ToNameList(input);

            Assert.IsTrue(actualOutput.Count == 0);
        }

        /// <summary>
        /// Method: ToNameList(List(of Tuple(of string, string)) data).
        /// Input: Valid list; one item has no surname.
        /// Output: List of names.
        /// </summary>
        [TestMethod]
        public void ToNameList_ValidDataNoSurname_ValidOutput()
        {
            List<Tuple<string, string>> input = new List<Tuple<string, string>>();
            input.Add(new Tuple<string, string>(string.Empty, "Duarte"));
            input.Add(new Tuple<string, string>("Iddins", "Orson Milka"));
            input.Add(new Tuple<string, string>("Battelle", "Erna Dorey"));
            
            List<string> actualOutput = _testObj.ToNameList(input);

            string expectedOutput = "Duarte";
            Assert.IsNotNull(actualOutput);
            Assert.AreEqual(expectedOutput, actualOutput[0]);
        }

        #endregion
    }
}
