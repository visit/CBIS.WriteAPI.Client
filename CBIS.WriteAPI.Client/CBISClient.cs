using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBIS.WriteAPI.Client.Generated;

namespace CBIS.WriteAPI.Client
{
    public class CBISClient
    {
        public readonly WriteAPIClient Client;

        public CBISClient(string endpointConfiguration, string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException(nameof(username));
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException(nameof(password));
            }

            Client = new WriteAPIClient(endpointConfiguration);
            Client.ChannelFactory.Credentials.UserName.UserName = username;
            Client.ChannelFactory.Credentials.UserName.Password = password;
        }
    }
}
