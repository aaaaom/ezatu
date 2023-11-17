using System;
using System.Collections.Generic;
//using static ScreenProfileInfoResonse;

namespace ProjectServiceEZATU.Models
{

    public class Respdpa
    {
        public resPDPA screeninfo { get; set; }
        public string linkpdpa { get; set; }
        public string versionpdpa { get; set; }
    }
    public class PDPADataModel
    {
        public string pdpaversion { get; set; }
        public string lasted { get; set; }
        public string pdpalink { get; set; }
        public string createat { get; set; }
        public string updateat { get; set; }





    }
    public class ResponseGeneral2
    {
        public ScreenProfileInfoResonse screeninfo { get; set; }
        public generalProfileInfoModel profile_general_info { get; set; }
        public ProfileEduInfo profile_edu_info { get; set; }
        public ProfileAddressInfo profile_address_info { get; set; }
        public ProfileContactInfo profile_contact_info { get; set; }
        public global::ProfileCareerInfo profile_career_info { get; set; }
        public global::ProfileCareerScreenInfo profile_career_screen_info { get; set; }

    }

   
    }
    public class Jobtype
    {
        public String jobname { get; set; }
    }

    public class ProfileAddressInfo
    {
        public String number { get; set; }
        public String moo { get; set; }
        public String soi { get; set; }
        public String road { get; set; }
        public String subdistrict { get; set; }
        public String district { get; set; }
        public String province { get; set; }
        public String zipcode { get; set; }
    }

    public class ProfileCareerInfo
    {
/*    public List<Attention> attentions { get; set; }
    public List<Status> statuses { get; set; }
    public List<Jobtype> jobtypes { get; set; }*/
    public String company { get; set; }
    public String attention { get; set; }
    public String status { get; set; }
    public String jobtype { get; set; }
    public String userworkplace { get; set; }
    public String usercareer { get; set; }
    public String usercompany { get; set; }
    public String userattention { get; set; }
    public String userstatus { get; set; }
    public String userjobtype { get; set; }
}
public class ProfileCareerScreenInfo
{
    public List<Attention> attention { get; set; }
    public List<Status> status { get; set; }
    public List<Jobtype> jobtype { get; set; }
}

public class ProfileContactInfo
    {
        public String phone { get; set; }
        public String line { get; set; }
        public String facebook { get; set; }
        public String instagram { get; set; }
        public String twitter { get; set; }
        public String youtube { get; set; }
    }

    public class ProfileEduInfo
    {
        public String faculty { get; set; }
        public String department { get; set; }
        public String major { get; set; }
        public String gpa_bd { get; set; }
        public String gpa_jhs { get; set; }
        public String gpa_shs { get; set; }
    }

    //public class generalProfileInfoModel
    //{
    //    public String name { get; set; }
    //    public String surname { get; set; }
    //    public String nickname { get; set; }
    //    public String stu_code { get; set; }
    //    public String gen { get; set; }
    //    public String tel { get; set; }
    //}
  
    public class Status
    {
        public String statusname { get; set; }
    }

    public class Attention
{
    public String attenname { get; set; }
    }

public class resPDPA
{
    public string titlepdpa { get; set; }
    public string btnaccept { get; set; }
    public string btndecline { get; set; }
    //public string linkpdpa { get; set; }

}

