
namespace NameSorter.Shared
{
    /// <summary>
    /// <code>Shared Var</code> holds all shared variables / constants throughout the application.
    /// --- Function: Stores all variables.
    /// --- Reference: Design Pattern - None.
    /// </summary>
    public static class SharedVar
    {
        public static char SEPARATOR_NAMESURNAME = ' ';

        public static string OUTPUT_FILENAME = "sorted-names-list.txt";

        public static string LOGINFO_STRFORMAT_TITLEDESC = "{0}: {1}.";
        public static string LOGERROR_STRFORMAT_TITLEDESCADVISE = "{0}: {1}. {2}.";

        public static string LOGTITLE_CONVERTTOTUPLE = "Conversion to Tuple List";
        public static string LOGTITLE_CONVERTTOSTR = "Conversion to String";
        public static string LOGTITLE_FATAL = "Fatal Error";
        public static string LOGTITLE_FILEVALIDATION = "File Validation";
        public static string LOGTITLE_FILEOPERATION = "File Operation";
        public static string LOGTITLE_SORTBYSURNAMETHENGIVENNAME = "Sort by Surname Then Given Name";

        public static string LOGDESC_ERROR_STRFORMAT_FATAL = "Program is exiting, {0}";
        public static string LOGDESC_ERROR_STRFORMAT_FILENOTEXIST = "File at path [{0}] doesn't exist";
        public static string LOGDESC_INFO_CONVERTINGTOTUPLE = "Converting data to a list of tuple";
        public static string LOGDESC_INFO_CONVERTINGTOSTRING = "Converting data to string";
        public static string LOGDESC_INFO_READINGFILE = "Reading file...";
        public static string LOGDESC_INFO_SORTBYSURNAMETHENGIVENNAME = "Sorting data by surname then by given name in ascending order";

        public static string LOGADVISE_ENSUREFILEVALID = "Make sure the path is correct, and the file exists. If problem persists, please contact Administrator to get further assistance.";
        public static string LOGADVISE_FATALERROR = "Thank you for using [Name Sorter], see you again soon. Contact Administrator for further inquiries.";

        public static string FULLNAME_STRFORMAT_NAMESURNAME = "{0} {1}";
    }
}
