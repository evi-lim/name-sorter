using System.Collections.Generic;
using N_Shared = NameSorter.Shared;

namespace NameSorter.Input
{
    /// <summary>
    /// <code>Extension to File Path</code> is an extension to <code>String</code> object.
    /// --- Reference: Part of Design Pattern: Strategy.
    /// </summary>
    public static class ExtensionToFilePath
    {
        static Task _task;

        /// <summary>
        /// Defines a task to perform.
        /// </summary>
        /// <param name="data">THIS: File path data.</param>
        /// <param name="task">The given task to perform on the file.</param>
        /// <returns>TRUE (for Unit Test purposes).</returns>
        public static bool DefineTask(this string data, Task task)
        {
            bool result = false;

            _task = task;

            result = true;
            return result;
        }

        /// <summary>
        /// Performs a specified task to current file path text.
        /// </summary>
        /// <param name="data">THIS: File path data.</param>
        /// <param name="sortTool">Type of sorting tool (if task is to sort data).</param>
        /// <returns>List of data as output.</returns>
        public static List<string> PerformTask(this string data, Sorter sortTool)
        {
            List<string> result = _task.Run(data, sortTool);
            
            return result;
        }
    }
}
