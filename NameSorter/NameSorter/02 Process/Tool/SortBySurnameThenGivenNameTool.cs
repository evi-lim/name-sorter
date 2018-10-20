using System.Collections.Generic;

namespace NameSorter.Process
{
    /// <summary>
    /// <code>Sort By Surname Then Given Name Tool</code> commands <code>Back Office</code> admin to sort a given name list.
    /// --- Function: Asks the <code>Back Office</code> admin to sort a given name list by specified order.
    /// --- Reference: Design Pattern - Command.
    /// </summary>
    public class SortBySurnameThenGivenNameTool : SuperTool
    {
        SortBySurnameThenGivenNameAssistant _adminAssistant;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="admin"><code>Sort by Surname Then Given Name Assistant</code> that sorts the list of paired data by surname then given names.</param>
        public SortBySurnameThenGivenNameTool(SortBySurnameThenGivenNameAssistant admin)
            : base(admin)
        {
            _adminAssistant = admin;
        }

        /// <summary>
        /// Sorts a list of paired data by surname, then by given name.
        /// --- A list of paired names >>> Sorted list of paired names.
        /// </summary>
        /// <returns>TRUE (for Unit Testing purposes).</returns>
        public override bool Work()
        {
            Input = Input ?? PreviousTool.Output;
            Output = _adminAssistant.SortBySurnameThenGivenName(Input);

            return Output.Count > 0;
        }
    }
}
