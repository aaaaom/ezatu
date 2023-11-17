using ProjectServiceEZATU.DTO.Request;
using System.Text.Json.Serialization;

namespace ProjectServiceEZATU.DTO.Request.activity
{
    public class DeleteaccountRequest
    {
        public string password { get; set; }
        [JsonPropertyName("refreshToken")]
        public string refreshtoken { get; set; }
    }
}
