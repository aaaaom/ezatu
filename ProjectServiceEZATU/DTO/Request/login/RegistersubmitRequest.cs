using ProjectServiceEZATU.DTO.Request;
namespace ProjectServiceEZATU.DTO.Request.login
{
    public class RegistersubmitRequest
    {
        public string userid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }
        public string language { get; set; }
    }
}

