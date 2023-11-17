namespace ProjectServiceEZATU.Jwt.JWTManager
{
    internal class JwtAuthResult
    {
        public string AccessToken { get; set; }
        public RefreshToken RefreshToken { get; set; }
    }
}