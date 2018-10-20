using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using N_Shared = NameSorter.Shared;

namespace NameSorter.Process
{
    /// <summary>
    /// <code>To Name List Assistant</code> assists <code>Back Office</code> admin to convert a list of paired names (of surname, given name) to a list of names.
    /// --- Function: Adds capability to convert a list of names for <code>Back Office</code> object.
    /// --- Reference: Design Pattern - Decorator.
    /// </summary>
    public class ToNameListAssistant : BackOfficeAssistant
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="admin"><code>Back Office</code> object.</param>
        public ToNameListAssistant(BackOffice admin)
            : base(admin)
        {

        }

        /// <summary>
        /// Converts a list of paired data to a list.
        /// </summary>
        /// <param name="data">Data as list of paired names (of surname, given name).</param>
        /// <returns>List of data.</returns>
        public List<string> ToNameList(List<Tuple<string, string>> data)
        {
            List<string> result = new List<string>();

            if (_validator.ValidateNullOrEmpty(data) == true)
            {
                _logger.LogInformation(N_Shared.SharedVar.LOGTITLE_CONVERTTOSTR, N_Shared.SharedVar.LOGDESC_INFO_CONVERTINGTOSTRING);
                for (int i = 0; i < data.Count; i++)
                {
                    result.Add(string.Format(N_Shared.SharedVar.FULLNAME_STRFORMAT_NAMESURNAME,
                                                data[i].Item2,
                                                data[i].Item1).Trim());
                }
            }

            return result;
        }
    }
}
