
namespace NameSorter.Shared
{
    /// <summary>
    /// Interface that logs errors and prints to screen.
    /// --- Returns: TRUE / FALSE.
    ///              True - Given input has values (NOT NULL or empty).
    ///              False - Given input is NULL or empty.
    /// </summary>
    public interface ILogError
    {
        /// <summary>
        /// Logs information and prints to screen.
        /// </summary>
        /// <param name="title">Title of the error.</param>
        /// <param name="desc">Description of the error.</param>
        /// <param name="advise">Advise to fix the error.</param>
        /// <returns>TRUE (for Unit Test purposes).</returns>
        bool LogError(string title, string desc, string advise);
    }
}
