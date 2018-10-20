using N_Shared = NameSorter.Shared;

namespace NameSorter.Process
{
    /// <summary>
    /// <code>Back Office Assistant</code> assists <code>Back Office</code> admin to perform tasks.
    /// --- Function: Adds functionalities to <code>Back Office</code> object.
    /// --- Reference: Design Pattern - Decorator.
    /// </summary>
    public abstract class BackOfficeAssistant : BackOffice
    {
        protected BackOffice _admin;
        protected N_Shared.Logger _logger;
        protected N_Shared.Validator _validator;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="admin"><code>Back Office</code> admin.</param>
        public BackOfficeAssistant(BackOffice admin)
        {
            this._admin = admin;
            this._logger = new N_Shared.Logger();
            this._validator = new N_Shared.Validator();
        }
    }
}
