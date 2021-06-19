using System.Text.Json.Serialization;

namespace Apis.Facebook.Models
{
    public class Page
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("about")]
        public string About { get; set; }
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
        [JsonPropertyName("affiliation")]
        public string Affiliation { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}