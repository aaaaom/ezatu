using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProjectServiceEZATU.Database;
using ProjectServiceEZATU.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectServiceEZATU.Models.home;

namespace ProjectServiceEZATU.DTO.Response.home
{
    public class SettingsResponse
    {
        public ScreenInfoSettings screenInfo { get; set; }
        public ErrorButton errorbutton { get; set; }
        public AlertMessageSettings alertmessage { get; set; }

        internal int status;
        internal string message;}
    public class ScreenInfoSettings
    {
        //public string titleact { get; set; }
        //public string btnadd { get; set; }
        //public string textname { get; set; }
        //public string textnickname { get; set; }
        //public string textgen { get; set; }
        //public string textstdcode { get; set; }
        //public string textemail { get; set; }
        //public string textrole { get; set; }
        //public string textappver { get; set; }
        public string textlang { get; set; }
        public string textthai { get; set; }
        public string btncpass { get; set; }
        public string btncpin { get; set; }
        public string btndelacc { get; set; }
        public string btnlogout { get; set; }
        public string modetheme { get; set; }
        public string lockscreencode { get; set; }
        public string dark { get; set; }
        public string setting { get; set; }
        public string label_change_email { get; set; }
        public string langeuage { get; set; }
       
    }
    public class AlertMessageSettings
    {
        public string alertdeleteaccount { get; set; }
        public string alertdeleteaccountpassword { get; set; }
        public string alertdeleteaccountpdpa { get; set; }
        public string alertlogout { get; set; }
        public string alertpassword { get; set; }
        public string emailsupport { get; set; }
        public string phonesupport { get; set; }
        public string texConfirmChangeEmail { get; set; }
        public string texConfirmChangepass { get; set; }
        public string alertChangeSuc { get; set; }
        public string alertChangepass { get; set; }


    }
    public class DeleteaccountDb
    {
        internal int statuss;
        internal string message;
        internal string errordelete;
        internal string erroroccurred;
        internal string passwrong;
        public int id { get; set; }
        public string userid { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string password { get; set; }
        public string useremail { get; set; }
        public string userphone { get; set; }
        public string userlanguage { get; set; }
        public string role { get; set; }
        public string number { get; set; }
        public string moo { get; set; }
        public string soi { get; set; }
        public string road { get; set; }
        public string subdistrict { get; set; }
        public string district { get; set; }
        public string province { get; set; }
        public string zipcode { get; set; }
        public string userattention { get; set; }
        public string userstatus { get; set; }
        public string userjobtype { get; set; }
        public string userworkplace { get; set; }
        public string usercareer { get; set; }
        public string usercompany { get; set; }
        public string phone { get; set; }
        public string line { get; set; }
        public string facebook { get; set; }
        public string instagram { get; set; }
        public string twitter { get; set; }
        public string youtube { get; set; }
        public string faculty { get; set; }
        public string department { get; set; }
        public string major { get; set; }
        public string gpajhs { get; set; }
        public string gpashs { get; set; }
        public string gpabd { get; set; }
        public string activityid { get; set; }
        public string activityname { get; set; }
        public string year { get; set; }
        public string term { get; set; }
        public string startdate { get; set; }
        public string Finishdate { get; set; }
        public string approver { get; set; }
        public string venue { get; set; }
        public string detail { get; set; }
        public string status { get; set; }
        public string timehours { get; set; }
        public string timeminutes { get; set; }
        public string img { get; set; }

    }
}
