using Microsoft.AspNetCore.Mvc;
using ProjectServiceEZATU.DTO.Request.activity;
using ProjectServiceEZATU.DTO.Response.activity;
using ProjectServiceEZATU.Models.activity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectServiceEZATU.Service.Interface.activity
{
    public interface IActivity
    {
        Task<List<calendarResponse>> calendar(CalendarRequest calendarRequest,string id);
        Task<CalendarScreenResponse> calendarScreen(CalendarScreenRequest calendarScreenRequest, string id);

    }
}
