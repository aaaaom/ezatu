namespace ProjectServiceEZATU.DTO.Request.home 
{ 
public class SubmitOTPChangeEmailRequest
    {
        public string otp { get; set; }
        public string refvalue { get; set; }
        public string language { get; internal set; }
    }
}