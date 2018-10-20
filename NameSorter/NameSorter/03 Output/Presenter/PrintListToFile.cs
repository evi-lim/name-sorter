using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NameSorter.Output
{
    public class PrintListToFile : Presenter
    {
        /// <summary>
        /// Print given data to console.
        /// </summary>
        /// <param name="data">Data in list (of string).</param>
        /// <returns>TRUE (for Unit Test purposes).</returns>
        public override bool DisplayInConsole(dynamic data)
        {
            bool result = false;

            Console.WriteLine(string.Empty);
            List<string> listdata = (data is List<string> ? data as List<string> : new List<string>()); // Define new list to prevent error.
            for (int i = 0; i < listdata.Count; i++)
            {
                Console.WriteLine(listdata[i]);
            }

            result = true;
            return result;
        }

        /// <summary>
        /// Print given data to specified file.
        /// </summary>
        /// <param name="data">Data in list (of string).</param>
        /// <returns></returns>
        public override bool DisplayInFile(dynamic data)
        {
            bool result = false;

            List<string> listdata = (data is List<string> ? data as List<string> : new List<string>()); // Define new list to prevent error.
            using (StreamWriter writer = new StreamWriter(_target_filepath, false))
            {
                for (int i = 0; i < listdata.Count; i++)
                {
                    writer.WriteLine(listdata[i]);
                }
            }

            result = true;
            return result;
        }
    }
}
