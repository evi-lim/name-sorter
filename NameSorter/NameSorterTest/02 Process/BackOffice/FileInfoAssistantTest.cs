using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Process;
using System.IO;
using System.Reflection;

namespace NameSorterTest
{
    /// <summary>
    /// Unit Test for <code>File Info Assistant</code> class.
    /// </summary>
    [TestClass]
    public class FileInfoAssistantTest
    {
        public FileInfoAssistant _testObj;

        /// <summary>
        /// Constructor.
        /// </summary>
        public FileInfoAssistantTest()
        {
            _testObj = new FileInfoAssistant(new BackOffice());
        }

        #region Method: GetFileInfo(filepath)

        /// <summary>
        /// Method: GetFileInfo(string filepath).
        /// Input: Valid filepath.
        /// Output: FileInfo object <> NULL.
        /// </summary>
        [TestMethod]
        public void GetFileInfo_ValidFile()
        {
            string input = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            input = Path.Combine(input, Directory.GetFiles(input)[0]); // Unless the directory is empty, this will always return any file.

            FileInfo actualOutput = _testObj.GetFileInfo(input);
            Assert.IsNotNull(actualOutput);
        }

        /// <summary>
        /// Method: GetFileInfo(string filepath).
        /// Input: File not exist.
        /// Output: NULL.
        /// </summary>
        [TestMethod]
        public void GetFileInfo_InvalidFile_ReturnNULL()
        {
            string input = "C:\test.sort";

            FileInfo actualOutput = _testObj.GetFileInfo(input);
            Assert.IsNull(actualOutput);
        }

        #endregion
    }
}
