using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProjectServiceEZATU.Database;
using ProjectServiceEZATU.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ProjectServiceEZATU.DTO.Response.more
{
    public class MoreScreenResponse
    {
        public MoreScreenInfoResponse screeninfo { get; set; }
        //public DepartmentContactModel department_contact { get; set; }
        public string facultyid { get; set; }
        public string departmentid { get; set; }
        public string branchid { get; set; }
        public string pavat_url { get; set; }
        public string luksuit_url { get; set; }
        public string facebook_url { get; set; }
        public string website_url { get; set; }

        internal int status;
        internal string message;

    }
    public class MoreScreenInfoResponse
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
        public string relatedlinks { get; set; }


    }
    public class DepartmentContactResponse
    {
        public string pavat { get; set; }
        public string luksuit { get; set; }
        public string facebook { get; set; }
        public string website { get; set; }


    }
    public class MoreNisitListnameGenResponse
    {
        public NisitListNameGenScreenInfoResponse screeninfo { get; set; }
        public List<ListOptionsNisitnameGenResponse> options { get; set; }
        public NisitListnameGenResponse user_gen { get; set; }
        public List<NisitListnameGenResponse> list_gen { get; set; }

        internal int status;
        internal string message;

    }
    public class NisitListNameGenScreenInfoResponse
    {
        public string titleboardnisit { get; set; }
        public string search { get; set; }
        public string here { get; set; }


    }
    public class NisitListnameGenResponse
    {
        public string namegen { get; set; }
        public string colorgen { get; set; }
        public string numgen { get; set; }


    }
    public class ListOptionsNisitnameGenResponse
    {
        public string title { get; set; }
        public string value { get; set; }
    }
    public class MoreBoardTeacherListResponse
    {
        public BoardTeacherScreenInfoResponse screeninfo { get; set; }
        public BoardTeacherResponse teacher { get; set; }
        public List<ListBoardStaffResponse> staff { get; set; }

        internal int status;
        internal string message;

    }
    public class BoardTeacherScreenInfoResponse
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

    public class BoardTeacherResponse
    {
        public List<ListBoardTeacherOneResoponse> teachermath { get; set; }
        public List<ListBoardTeacherTwoResoponse> teacherstats { get; set; }



    }
    public class ListBoardTeacherOneResoponse
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public string position { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string img { get; set; }
        public string website { get; set; }


    }   
    public class ListBoardTeacherTwoResoponse
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public string position { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string img { get; set; }
        public string website { get; set; }


    }
    public class ListBoardStaffResponse
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public string position { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string img { get; set; }


    }
    public class MoreBoardNisitListResponse
    {
        public BoardNisitListScreenInfoResponse screeninfo { get; set; }

        public List<ListOptionsNisitResponse> options { get; set; }
        public List<BoardNisitListDataResponse> data { get; set; }

        internal int status;
        internal string message;

    }
    public class ListOptionsNisitResponse
    {
        public string title { get; set; }
        public string value { get; set; }
    }
    public class BoardNisitListScreenInfoResponse
    {
        public string titleboardgen { get; set; }
        public string search { get; set; }
        public string here { get; set; }
        public string textsorryth { get; set; }
        public string textsorryen { get; set; }


    }

    public class BoardNisitListDataResponse
    {
        public string textstudentcode { get; set; }
        public string textstudentname { get; set; }
        public string textstudentlastname { get; set; }
        public string textstudentimg { get; set; }


    }
    public class MoreBoardNisitDetailResponse
    {
        public BoardNisitDetailScreenInfoResponse screeninfo { get; set; }
        public BoardNisitDetailDataResponse data { get; set; }

        internal int status;
        internal string message;

    }
    public class BoardNisitDetailScreenInfoResponse
    {
        public string titleboardnisit { get; set; }
        public string textnisit { get; set; }
        public string textstudentcode { get; set; }
        public string textname { get; set; }
        public string textnickname { get; set; }
        public string textgen { get; set; }
        public string textadvisor { get; set; }
        public string texttel { get; set; }
        public string textcontact { get; set; }
        public string textcareer { get; set; }
        public string textworkstatus { get; set; }
        public string textcompany { get; set; }


    }
    public class BoardNisitDetailDataResponse
    {
        public string gen { get; set; }
        public string studentcode { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string nickname { get; set; }

        public List<advisorGenListResponse> advisor { get; set; }
        public string phone { get; set; }
        public string line { get; set; }
        public string facebook { get; set; }
        public string instagram { get; set; }
        public string twitter { get; set; }
        public string youtube { get; set; }
        public string userworkplace { get; set; }
        public string usercareer { get; set; }
        public string usercompany { get; set; }
        public string attention { get; set; }


        public string status { get; set; }
        public string jobtype { get; set; }
        public string img { get; set; }


    }
    public class advisorGenResponse
    {
        public string position { get; set; }
        public string teachername { get; set; }
        public string teacherlastname { get; set; }


    } 
    public class advisorGenClassResponse
    {
        public List<advisorGenListResponse> advisor { get; set; }


    }
    public class advisorGenListResponse
    {
        public string position { get; set; }
        public string teachername { get; set; }
        public string teacherlastname { get; set; }
       


    }
    public class MoreContactUsResponse
    {
        public BoardContactUsScreenInfoResponse screeninfo { get; set; }
        public BoardContactUsMainResponse datamain { get; set; }
        public BoardContactUsResponse data { get; set; }

        internal int status;
        internal string message;

    } 
 
    public class BoardContactUsScreenInfoResponse
    {
        public string titlecontactus { get; set; }
        public string subtitlecontactus { get; set; }
        public string texttel { get; set; }
        public string textfax { get; set; }
        public string textemail { get; set; }
        public string textfacebook { get; set; }
        public string texttwitter { get; set; }
        public string textinstagram { get; set; }
        public string textline { get; set; }
        public string textunittime { get; set; }


    }
    public class BoardContactUsMainResponse
    {
        public string contactname { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string startperiod { get; set; }
        public string endtperiod { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
        public string address { get; set; }
        public string twitter { get; set; }
        public string instagram { get; set; }
        public string facebook { get; set; }
        public string line { get; set; }
        public string lineid { get; set; }


    }  public class BoardContactUsResponse
    {
        public string contactname { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string startperiod { get; set; }
        public string endtperiod { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
        public string address { get; set; }
        public string twitter { get; set; }
        public string instagram { get; set; }
        public string facebook { get; set; }
        public string line { get; set; }
        public string lineid { get; set; }


    }
    public class CheckTokenExpiredResponseResponse
    {
        public bool expired { get; set; }


    }
    public class MoreFAQsResponse
    {
        public MoreFAQsScreenInfoResponse screeninfo { get; set; }

        internal int status;
        internal string message;
        public List<MoreFAQsDataResponse> faq { get; set; }

    }
    public class MoreFAQsScreenInfoResponse
    {
        public string titlefaq { get; set; }
        public string textquestion { get; set; }
        public string textanswer { get; set; }
       


    }
    public class MoreFAQsDataResponse
    {
        public string question { get; set; }
        public string answer { get; set; }



    }
    
    public class MorePDPAResponse
    {

        internal int status;
        internal string message;
        public MorePDPAScreenInfoResponse screeninfo { get; set; }
        public MorePDPADataResponse data { get; set; }

    } 
    public class MorePDPAScreenInfoResponse
    {
        public string titlepdpa { get; set; }
        public string btnaccept { get; set; }
        public string btndecline { get; set; }
        public string textcheckbox { get; set; }
       


    } 
    public class MorePDPADataResponse
    {
        public string pdpaversion { get; set; }
        public string pdpaurl { get; set; }
        public string versionuse { get; set; }
 
    }
    public class ChangePasswordResponse
    {
        internal int status;
        internal string message;
        internal string fillempty;
       
        internal string errornewandconfirm;
        internal string errorcurrent;
        internal string alertlengthpassword;
        internal string format;     
        internal string errorinternet;      
        internal string errorlength;      
        internal string errorspecial;
        internal string leastnum;
        internal string uppercase;
        internal string lowercase;
        public string token { get; set; }
        public string refreshtoken { get; set; }
        public string role { get; set; }
        public string language { get; set; }
    }
    public class MoreCourseResponse
    {
        public MoreCourseScreenInfoResponse screeninfo { get; set; }
        public List<MoreCourseListDataResponse> bachelors { get; set; }
        public List<MoreCourseListDataResponse> masters { get; set; }

        internal int status;
        internal string message;

    }
    public class MoreCourseScreenInfoResponse
    {
        public string titlecourse { get; set; }
        public string bachelor { get; set; }
        public string graduate { get; set; }
        public string coursall { get; set; }
        public string websitecoursall { get; set; }
        public string publish { get; set; }
        public string by { get; set; }


    } 
    public class MoreCourseScreenInfoModel
    {
        public string namecoursesth { get; set; }
        public string namecoursesen { get; set; }
        public string weblink { get; set; }
        public string publish { get; set; }
        public string updater { get; set; }
        public string userlanguage { get; set; }


    }
    public class MoreCourseListDataResponse
    {
        public string namecourses { get; set; }
        public string weblink { get; set; }
        public string publish { get; set; }
        public string updater { get; set; }



    }
    public class MoreRelatedLinksResponse
    {
        public MoreRelatedLinksScreenInfoResponse screeninfo { get; set; }
        public List<MoreMoreRelatedLinksDataResponse> datalink { get; set; }

        internal int status;
        internal string message;

    }
    public class MoreRelatedLinksScreenInfoResponse
    {
        public string titlerelatedlinks { get; set; }
        


    }
    public class MoreMoreRelatedLinksScreenInfoModel
    {
        public string titleen { get; set; }
        public string titleth { get; set; }
        public string link { get; set; }
        public string userlanguage { get; set; }


    }
    public class MoreMoreRelatedLinksDataResponse
    {
      
        public string title { get; set; }
        public string link { get; set; }



    }
    



}
