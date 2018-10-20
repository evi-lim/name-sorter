using System;
using System.Collections.Generic;

namespace NameSorter.Shared
{
    /// <summary>
    /// Interface that validates whether or not a given input is NULL or empty.
    /// --- Returns: TRUE / FALSE.
    ///              True - Given input has values (NOT NULL or empty).
    ///              False - Given input is NULL or empty.
    /// </summary>
    public interface IValidateNullOrEmpty
    {
        /// <summary>
        /// Validates a given text input.
        /// </summary>
        /// <param name="input">The given text input.</param>
        /// <returns>TRUE: If the given text input has values (NOT NULL or empty).</returns>
        /// <returns>FALSE: If the given text input is NULL or empty.</returns>
        bool ValidateNullOrEmpty(string input);

        /// <summary>
        /// Validates a given array of text inputs.
        /// </summary>
        /// <param name="input">The given array of text inputs.</param>
        /// <returns>TRUE: If the given array has values (LENGTH > 0).</returns>
        /// <returns>FALSE: If the given array is NULL or empty.</returns>
        bool ValidateNullOrEmpty(string[] input);

        /// <summary>
        /// Validates a given list of text inputs.
        /// </summary>
        /// <param name="input">The given list of text inputs.</param>
        /// <returns>TRUE: If the given list has values (LENGTH > 0).</returns>
        /// <returns>FALSE: If the given list is NULL or empty.</returns>
        bool ValidateNullOrEmpty(List<string> input);
        
        /// <summary>
        /// Validates a given list of paired text inputs.
        /// </summary>
        /// <param name="input">The given list of paired text inputs.</param>
        /// <returns>TRUE: If the given list has values (LENGTH > 0).</returns>
        /// <returns>FALSE: If the given list is NULL or empty.</returns>
        bool ValidateNullOrEmpty(List<Tuple<string, string>> input);
    }
}
