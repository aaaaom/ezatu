using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProjectServiceEZATU.Database;
using System.Text.Json.Serialization;

namespace ProjectServiceEZATU.Models.home
{
    public class HomeActivityResponse
    {
        public ScreeninfoHo screeninfo { get; set; }
        public ErrorButton errorbutton { get; set; }
        public AlertMessageHomeActivity alertmessage { get; set; }
        public List<Activity> activity { get; set; }


        internal int status;
        internal string message;
    }

    public class ImageUploadResponse
    {
        internal int status;
        internal string message; 
        internal string image;
        internal string userid;

    }  
    public class CheckTokenExpiredResponseResponse
    {
        public bool expired { get; set; }


    }
   
    public class ActivityDataModel
    { 
        public List<DataListActivity> DataListActivity { get; set; }
    }


    public class ChangelanguageResponse
    {
        internal int status;
        internal string message;
    }
    public class LockScreenCodeResponse
    {
        internal int status;
        internal string message;
        public string lockapp { get; set; }
        public string lockappdetail { get; set; }
        public string bioscan { get; set; }
        public string changepasscode { get; set; }
        public string enternewpin { get; set; }
        public string enterconfirmpin { get; set; }
        public string enterpin { get; set; }
        public string hello { get; set; }
        public string niceday { get; set; }
        public string setpinscreen { get; set; }

    }
    
    
    public class Activity
    {
        //public string id { get; set; }
        public string activityid { get; set; }
        public string name { get; set; }
        //public string year { get; set; }
        //public string term { get; set; }
        public string startdate { get; set; }
        public string finishdate { get; set; }
        //public string timehours { get; set; }
        //public string timeminutes { get; set; }
        public string venue { get; set; }
        public string objectives { get; set; }
        //public string approvername { get; set; }
        //public string approverlastname { get; set; }
        public string teachername { get; set; }
        public string teacherlastname { get; set; }
        //public string approvercode { get; set; }
        //public string detail { get; set; }
        public string status { get; set; }
        public string color { get; set; }
    }

    public class ScreeninfoHo
    {
        public string titleapproved { get; set; }
        public string titleunapproved { get; set; }
        public string titlerejected { get; set; }
        public string textactivity { get; set; }
        public string textyear { get; set; }
        public string textterm { get; set; }
        public string textstartdate { get; set; }
        public string textfinishdate { get; set; }
        public string textunittime { get; set; }
        public string texttime { get; set; }
        public string textvenue { get; set; }
        public string textobjectives { get; set; }
        public string edtapprover { get; set; }
        public string textdetail { get; set; }
        public string buttonleft { get; set; }
        public string buttonright { get; set; }
    }
    public class ScreenInfoHome
    {
        public string titleact { get; set; }
        public string btnadd { get; set; }
        public string textname { get; set; }
        public string textnickname { get; set; }
        public string textgen { get; set; }
        public string textstdcode { get; set; }
        public string textemail { get; set; }
        public string textrole { get; set; }
        public string textlang { get; set; }
        public string textthai { get; set; }
        public string btncpass { get; set; }
        public string btncpin { get; set; }
        public string btndelacc { get; set; }
        public string textappver { get; set; }
        public string btnlogout { get; set; }
        public string modetheme { get; set; }
        public string lockscreencode { get; set; }
        public string dark { get; set; }
        public string setting { get; set; }
        public string position { get; set; }
        public string titleactteacher { get; set; }
        public string btnseeall { get; set; }
        public string btnhome { get; set; }
        public string btnprofile { get; set; }
        public string btnfunction { get; set; }
        public string btnmore { get; set; }
    }
    public class ScreenInfoHomeTC
    {
        public string titleact { get; set; }
        public string btnadd { get; set; }
        public string textname { get; set; }
        public string textnickname { get; set; }
        public string texttccode { get; set; }
        public string textemail { get; set; }
        public string textrole { get; set; }
        public string textlang { get; set; }
        public string textthai { get; set; }
        public string btncpass { get; set; }
        public string btncpin { get; set; }
        public string btndelacc { get; set; }
        public string textappver { get; set; }
        public string btnlogout { get; set; }
        public string modetheme { get; set; }
        public string lockscreencode { get; set; }
        public string dark { get; set; }
        public string setting { get; set; }
        public string position { get; set; }
        public string titleactteacher { get; set; }
        public string btnseeall { get; set; }
    }
    public class DataListActivity
    {
        public string id { get; set; }
        public string textactivitydetail { get; set; }
        public string textteacherdetail { get; set; }
        public string textstartdatedetail { get; set; }
        public string textfinishdatedetail { get; set; }
        public string statusactivity { get; set; }
    }

