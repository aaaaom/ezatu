using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace ProjectServiceEZATU.Models.home
{
    public class DrModel
    {
        public ScreenInfoDr1 screenInfo { get; set; }
        public string vs { get; set; }
    }
    public class ScreenInfoDr1
    {
        public string titlestatus { get; set; }
        public string btnadd { get; set; }
        public string textname { get; set; }
        public string textnickname { get; set; }
        public string textgen { get; set; }
        public string textstdcode { get; set; }
        public string textemail { get; set; }
        public string textrole { get; set; }
        public string textlang { get; set; }
        public string textlangdetail { get; set; }
        public string textstdtc { get; set; }
        public string btncpass { get; set; }
        public string btndelacc { get; set; }
        public string textappver { get; set; }
        public string btnlogout { get; set; }
    }
}
