using System.Collections.Generic;
using System.IO;
using N_Shared = NameSorter.Shared;

namespace NameSorter.Process
{
    /// <summary>
    /// <code>File Reader Assistant</code> assists <code>Back Office</code> admin to read files.
    /// --- Function: Adds capability to read file for <code>Back Office</code> object.
    /// --- Reference: Design Pattern - Decorator.
    /// </summary>
    public class FileReaderAssistant : BackOfficeAssistant
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="admin"><code>Back Office</code> admin.</param>
        public FileReaderAssistant(BackOffice admin)
            : base(admin)
        {

        }

        /// <summary>
        /// Reads file in the specified filepath.
        /// </summary>
        /// <param name="filepath">File path.</param>
        /// <returns>A list of lines written on the file.</returns>
        public List<string> ReadFile(string filepath)
        {
            List<string> result = new List<string>();

            this._logger.LogInformation(N_Shared.SharedVar.LOGTITLE_FILEOPERATION, N_Shared.SharedVar.LOGDESC_INFO_READINGFILE);
            if (_validator.ValidateFileExists(filepath) == true)
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string lineItem = string.Empty;
                    while (reader.EndOfStream == false)
                    {
                        lineItem = reader.ReadLine().Trim();
                        if (string.IsNullOrEmpty(lineItem) == true)
                        {
                            continue;
                        }

                        result.Add(lineItem);
                    }
                }
            }

            return result;
        }
    }
}
