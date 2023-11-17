using System;

namespace ProjectServiceEZATU.Jwt.JWTManager
{
    internal class RefreshToken
    {
        public string UserName { get; set; }
        public string TokenString { get; set; }
        public DateTime ExpireAt { get; set; }
    }
}