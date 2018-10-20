using System;
using System.Collections.Generic;

namespace NameSorter.Process
{
    /// <summary>
    /// <code>File Reader Tool</code> commands <code>Back Office</code> admin to read a specified file input.
    /// --- Function: Asks the <code>Back Office</code> admin to read file.
    /// --- Reference: Design Pattern - Command.
    /// </summary>
    public class FileReaderTool : SuperTool
    {
        FileReaderAssistant _adminAssistant;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="admin"><code>File Reader Assistant</code> that performs file reading task.</param>
        public FileReaderTool(FileReaderAssistant admin)
            : base(admin)
        {
            _adminAssistant = admin;
        }

        /// <summary>
        /// Executes reading file.
        /// --- Filepath >>> File content as List(of string).
        /// </summary>
        /// <returns>TRUE: File has contents. FALSE: File does NOT have contents.</returns>
        public override bool Work()
        {
            Input = Input ?? PreviousTool.Output;
            Output = _adminAssistant.ReadFile(Input);

            return Output.Count > 0;
        }
    }
}
