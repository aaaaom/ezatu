namespace ProjectServiceEZATU.DTO.Request.home
{
    //public class SubmitnewemailRequest
    //{
    //    public string language { get; set; }
    //    public SubmitOTPConfirmChangeEmailRequest submitOTPConfirmChangeEmailRequest { get; set; }
    //    public ExpChangeemailRequest expChangeemailRequest { get; set; }
    //}
    public class SubmitOTPConfirmChangeEmailRequest
    {

        public string newemail { get; set; }
        public string confirmemail { get; set; }
        public string otp { get; set; }
        public string refvaluetext { get; set; }
        public string language { get; set; }


    }

    //public class ExpChangeemailRequest
    //{
    //    public string newemail { get; set; }
    //    public string confirmemail { get; set; }
    //    public string language { get; set; }
    //}
}
