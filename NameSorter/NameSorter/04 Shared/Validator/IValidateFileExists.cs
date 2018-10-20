using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter.Shared
{
    /// <summary>
    /// Interface that validates whether or not a given file input exists.
    /// --- Returns: TRUE / FALSE.
    ///              True - Given file input exists.
    ///              False - Given file input does NOT exist.
    /// </summary>
    public interface IValidateFileExists
    {
        /// <summary>
        /// Validates a given file path.
        /// </summary>
        /// <param name="path">The given file path.</param>
        /// <returns>TRUE: If the given file path exists.</returns>
        /// <returns>FALSE: If the given file path does NOT exist.</returns>
        bool ValidateFileExists(string path);
    }
}
