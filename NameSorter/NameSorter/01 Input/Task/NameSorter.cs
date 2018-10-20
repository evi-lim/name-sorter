using System;
using System.Collections.Generic;
using N_Shared = NameSorter.Shared;

namespace NameSorter.Input
{
    /// <summary>
    /// <code>Name Sorter</code> sorts names.
    /// --- Function: Sorts a list of names.
    /// --- Reference: Design Pattern - Strategy.
    /// </summary>
    public class NameSorter : Task
    {
        /// <summary>
        /// Runs a task with the given data and given tool.
        /// </summary>
        /// <param name="data">The given input data.</param>
        /// <param name="sortTool">The given tool.</param>
        /// <returns>A list of data as output.</returns>
        public override List<string> Run(string data, Sorter sortTool)
        {
            return sortTool.Sort(data);
        }
    }
}
