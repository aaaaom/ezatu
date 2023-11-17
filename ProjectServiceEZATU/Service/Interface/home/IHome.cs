using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectServiceEZATU.Models.home;
using ProjectServiceEZATU.DTO.Response.more;
using ProjectServiceEZATU.DTO.Request.home;
using ProjectServiceEZATU.Database;
using ProjectServiceEZATU.DTO.Request.activity;
using ProjectServiceEZATU.DTO.Response.home;

namespace ProjectServiceEZATU.Service.Interface.home
{
    public interface IHome
    {
        Task<MoreContactUsResponse> MoreContactUs(MoreContactUsRequest moreContactUsRequest, String id);
        Task<ChangEmail_OTP_OLD_Response> ChangEmail_OTP_OLD(ChangEmail_OTP_OLD_Request changEmail_OTP_OLD_Request,string id);
        Task<SubmitOTPConfirmChangeEmailResponse> submitOTPConfirmChangeEmail(SubmitOTPConfirmChangeEmailRequest submitOTPConfirmChangeEmailRequest, string id);
        Task<SubmitOTPChangeEmailResponse> submitOTPChangeEmail(SubmitOTPChangeEmailRequest submitOTPChangeEmailRequest, string id);
        Task<ChangeEmailScreenResponse> ChangeEmailScreen(ChangeEmailScreenRequest changeEmailScreenRequest, String id);


    }
}
