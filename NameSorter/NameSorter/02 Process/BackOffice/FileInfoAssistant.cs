using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NameSorter.Process
{
    /// <summary>
    /// <code>File Info Assistant</code> assists <code>Back Office</code> admin to get information about a given filepath.
    /// --- Function: Adds capability to get information about a file for <code>Back Office</code> object.
    /// --- Reference: Design Pattern - Decorator.
    /// </summary>
    public class FileInfoAssistant : BackOfficeAssistant
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="admin"><code>Back Office</code> admin.</param>
        public FileInfoAssistant(BackOffice admin)
            : base(admin)
        {

        }

        /// <summary>
        /// Gets the file information of a given filepath.
        /// </summary>
        /// <param name="filepath">The given filepath.</param>
        /// <returns>The file information.</returns>
        public FileInfo GetFileInfo(string filepath)
        {
            FileInfo result = null; // Prevents exception.
            if (_validator.ValidateFileExists(filepath) == true)
            {
                result = new FileInfo(filepath);
            }

            return result;
        }
    }
}
