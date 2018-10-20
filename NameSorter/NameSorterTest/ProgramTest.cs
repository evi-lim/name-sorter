using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NameSorterTest
{
    /// <summary>
    /// Unit Test for <code>Program</code> class.
    /// </summary>
    [TestClass]
    public class ProgramTest
    {
        #region Method: Main(args)

        /// <summary>
        /// Method: Main(string[] args).
        /// Input: Valid file path.
        /// Output: New generated file with sorted list.
        /// </summary>
        [TestMethod]
        public void Main_ValidInput()
        {
            NameSorter.Program.Main(new string[1] { "./unsorted-names-list.txt" });
        }

        #endregion
    }
}