    public class HomeChangePasswordResponse
    {
        public ChangePasswordScreenInfo screeninfo { get; set; }
        public ErrorChangePasswordScreenInfo errorscreeninfo { get; set; }
        public ErrorButton errorbutton { get; set; }

        internal int status;
        internal string message;
    }
    public class ChangePasswordScreenInfo
    {
        public string titlechangenewpass { get; set; }
        public string edtcurrentpass { get; set; }
        public string edtnewpass { get; set; }
        public string edtcpass { get; set; }
        public string btnforgotpass { get; set; }
        public string btnconfirm { get; set; }
        public string textfieldPass { get; set; }
        public string textPassNote { get; set; }



    }
    public class ErrorChangePasswordScreenInfo
    {
        public string errorsubmit { get; set; }
 


    }
    public class MoreScreenModel
    {
        public MoreScreenInfo screeninfo { get; set; }
        //public DepartmentContactModel department_contact { get; set; }
        public string pavat_url { get; set; }
        public string luksuit_url { get; set; }
        public string facebook_url { get; set; }
        public string website_url { get; set; }

    }
    public class MoreScreenInfo
    {
        public string titlemore { get; set; }
        public string subtitileboard { get; set; }
        public string btnstd { get; set; }
        public string btntc { get; set; }
        public string subtitiledepart { get; set; }
        public string btndeparthis { get; set; }
        public string btncou { get; set; }
        public string btnface { get; set; }
        public string btnweb { get; set; }
        public string subtitilesup { get; set; }
        public string btntermandcon { get; set; }
        public string btnfaq { get; set; }
        public string btncontactus { get; set; }

    
    }
    public class DepartmentContactModel
    {
        public string facultyid { get; set; }
        public string departmentid { get; set; }
        public string branchid { get; set; }
        public string pavat { get; set; }
        public string luksuit { get; set; }
        public string facebook { get; set; }
        public string website { get; set; }


    }
    public class MoreNisitListnameGenModel
    {
        public NisitListNameGenScreenInfo screeninfo { get; set; }
        public NisitListnameGen user_gen { get; set; }
        public List<NisitListnameGen> list_gen { get; set; }

    }
    public class NisitListNameGenScreenInfo
    {
        public string titleboardnisit { get; set; }
        

    }
    public class NisitListnameGen
    {
        public string namegen { get; set; }
        public string colorgen { get; set; }
        public string numgen { get; set; }


    }
    public class NisitListnameGenModel
    {   
        public string gen { get; set; }
        public string genname { get; set; }
        public string gencolor { get; set; }
        


    }
    public class ListOptionsNisitnameGenModel
    {
        public string title { get; set; }
        public string value { get; set; }
        public string userlanguage { get; set; }



    }
    public class MoreBoardTeacherListModel
    {
        public BoardTeacherScreenInfo screeninfo { get; set; }
        public BoardTeacherModel teacher { get; set; }
        public List<ListBoardStaffModel>  staff { get; set; }

    }
    public class BoardTeacherScreenInfo
    {
        public string titileboardpersonal { get; set; }
        public string textmath { get; set; }
        public string textstats { get; set; }
        public string textadvisor { get; set; }
        public string textacademicstaff { get; set; }
        public string textname { get; set; }
        public string textpositon { get; set; }
        public string texttel { get; set; }
        public string textemail { get; set; }
        public string textgotoweb { get; set; }


    }

