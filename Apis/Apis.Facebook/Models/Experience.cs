using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Apis.Facebook.Models
{
    public class Experience
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("from")]
        public User From { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("with")]
        public List<User> With { get; set; }
    }
}