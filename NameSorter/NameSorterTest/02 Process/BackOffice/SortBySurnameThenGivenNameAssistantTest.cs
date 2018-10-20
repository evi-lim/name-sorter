using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Process;
using System;
using System.Collections.Generic;

namespace NameSorterTest
{
    /// <summary>
    /// Unit Test for <code>Sort By Surname Then Given Name Assistant</code> class.
    /// </summary>
    [TestClass]
    public class SortBySurnameThenGivenNameAssistantTest
    {
        public SortBySurnameThenGivenNameAssistant _testObj;

        /// <summary>
        /// Constructor.
        /// </summary>
        public SortBySurnameThenGivenNameAssistantTest()
        {
            _testObj = new SortBySurnameThenGivenNameAssistant(new BackOffice());
        }

        #region Method: SortBySurnameThenGivenName(data)

        /// <summary>
        /// Method: SortBySurnameThenGivenName(Dictionary(of string, string) data).
        /// Input: Valid dictionary.
        /// Output: Sorted Dictionary.
        /// </summary>
        [TestMethod]
        public void SortBySurnameThenGivenName_ValidData()
        {
            List<Tuple<string, string>> input = new List<Tuple<string, string>>();
            input.Add(new Tuple<string, string>("Iddins", "Orson Milka"));
            input.Add(new Tuple<string, string>("Battelle", "Erna Dorey"));
            input.Add(new Tuple<string, string>("Battelle", "Abah Lokki"));

            List<Tuple<string, string>> actualOutput = _testObj.SortBySurnameThenGivenName(input);
            string expectedFirstKey = "Battelle";
            string expectedFirstVal = "Abah Lokki";
            Assert.AreEqual(expectedFirstKey, actualOutput[0].Item1);
            Assert.AreEqual(expectedFirstVal, actualOutput[0].Item2);
        }

        /// <summary>
        /// Method: SortBySurnameThenGivenName(Dictionary(of string, string) data).
        /// Input: NULL.
        /// Output: NULL.
        /// </summary>
        [TestMethod]
        public void SortBySurnameThenGivenName_NullInput_ReturnNull()
        {
            List<Tuple<string, string>> input = null;

            List<Tuple<string, string>> actualOutput = _testObj.SortBySurnameThenGivenName(input);
            Assert.IsNull(actualOutput);
        }

        #endregion
    }
}
