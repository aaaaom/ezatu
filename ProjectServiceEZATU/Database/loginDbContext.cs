using Microsoft.EntityFrameworkCore;
using ProjectServiceEZATU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectServiceEZATU.Models.Data;
using ProjectServiceEZATU.Models.activity;
using Dapper.Contrib.Extensions;
//using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectServiceEZATU.Database
{
    public class loginDbContext : DbContext
    {
        public loginDbContext(DbContextOptions<loginDbContext> options) : base(options)
        {

        }

        public ScreenDbContextData LabelScreen { get; set; }
        public UserDbContextData user { get; set; }
        public DbSet<Activity> Activity { get; set; }



    }
    public class ScreenDbContextData
    {
        //public string Parameter { get; set; }
        public string Screen { get; set; }
        public string parameter { get; set; }
        public string img { get; set; }
        public string value { get; set; }
        public string EN { get; set; }
        public string TH { get; set; }
        public string userlanguage { get; set; }
        public string language { get; set; }

    }
    public class UserRoleDbContextData
    {
        public string role { get; set; }
    } public class TasksOntionDbContextData
    {
        public string option { get; set; }
    }
    public class ScreenListDbContextData
    {
        //public string Parameter { get; set; }
        public int id { get; set; }
        public string screen { get; set; }
        public string parameter { get; set; }
        public string value { get; set; }
        public string EN { get; set; }
        public string TH { get; set; }
        public string userlanguage { get; set; }


    }
    public class OtherData
    {
        internal int status;
        internal string message;
        public string user_pdpa_version { get; set; }
        public string pdpa_version { get; set; }
        public string pdpa_link { get; set; }
        public string app_version { get; set; }
        public string app_link { get; set; }
    }
 
    public class ErrorButton
    {
        internal int status;
        internal string message;
        public string buttonok { get; set; }
        public string buttonconfirm { get; set; }
        public string buttonyes { get; set; }
        public string buttonno { get; set; }
        public string buttoncancel { get; set; }


    }
    public class AlertMessageChangeEmail
    {
        public string ChangeSuc { get; set; }
        public string texConfirmChangeEmail { get; set; }
    }
    public class AlertMessageHome
{
        public string alertdeleteaccount { get; set; }
        public string alertdeleteaccountpassword { get; set; }
        public string alertdeleteaccountpdpa { get; set; }
        public string alertlogout { get; set; }
        public string alertpassword { get; set; }
        public string emailsupport { get; set; }
        public string phonesupport { get; set; }
        public string alertpdpa { get; set; }
        public string alertupdateapp { get; set; }
        public string titlenewappversion { get; set; }
        public string subtitlenewappversion { get; set; }
        public string titlenewpadaversion { get; set; }
        public string subtitlenewpadaversion { get; set; }

    } 
    public class AlertMessageResume
    {
        public string alertdeletedata_th{ get; set; }
        public string alertdeletedata_en{ get; set; }
        public string alertsavedata_th { get; set; }
        public string alertsavedata_en { get; set; }
        public string completefields_th { get; set; }
        public string completefields_en { get; set; }

    }
    public class AlertMessageAddEditActivity
    {
        public string alertfillallactivity { get; set; }

    }
    public class AlertMessageHomeActivity
    {
        public string alertdeleteactivity { get; set; }

    }


    public class UserDbContextData
    {
        public string userid { get; set; }
        public string password { get; set; }
        public string userlanguage { get; set; }
        public string role { get; set; }
    }
    [Table("languagelogin")]
    public class langDbContextData
    {
        public string userid { get; set; }
        public string language { get; set; }
    }
    public class TokenDbContextData
    {
        public string token { get; set; }
    }
    [Table("useraccount")]
    public class UserregisDbContextData
    {
        public string userid { get; set; }
        public string password { get; set; }
        public string useremail { get; set; }
        public string userphone { get; set; }
        public string versionpdpa { get; set; }

    }
    [Table("useraccount")]
    public class UpdatePasswordDbContextData
    {
        public int id { get; set; }
        public string password { get; set; }

    }
    [Table("otptemporary")]
    public class OTPTtemporaryData
    {
        //[Key]
        public int id { get; set; }
        [Key]
        public string userid { get; set; }
        public string email { get; set; }
        public string valueref { get; set; }
        public string otp { get; set; }
        public string createAt { get; set; }
        public string timeout { get; set; }

    }
    [Table("otptemporary")]
    public class OTPTtemporaryData1
    {

        public int id { get; set; }
        [Key]
        public string userid { get; set; }
        public string email { get; set; }
        public string valueref { get; set; }
        public string otp { get; set; }
        public string createAt { get; set; }
        public string timeout { get; set; }

    }

    [Table("userregisdb")]
    public class UserregisDbContextDataTB
    {
        public string userid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
    [Table("profileeducationdata")]
    public class EducationProfileDbContextData
    {
        public string userid { get; set; }
        public string role { get; set; }
        public string faculty { get; set; }
        public string department { get; set; }
        public string major { get; set; }
        public string gpajhs { get; set; }
        public string gpashs { get; set; }
        public string gpabd { get; set; }
    }
    [Table("profileaddressdata")]
    public class AddressProfileDbContextData
    {
        public string userid { get; set; }
        public string role { get; set; }
        public string number { get; set; }
        public string moo { get; set; }
        public string soi { get; set; }
        public string road { get; set; }
        public string subdistrict { get; set; }
        public string province { get; set; }
        public string zipcode { get; set; }
        public string district { get; set; }
    }
    [Table("profilecontactdata")]
    public class ContactProfileDbContextData
    {
        public string userid { get; set; }
        public string role { get; set; }
        public string phone { get; set; }
        public string line { get; set; }
        public string facebook { get; set; }
        public string instagram { get; set; }
        public string twitter { get; set; }
        public string youtube { get; set; }
    }
    [Table("profilecareerdata")]
    public class CareerProfileDbContextData
    {
        public string userid { get; set; }
        public string role { get; set; }
        public string userattention { get; set; }
        public string userstatus { get; set; }
        public string userjobtype { get; set; }
        public string userworkplace { get; set; }
        public string usercareer { get; set; }
        public string usercompany { get; set; }
    }
    [Table("profilegeneraldata")]
    public class profilegeneraldataDbContextDatainsert
    {
        public string studentid { get; set; }
        public string role { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string nickname { get; set; }
        public string generation { get; set; }
    }
    [Table("profilegeneraldata")]
    public class profilegeneraldataDbContextDatadelete
    {
        [Key]
        public string studentid { get; set; }
        public string role { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string nickname { get; set; }
        public string generation { get; set; }
    }
    [Table("otptemporary")]
    public class OTPTemporaryDbContextData
    {

        public string userid { get; set; }
        public string email { get; set; }
        public string otp { get; set; }
        public string valueref { get; set; }
        public string createAt { get; set; }
        public string timeout { get; set; }

    }
    [Table("otptemporary")]
    public class DeleteOTPTemporaryDbContextData
    {
        [Key]
        public string userid { get; set; }
        public string email { get; set; }
        public string otp { get; set; }
        public string valueref { get; set; }
        public string createAt { get; set; }
        public string timeout { get; set; }

    }


    public class ActivityListTeacherDbContextData
    {
        public string studentid { get; set; }
        public int activityid { get; set; }
        public string activityname { get; set; }
        public string startdatebyteacher { get; set; }
        public string finishdatebyteacher { get; set; }
        public string venue { get; set; }
        public string status { get; set; }
        public string color { get; set; }
        public string detailstatus { get; set; }
        public string stname { get; set; }
        public string stlastname { get; set; }
    }
    public class SelectActivityByStudentListDbContextData
    {
        public int activitynameid { get; set; }
        public string activityname { get; set; }
        public string teacherid { get; set; }
    }
    public class ActivityListDbContextData
    {
        //public string userid { get; set; }
        public string activityid { get; set; }
        public string activityname { get; set; }
        //public string year { get; set; }
        //public string term { get; set; }
        public string startdatebyteacher { get; set; }
        public string finishdatebyteacher { get; set; }
        //public string timehours { get; set; }
        //public string timeminutes { get; set; }
        //public string approver { get; set; }
        public string venue { get; set; }
        public string objectives { get; set; }
        //public string detail { get; set; }
        //public string status { get; set; }
        public string color { get; set; }
        public string detailstatus { get; set; }
        //public string teachercode { get; set; }
        public string teachername { get; set; }
        public string teacherlastname { get; set; }
    }

    public class ActivityNameListByTeacherDbContextData
    {
        public int activitynameid { get; set; }
        public string teacherid { get; set; }
        public string activityname { get; set; }
        public string objectives { get; set; }
        public string venue { get; set; }
        public string startdatebyteacher { get; set; }
        public string finishdatebyteacher { get; set; }

    }
    public class ActivityDbContextData
    {
        public string userid { get; set; }
        public string activityid { get; set; }
        public string activityname { get; set; }
        public string year { get; set; }
        public string term { get; set; }
        public string startdate { get; set; }
        public string finishdate { get; set; }
        public string time { get; set; }
        public string approver { get; set; }
        public string venue { get; set; }
        public string detail { get; set; }
        public string status { get; set; }
    }
    [Table("activity")]
    public class ConActivityDbContextData
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[ExplicitKey]
        public string userid { get; set; }
        [Key]
        public int activityid { get; set; }
        public string activityname { get; set; }
        public string year { get; set; }
        public string term { get; set; }
        public string startdate { get; set; }
        public string finishdate { get; set; }
        public string timehours { get; set; }
        public string timeminutes { get; set; }
        public string approver { get; set; }
        public string venue { get; set; }
        public string detail { get; set; }
        public string status { get; set; }

    }
    public class CodetatusActivityDbContextData
    {
        public string status { get; set; }
        public string color { get; set; }
        public string detailstatus { get; set; }
    }

    public class LangageUserDbContextData
    {
        public string user { get; set; }
        public string language { get; set; }
    }
    public class ListAcDbContextData
    {
        public string yearlist { get; set; }
        public string termlist { get; set; }
        public string approverlist { get; set; }
    }
    public class ProfileGeneralInfo
    {
        public string parameter { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public String nickname { get; set; }
        public String stu_code { get; set; }
        public String gen { get; set; }
        public String genname { get; set; }
        public String gencolor { get; set; }
        public String studentid { get; set; }
        public String email { get; set; }
        public String role { get; set; }
        public String img { get; set; }

    }

    public class CheckDeleteAcModel
    {
        public string booldelete { get; set; }

    }
    [Table("useraccount")]
    public class DeleteaccountDbContextData
    {

        public int id { get; set; }
        [Key]
        public string userid { get; set; }
        public string password { get; set; }
        public string useremail { get; set; }
        public string userphone { get; set; }
    }
    [Table("savedataformdelete")]
    public class insertDbContextData
    {
        //[Key]
        public string userid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string line { get; set; }
        public string facebook { get; set; }

    }

    [Table("profileaddressdata")]
    public class DeleteaddrressDbContextData
    {
        [Key]
        public string userid { get; set; }
        public string role { get; set; }
        public string number { get; set; }
        public string moo { get; set; }
        public string soi { get; set; }
        public string road { get; set; }
        public string subdistrict { get; set; }
        public string district { get; set; }
        public string province { get; set; }
        public string zipcode { get; set; }
    }

    [Table("refreshtoken")]
    public class RefreshtokenDbContextData
    {
        [Key]
        public int id { get; set; }
        public string refresh { get; set; }
        public string userId { get; set; }
        public string createAt { get; set; }
        public string updateAt { get; set; }
    }
    [Table("refreshtoken")]
    public class drefreshtokenDbContextData
    {
        [Key]
        public int id { get; set; }
        public string refresh { get; set; }
        public string userId { get; set; }
        public string createAt { get; set; }
        public string updateAt { get; set; }
    }

    public class langtokenDbContextData
    {
        [Key]
        public string userlanguage { get; set; }
    }


    [Table("languagelogin")]
    public class languageDataDB
    {
        [Key]
        public string userid { get; set; }
        public string language { get; set; }
    }

    [Table("language")]
    public class languageChangeDataDB
    {
        [Key]
        public string userid { get; set; }
        public string userlanguage { get; set; }
    }
    [Table("language")]
    public class languageInsertDataDB
    {
        public string userid { get; set; }
        public string userlanguage { get; set; }
    }
    [Table("language")]
    public class languageDeleteDataDB
    {
        [Key]
        public string userid { get; set; }
        public string userlanguage { get; set; }
    }
    public class RefreshtokenUserlanguageDbContextData
    {
        [Key]
        public int id { get; set; }
        public string refresh { get; set; }
        public string userId { get; set; }
        public string createAt { get; set; }
        public string updateAt { get; set; }
        public string userlanguage { get; set; }

    }
    [Table("profilecareerdata")]
    public class profilecareerdataDbContextData
    {
        [Key]
        public string userid { get; set; }
        public string role { get; set; }
        public string userattention { get; set; }
        public string userstatus { get; set; }
        public string userjobtype { get; set; }
        public string userworkplace { get; set; }
        public string usercareer { get; set; }
        public string usercompany { get; set; }
    }
    [Table("profilecontactdata")]
    public class profilecontactdataDbContextData
    {
        [Key]
        public string userid { get; set; }
        public string role { get; set; }
        public string phone { get; set; }
        public string line { get; set; }
        public string facebook { get; set; }

        public string instagram { get; set; }
        public string twitter { get; set; }
        public string youtube { get; set; }
    }
    [Table("profileeducationdata")]
    public class profileeducationdataDbContextData
    {
        [Key]
        public string userid { get; set; }
        public string role { get; set; }
        public string faculty { get; set; }
        public string department { get; set; }
        public string major { get; set; }
        public string gpajhs { get; set; }
        public string gpashs { get; set; }
        public string gpabd { get; set; }

    }
    [Table("profilegeneraldata")]
    public class profilegeneraldataDbContextData
    {
        [Key]
        public string studentid { get; set; }
        public string role { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string nickname { get; set; }
        public string generation { get; set; }
    }
    [Table("imguser")]
    public class imgDbcontextData
    {
        [Key]
        public string userid { get; set; }
        public string img { get; set; }
    }
    [Table("activity")]
    public class activityDbcontetxtData
    {
        [Key]
        public string userid { get; set; }
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
    }
    [Table("refreshtoken")]
    public class refreshtokenDbContextData
    {
        public int id { get; set; }
        [Key]
        public string userid { get; set; }
        public string refresh { get; set; }
        public string createAt { get; set; }
        public string updateAt { get; set; }

    }
    public class DeleteaccountQueryDbModel
    {
        public string token { get; set; }
        public int id { get; set; }
        [ExplicitKey]
        public string userid { get; set; }
        public string password { get; set; }
        public string useremail { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string userphone { get; set; }
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
        public string userlanguage { get; set; }
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
        public string refresh { get; set; }
        public string createAt { get; set; }
        public string updateAt { get; set; }
        public string studentid { get; set; }
        public string nickname { get; set; }
        public string generation { get; set; }
    }
    public class Deleteotp
    {
        public int id { get; set; }
        [ExplicitKey]
        public string userid { get; set; }
        public string valueref { get; set; }
        public string email { get; set; }
        public string otp { get; set; }
        public string createAt { get; set; }
        public string userphone { get; set; }
        public string timeout { get; set; }

        [Table("keeplogsessions")]
        public class keepLogSessionsDbContextData
        {
            [Key]
            public int id { get; set; }

            public string sessions { get; set; }
            public string userid { get; set; }
            public string phone { get; set; }
            public string phoneversionos { get; set; }
            public string operatingsystem { get; set; }
            public string screenresolution { get; set; }
            public string appversion { get; set; }
            public string packagename { get; set; }
            public string logindate { get; set; }
            public string logoutdate { get; set; }
        }
        [Table("keeplogsessions")]
        public class keepLogLogoutSessionsDbContextData
        {
            [Key]
            public int id { get; set; }

            public string sessions { get; set; }
            public string userid { get; set; }
            public string logoutdate { get; set; }
        }
    }
    [Table("activitynamebyteacher")]
    public class InfarActivityNameByTeacherDbContextData
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[ExplicitKey]
        [Key]
        public int activitynameid { get; set; }
        public string activityname { get; set; }
        public string objectives { get; set; }
        public string venue { get; set; }
        public string teacherid { get; set; }
        public string startdatebyteacher { get; set; }
        public string finishdatebyteacher { get; set; }
        public string image { get; set; }
        public string image_type { get; set; }
    }
    [Table("activityofstudent")]
    public class InfarSelectActivityByStudentDbContextData
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[ExplicitKey]
        public string userid { get; set; }
        [Key]
        public int activityid { get; set; }
        //public string teacherid { get; set; }
        public int activitynameid { get; set; }
        public string status { get; set; }

    }
    [Table("activityofstudent")]
    public class InfarDeleteActivityTeacherAndStudentTogetherContextData
    {
        [Key]
        public int activitynameid { get; set; }
    }

    [Table("activityofstudent")]
    public class InfarDeleteActivityByStudentDbContextData
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[ExplicitKey]
        [Key]
        public int activityid { get; set; }
        //public string teacherid { get; set; }
    }
    [Table("profilegeneralteacherdata")]
    public class profilegeneralTHdataDbContextDatainsert
    {
        public string teacherid { get; set; }
        public string role { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string nickname { get; set; }
        public string position { get; set; }
    }
    [Table("profileacademicthdata")]
    public class profileAcademicTHdataDbContextDatainsert
    {
        public string userid { get; set; }
        public string role { get; set; }
        public string graduatedegree { get; set; }
        public string masterdegree { get; set; }
        public string phd { get; set; }
        public string reshercharea { get; set; }
        //public string univofgraduatedegree { get; set; }
        //public string univofmasterdegree { get; set; }
        //public string univofphd { get; set; }
    }
    [Table("profileuniversitythdata")]
    public class profileunivTHdataDbContextDatainsert
    {
        public string userid { get; set; }
        public string role { get; set; }
        public string univofgraduatedegree { get; set; }
        public string univofmasterdegree { get; set; }
        public string univofphd { get; set; }
    }

    [Table("profilethcontactdata")]
    public class profilecontactTHdataDbContextDatainsert
    {
        public string userid { get; set; }
        public string role { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string workshop { get; set; }
    }
    [Table("profilepositiontcdata")]
    public class profilepositionTCdata
    {
        public string userid { get; set; }
        public string role { get; set; }
        public string userposition { get; set; }
        public string userpositionth { get; set; }
        public string userpositionen { get; set; }
    }
    public class DeleteaccountTCQueryDbModel
    {
        public string token { get; set; }
        public int id { get; set; }
        [ExplicitKey]
        public string userid { get; set; }
        public string teacherid { get; set; }
        public string password { get; set; }
        public string useremail { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string graduatedegree { get; set; }
        public string masterdegree { get; set; }
        public string phd { get; set; }
        public string reshercharea { get; set; }
        public string univofgraduatedegree { get; set; }
        public string univofmasterdegree { get; set; }
        public string univofphd { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string workshop { get; set; }
        public string nickname { get; set; }
        public string lastname { get; set; }
        public string userposition { get; set; }
        public string userpositionth { get; set; }
        public string userpositionen { get; set; }


    }
    [Table("profilegeneralteacherdata")]
    public class DeleteGeneralTCQueryModel 
    {
        [Key]
        public string teacherid { get; set; }
        public string role { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string nickname { get; set; }
    }
    [Table("profilethcontactdata")]
    public class DeleteContactTCQueryModel
    {
        [Key]
        public string userid { get; set; }
        public string role { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string workshop { get; set; }
    }
    [Table("profileacademicthdata")]
    public class DeleteAcademicTCQueryModel
    {
        [Key]
        public string userid { get; set; }
        public string role { get; set; }
        public string graduatedegree { get; set; }
        public string masterdegree { get; set; }
        public string phd { get; set; }
        public string reshercharea { get; set; }
    }
    [Table("profileuniversitythdata")]
    public class DeleteUnivTCQueryModel
    {
        [Key]
        public string userid { get; set; }
        public string role { get; set; }
        public string univofgraduatedegree { get; set; }
        public string univofmasterdegree { get; set; }
        public string univofphd { get; set; }
    }
    [Table("profilepositiontcdata")]
    public class DeletepositionTCQueryModel
    {
        [Key]
        public string userid { get; set; }
        public string role { get; set; }
        public string userposition { get; set; }
        public string userpositionth { get; set; }
        public string userpositionen { get; set; }
    }
    [Table("useraccount")]
    public class UpdateEmailModel
    {
        [Key]
        public string userid { get; set; }

        public string useremail { get; set; }
    }

    [Table("expireemail")]
    public class expireEmailModel
    {
        //[Key]
        public string userid { get; set; }

        public string useremail { get; set; }
    }
}


