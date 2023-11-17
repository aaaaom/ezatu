using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ProjectServiceEZATU.Models;
using ProjectServiceEZATU.Database;
using System;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using ProjectServiceEZATU.Manager;
using ProjectServiceEZATU.Service;
using ProjectServiceEZATU.Service.Interface;
using ProjectServiceEZATU.DTO.Request.login;
using ProjectServiceEZATU.DTO.Request.activity;
using ProjectServiceEZATU.Service.Interface.activity;
using ProjectServiceEZATU.DTO.Response.activity;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Http;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Dapper;
using ProjectServiceEZATU.DTO.Request.profile;
using System.Globalization;
using ProjectServiceEZATU.Database.ConstantFixedDB;
using ProjectServiceEZATU.DTO.Request.home;
using ProjectServiceEZATU.Service.Interface.home;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectServiceEZATU.Controllers.activity
{
    [Route("[controller]")]
    [ApiController]
    public class activityController : ControllerBase
    {
        private readonly ILogger<activityController> _logger;
        private IActivity _iactivity;
        private readonly DapperContext _context;


        public static string DateTimeFormat_dd_MM_yyyy = ConstantFixedDB.DateTimeFormat_dd_MM_yyyy;
        public activityController(ILogger<activityController> logger, IActivity iactivity, DapperContext context)
        {
            _logger = logger;
            _iactivity = iactivity;
            _context = context;
        }
        
        [HttpPost]
        [Route("calendar")]
        public async Task<IActionResult> calendar(CalendarRequest calendarRequest)
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
                            var result = await _iactivity.calendar(calendarRequest, id);
                            response = Wrap.ResponseOK(Expire, result, true, "success", "activity");
                        }
                    }
                    else
                    {
                        response = Wrap.ResponseError(Expire, null, "Token Expiration", 401, "activity");
                    }
                }
                else
                {
                    response = Wrap.ResponseError(Expire, null, "Invalid access token.", 401, "activity");
                }
            }
            catch (Exception ex)
            {
                response = Wrap.ResponseError(Expire, null, ex.Message, 401, "activity");

            }

            return response;
        }


        [HttpPost]
        [Route("calendarScreen")]
        public async Task<IActionResult> calendarScreen(CalendarScreenRequest calendarScreenRequest)
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
                            var result = await _iactivity.calendarScreen(calendarScreenRequest, id);
                            response = Wrap.ResponseOK(Expire, result, true, "success", "activity");
                        }
                    }
                    else
                    {
                        response = Wrap.ResponseError(Expire, null, "Token Expiration", 401, "activity");
                    }
                }
                else
                {
                    response = Wrap.ResponseError(Expire, null, "Invalid access token.", 401, "activity");
                }
            }
            catch (Exception ex)
            {
                response = Wrap.ResponseError(Expire, null, ex.Message, 401, "activity");

            }

            return response;
        }
        
    }
}
