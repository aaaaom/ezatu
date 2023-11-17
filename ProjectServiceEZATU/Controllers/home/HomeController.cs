using Dapper;
using ProjectServiceEZATU.Database;
using ProjectServiceEZATU.DTO.Request.activity;
using ProjectServiceEZATU.DTO.Request.home;
using ProjectServiceEZATU.Service;
using ProjectServiceEZATU.Service.Interface;
using ProjectServiceEZATU.Service.Interface.home;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
using ProjectServiceEZATU.Database.ConstantFixedDB;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectServiceEZATU.Controllers.home
{
    [Route("api/[controller]")]
    [ApiController]
    public class homeController : ControllerBase
    {
        private readonly ILogger<homeController> _logger;
        private IHome _ihome;
        private readonly DapperContext _context;


        public static string DateTimeFormat_dd_MM_yyyy = ConstantFixedDB.DateTimeFormat_dd_MM_yyyy;
        public homeController(ILogger<homeController> logger, IHome ihome,  DapperContext context)
        {
            _logger = logger;
            _ihome = ihome;
            _context = context;
        }

        [HttpPost]
        //[Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        [Route("morecontactus")]
        public async Task<IActionResult> MoreContactUs(MoreContactUsRequest moreContactUsRequest)
        {
            IActionResult response = null;
            bool Expire = true;
            try
            {
                Request.Headers.TryGetValue("Authorization", out var header);
                String token = header.ToString().Replace("Bearer ", "");

                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(token);
                var tokenS = jsonToken as JwtSecurityToken;
                var id = "";
                if (token != null && !token.Equals(""))
                {
                    var TimeExpire = tokenS.Claims.FirstOrDefault(claim => claim.Type.Contains("exp")).Value;
                    string iStringimeExpire = TimeExpire;
                    DateTime isTimeExpire = DateTime.ParseExact(iStringimeExpire, DateTimeFormat_dd_MM_yyyy, null);
                    string iStringUtcNow = DateTime.UtcNow.ToString(DateTimeFormat_dd_MM_yyyy, new CultureInfo("en-US"));
                    DateTime isUtcNow = DateTime.ParseExact(iStringUtcNow, DateTimeFormat_dd_MM_yyyy, null);
                    if (isTimeExpire > isUtcNow)
                    {
                        if (tokenS.Claims.FirstOrDefault(claim => claim.Type.Contains("name")) != null)
                        {
                            id = tokenS.Claims.FirstOrDefault(claim => claim.Type.Contains("name")).Value;
                            Expire = false;
                            var result = await _ihome.MoreContactUs(moreContactUsRequest, id);
                            if (result.status == 200)
                            {

                                response = Wrap.ResponseOK(false, result, true, "success", "home");
                            }
                            else
                            {
                                response = Wrap.ResponseError(false, null, result.message, 401, "home");
                            }
                        }
                    }
                    else
                    {
                        response = Wrap.ResponseError(Expire, null, "Token Expiration", 401, "home");
                    }
                }
                else
                {
                    response = Wrap.ResponseError(Expire, null, "Invalid access token.", 401, "home");
                }
            }
            catch (Exception ex)
            {
                response = Wrap.ResponseError(Expire, null, ex.Message, 401, "home");

            }

            return response;
        }

        [HttpPost]
        [Route("ChangeEmail")]
        public async Task<IActionResult> ChangEmail_OTP_OLD(ChangEmail_OTP_OLD_Request changEmail_OTP_OLD_Request)
        {
            IActionResult response = null;
            bool Expire = true;
            try
            {
                Request.Headers.TryGetValue("Authorization", out var header);
                String token = header.ToString().Replace("Bearer ", "");

                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(token);
                var tokenS = jsonToken as JwtSecurityToken;
                var id = "";
                if (token != null && !token.Equals(""))
                {
                    var TimeExpire = tokenS.Claims.FirstOrDefault(claim => claim.Type.Contains("exp")).Value;
                    string iStringimeExpire = TimeExpire;
                    DateTime isTimeExpire = DateTime.ParseExact(iStringimeExpire, DateTimeFormat_dd_MM_yyyy, null);
                    string iStringUtcNow = DateTime.UtcNow.ToString(DateTimeFormat_dd_MM_yyyy, new CultureInfo("en-US"));
                    DateTime isUtcNow = DateTime.ParseExact(iStringUtcNow, DateTimeFormat_dd_MM_yyyy, null);
                    if (isTimeExpire > isUtcNow)
                    {
                        id = tokenS.Claims.FirstOrDefault(claim => claim.Type.Contains("name")).Value;
                        Expire = false;
                        var result = await _ihome.ChangEmail_OTP_OLD(changEmail_OTP_OLD_Request, id);
                        if (result.status == 200)
                        {
                            if (result.message == "success")
                            {
                                response = Wrap.ResponseError(false, null, result.expemail, result.status, "home");
                            }else 
                            { 
                                response = Wrap.ResponseOK(false, result, true, result.message, "home"); 
                            }
                            
                        }

                        else if (result.status == 204)
                        {
                            if (result.message == "fillempty")
                            {
                                response = Wrap.ResponseError(false, null, result.fillempty, result.status, "home");
                            }
                            else if (result.message == "expemail")
                            {
                                response = Wrap.ResponseError(false, null, result.expemail, result.status, "home");
                            }
                            else if (result.message == "invalidpassword")
                            {
                                response = Wrap.ResponseError(false, null, result.invalidpassword, result.status, "home");
                            }
                            else if (result.message == "otpsuccess")
                            {
                                response = Wrap.ResponseError(false, null, result.otpsuccess, result.status, "home");
                            }
                            else if (result.message == "emailsub")
                            {
                                response = Wrap.ResponseError(false, null, result.emailsub, result.status, "home");
                            }
                            else if (result.message == "userandemailnotregis----- password")
                            {
                                response = Wrap.ResponseError(false, null, "userandemailnotregis----- password", result.status, "home");
                            }
                            else
                            {
                                response = Wrap.ResponseError(false, null, "exceptional case changeemail", result.status, "home");
                            }

                        }
                        else
                        {
                            response = Wrap.ResponseError(false, null, result.erroroccurred, 204, "home"); ;
                        }
                    }
                    else
                    {
                        response = Wrap.ResponseError(Expire, null, "Token Expiration", 401, "home");
                    }
                }
                else
                {
                    response = Wrap.ResponseError(Expire, null, "Token Expiration", 401, "home");
                }
            }

            catch (Exception ex)
            {
                response = Wrap.ResponseError(Expire, null, ex.Message, 401, "home");

            }

            return response;
        }
        [HttpPost]
        [Route("submitOTPConfirmChangeEmail")]
        public async Task<IActionResult> submitOTPConfirmChangeEmail(SubmitOTPConfirmChangeEmailRequest submitOTPConfirmChangeEmailRequest)
        {//ใช้request 2 ตัวไม่ได้
            IActionResult response = null;
            bool Expire = true;
            try
            {
                Request.Headers.TryGetValue("Authorization", out var header);
                String token = header.ToString().Replace("Bearer ", "");

                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(token);
                var tokenS = jsonToken as JwtSecurityToken;
                var id = "";
                if (token != null && !token.Equals(""))
                {
                    var TimeExpire = tokenS.Claims.FirstOrDefault(claim => claim.Type.Contains("exp")).Value;
                    string iStringimeExpire = TimeExpire;
                    DateTime isTimeExpire = DateTime.ParseExact(iStringimeExpire, DateTimeFormat_dd_MM_yyyy, null);
                    string iStringUtcNow = DateTime.UtcNow.ToString(DateTimeFormat_dd_MM_yyyy, new CultureInfo("en-US"));
                    DateTime isUtcNow = DateTime.ParseExact(iStringUtcNow, DateTimeFormat_dd_MM_yyyy, null);
                    if (isTimeExpire > isUtcNow)
                    {
                        id = tokenS.Claims.FirstOrDefault(claim => claim.Type.Contains("name")).Value;
                        Expire = false;
                        var result = await _ihome.submitOTPConfirmChangeEmail(submitOTPConfirmChangeEmailRequest, id);
                        if (result.status == 200)
                        {
                            if (result.message == "success")
                            {
                                response = Wrap.ResponseError(false, null, result.otpsuccess, result.status, "home");
                            }

                            else
                            {
                                response = Wrap.ResponseOK(false, result, true, result.message, "home");
                            }
                            
                        }

                        else if (result.status == 204)
                        {
                            if (result.message == "errornewandconfirm")
                            {
                                response = Wrap.ResponseError(false, null, result.errornewandconfirm, result.status, "home");
                            }

                            else if (result.message == "errornewemail")
                            {
                                response = Wrap.ResponseError(false, null, result.typeemail, result.status, "home");
                            }
                            else if (result.message == "fillempty")
                            {
                                response = Wrap.ResponseError(false, null, result.fillempty, result.status, "home");
                            }
                            else if (result.message == "typeemail")
                            {
                                response = Wrap.ResponseError(false, null, result.newemailsub, result.status, "home");
                            }
                            else if (result.message == "confirmnewemailsub")
                            {
                                response = Wrap.ResponseError(false, null, result.confirmnewemailsub, result.status, "home");
                            }
                            else if (result.message == "invalidotp")
                            {
                                response = Wrap.ResponseError(false, null, result.invalidotp, result.status, "home");
                            }
                            else if (result.message == "otpsuccess")
                            {
                                response = Wrap.ResponseError(false, null, result.otpsuccess, result.status, "home");
                            }
                            else if (result.message == "otpempty")
                            {
                                response = Wrap.ResponseError(false, null, result.otpempty, result.status, "home");
                            }
                            else if (result.message == "emailsub")
                            {
                                response = Wrap.ResponseError(false, null, result.emailsub, result.status, "home");
                            }
                            else if (result.message == "expotp")
                            {
                                response = Wrap.ResponseError(false, null, result.expotp, result.status, "home");
                            }
                        }
                        else
                        {
                            response = Wrap.ResponseError(false, null, result.erroroccurred, 204, "home"); ;
                        }
                    }
                    else
                    {
                        response = Wrap.ResponseError(Expire, null, "Token Expiration", 401, "home");
                    }
                }
                else
                {
                    response = Wrap.ResponseError(Expire, null, "Token Expiration", 401, "home");
                }
            }

            catch (Exception ex)
            {
                response = Wrap.ResponseError(Expire, null, ex.Message, 401, "home");

            }

            return response;
        }
        [HttpPost]
        [Route("SubmitOTPChangeEmail")]
        public async Task<IActionResult> submitOTPChangeEmail(SubmitOTPChangeEmailRequest submitOTPChangeEmailRequest)
        {
            IActionResult response = null;
            bool Expire = true;
            try
            {
                Request.Headers.TryGetValue("Authorization", out var header);
                String token = header.ToString().Replace("Bearer ", "");

                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(token);
                var tokenS = jsonToken as JwtSecurityToken;
                var id = "";
                if (token != null && !token.Equals(""))
                {
                    var TimeExpire = tokenS.Claims.FirstOrDefault(claim => claim.Type.Contains("exp")).Value;
                    string iStringimeExpire = TimeExpire;
                    DateTime isTimeExpire = DateTime.ParseExact(iStringimeExpire, DateTimeFormat_dd_MM_yyyy, null);
                    string iStringUtcNow = DateTime.UtcNow.ToString(DateTimeFormat_dd_MM_yyyy, new CultureInfo("en-US"));
                    DateTime isUtcNow = DateTime.ParseExact(iStringUtcNow, DateTimeFormat_dd_MM_yyyy, null);
                    if (isTimeExpire > isUtcNow)
                    {
                        id = tokenS.Claims.FirstOrDefault(claim => claim.Type.Contains("name")).Value;
                        Expire = false;
                        var result = await _ihome.submitOTPChangeEmail(submitOTPChangeEmailRequest, id);
                        if (result.status == 200)
                        {
                            if (result.message == "success")
                            {
                                response = Wrap.ResponseError(false, null, result.success, result.status, "home");
                            }
                            else 
                            {
                                response = Wrap.ResponseOK(false, result, true, result.changeemailsuccess, "home");
                            }
                            
                        }

                        else if (result.status == 204)
                        {
                            if (result.message == "invalidotp")
                            {
                                response = Wrap.ResponseError(false, null, result.invalidotp, result.status, "home");
                            }
                            else if (result.message == "otpempty")
                            {
                                response = Wrap.ResponseError(false, null, result.otpempty, result.status, "home");
                            }
                            else if (result.message == "expotp")
                            {
                                response = Wrap.ResponseError(false, null, result.expotp, result.status, "home");
                            }
                        }
                        else
                        {
                            response = Wrap.ResponseError(false, null, result.erroroccurred, 204, "home"); ;
                        }
                    }
                    else
                    {
                        response = Wrap.ResponseError(Expire, null, "Token Expiration", 401, "home");
                    }
                }
                else
                {
                    response = Wrap.ResponseError(Expire, null, "Token Expiration", 401, "home");
                }
            }

            catch (Exception ex)
            {
                response = Wrap.ResponseError(Expire, null, ex.Message, 401, "home");

            }

            return response;
        }
        [HttpPost]
        [Route("ChangeEmaiilScreen")]
        public async Task<IActionResult> ChangeEmailScreen(ChangeEmailScreenRequest changeEmailScreenRequest)
        {
            IActionResult response = null;
            bool Expire = true;
            try
            {
                Request.Headers.TryGetValue("Authorization", out var header);
                String token = header.ToString().Replace("Bearer ", "");

                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(token);
                var tokenS = jsonToken as JwtSecurityToken;
                var id = "";
                if (token != null && !token.Equals(""))
                {
                    var TimeExpire = tokenS.Claims.FirstOrDefault(claim => claim.Type.Contains("exp")).Value;
                    string iStringimeExpire = TimeExpire;
                    DateTime isTimeExpire = DateTime.ParseExact(iStringimeExpire, DateTimeFormat_dd_MM_yyyy, null);
                    string iStringUtcNow = DateTime.UtcNow.ToString(DateTimeFormat_dd_MM_yyyy, new CultureInfo("en-US"));
                    DateTime isUtcNow = DateTime.ParseExact(iStringUtcNow, DateTimeFormat_dd_MM_yyyy, null);
                    if (isTimeExpire > isUtcNow)
                    {
                        if (tokenS.Claims.FirstOrDefault(claim => claim.Type.Contains("name")) != null)
                        {
                            id = tokenS.Claims.FirstOrDefault(claim => claim.Type.Contains("name")).Value;
                            Expire = false;
                            var result = await _ihome.ChangeEmailScreen(changeEmailScreenRequest, id);
                            response = Wrap.ResponseOK(Expire, result, true, "success", "home");
                        }
                    }
                    else
                    {
                        response = Wrap.ResponseError(Expire, null, "Token Expiration", 401, "home");
                    }
                }
                else
                {
                    response = Wrap.ResponseError(Expire, null, "Invalid access token.", 401, "home");
                }
            }
            catch (Exception ex)
            {
                response = Wrap.ResponseError(Expire, null, ex.Message, 401, "home");

            }

            return response;
        }
    }
}



