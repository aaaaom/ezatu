using System;

namespace ProjectServiceEZATU.DTO.Response.login
{
    public class CheckTokenExpiredResponse
    {
        internal int status;
        internal string message;
        public bool expire { get; set; }
        public string expiremessage { get; set; }
        public string code { get; set; }
        public string timenow { get; set; }
        public string timeexpir { get; set; }
        public string typetime { get; set; }
    }
}