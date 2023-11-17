using Dapper;
using Dapper.Contrib.Extensions;
using ProjectServiceEZATU.Database;
using ProjectServiceEZATU.DTO.Request.activity;
using ProjectServiceEZATU.Models.activity;
using ProjectServiceEZATU.Service.Interface.activity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectServiceEZATU.DTO.Request.home;
using System.Globalization;
using ProjectServiceEZATU.DTO.Response.activity;
using System.Data;
using sun.util.resources.cldr;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using sun.security.util;
using System.Net;
using IronPdf.Imaging;
using com.sun.tools.@internal.xjc.reader.gbind;
using ProjectServiceEZATU.DTO.Response.home;
using Google.Protobuf.WellKnownTypes;

namespace ProjectServiceEZATU.Manager.activity
{
    public class ActivityMa : IActivity
    {
        private readonly ILogger<ActivityMa> _logger;
        private readonly DapperContext _context;
        //private ActivityModel1 screenInfo;

        public ActivityMa(ILogger<ActivityMa> logger, DapperContext context)
        {
            _logger = logger;
            _context = context;
        }
        public async Task<List<calendarResponse>> calendar(CalendarRequest calendarRequest, string id)
        {
            List<calendarResponse> calendarResponseList = new List<calendarResponse>();

            try
            {
                using (var connection = _context.GetDbconnection())
                {
                    connection.Open();

                    var query = "SELECT activityname,venue,startdatebyteacher,finishdatebyteacher  FROM activitynamebyteacher";

                    var calendarInfos = await connection.QueryAsync<CalendarInfoResponse>(query, commandType: CommandType.Text);

                    foreach (var calendarInfo in calendarInfos)
                    {
                        if (DateTime.TryParseExact(calendarInfo.startdatebyteacher, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate) && (DateTime.TryParseExact(calendarInfo.finishdatebyteacher, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime finishDate)))
                        {
                            calendarResponseList.Add(new calendarResponse
                            {
                                activityname = calendarInfo.activityname,
                                activitystartdate = startDate,
                                activityfinishdate = finishDate,
                                activityvenue = calendarInfo.venue
                            });
                        }
                        else if (DateTime.TryParseExact(calendarInfo.startdatebyteacher, "dd/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate) && (DateTime.TryParseExact(calendarInfo.finishdatebyteacher, "dd/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out finishDate)))
                        {
                            calendarResponseList.Add(new calendarResponse
                            {
                                activityname = calendarInfo.activityname,
                                activitystartdate = startDate,
                                activityfinishdate = finishDate,
                                activityvenue = calendarInfo.venue
                            });
                        }
                        else if (DateTime.TryParseExact(calendarInfo.startdatebyteacher, "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate) && (DateTime.TryParseExact(calendarInfo.finishdatebyteacher, "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out finishDate)))
                        {
                            calendarResponseList.Add(new calendarResponse
                            {
                                activityname = calendarInfo.activityname,
                                activitystartdate = startDate,
                                activityfinishdate = finishDate,
                                activityvenue = calendarInfo.venue
                            });
                        }
                        else
                        {
                            
                        }
                        
                    }

                }
            }
            catch (Exception ex)
            {
                
            }

            return calendarResponseList;
        }
        public async Task<CalendarScreenResponse> calendarScreen(CalendarScreenRequest calendarScreenRequest, string id)
        {
            CalendarScreenResponse calendarScreenResponse = new CalendarScreenResponse()
            {
               
            };

            try
            {
                var query = "select a.*, b.userlanguage from LabelScreen a , language b where Screen =  @Screen  and userid = @userid ";
                //var query = "select * from LabelScreen  ";
                using (var connection = _context.GetDbconnection())
                {
                    connection.Open();
                    var activityscreen = (await connection.QueryAsync<ScreenDbContextData>(query, new { Screen = "calendarpage", userid = id })).ToList();
                    foreach (var screenData in activityscreen)
                    {
                        switch (screenData.parameter.ToLower().Trim())
                        {
                            case "titlecalendar":
                                calendarScreenResponse.titlecalendar = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;                      
                        }
                    }
                }
            }
            catch (Exception ex) { }


            return calendarScreenResponse;
        }

    }
}
