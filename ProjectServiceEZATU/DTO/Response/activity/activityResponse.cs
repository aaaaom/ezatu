using ProjectServiceEZATU.Database;
using ProjectServiceEZATU.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ProjectServiceEZATU.DTO.Response.activity
{
    public class activityResponse
    {
        public Body Body { get; set; }
        public ScreeninfoResponse screeninfo { get; set; }
    }
    public class Body
    {
        public ScreenProfileInfoResonse screeninfo { get; set; }
        public List<string> yearlist { get; set; }
        public List<string> termlist { get; set; }
        public List<string> approverlist { get; set; }
    }

    public class ScreeninfoResponse
    {
        public string Titleaddact { get; set; }
        public string Titleeditact { get; set; }
        public string Edtactname { get; set; }
        public string Edtyear { get; set; }
        public string Edtterm { get; set; }
        public string Edtstartdate { get; set; }
        public string Edtfinishdate { get; set; }
        public string Edttime { get; set; }
        public string Edttvenue { get; set; }
        public string Edtdetail { get; set; }
        public string Btnconfirm { get; set; }
    }

    public class calendarResponse
    {
        public string activityname { get; set; }
        public DateTime activitystartdate { get; set; }
        public DateTime activityfinishdate { get; set; }
        public string activityvenue { get; set; }

    }


}
