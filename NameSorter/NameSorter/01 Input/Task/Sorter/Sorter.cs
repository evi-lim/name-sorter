using System.Collections.Generic;

namespace NameSorter.Input
{
    /// <summary>
    /// <code>Sorter</code> is general idea of sorting task.
    /// --- Function: Sorts a given data.
    /// --- Reference: Design Pattern - Strategy.
    /// </summary>
    public abstract class Sorter : NameSorter
    {
        /// <summary>
        /// Sorts a list of data.
        /// </summary>
        /// <param name="data">Input data.</param>
        /// <returns>A list of sorted data.</returns>
        public abstract List<string> Sort(string data);
    }
}
