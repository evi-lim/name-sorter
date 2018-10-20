using System;
using System.Collections.Generic;
using System.IO;

namespace NameSorter.Output
{
    /// <summary>
    /// <code>Presenter</code> helps make the result looks presentable.
    /// --- Function: Converts the result into text representation (as <code>String Builder</code> object).
    /// --- Reference: Design Pattern - Template.
    /// </summary>
    public abstract class Presenter
    {
        protected string _target_filepath;

        /// <summary>
        /// Sets the target filepath (if result is printing to file).
        /// </summary>
        /// <param name="filepath">The given filepath.</param>
        /// <returns>THIS (for simplicity when calling).</returns>
        public Presenter SetTargetFilePath(string filepath)
        {
            _target_filepath = filepath;

            return this;
        }

        /// <summary>
        /// Presents result of process to user.
        /// </summary>
        /// <param name="data">Data as list (of string).</param>
        public void PresentListResult(List<string> data)
        {
            DisplayInConsole(data);
            DisplayInFile(data);
        }

        /// <summary>
        /// Print given data to console.
        /// </summary>
        /// <param name="data">Data input to display.</param>
        /// <returns>TRUE (for Unit Test purposes).</returns>
        public virtual bool DisplayInConsole(dynamic data)
        {
            return true;
        }

        /// <summary>
        /// Print given data to specified file.
        /// </summary>
        /// <param name="data">Data input to display.</param>
        /// <returns></returns>
        public virtual bool DisplayInFile(dynamic data)
        {
            return true;
        }
    }
}
