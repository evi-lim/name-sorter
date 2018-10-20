using System.Collections.Generic;

namespace NameSorter.Process
{
    /// <summary>
    /// <code>To Surname Tuple Tool</code> commands <code>Back Office</code> admin to modify a given list to paired data.
    /// --- Function: Asks the <code>Back Office</code> admin to convert a given list to paired names (of surname, given name).
    /// --- Reference: Design Pattern - Command.
    /// </summary>
    public class ToSurnameTupleTool : SuperTool
    {
        ToSurnameTupleAssistant _adminAssistant;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="admin"><code>To Surname Tuple Assistant</code> that converts a list of names to a list of paired names.</param>
        public ToSurnameTupleTool(ToSurnameTupleAssistant admin)
            : base(admin)
        {
            _adminAssistant = admin;
        }

        /// <summary>
        /// Executes converting list of names to a list of paired names.
        /// --- List (of string) of names >>> List of paired names (of surname, given name).
        /// </summary>
        /// <returns>TRUE: List has values, successful convert. FALSE: List does NOT have values, failed to convert.</returns>
        public override bool Work()
        {
            Input = Input ?? PreviousTool.Output;
            Output = _adminAssistant.ToSurnameTuple(Input);

            return Output.Count > 0;
        }
    }
}
