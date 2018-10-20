using System.Collections.Generic;

namespace NameSorter.Input
{
    /// <summary>
    /// <code>Task</code> is general idea of <code>Task</code> object that runs a process.
    /// --- Function: Runs a process.
    /// --- Reference: Design Pattern - Strategy.
    /// </summary>
    public abstract class Task
    {
        /// <summary>
        /// Runs a task with specified parameters.
        /// </summary>
        /// <param name="data">Input data.</param>
        /// <param name="sortTool">Type of sorting tool (if task to perform is sorting).</param>
        /// <returns>A list of sorted data.</returns>
        public abstract List<string> Run(string data, Sorter sortTool);
    }
}
