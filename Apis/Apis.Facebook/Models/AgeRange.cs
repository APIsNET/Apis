using System.Text.Json.Serialization;

namespace Apis.Facebook.Models
{
    public class AgeRange
    {
        [JsonPropertyName("max")]
        public int Max { get; set; }
        [JsonPropertyName("min")]
        public int Min { get; set; }
    }
}