    public class BoardTeacherModel
    {
        public List<ListBoardTeacherModel> teachermath { get; set; }
        public List<ListBoardTeacherModel> teacherstats { get; set; }



    }
    public class ListBoardTeacherModel
    {
        public string teachername { get; set; }
        public string teacherlastname { get; set; }
        public string positionth { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string img { get; set; }
        public string website { get; set; }


    }
    public class ListBoardStaffModel
    {
        public string teachername { get; set; }
        public string teacherlastname { get; set; }
        public string positionth { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string img { get; set; }
        public string website { get; set; }


    }
    public class NisitListDtaModel
    {
        public string userid { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string img { get; set; }


    }
    public class BoardNisitDetailDataModel
    {
        public string gen { get; set; }
        public string userid { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string nickname { get; set; }
        public string img { get; set; }
        public string phone { get; set; }
        public string line { get; set; }
        public string facebook { get; set; }
        public string instagram { get; set; }


        public string twitter { get; set; }
        public string youtube { get; set; }
        public string userworkplace { get; set; }
        public string usercareer { get; set; }
        public string usercompany { get; set; }
        public string userlanguage { get; set; }
        public string attentionth { get; set; }
        public string attentionen { get; set; }


        public string statusth { get; set; }
        public string statusen { get; set; }
        public string jobtypeth { get; set; }
        public string jobtypeen { get; set; }



    }
    public class advisorGenModel
    {
        public string userid { get; set; }
        public string teachername { get; set; }
        public string teacherlastname { get; set; }
        public string position { get; set; }

    }
    public class advisorGenListModel
    {
        public string userid { get; set; }
        public string teachername { get; set; }
        public string teacherlastname { get; set; }
        public string position { get; set; } 

       

    }
    public class OtherDataModel
    {
        public string pdpaversion { get; set; }
        public string versionpdpa { get; set; }
        public string pdpalink { get; set; }
        public string releaseversion { get; set; }
        public string releaselink { get; set; } 

       

    }
    public class ContactUsModel
    {
        public string userlanguage { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string startperiodth { get; set; }
        public string endperiodth { get; set; } 
        public string startperioden { get; set; }
        public string endperioden { get; set; } 
        public string starttime { get; set; }
        public string endtime { get; set; }
        public string address { get; set; }
        public string addressen { get; set; } 
        public string contactnameth { get; set; }
        public string contactnameen { get; set; }
        public string twitter { get; set; }
        public string instagram { get; set; }
        public string facebook { get; set; }
        public string line { get; set; }
        public string lineid { get; set; }

    }
    public class papaDataModel
    {
        public string pdpaversion { get; set; }
        public string lasted { get; set; }
        public string pdpalink { get; set; }
        public string createat { get; set; }
        public string updateat { get; set; }
    }
    public class changePasswordModel
    {
        public string userid { get; set; }
        public string userlanguage { get; set; }
        public string role { get; set; }
    }
    public class papaDataCheckModel
    {
        internal string pdpaversion;
        internal string versionuse;
        internal string lasted;
        internal string pdpalink;
        internal string pdpafile;
        internal string createat;
        internal string updateat;



    }
    public class questionAnswerModel
    {
       
        public string userlanguage { get; set; }
        public string answerth { get; set; }
        public string answeren { get; set; }
        public string questionth { get; set; }
        public string questionen { get; set; }
        public string language { get; set; }


    }
    public class LogoutModel 
    {
        internal int status;
        internal string message;
        internal string somewrong;
        [JsonPropertyName("refreshToken")]
        public string refreshToken { get; set; }

    }

    }
  