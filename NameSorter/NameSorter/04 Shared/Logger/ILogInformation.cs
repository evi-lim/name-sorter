using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter.Shared
{
    /// <summary>
    /// Interface that logs information and prints to screen.
    /// --- Returns: TRUE / FALSE.
    ///              True - Given input has values (NOT NULL or empty).
    ///              False - Given input is NULL or empty.
    /// </summary>
    public interface ILogInformation
    {
        /// <summary>
        /// Logs information and prints to screen.
        /// </summary>
        /// <param name="title">Title of the notification.</param>
        /// <param name="desc">Description of the notification.</param>
        /// <returns>TRUE (for Unit Test purposes).</returns>
        bool LogInformation(string title, string desc);
    }
}
