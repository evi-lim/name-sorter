using System;
using System.Collections.Generic;
using System.IO;

namespace NameSorter.Shared
{
    /// <summary>
    /// <code>Validator</code> flies to all classes throughout the system.
    /// --- Function: Validates any given input, always return TRUE / FALSE.
    /// --- Reference: Design Pattern - Flyweight.
    /// </summary>
    public class Validator : IValidateNullOrEmpty, IValidateFileExists
    {
        /// <summary>
        /// Validates a given text input.
        /// </summary>
        /// <param name="input">The given text input.</param>
        /// <returns>TRUE: If the given text input has values (NOT NULL or empty).</returns>
        /// <returns>FALSE: If the given text input is NULL or empty.</returns>
        public bool ValidateNullOrEmpty(string input)
        {
            return !string.IsNullOrEmpty(input);
        }

        /// <summary>
        /// Validates a given array of text inputs.
        /// </summary>
        /// <param name="input">The given array of text inputs.</param>
        /// <returns>TRUE: If the given array has values (LENGTH > 0).</returns>
        /// <returns>FALSE: If the given array is NULL or empty.</returns>
        public bool ValidateNullOrEmpty(string[] input)
        {
            return (input != null && input.Length > 0 && string.IsNullOrEmpty(input[0]) == false);
        }

        /// <summary>
        /// Validates a given list of text inputs.
        /// </summary>
        /// <param name="input">The given list of text inputs.</param>
        /// <returns>TRUE: If the given list has values (LENGTH > 0).</returns>
        /// <returns>FALSE: If the given list is NULL or empty.</returns>
        public bool ValidateNullOrEmpty(List<string> input)
        {
            return (input != null && input.Count > 0 && string.IsNullOrEmpty(input[0]) == false);
        }

        /// <summary>
        /// Validates a given list of paired text inputs.
        /// </summary>
        /// <param name="input">The given list of paired text inputs.</param>
        /// <returns>TRUE: If the given list has values (LENGTH > 0).</returns>
        /// <returns>FALSE: If the given list is NULL or empty.</returns>
        public bool ValidateNullOrEmpty(List<Tuple<string, string>> input)
        {
            return (input != null && input.Count > 0);
        }

        /// <summary>
        /// Validates a given file path.
        /// </summary>
        /// <param name="path">The given file path.</param>
        /// <returns>TRUE: If the given file path exists.</returns>
        /// <returns>FALSE: If the given file path does NOT exist.</returns>
        public bool ValidateFileExists(string path)
        {
            return File.Exists(path) && new FileInfo(path).Length > 0;
        }
    }
}
