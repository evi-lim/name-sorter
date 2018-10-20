using System;
using System.Collections.Generic;
using N_Shared = NameSorter.Shared;

namespace NameSorter.Process
{
    /// <summary>
    /// <code>To Surname Tuple Assistant</code> assists <code>Back Office</code> admin to convert a list of names to a list of paired names (of surname, given name).
    /// --- Function: Adds capability to convert names to a list of paired names (of surname, given name) for <code>Back Office</code> object.
    /// --- Reference: Design Pattern - Decorator.
    /// </summary>
    public class ToSurnameTupleAssistant : BackOfficeAssistant
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="admin"><code>Back Office</code> admin.</param>
        public ToSurnameTupleAssistant(BackOffice admin)
            : base(admin)
        {

        }

        /// <summary>
        /// Converts a list of names to a list of paired names (of surname, given names).
        /// </summary>
        /// <param name="data">A list of names.</param>
        /// <returns>A list of paired names (of surname, given name).</returns>
        public List<Tuple<string, string>> ToSurnameTuple(List<string> data)
        {
            List<Tuple<string, string>> result = new List<Tuple<string, string>>();

            if (_validator.ValidateNullOrEmpty(data) == true)
            {
                _logger.LogInformation(N_Shared.SharedVar.LOGTITLE_CONVERTTOTUPLE, N_Shared.SharedVar.LOGDESC_INFO_CONVERTINGTOTUPLE);
                string nameItem = string.Empty;
                string[] nameArray = new string[0];
                string surname = string.Empty;
                string givenName = string.Empty;
                for (int i = 0; i < data.Count; i++)
                {
                    nameItem = data[i];
                    nameArray = nameItem.Split(N_Shared.SharedVar.SEPARATOR_NAMESURNAME);
                    surname = (nameArray.Length == 1 ? string.Empty : nameArray[nameArray.Length - 1]); // Some people doesn't have surnames.
                    givenName = string.IsNullOrEmpty(surname) == true ?
                                        nameItem :
                                        nameItem.Replace(N_Shared.SharedVar.SEPARATOR_NAMESURNAME.ToString() + surname,
                                                            string.Empty);
                    // Concat [Separator] + [Surname], because [Separator] may be anything other than [Space].
                    result.Add(new Tuple<string, string>(surname, givenName));
                }
            }

            return result;
        }
    }
}
