using System;
using System.Collections.Generic;
using System.Linq;
using N_Shared = NameSorter.Shared;

namespace NameSorter.Process
{
    /// <summary>
    /// <code>Sort by Surname Then Given Name Assistant</code> assists <code>Back Office</code> admin to sort names by surname.
    /// --- Function: Adds capability to sort by surname then given name for <code>Back Office</code> object.
    /// --- Reference: Design Pattern - Decorator.
    /// </summary>
    public class SortBySurnameThenGivenNameAssistant : BackOfficeAssistant
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="admin"><code>Back Office</code> admin.</param>
        public SortBySurnameThenGivenNameAssistant(BackOffice admin)
            : base(admin)
        {

        }

        /// <summary>
        /// Sorts a list of paired data based on surname (key).
        /// </summary>
        /// <param name="data">Input data as a list of paired data.</param>
        /// <returns>Sorted list of paired data.</returns>
        public List<Tuple<string, string>> SortBySurnameThenGivenName(List<Tuple<string, string>> data)
        {
            List<Tuple<string, string>> result = data;

            if (_validator.ValidateNullOrEmpty(data) == true)
            {
                _logger.LogInformation(N_Shared.SharedVar.LOGTITLE_SORTBYSURNAMETHENGIVENNAME, N_Shared.SharedVar.LOGDESC_INFO_SORTBYSURNAMETHENGIVENNAME);
                result = result.OrderBy(x => x.Item1)
                                .ThenBy(x => x.Item2)
                                .ToList();
            }

            return result;
        }
    }
}
