using ProjectServiceEZATU.DTO.Request;
namespace ProjectServiceEZATU.DTO.Request.activity
{
    public class SubmitaddeditactivityRequest
    {
        //public string token { get; set; }
        //public string userid { get; set; }
        public int activityid { get; set; }
        public string activityname { get; set; }
        public string year { get; set; }
        public string term { get; set; }
        public string startdate { get; set; }
        public string finishdate { get; set; }
        public string timehours { get; set; }
        public string timeminutes { get; set; }
        public string venue { get; set; }
        public string approver { get; set; }
        public string detail { get; set; }
        public string isdelete { get; set; }
        //public string status { get; set; }
    }
}
