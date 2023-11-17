using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProjectServiceEZATU.Database;
namespace ProjectServiceEZATU.Models.activity
{
    public class ActivityModel
    {
        public ScreenInfoActivity screeninfo { get; set; }
        public ErrorButton errorbutton { get; set; }
        public AlertMessageAddEditActivity alertmessage { get; set; }
        public List<string> yearlist { get; set; }
        //public List<YearListResponse> yearlist { get; set; }
        public List<string> termlist { get; set; }
        public List<ApproverListResponse> approverlist { get; set; }
    }

    public class YearListModel
    {
        public string yearlist { get; set; }
    }
    public class TermListModel
    {
        public string termlist { get; set; }
    }
    public class approverlists
    {
        public string approverlist { get; set; }
    }
    public class ApproverListResponse
    {
        public string approvercode { get; set; }
        public string approvername { get; set; }
        public string approverlastname { get; set; }

    }
    public class ApproverListModel
    {
        public string teachercode { get; set; }
        public string teachername { get; set; }
        public string teacherlastname { get; set; }
        public string enteachername { get; set; }
        public string enteacherlastname { get; set; }
        public string userlanguage { get; set; }

    }
    public class ScreenInfoActivity
    {
        public string titleaddact { get; set; }
        public string titleeditact { get; set; }
        public string edtactname { get; set; }
        public string edtyear { get; set; }
        public string edtterm { get; set; }
        public string edtstartdate { get; set; }
        public string edtfinishdate { get; set; }
        public string edttimehours { get; set; }
        public string edttimeminutes { get; set; }
        public string edtvenue { get; set; }
        public string edtapprover { get; set; }
        public string edtdetail { get; set; }
        public string btnconfirm { get; set; }
        //public List<string> yearlist { get; set; }
        //public List<string> termlist { get; set; }
        //public List<string> approverlist { get; set; }

    }
    public class ApprovedModel
    {
        public ScreeninfoApp screeninfo { get; set; }
        public string id { get; set; }
        public Activity activity { get; set; }
    }
    public class ScreeninfoApp
    {
        public string titlestatus { get; set; }
        public string textactivity { get; set; }
        public string textyear { get; set; }
        public string textterm { get; set; }
        public string textstartdate { get; set; }
        public string textfinishdate { get; set; }
        public string texttime { get; set; }
        public string textvenue { get; set; }
        public string edtapprover { get; set; }
        public string textdetail { get; set; }
        public string bottonleft { get; set; }
        public string buttonright { get; set; }
    }
    public class Activity
    {
        public string id { get; set; }
        public string name { get; set; }
        public string year { get; set; }
        public string term { get; set; }
        public string startdate { get; set; }
        public string finishdate { get; set; }
        public string timehours { get; set; }
        public string timeminutes { get; set; }
        public string venue { get; set; }
        public string approver { get; set; }
        public string detail { get; set; }
        public string status { get; set; }
        public string color { get; set; }
    }

    public class ActivityListTeacherResponse
    {
        public ScreeninfoActivity screeninfo { get; set; }
        public List<ActivityListTeacher> activitylist { get; set; }
        public List<OptionsActivitySearchTeacherResponse> options { get; set; }
        public List<OptionsActivityStatusSearchTeacherResponse> options_status { get; set; }
    }
    public class ScreeninfoActivity
    {
        public string titleteacheractivity { get; set; }
        public string textactivity { get; set; }
        public string studentcode { get; set; }
        public string student { get; set; }
        public string startdate { get; set; }
        public string time { get; set; }
        public string venue { get; set; }
        public string year { get; set; }
        public string term { get; set; }
        public string detail { get; set; }
        public string finishdate { get; set; }
        public string date { get; set; }
        public string buttonapprove { get; set; }
        public string buttondisapprove { get; set; }
        public string textsearch { get; set; }
        public string texthere { get; set; }

    }
    public class ActivityListTeacher
    {
        public int acid { get; set; }
        public string acname { get; set; }
        public string startdate { get; set; }
        public string finishdate { get; set; }
        public string venue { get; set; }
        public string stdname { get; set; }
        public string stdlastname { get; set; }
        public string stdcode { get; set; }
        public string status { get; set; }
        public string color { get; set; }
    }
    public class ActivityApproveTeacherSubmitResponse
    {

    }
    public class OptionsActivitySearchTeacherResponse
    {
        public string title { get; set; }
        public string value { get; set; }
    }
    public class OptionsActivityStatusSearchTeacherResponse
    {
        public string status { get; set; }
        public string value { get; set; }
    }
    public class AddEditDeleteActivityByTeacherResponse
    {
        internal int status;
        public int activitynameid { get; set; }
        public string activityname { get; set; }
        public string teacherid { get; set; }
        public string startdatebyteacher { get; set; }
        public string finishdatebyteacher { get; set; }

        public string url { get; set; }
        internal string message;
        internal string doubleimage;
        internal string sucaddactivity;
        internal string fillempty;

    }


    public class AddEditDeleteActivityByTeacherScreenResponse
    {
        public ScreenInfoAddEditActivityByTeacher screeninfo { get; set; }

    }
    public class ScreenInfoAddEditActivityByTeacher
    {
        public string titleaddactivity { get; set; }
        public string textactivityname { get; set; }
        public string textobjectives { get; set; }
        public string textvenue { get; set; }
        public string textstartdate { get; set; }
        public string textfinishdate { get; set; }
        public string buttonadd { get; set; }
        public string titlelistactivityname { get; set; }
        public string titleeditactivity { get; set; }
        public string buttonsave { get; set; }
        public string buttondelete { get; set; }
        public string buttoncancel { get; set; }
        public string warningdeletetext { get; set; }
        public string warningfillall { get; set; }
    }
    public class ActivityNameListTeacherResponse
    {
        public ScreenInfoActivityListByTeacher screeninfo { get; set; }
        public List<ActivityNameListByTeacher> activitynamelistteacher { get; set; }
    }
    public class ScreenInfoActivityListByTeacher
    {
        public string titlelistactivityname { get; set; }
    }
    public class ActivityNameListByTeacher
    {
        public int activitynameidresponse { get; set; }
        public string activitynameresponse { get; set; }
        public string objectivesresponse { get; set; }
        public string venueresponse { get; set; }
        public string startdatebyteacherresponse { get; set; }
        public string finishdatebyteacherresponse { get; set; }


    }

    public class SelectActivityByStudentResponse
    {
        public int activityid { get; set; }
        public string activitynameid { get; set; }
        public string status { get; set; }
    }
    public class SelectActivityByStudentScreenInfoResponse
    {
        public ScreenInfoSelectActivityByStudent screeninfo { get; set; }
        public List<SelectActivityNameList> activitynamelist { get; set; }
    }
    public class ScreenInfoSelectActivityByStudent
    {
        public string titleselectactivity { get; set; }
        public string buttonselectactivity { get; set; }
        public string textactivityname { get; set; }
    }
    public class SelectActivityNameList
    {
        public int activitynameidresponse { get; set; }
        public string activitynameresponse { get; set; }
        public string teacheridresponse { get; set; }
        //public string startdatebyteacher { get; set; }
        //public string finishdatebyteacher { get; set; }
    }
    public class DeleteActivityByStudentResponse
    {

    }

    public class CalendarInfoResponse
    {
        public int activitynameid { get; set; }
        public string activityname { get; set; }
        public string teacherid { get; set; }
        public string startdatebyteacher { get; set; }
        public string finishdatebyteacher { get; set; }
        public string venue { get;set; }

    }
    public class CalendarScreenResponse
    {
        public string titlecalendar { get; set; }}

    }


