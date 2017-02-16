using log4net;

namespace SpareParts.Logic
{
    public class BaseLogic
    {
        #region .: Private Members :.
        /// <summary>
        /// The logger
        /// </summary>
        private ILog logger;

        #endregion

        #region .: Public properties :.
        /// <summary>
        /// Gets the logger.
        /// </summary>
        /// <value>
        /// The logger.
        /// </value>
        protected ILog Logger
        {
            get
            {
                if (this.logger == null)
                {
                    log4net.Config.XmlConfigurator.Configure();
                    this.logger = log4net.LogManager.GetLogger("SpareParts");
                }

                return this.logger;
            }
        }

        #endregion
    }
}