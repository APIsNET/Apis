using Apis.Facebook.Enums;
using Apis.Facebook.Models;
using Apis.Facebook.Services.Interfaces;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
namespace Apis.Facebook.Services
{
    public class UserService : IUserService
    {
        #region Fields
        private readonly HttpClient _httpClient;
        private string _accessToken;
        #endregion


        #region ctors
        public UserService() : this(string.Empty, null)
        {

        }

        public UserService(string accessToken, HttpClient httpClient)
        {
            _accessToken = accessToken;
            _httpClient = httpClient ?? new HttpClient()
            {
                BaseAddress = new Uri("https://graph.facebook.com")
            };
        }
        #endregion


        #region Methods
        public async Task<User> GetMeAsync()
        {
            return await GetMeAsync(UserField.id, UserField.name);
        }

        public async Task<User> GetMeAsync(params UserField[] fields)
        {
            string fieldsToEndpoint = string.Empty;
            for (int i = 0; i < fields.Length; i++)
            {
                fieldsToEndpoint += fields[i].ToString();
                fieldsToEndpoint += ",";
            }
            fieldsToEndpoint = fieldsToEndpoint.Remove(fieldsToEndpoint.Length - 1);
            var endpoint = $"v11.0/me?access_token={_accessToken}&fields={fieldsToEndpoint}";
            var res = await _httpClient.GetAsync(endpoint);
            User userToReturn = null;
            if (res.IsSuccessStatusCode)
            {
                userToReturn = JsonSerializer.Deserialize<User>(await res.Content.ReadAsStringAsync());
            }
            else
            {
                userToReturn = new User();
                userToReturn.Error = JsonSerializer.Deserialize<FacebookError>(await res.Content.ReadAsStringAsync());
            }
            return userToReturn;
        }
        #endregion
    }
}