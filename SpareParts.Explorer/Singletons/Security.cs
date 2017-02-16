using SpareParts.Dto;
using SpareParts.Explorer.DataService;
using System;
using System.ServiceModel;

namespace SpareParts.Explorer.Singletons
{
    public class Security
    {
        private string _CurrentUserName;

        public string CurrentUserName
        {
            get { return this._CurrentUserName; }
            set { this._CurrentUserName = value; }
        }

        private UserDto _LoggedUser;
        /// <summary>
        /// Gets the logged user.
        /// </summary>
        /// <value>
        /// The logged user.
        /// </value>
        public UserDto LoggedUser
        {
            get
            {
                if (this._LoggedUser == null)
                {
                    this._LoggedUser = ServiceClient.GetUserByUserName(this._CurrentUserName);
                }

                return this._LoggedUser;
            }
        }

        /// <summary>
        /// Gets the display name of the logged.
        /// </summary>
        /// <value>
        /// The display name of the logged.
        /// </value>
        public string LoggedDisplayName
        {
            get
            {
                if (this.LoggedUser != null)
                    return string.Format("{0} {1}", this.LoggedUser.FirstName, this.LoggedUser.LastName);

                return Environment.UserName;
            }
        }

        private IDataService _ServiceClient;
        /// <summary>
        /// Gets the service client.
        /// </summary>
        /// <value>
        /// The service client.
        /// </value>
        protected IDataService ServiceClient
        {
            get
            {
                if (this._ServiceClient == null)
                    _ServiceClient = new ChannelFactory<IDataService>("DataService").CreateChannel();

                return _ServiceClient;
            }
        }

        private static readonly Security _Instance = new Security();
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static Security Instance
        {
            get
            {
                return _Instance;
            }
        }
    }
}