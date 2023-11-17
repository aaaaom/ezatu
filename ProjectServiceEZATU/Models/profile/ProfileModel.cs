using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace ProjectServiceEZATU.Models
{
    public class ChangeImgeProfileModel
    {

    }

    public class ProfileModel
    {

        public ScreenProfileInfoResonse screeninfo { get; set; }
        public GeneralProfileInfoResponse profile_general_info { get; set; }
        public eduProfileInfoResponse profile_edu_info { get; set; }
        public AddressProfileInfoResponse profile_address_info { get; set; }
        public ContactProfileInfoResponse profile_contact_info { get; set; }
        public ProfileCareerInfoResponse profile_career_info { get; set; }
        public ProfileCareerScreenInfoResponse profile_career_screen_info { get; set; } 


    }
    public class Allprofile
    {
        public generalProfileInfoModel profile_general_info { get; set; }
        public ProfileEduInfoModel profile_edu_info { get; set; }
        public AddressProfileInfoModel profile_address_info { get; set; }
        public ContactProfileInfoModel profile_contact_info { get; set; }
        public ProfileCareerInfoModel profile_career_info { get; set; }
        public ProfileCareerScreenInfo profile_career_screen_info { get; set; }
    }

    public class ScreenProfileInfoModel
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
        public String textstatus { get; set; } = "Status";
        

    }
    public class generalProfileInfoModel
    {
        public String name { get; set; }
        public String lastname { get; set; }
        public String nickname { get; set; }
        public String generation { get; set; }
        public String genname { get; set; }
        public String position { get; set; }
        public String enposition { get; set; }
        public String gencolor { get; set; }
        public String studentid { get; set; }
        public String userlanguage { get; set; }
        public String roleTH { get; set; }
        public String roleEN { get; set; }
        public String role { get; set; }
    }
    public class generalProfileInfoModelImgeEmail
    {

        public String img { get; set; }

        public String email { get; set; }
    }  
    public class generalProfileInfoModelII
    {

        public String userid { get; set; }
        public String branchid { get; set; }
        public String departmentid { get; set; }
        public String facultyid { get; set; }
        public String userlanguage { get; set; }
        public String branchnameth { get; set; }
        public String branchnameen { get; set; }
        public String facultynameth { get; set; }
        public String facultynameen { get; set; }
        public String departmentnameth { get; set; }
        public String departmentnameen { get; set; }
    }
    public class ContactProfileInfoModel
    {
        public String phone { get; set; }
        public String line { get; set; }
        public String facebook { get; set; }
        public String instagram { get; set; }
        public String twitter { get; set; }
        public String youtube { get; set; }
        public String link_line { get; set; }
        public String link_fb { get; set; }
        public String link_insta { get; set; }
        public String link_tw { get; set; }
        public String link_yt { get; set; }
    }
    public class ProfileEduInfoModel
    {

        public String branchnameen { get; set; }
        public String departmentnameen { get; set; }
        public String facultynameen { get; set; }
        public String branchnameth { get; set; }
        public String departmentnameth { get; set; }
        public String facultynameth { get; set; }
        public String gpabd { get; set; }
        public String gpajhs { get; set; }
        public String gpashs { get; set; }
        public String role { get; set; }
        public String userlanguage { get; set; }
    }
    public class ProfileCareerInfoModel
    {

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
    public class AddressProfileInfoModel
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
    public class StatusProfileModel
    {
        public String value { get; set; }
        public String statusname { get; set; }
        public String TH { get; set; }
        public String EN { get; set; }
        public String userlanguage { get; set; }
    }

    public class AttentionProfileModel
    {
        public String value { get; set; } 
        public String attenname { get; set; } 
        public String TH { get; set; } 
        public String EN { get; set; }
        public String userlanguage { get; set; }
    }
    public class JobTypeProfileModel
    {
        public String value { get; set; }
        public String jobname { get; set; }
        public String TH { get; set; }
        public String EN { get; set; }
        public String userlanguage { get; set; }
    }
}


public class ImgeProfileModel
{

}
public class GeneralProfileSubmitModel
{

}
public class EducationProfileSubmitModel
{

}
public class AddressProfileSubmitModel
{

}
public class ContactProfileSubmitModel
{

}
public class CareerProfileSubmitModel
{

}


public class ProfilecareerModel
{
    //public string Parameter { get; set; }
    public string Screen { get; set; }
    public string parameter { get; set; }
    public string EN { get; set; }
    public string TH { get; set; }
    public string userlanguage { get; set; }
    public string userworkplace { get; set; }
    public string usercareer { get; set; }
    public string usercompany { get; set; }
    public string attentionth { get; set; }
    public string attentionen { get; set; }
    public string statusth { get; set; }
    public string statusen { get; set; }
    public string jobtypeth { get; set; }
    public string jobtypeen { get; set; }
    public string userattention { get; set; }
    public string userstatus { get; set; }
    public string userjobtype { get; set; }

}
