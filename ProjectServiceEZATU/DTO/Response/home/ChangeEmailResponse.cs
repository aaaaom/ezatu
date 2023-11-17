using ProjectServiceEZATU.Database;

namespace ProjectServiceEZATU.DTO.Response.home
{
    public class ChangeEmailResponse
    {
        
    }
    public class ChangEmail_OTP_OLD_Response
    {
        public string refvalue { get; set; }
        public string useremail { get; set; }
        public int time { get; set; }
        public bool alumni_expire { get; set; }
        

        internal int status;
        internal string message;
        internal string language;
        internal string fillempty;
        internal string expemail;
        internal string invalidpassword;
        internal string otpsuccess;
        internal string emailsub;
        internal string failedsendotp;
        internal string erroroccurred;
        internal string success;

    }
    public class SubmitOTPChangeEmailResponse
    {
        internal string refvalue { get; set; }
        //public string email { get; set; }
        //public int time { get; set; }

        internal int status;
        internal string message;
        internal string invalidotp;
        internal string otpempty;
        internal string expotp;
        internal string erroroccurred;
        internal string language;
        internal string changeemailsuccess;
        public string useremail;
        internal string success;

    }
    public class ChangeEmailScreenResponse
    {
        public ErrorButton errorButton { get; set; }
        public AlertMessageChangeEmail alertMessageChangeEmail { get; set; }
        public string texEXPEmail { get; set; }
        public string btnSubmit { get; set; }
        public string edtConNewEmail { get; set; }
        public string edtNewEmail { get; set; }
        public string resetRefMin { get; set; }
        public string resetRef { get; set; }
        public string textref { get; set; }
        public string EnterOTP { get; set; }
        public string texFindEmail { get; set; }
        public string texCheckEmail { get; set; }
        public string titlechangEmail { get; set; }
        public string btnCancel { get; set; }
        public string btnconfirm { get; set; }
        public string texPassword { get; set; }
 


    }
}
