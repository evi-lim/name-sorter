using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Process;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace NameSorterTest
{
    /// <summary>
    /// Unit Test for <code>File Reader Assistant</code> class.
    /// </summary>
    [TestClass]
    public class FileReaderAssistantTest
    {
        public FileReaderAssistant _testObj;

        /// <summary>
        /// Constructor.
        /// </summary>
        public FileReaderAssistantTest()
        {
            _testObj = new FileReaderAssistant(new BackOffice());
        }

        #region Method: ReadFile(filepath)

        /// <summary>
        /// Method: ReadFile(string filepath).
        /// Input: Valid filepath.
        /// Output: Content of the file as list (of string) Count > 0.
        /// </summary>
        [TestMethod]
        public void ReadFile_ValidFile()
        {
            string input = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            input = Path.Combine(input, Directory.GetFiles(input)[0]); // Unless the directory is empty, this will always return any file.

            List<string> actualOutput = _testObj.ReadFile(input);
            Assert.IsTrue(actualOutput.Count > 0);
        }

        /// <summary>
        /// Method: ReadFile(string filepath).
        /// Input: File not exist.
        /// Output: Count = 0.
        /// </summary>
        [TestMethod]
        public void ReadFile_InvalidFile_ReturnEmpty()
        {
            string input = "C:\test.sort";

            List<string> actualOutput = _testObj.ReadFile(input);
            Assert.IsTrue(actualOutput.Count == 0);
        }

        #endregion
    }
}
