using ProjectServiceEZATU.DTO.Request;
namespace ProjectServiceEZATU.DTO.Request.login
{
    public class SendOTPForgotPasswordRequest
    {
        public string userid { get; set; }
        public string email { get; set; }
        public string language { get; set; }

    }
    public class SubmitOTPForgotPasswordRequest
    {
        public string userid { get; set; }
        public string email { get; set; }
        public string newpassword { get; set; }
        public string confirmpassword{ get; set; }
        public string otp { get; set; }  
        public string refvaluetext { get; set; }
        public string language { get; set; }


    }
}
