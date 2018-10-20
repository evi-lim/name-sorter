using System;
using N_Input = NameSorter.Input;
using N_Shared = NameSorter.Shared;

namespace NameSorter
{
    /// <summary>
    /// <code>Program</code> starts shop.
    /// --- Function: Acts as the company / shop that opens everyday.
    /// --- Modification: Added <code>public</code> and <code>static</code> for Unit Test purposes.
    /// </summary>
    public static class Program
    {
        static N_Shared.Validator _validator = new N_Shared.Validator();
        static N_Shared.Logger _logger = new N_Shared.Logger();
        static N_Input.CustomerService _operator = new N_Input.CustomerService();

        /// <summary>
        /// Main execution method.
        /// </summary>
        /// <param name="args">Command arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                if (_validator.ValidateNullOrEmpty(args) == true)
                {
                    _operator.SortSurnameThenGivenName(args[0]);
                }
            }
            catch(Exception exc)
            {
                string message = (exc.InnerException != null && string.IsNullOrEmpty(exc.InnerException.Message) == false) ?
                                    exc.InnerException.Message :
                                    exc.Message;

                _logger.LogError(N_Shared.SharedVar.LOGTITLE_FATAL,
                                    string.Format(N_Shared.SharedVar.LOGDESC_ERROR_STRFORMAT_FATAL, message),
                                    N_Shared.SharedVar.LOGADVISE_FATALERROR);
            }
        }
    }
}
