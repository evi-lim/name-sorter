using System.Collections.Generic;
using N_Shared = NameSorter.Shared;
using N_Process = NameSorter.Process;
using N_Output = NameSorter.Output;
using System.IO;

namespace NameSorter.Input
{
    /// <summary>
    /// <code>Customer Service</code> facilitates all requests and responses.
    /// --- Function: Directs all requests to appropriate agent.
    /// --- Reference: Design Pattern - Strategy.
    /// </summary>
    public class CustomerService
    {
        N_Shared.Validator _validator;
        N_Shared.Logger _logger;
        Task _task;

        /// <summary>
        /// Constructor.
        /// </summary>
        public CustomerService()
        {
            _validator = new N_Shared.Validator();
            _logger = new N_Shared.Logger();

            _task = new NameSorter();
        }

        /// <summary>
        /// Sorts surname then given name.
        /// </summary>
        /// <param name="filepath">File path to a list of names.</param>
        /// <returns>A list of sorted names.</returns>
        public bool SortSurnameThenGivenName(string filepath)
        {
            bool result = false;
            List<string> sortedList = new List<string>();

            if (_validator.ValidateFileExists(filepath) == true)
            {
                filepath.DefineTask(_task);
                sortedList = filepath.PerformTask(new SortSurnameThenGivenName());

                N_Output.Presenter displayboard = new N_Output.PrintListToFile();
                displayboard.SetTargetFilePath(GetTargetFilepath(filepath))
                            .PresentListResult(sortedList);
                result = true;
            }
            else
            {
                _logger.LogError(N_Shared.SharedVar.LOGTITLE_FILEVALIDATION,
                                string.Format(N_Shared.SharedVar.LOGDESC_ERROR_STRFORMAT_FILENOTEXIST, filepath),
                                N_Shared.SharedVar.LOGADVISE_ENSUREFILEVALID);
            }

            return result;
        }

        #region Private method to get target filepath

        /// <summary>
        /// Get target file path based on source file path.
        /// </summary>
        /// <param name="src_filepath">Source file path.</param>
        /// <returns>The target full filename.</returns>
        private string GetTargetFilepath(string src_filepath)
        {
            string result = src_filepath;

            N_Process.SuperTool fileTool = new N_Process.FileInfoTool(new N_Process.FileInfoAssistant(new N_Process.BackOffice()));
            fileTool.Input = src_filepath;
            fileTool.Work();

            result = Path.Combine((fileTool.Output as FileInfo).DirectoryName, N_Shared.SharedVar.OUTPUT_FILENAME);

            return result;
        }

        #endregion
    }
}
