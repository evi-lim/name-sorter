using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter.Shared
{
    /// <summary>
    /// <code>Logger</code> waits for all classes throughout the system to notify new changes.
    /// --- Function: Logs every changes and print to screen.
    /// --- Reference: Design Pattern - Observer.
    /// </summary>
    public class Logger : ILogInformation, ILogError
    {
        /// <summary>
        /// Logs information and prints to screen.
        /// </summary>
        /// <param name="title">Title of the notification.</param>
        /// <param name="desc">Description of the notification.</param>
        /// <returns>TRUE (for Unit Test purposes).</returns>
        public bool LogInformation(string title, string desc)
        {
            bool result = false;

            Console.WriteLine(string.Format(SharedVar.LOGINFO_STRFORMAT_TITLEDESC, title, desc));

            result = true; // Nothing is wrong.
            return result;
        }

        /// <summary>
        /// Logs information and prints to screen.
        /// </summary>
        /// <param name="title">Title of the error.</param>
        /// <param name="desc">Description of the error.</param>
        /// <param name="advise">Advise to fix the error.</param>
        /// <returns>TRUE (for Unit Test purposes).</returns>
        public bool LogError(string title, string desc, string advise)
        {
            bool result = false;

            Console.WriteLine(string.Format(SharedVar.LOGERROR_STRFORMAT_TITLEDESCADVISE, title, desc, advise));

            result = true; // Nothing is wrong.
            return result;
        }
    }
}
