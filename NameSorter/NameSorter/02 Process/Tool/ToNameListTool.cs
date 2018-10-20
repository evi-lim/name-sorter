using System.Collections.Generic;
using System.Text;

namespace NameSorter.Process
{
    /// <summary>
    /// <code>To Name List Tool</code> commands <code>Back Office</code> admin to modify a list of paired names to text representation.
    /// --- Function: Asks the <code>Back Office</code> admin to convert a given list of paired names to <code>String Builder</code>.
    /// --- Reference: Design Pattern - Command.
    /// </summary>
    public class ToNameListTool : SuperTool
    {
        public ToNameListAssistant _adminAssistant;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="admin"><code>To Name List Assistant</code> that converts a list of paired names to its text representation.</param>
        public ToNameListTool(ToNameListAssistant admin)
            : base(admin)
        {
            _adminAssistant = admin;
        }

        /// <summary>
        /// Executes converting a list of paired names to its text representation.
        /// --- A list paired sorted names >>> List (of string).
        /// </summary>
        /// <returns>TRUE: Text representation exists, successful conversion. FALSE: Text representation does NOT exist, failed conversion.</returns>
        public override bool Work()
        {
            Input = Input ?? PreviousTool.Output;
            Output = _adminAssistant.ToNameList(Input);

            return Output.Count > 0;
        }
    }
}
