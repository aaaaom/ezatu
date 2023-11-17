using Microsoft.AspNetCore.Http;
using ProjectServiceEZATU.DTO.Request;
namespace ProjectServiceEZATU.DTO.Request.activity
{
    public class AddEditDeleteNameActivityByTeacherRequest
    {
        public int activitynameid { get; set; }
        public string activityname { get; set; }
        public string objectives { get; set; }
        public string venue { get; set; }
        public string startdatebyteacher { get; set; }
        public string finishdatebyteacher { get; set; }
        public string isdelete { get; set; }
        public IFormFile image { get; set; }
    }
}