public class ScreenProfileInfoResonse
{
    public String titleprofile { get; set; } = "Profile";
    public String subtitlegeninfo { get; set; } = "General information";
    public String subtitlecont { get; set; } = "Contact";
    public String subtitleeduinfo { get; set; } = "Education information";
    public String subtitleaddress { get; set; } = "Address";
    public String subtitleworkinfo { get; set; } = "Career";
    public String textedit { get; set; } = "Edit";
    public String textsave { get; set; } = "Save";
    public String textname { get; set; } = "Name";
    public String textlname { get; set; } = "Lastname";
    public String textnickname { get; set; } = "Nickname";
    public String textstdcode { get; set; } = "Student code";
    public String textgen { get; set; } = "Generation";
    public String texttel { get; set; } = "Tel";
    public String textfac { get; set; } = "Faculty";
    public String textdepart { get; set; } = "Department";
    public String textmajor { get; set; } = "Major";
    public String textgpaju { get; set; } = "GPA (Junior high school)";
    public String textgpase { get; set; } = "GPA (Senior high school)";
    public String textgpaba { get; set; } = "GPA (Bachelor degree)";
    public String texthousenumber { get; set; } = "House no";
    public String textmoo { get; set; } = "Moo";
    public String textsoi { get; set; } = "Soi";
    public String textroad { get; set; } = "Road";
    public String textsubdistrict { get; set; } = "Subdistrict";
    public String textdistrict { get; set; } = "District";
    public String textprovince { get; set; } = "Province";
    public String textpostcode { get; set; } = "Zip code";
    public String subtitleworkplace { get; set; } = "Work place";
    public String textcomp { get; set; } = "Company";
    public String textatt { get; set; } = "Attention";
    public String textcareer { get; set; } = "Career";
    public String textJobtype { get; set; } = "Job type";
    public String textemp { get; set; } = "Employed";
    public String textunemp { get; set; } = "Unemployed";
    public String textfustud { get; set; } = "Futher study";
    public String textstudying { get; set; } = "Studying";
    public String textstatus { get; set; } = "Status";
    public String textig { get; set; }
    public String textfacebook { get; set; }
    public String textline { get; set; }
    /*public ProfileCareerScreeninfo profile_career_screeninfo { get; set; }*/

}
public class GeneralProfileInfoResponse
{
    public String name { get; set; }
    public String lastname { get; set; }
    public String nickname { get; set; }
    public String generation { get; set; }
    public String genname { get; set; }
    public String position { get; set; }
    public String gencolor { get; set; }
    public String branchname { get; set; }
    public String facultyname { get; set; }
    public String department { get; set; }
    public String studentid { get; set; }
    public String email { get; set; }
    public String langeuage { get; set; }
    public String role { get; set; }
    public String rolename { get; set; }
    public String img { get; set; }

}
public class eduProfileInfoResponse
   
{
    public String faculty { get; set; }
    public String department { get; set; }
    public String major { get; set; }
    public String gpa_bd { get; set; }
    public String gpa_jhs { get; set; }
    public String gpa_shs { get; set; }

}
public class AddressProfileInfoResponse
{
    public String number { get; set; }
    public String moo { get; set; }
    public String soi { get; set; }
    public String road { get; set; }
    public String subdistrict { get; set; }
    public String district { get; set; }
    public String province { get; set; }
    public String zipcode { get; set; }
}
public class ContactProfileInfoResponse

{
    public String phone { get; set; }
    public String line { get; set; }
    public String facebook { get; set; }
    public String instagram { get; set; }
    public String twitter { get; set; }
    public String youtube { get; set; }
}
public class ProfileCareerInfoResponse
{

    //public String company { get; set; }
    //public String attention { get; set; }
    //public String status { get; set; }
    //public String jobtype { get; set; }
    public String userworkplace { get; set; }
    public String usercareer { get; set; }
    public String usercompany { get; set; }
    public String userattention { get; set; }
    public String userstatus { get; set; }
    public String userjobtype { get; set; }
    public String userattentionvalue { get; set; }
    public String userstatusvalue { get; set; }
    public String userjobtypevalue { get; set; }
}

public class ProfileCareerScreenInfoResponse
{
    public List<AttentionScreenInfoResponse> attention { get; set; }
    public List<StatusScreenInfoResponse> status { get; set; }
    public List<JobtypeScreenInfoResponse> jobtype { get; set; }
   
}
public class AttentionScreenInfoResponse
{
    public String attenvalue { get; set; }
    public String attenname { get; set; }
}
public class StatusScreenInfoResponse
{
    public String statusvalue { get; set; }
    public String statusname { get; set; }
}

public class JobtypeScreenInfoResponse
{
    public String jobtypevalue { get; set; }
    public String jobtype { get; set; }
}