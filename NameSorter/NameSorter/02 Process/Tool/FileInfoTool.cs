namespace NameSorter.Process
{
    /// <summary>
    /// <code>File Info Tool</code> commands <code>Back Office</code> admin to get information about a specified file input.
    /// --- Function: Asks the <code>Back Office</code> admin to get information about a given filepath.
    /// --- Reference: Design Pattern - Command.
    /// </summary>
    public class FileInfoTool : SuperTool
    {
        FileInfoAssistant _adminAssistant;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="admin"><code>File Info Assistant</code> that searches for information about a given filepath.</param>
        public FileInfoTool(FileInfoAssistant admin)
            : base(admin)
        {
            _adminAssistant = admin;
        }

        /// <summary>
        /// Gets information about a file.
        /// </summary>
        /// <returns></returns>
        public override bool Work()
        {
            Input = Input ?? PreviousTool.Output;
            Output = _adminAssistant.GetFileInfo(Input);

            return Output != null;
        }
    }
}
