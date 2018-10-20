using System.Collections.Generic;
using N_Process = NameSorter.Process;

namespace NameSorter.Input
{
    /// <summary>
    /// <code>Sort Surname Then Given Name</code> sorts a list of data in ascending order.
    /// --- Function:
    ///             1. Accepts request to sort by last name then by given name.
    ///             2. Sends request to back office.
    /// --- Reference: Design Pattern - Strategy (Sort by surname then by given name).
    /// </summary>
    public class SortSurnameThenGivenName : Sorter
    {
        /// <summary>
        /// Runs a task with specified parameters.
        /// --- Aligns with parent class: <code>Task</code>.
        /// </summary>
        /// <param name="data">Input data.</param>
        /// <param name="sortTool">Should be: <code>Sort Surname Then Given Name</code>.</param>
        /// <returns>A list of sorted data.</returns>
        public override List<string> Run(string data, Sorter sortTool)
        {
            return Sort(data);
        }

        /// <summary>
        /// Sorts a list of data.
        /// </summary>
        /// <param name="data">Input data.</param>
        /// <returns>A list of sorted data.</returns>
        public override List<string> Sort(string data)
        {
            List<string> result = new List<string>();

            List<N_Process.SuperTool> todo = CreateToDoList(new N_Process.BackOffice());
            N_Process.SuperTool toolItem = null;
            for (int i = 0; i < todo.Count; i++)
            {
                toolItem = todo[i];

                toolItem.PreviousTool = (i == 0 ? null : todo[i - 1]);
                toolItem.Input = toolItem.PreviousTool == null ? data : toolItem.PreviousTool.Output;
                todo[i].Work();
            }

            result = toolItem.Output;
            return result;
        }

        #region Private method to help build sequence of tasks to sort data

        /// <summary>
        /// Distributes all the tasks required to sort data.
        /// </summary>
        /// <param name="admin"><code>Back Office</code> admin that will do the work.</param>
        /// <returns>List of all the tasks required to sort data.</returns>
        private List<N_Process.SuperTool> CreateToDoList(N_Process.BackOffice admin)
        {
            List<N_Process.SuperTool> result = new List<N_Process.SuperTool>();

            result.Add(new N_Process.FileReaderTool(new N_Process.FileReaderAssistant(admin)));
            result.Add(new N_Process.ToSurnameTupleTool(new N_Process.ToSurnameTupleAssistant(admin)));
            result.Add(new N_Process.SortBySurnameThenGivenNameTool(new N_Process.SortBySurnameThenGivenNameAssistant(admin)));
            result.Add(new N_Process.ToNameListTool(new N_Process.ToNameListAssistant(admin)));

            return result;
        }

        #endregion
    }
}
