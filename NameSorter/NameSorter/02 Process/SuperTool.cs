using System;
using System.Collections.Generic;

namespace NameSorter.Process
{
    /// <summary>
    /// <code>Super Tool</code> is a general idea that asks <code>Back Office</code> to execute tasks.
    /// --- Function: Distributes tasks to appropriate tools.
    /// --- Reference: Design Pattern - Command.
    /// </summary>
    public abstract class SuperTool
    {
        protected BackOffice _admin;

        public SuperTool PreviousTool { get; set; }
        public dynamic Input { get; set; }
        public dynamic Output { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="admin"><code>Back Office</code> object.</param>
        public SuperTool(BackOffice admin)
        {
            this._admin = admin;
        }

        /// <summary>
        /// Performs task according to its specialisation.
        /// </summary>
        /// <returns>TRUE (for Unit Test purposes).</returns>
        public abstract bool Work();
    }
}
