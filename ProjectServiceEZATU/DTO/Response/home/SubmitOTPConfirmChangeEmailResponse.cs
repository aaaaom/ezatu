namespace ProjectServiceEZATU.DTO.Response.home
{
    public class SubmitOTPConfirmChangeEmailResponse
    {
        
        internal int status;
        internal string message;
        internal string errornewandconfirm;
        internal string typeemail;
        internal string fillempty;
        internal string newemailsub;
        internal string confirmnewemailsub;
        internal string invalidotp;
        internal string otpsuccess;
        internal string otpempty;
        internal string emailsub;
        internal string expotp;
        internal string erroroccurred;
        internal string refvalue;
        internal string language;
        internal string success;
        public int time { get; set; }
        public string refvalueforSubmitChangeEmail { get; set; }
        public string sendotptonewemail { get; set; }
    }
}
