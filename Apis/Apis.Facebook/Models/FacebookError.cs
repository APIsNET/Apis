using System.Text.Json.Serialization;

namespace Apis.Facebook.Models
{
    public class FacebookError
    {
        [JsonPropertyName("error")]
        public FacebookErrorInfo Error { get; set; }
    }

    public class FacebookErrorInfo
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("code")]
        public int Code { get; set; }
        [JsonPropertyName("fbtrace_id")]
        public string FbtraceId { get; set; }
    }
}