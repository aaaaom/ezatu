using ProjectServiceEZATU.DTO.Request;
namespace ProjectServiceEZATU.DTO.Request.login
{
    public class SetnewpassforgotRequest
    {
        public string UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public string OTP { get; set; }
    }
}
