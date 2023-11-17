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
    public class HomeResponse
    {
    }
    public class DrawersResponse
    {
        public ScreenInfoHome screenInfo { get; set; }
        public ErrorButton errorbutton { get; set; }
        public AlertMessageHome alertmessage { get; set; }

        internal int status;
        internal string message;

    }
    public class DrawersTCResponse
    {
        public ScreenInfoHomeTC screenInfo1 { get; set; }
        public ErrorButton errorbutton { get; set; }
        public AlertMessageHome alertmessage { get; set; }

        internal int status;
        internal string message;

    }
    public class HomeScreenResponse
    {
        public ScreenInfoHome screenInfo { get; set; }
        public ErrorButton errorbutton { get; set; }
        public AlertMessageHome alertmessage { get; set; }
        public OtherData other { get; set; }

        internal int status;
        internal string message;

    }
    public class NoActivityResponse
    {

        internal int status;
        internal string message;
        public NoActivityScreenInfoResponse screeninfo { get; set; }

    }
    public class NoActivityScreenInfoResponse
    {
        public string noactivity { get; set; }
        public string subactlineone { get; set; }
        public string subactlinetwo { get; set; }
    }

    public class NoActivityTeacherResponse
    {

        internal int status;
        internal string message;
        public NoActivityTeacherScreenInfoResponse screeninfo { get; set; }

    }
    public class NoActivityTeacherScreenInfoResponse
    {
        public string noactivity { get; set; }
        public string subactlineone { get; set; }
        public string subactlinetwo { get; set; }
    }

    public class MorePreViewResumeResponse
    {

        internal int status;
        internal string message;
        public ScreenInfoMorePreViewResumeResponse screenInfo { get; set; }
        public MorePreViewResumeDataResponse data { get; set; }

    }
    public class ScreenInfoMorePreViewResumeResponse
    {
        public string aboutme { get; set; }
        public string aboutmedetail { get; set; }
        public string address { get; set; }
        public string appliedposition { get; set; }
        public string certificate { get; set; }
        public string contact { get; set; }
        public string textdefault { get; set; }
        public string description { get; set; }
        public string detail { get; set; }
        public string district { get; set; }
        public string editinfomations { get; set; }
        public string education { get; set; }
        public string educationinfo { get; set; }
        public string email { get; set; }
        public string enddate { get; set; }
        public string experience { get; set; }
        public string feacbook { get; set; }
        public string instagram { get; set; }
        public string language { get; set; }
        public string lastname { get; set; }
        public string line { get; set; }
        public string moo { get; set; }
        public string mypositions { get; set; }
        public string n { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string phone { get; set; }
        public string pictuce { get; set; }
        public string placeofstudy { get; set; }
        public string position { get; set; }
        public string positions { get; set; }
        public string prefix { get; set; }
        public string province { get; set; }
        public string ratio { get; set; }
        public string road { get; set; }
        public string select { get; set; }
        public string selectacolor { get; set; }
        public string selecttheinformation { get; set; }
        public string size { get; set; }
        public string sizepictuce { get; set; }
        public string skill { get; set; }
        public string soi { get; set; }
        public string startdate  { get; set; }
        public string subdistrict { get; set; }
        public string themecolor { get; set; }
        public string title { get; set; }
        public string titlesetthemecolor { get; set; }
        public string twitter { get; set; }
        public string type { get; set; }
        public string value { get; set; }
        public string whcm { get; set; }
        public string zipcode { get; set; }
        public string unkhown { get; set; }
        public string viewpdf { get; set; }






    }
    public class MorePreViewResumeDataResponse
    {
        public string image { get; set; }
        public UserInfoPreViewResumeResponse userinfo { get; set; }
        public string position { get; set; }   
        public string aboutme { get; set; }
        public PersonInfoPreViewResumeResponse personinfo { get; set; }
        public AddressViewResumeResponse address { get; set; }
        public List<ExperiencePreViewResumeResponse> experience { get; set; }
        public List<EducationPreViewResumeResponse> education { get; set; }
        public List<SkillPreViewResumeResponse>  skill { get; set; }
        public List<CertificateViewResumeResponse> certificate { get; set; }
        public List<LanguageViewResumeResponse> languge { get; set; }
    }
    public class UserInfoPreViewResumeResponse
    {
        public string prefix { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
    }
    public class PersonInfoPreViewResumeResponse
    {
        public string email { get; set; }
        public string phone { get; set; }
        public string feacbook { get; set; }
        public string line { get; set; }
        public string instagram { get; set; }
        public string twitter { get; set; }
    }public class ExperiencePreViewResumeResponse
    {
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string position { get; set; }
        public string detail { get; set; }
    }
    public class EducationPreViewResumeResponse
    {
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string type { get; set; }
        public string placeofstudy { get; set; }
        public string detail { get; set; }
    }
    public class SkillPreViewResumeResponse
    {
        public string skill { get; set; }
        public string value { get; set; }
        public string detail { get; set; }
    }
    public class CertificateViewResumeResponse
    {
        public string title { get; set; }
        public string caption { get; set; }
    }

    public class LanguageViewResumeResponse
    {
        public string language { get; set; }
        public string value { get; set; }
        public string detail { get; set; }
    }public class AddressViewResumeResponse
    {
        //public string role { get; set; }
        public string number { get; set; }
        public string moo { get; set; }
        public string soi { get; set; }
        public string road { get; set; }
        public string subdistrict { get; set; }
        public string district { get; set; }
        public string province { get; set; }
        public string zipcode { get; set; }
    }
    public class GetUserRoleResponse
    {

        public String userrole { get; set; }
        //public UserRoleData userrole { get; set; }



    }
    //public class UserRoleData
    //{

    //    public string userrole { get; set; }



    //}
}

