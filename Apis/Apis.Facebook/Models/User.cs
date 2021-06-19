using Apis.Models;
using System.Text.Json.Serialization;
namespace Apis.Facebook.Models
{
    public class User : BaseModel<FacebookError>
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("first_name")]
        public string Firstname { get; set; }
        [JsonPropertyName("last_name")]
        public string Lastname { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }
    }
}