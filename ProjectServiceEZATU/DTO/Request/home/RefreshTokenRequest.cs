using System.Text.Json.Serialization;
using ProjectServiceEZATU.DTO.Request;
namespace ProjectServiceEZATU.DTO.Request.home
{
    public class RefreshTokenRequest
    {
        [JsonPropertyName("refreshToken")]
        public string refreshtoken { get; set; }
    }
}
