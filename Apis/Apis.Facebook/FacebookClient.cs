using Apis.Facebook.Services;
using Apis.Facebook.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Apis.Facebook
{
    public class FacebookClient : IFacebookClient
    {
        private string _accessToken;
        private IUserService _users;
        public IUserService Users => _users;

        public string AccessToken => _accessToken;

        public FacebookClient() : this(null, null)
        {

        }
        public FacebookClient(string accessToken) : this(accessToken, null)
        {
        }

        public FacebookClient(string accessToken, HttpClient httpClient)
        {
            _accessToken = accessToken;
            _users = new UserService(_accessToken, httpClient);
        }
    }
}
