using ProjectServiceEZATU.Database;
using ProjectServiceEZATU.DTO.Response.home;
using Microsoft.AspNetCore.Mvc;
using ProjectServiceEZATU.Models.resume;
using System.Collections.Generic;

namespace ProjectServiceEZATU.DTO.Response.resume
{
   
    public class ResumeResponse
    {
    }

    public class ImageUploadResumeResponse
    {
        internal int status;
        internal string message;
        public Datatoinsert data { get; set; }
    }
    public class UserInfoResumeResponse
    {
        internal int status;
        internal string message;

        public UserInfoResumeResponseScreenData screeninfo { get; set; }
        public List<UserInfoPrefixResumeResponse> prefix { get; set; }
        public UserInfoResumeResponseData data { get; set; }
        public ErrorButton errorbutton { get; set; }
        public AlertMessageResume alertmessage { get; set; }
    }
    public class UserInfoResumeResponseScreenData
    { 
        public string textprefix_th { get; set; }
        public string textprefix_en { get; set; }
        public string textname_th { get; set; }
        public string textname_en { get; set; }
        public string textlastname_th { get; set; }
        public string textlastname_en { get; set; }
        public string save { get; set; }
        public string editinfomations { get; set; }
    }
    public class UserInfoResumeResponseData
    { 
        public string prefixid { get; set; }
        public string prefix_th { get; set; }
        public string prefix_en { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string nameen { get; set; }
        public string lastnameen { get; set; }
    }
    public class AboutMeResumeResponse
    {
        internal int status;
        internal string message;

        public AboutMeResumeResponseScreenData screeninfo { get; set; }
        public AboutMeResumeResponseData data { get; set; }
        public ErrorButton errorbutton { get; set; }
        public AlertMessageResume alertmessage { get; set; }
    }
    public class AboutMeResumeResponseScreenData
    {
       
        public string aboutme_th { get; set; }
        public string aboutme_en { get; set; }
        public string save { get; set; }
        public string editinfomations { get; set; }
        public string deleteor { get; set; }
        public string delete { get; set; }
    }
    public class AboutMeResumeResponseData 
    { 
        public string details { get; set; }
        public string DETAILSEN { get; set; }
    }
    public class PositionResumeResponse
    
    {
        internal int status;
        internal string message;

        public PositionResumeResponseScreenData screeninfo { get; set; }
        public PositionResumeResponseData data { get; set; }
        public ErrorButton errorbutton { get; set; }
        public AlertMessageResume alertmessage { get; set; }
    }

    public class PositionResumeResponseScreenData
    {

        public string save { get; set; }
        public string editinfomations { get; set; }
        public string position_th { get; set; }
        public string office_th { get; set; }
        public string position_en { get; set; }
        public string office_en { get; set; }
        public string detail_th { get; set; }
        public string detail_en { get; set; }
        public string deleteor { get; set; }
        public string delete { get; set; }
    }
    public class PositionResumeResponseData
    {

        public int id { get; set; }
        public int orderchoose { get; set; }
        public string position_th { get; set; }
        public string position_en { get; set; }
        public string office_th { get; set; }
        public string office_en { get; set; }
        public string detail_th { get; set; }
        public string detail_en { get; set; }
    }
    public class EducationResumeResponse
    {
        internal int status;
        internal string message;
        public EducationResumeResponseScreenData screeninfo { get; set; }
        public EducationResumeResponseData data { get; set; }

        public List<EducationTypeResumeResponseData> type { get; set; }
        public ErrorButton errorbutton { get; set; }
        public AlertMessageResume alertmessage { get; set; }
        //public EducationResumeResponseDataList data { get; set; }
    }

    public class EducationTypeResumeResponseData
    {

        public string typeid { get; set; }
        public string type_th { get; set; }
        public string type_en { get; set; }

    }
    public class EducationResumeResponseDataList
    {
        public EducationResumeResponseData hsc { get; set; }
        public EducationResumeResponseData bd { get; set; }
        public EducationResumeResponseData md { get; set; }
        public EducationResumeResponseData dd { get; set; }
        public EducationResumeResponseData hdd { get; set; }
    }
    public class EducationResumeResponseScreenData
    {

        public string save { get; set; }
        public string editinfomations { get; set; }
        public string startdate_th { get; set; }
        public string enddate_th { get; set; }
        public string startdate_en { get; set; }
        public string enddate_en { get; set; }
        public string type_th { get; set; }
        public string type_en { get; set; }
        public string placeofstudy_th { get; set; }
        public string placeofstudy_en { get; set; }
        public string fbc_th { get; set; }
        public string fbc_en { get; set; }
        public string detail_th { get; set; }
        public string detail_en { get; set; }
        public string deleteor { get; set; }
        public string delete { get; set; }


    }
    public class EducationResumeResponseData
    {
        internal string userid;
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string typeid { get; set; }
        public string type_th { get; set; }
        public string type_en { get; set; }
        public string placeofstudy_th { get; set; }
        public string placeofstudy_en { get; set; }
        public string detail_th { get; set; }
        public string detail_en { get; set; }

    }

    public class ExperienceResumeResponse
    {
        internal int status;
        internal string message;
        public ExperienceResumeResponseScreenData screeninfo { get; set; }
        public ExperienceResumeResponseData data { get; set; }
        public ErrorButton errorbutton { get; set; }
        public AlertMessageResume alertmessage { get; set; }
    }
    public class ExperienceResumeResponseData
    {
        internal string userid;
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string position_th { get; set; }
        public string position_en { get; set; }
        public string detail_th { get; set; }
        public string detail_en { get; set; }

    }
    public class ExperienceResumeResponseScreenData
    {

        public string save { get; set; }
        public string editinfomations { get; set; }
        public string startdate_th { get; set; }
        public string enddate_th { get; set; }
        public string startdate_en { get; set; }
        public string enddate_en { get; set; }
        public string position_th { get; set; }
        public string position_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
        public string deleteor { get; set; }
        public string delete { get; set; }

    }
    public class ContactResumeResponse
    {
        internal int status;
        internal string message;
        public ContactResumeResponseScreenData screeninfo { get; set; }
        public ContactResumeResponseData data { get; set; }
        public ErrorButton errorbutton { get; set; }
        public AlertMessageResume alertmessage { get; set; }
    }

    public class ContactResumeResponseScreenData
    {

        public string save { get; set; }
        public string editinfomations { get; set; }
        public string deleteor { get; set; }
        public string delete { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string facebook { get; set; }
        public string line { get; set; }
        public string instagram { get; set; }
        public string twitter { get; set; }
        public string youtube { get; set; }

    }
    public class ContactResumeResponseData
    {
        public string email { get; set; }
        public string phone { get; set; }
        public string facebook { get; set; }
        public string line { get; set; }
        public string instagram { get; set; }
        public string twitter { get; set; }
        public string youtube { get; set; }

    }
    public class AddressResumeResponse
    {
        internal int status;
        internal string message;
        public AddressResumeResponseScreenData screeninfo { get; set; }
        public AddressResumeResponseData data { get; set; }

        public List<AddressDistrictList> districtlist { get; set; }

        public List<AddressTambonList> tambonlist { get; set; }
        public ErrorButton errorbutton { get; set; }
        public AlertMessageResume alertmessage { get; set; }
    }

    public class AddressResumeResponseScreenData
    {

        public string save { get; set; }
        public string editinfomations { get; set; }
        public string deleteor { get; set; }
        public string delete { get; set; }
        public string number { get; set; }
        public string moo { get; set; }
        public string soi_th { get; set; }
        public string road_th { get; set; }
        public string subdistrict_th { get; set; }
        public string district_th { get; set; }
        public string province_th { get; set; }
        public string soi_en { get; set; }
        public string road_en { get; set; }
        public string subdistrict_en { get; set; }
        public string district_en { get; set; }
        public string province_en { get; set; }
        public string zipcode { get; set; }

    }
    public class AddressResumeResponseData
    {

        public string number { get; set; }
        public string moo { get; set; }
        public string soi_th { get; set; }
        public string soi_en { get; set; }
        public string road_th { get; set; }
        public string road_en { get; set; }
        public string subdistrict_id { get; set; }
        public string district_id { get; set; }
        public string province_id { get; set; }
        public string subdistrict_th { get; set; }
        public string district_th { get; set; }
        public string province_th { get; set; }
        public string subdistrict_en { get; set; }
        public string district_en { get; set; }
        public string province_en { get; set; }
        public string zipcode { get; set; }
        public bool onselected_number { get; set; }
        public bool onselected_moo { get; set; }
        public bool onselected_soi { get; set; }
        public bool onselected_road { get; set; }
        public bool onselected_subdistrict { get; set; }
        public bool onselected_district { get; set; }
        public bool onselected_province { get; set; }
        public bool onselected_zipcode { get; set; }

    }
    public class CertificateResumeResponse
    {
        internal int status;
        internal string message;
        public CertificateResumeResponseScreenData screeninfo { get; set; }
        public CertificateResumeResponseData data { get; set; }
        public ErrorButton errorbutton { get; set; }
        public AlertMessageResume alertmessage { get; set; }
    }

    public class CertificateResumeResponseScreenData
    {

        public string save { get; set; }
        public string editinfomations { get; set; }
        public string title_th { get; set; }
        public string title_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
        public string deleteor { get; set; }
        public string delete { get; set; }

    }
    public class CertificateResumeResponseData
    {


        public int id { get; set; }
        public int orderchoose { get; set; }
        public string title { get; set; }
        public string TITLEEN { get; set; }
        public string description { get; set; }
        public string DESCRIPTIONEN { get; set; }

    }
    public class SkillResumeResponse
    {
        internal int status;
        internal string message;
        public SkillResumeResponseScreenData screeninfo { get; set; }
        public SkillResumeResponseData data { get; set; }
        public ErrorButton errorbutton { get; set; }
        public AlertMessageResume alertmessage { get; set; }
    }

    public class SkillResumeResponseScreenData
    {

        public string save { get; set; }
        public string editinfomations { get; set; }
        public string skill_th { get; set; }
        public string skill_en { get; set; }
        public string level { get; set; }
        public string level_th { get; set; }
        public string level_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
        public string deleteor { get; set; }
        public string delete { get; set; }

    }
    public class SkillResumeResponseData
    {

        public int id { get; set; }
        public int orderchoose { get; set; }
        public string skill { get; set; }
        public string SKILLEN { get; set; }
        public string value { get; set; }
        public string detail { get; set; }
        public string DETAILEN { get; set; }

    }
    public class SkillLanguageResumeResponse
    {
        internal int status;
        internal string message;
        public SkillLanguageResumeResponseScreenData screeninfo { get; set; }
        public SkillLanguageResumeResponseData data { get; set; }
        public ErrorButton errorbutton { get; set; }
        public AlertMessageResume alertmessage { get; set; }
    }

    public class SkillLanguageResumeResponseScreenData
    {

        public string save { get; set; }
        public string editinfomations { get; set; }
        public string language_th { get; set; }
        public string language_en { get; set; }
        public string level { get; set; }
        public string level_th { get; set; }
        public string level_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
        public string deleteor { get; set; }
        public string delete { get; set; }

    }
    public class SkillLanguageResumeResponseData
    {

        public int id { get; set; }
        public int orderchoose { get; set; }
        public string language { get; set; }
        public string LANGUAGEEN { get; set; }
        public string value { get; set; }
        public string detail { get; set; }
        public string DETAILEN { get; set; }

    }


    public class EditUserInfoResumeResponse
    {
        internal int status;
        internal string message;
        public Datatoinsert data { get; set; }
    }
    public class EditAboutMeResumeResponse
    {
        internal int status;
        internal string message;
        public Datatoinsert data { get; set; }
    } public class SetOnSelectResumeResponse
    {
        internal int status;
        internal string message;

    }
    public class EditPositionResumeResponse
    {
        internal int status;
        internal string message;
        public Datatoinsert data { get; set; }
    }
    public class EditEducationResumeResponse
    {
        internal int status;
        internal string message;
        public Datatoinsert data { get; set; }
    }
    public class EditExperienceResumeResponse
    {
        internal int status;
        internal string message;
        public Datatoinsert data { get; set; }
    }
    
    public class EditContactResumeResponse
    {
        internal int status;
        internal string message;
        public Datatoinsert data { get; set; }
    }
    public class EditAddressResumeResponse
    {
        internal int status;
        internal string message;
        public Datatoinsert data { get; set; }
    }
    public class EditCertificateResumeResponse
    {
        internal int status;
        internal string message;
        public Datatoinsert data { get; set; }
    }
    public class EditSkillResumeResponse
    {
        internal int status;
        internal string message;
        public Datatoinsert data { get; set; }
    }
    
    public class EditSkillLanguageResumeResponse
    {
        internal int status;
        internal string message;
        public Datatoinsert data { get; set; }
    }

    public class MorePreViewResumeResponse
    {

        internal int status;
        internal string message;
        public ScreenInfoMorePreViewResumeResponse screeninfo { get; set; }
        public MorePreViewResumeDataResponse data { get; set; }

    }

    //public class OnSelectResumeResponse
    //{

    //    internal int status;
    //    internal string message;
    //    public OnSelectResumeResponseData data_on_select { get; set; }

    //}
    //public class OnSelectResumeResponseData
    //{
    //    public List<OnSelectResume> position_on_select { get; set; }
    //    public List<OnSelectResume> experience_on_select { get; set; }
    //    public OnSelectEducationResumeResponseList education_on_select { get; set; }
    //    public List<OnSelectResume> skill_on_select { get; set; }
    //    public List<OnSelectResume> certificate_on_select { get; set; }
    //    public List<OnSelectResume> language_on_select { get; set; }
    //    public OnSelectSocialResume social_on_select { get; set; }
    //    public OnSelectAddressResume address_on_select { get; set; }
    //}
  
    //public class OnSelectResume
    //{
    //    public int id { get; set; }
    //    public bool onselect { get; set; }

    //}
    //public class OnSelectSocialResume
    //{
    //    public bool onselected_email { get; set; }
    //    public bool onselected_phone { get; set; }
    //    public bool onselected_facebook { get; set; }
    //    public bool onselected_line { get; set; }
    //    public bool onselected_instagram { get; set; }
    //    public bool onselected_twitter { get; set; }
    //    public bool onselected_youtube { get; set; }

    //}
    //public class OnSelectAddressResume
    //{

    //    public bool onselected_number { get; set; }
    //    public bool onselected_moo { get; set; }
    //    public bool onselected_soi { get; set; }
    //    public bool onselected_road { get; set; }
    //    public bool onselected_subdistrict { get; set; }
    //    public bool onselected_district { get; set; }
    //    public bool onselected_province { get; set; }
    //    public bool onselected_zipcode { get; set; }

    //}
    //public class OnSelectEducationResumeResponseList
    //{
    //    public List<OnSelectResume> hsc_on_select { get; set; }
    //    public List<OnSelectResume> bd_on_select { get; set; }
    //    public List<OnSelectResume> md_on_select { get; set; }
    //    public List<OnSelectResume> dd_on_select { get; set; }
    //    public List<OnSelectResume> hdd_on_select { get; set; }
    //}

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
        public string facebook { get; set; }
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
        public string startdate { get; set; }
        public string subdistrict { get; set; }
        public string themecolor { get; set; }
        public string title { get; set; }
        public string titlesetthemecolor { get; set; }
        public string titlesettheme { get; set; }
        public string twitter { get; set; }
        public string type { get; set; }
        public string value { get; set; }
        public string whcm { get; set; }
        public string zipcode { get; set; }
        public string unkhown { get; set; }
        public string viewpdf { get; set; }
        public string titleresumeinformation { get; set; }
        public string hsc { get; set; }
        public string bd { get; set; }
        public string md { get; set; }
        public string dd { get; set; }
        public string hdd { get; set; }
        public string tapedit { get; set; }
        public string save { get; set; }
        public string saveor { get; set; }
        public string youtube { get; set; }
        public string showall { get; set; }
        public string showsome { get; set; }
        public string activitynot { get; set; }
        public string btnresume1 { get; set; }
        public string btnresume2 { get; set; }
        public string selectednot { get; set; }









    }
    public class MorePreViewResumeDataResponse
    {

        public bool resumeColor { get; set; }
        public UserInfoPreViewResumeResponse userinfo { get; set; }
        public List<PositionPreViewResumeResponseList> position { get; set; }
        public string aboutme { get; set; }
        public PersonInfoPreViewResumeResponse contactinfo { get; set; }
        public AddressViewResumeResponse address { get; set; }
        public List<ExperiencePreViewResumeResponse> experience { get; set; }
        public EducationResumeResponseList education { get; set; }
        public List<SkillPreViewResumeResponse> skill { get; set; }
        public List<CertificateViewResumeResponse> certificate { get; set; }
        public List<LanguageViewResumeResponse> language { get; set; }
        public ResumeDataCount resumedatacount { get; set; }
        public ResumeDataColor resumedatacolor { get; set; }
        public string image { get; set; }
    }
    public class PositionPreViewResumeResponseList
    {
      
        public int id { get; set; }
        public int orderchoose { get; set; }
        public bool onselect { get; set; }

        public string position { get; set; }
        public string office { get; set; }
        public string detail { get; set; }
    }
    public class  ResumeDataCount
    {
        public int position { get; set; }
        public int experience { get; set; }
        public int education_hsc { get; set; }
        public int education_bd { get; set; }
        public int education_md { get; set; }
        public int education_dd { get; set; }
        public int education_hdd { get; set; }
        public int skill { get; set; }
        public int certificate { get; set; }
        public int language { get; set; }

    }public class ResumeDataColor
    {
        public int text { get; set; }
        public int name { get; set; }
        public int theme { get; set; }
        public int aboutme { get; set; }
        public int position { get; set; }
        public int education { get; set; }
        public int contact { get; set; }
        public int address { get; set; }
        public int experience { get; set; }
        public int certificate { get; set; }
        public int skill { get; set; }
        public int language { get; set; }

    }
    public class UserInfoPreViewResumeResponse
    {
      
        public string prefixid { get; set; }
        public string prefix { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
    } 
    
    
    public class UserInfoPrefixResumeResponse
    {
        public string specifically { get; set; }
        public string th { get; set; }
        public string en { get; set; }
    }
    public class PersonInfoPreViewResumeResponse
    {
        public string email { get; set; }
        public string phone { get; set; }
        public string facebook { get; set; }
        public string line { get; set; }
        public string instagram { get; set; }
        public string twitter { get; set; }
        public string youtube { get; set; }
        public bool onselected_email { get; set; }
        public bool onselected_phone { get; set; }
        public bool onselected_facebook { get; set; }
        public bool onselected_line { get; set; }
        public bool onselected_instagram { get; set; }
        public bool onselected_twitter { get; set; }
        public bool onselected_youtube { get; set; }
    }
    public class ExperiencePreViewResumeResponse
    {
        public int id { get; set; }
        public int orderchoose { get; set; }
        public bool onselect { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string position { get; set; }
        public string detail { get; set; }
    }
    public class EducationResumeResponseList
    {
        public List<EducationPreViewResumeResponseHSC> hsc { get; set; }
        public List<EducationPreViewResumeResponse> bd { get; set; }
        public List<EducationPreViewResumeResponse> md { get; set; }
        public List<EducationPreViewResumeResponse> dd { get; set; }
        public List<EducationPreViewResumeResponse> hdd { get; set; }
    }
    public class EducationPreViewResumeResponseHSC
    {
        public int id { get; set; }
        public int orderchoose { get; set; }
        public bool onselect { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string type { get; set; }
        public string placeofstudy { get; set; }
        public string detail { get; set; }
    }
    public class EducationPreViewResumeResponse
    {
        public int id { get; set; }
        public int orderchoose { get; set; }
        public bool onselect { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string type { get; set; }
        public string placeofstudy { get; set; }
        public string detail { get; set; }
    }
    public class SkillPreViewResumeResponse
    {
        public int id { get; set; }
        public int orderchoose { get; set; }
        public bool onselect { get; set; }
        public string skill { get; set; }
        public string value { get; set; }
        public string detail { get; set; }
    }
    public class CertificateViewResumeResponse
    {
        public int id { get; set; }
        public int orderchoose { get; set; }
        public bool onselect { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }

    public class LanguageViewResumeResponse
    {
        public int id { get; set; }
        public int orderchoose { get; set; }
        public bool onselect { get; set; }
        public string language { get; set; }
        public string value { get; set; }
        public string detail { get; set; }
    }
    public class AddressViewResumeResponse
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
        public bool onselected_number { get; set; }
        public bool onselected_moo { get; set; }
        public bool onselected_soi { get; set; }
        public bool onselected_road { get; set; }
        public bool onselected_subdistrict { get; set; }
        public bool onselected_district { get; set; }
        public bool onselected_province { get; set; }
        public bool onselected_zipcode { get; set; }
    }
    public class generatepdfResponse 
    {
        internal int status;
        internal string message;
    }  public class GenerateResumePdfResponse 
    {
        internal int status;
        internal string message;
        public FileStreamResult ResultPdf;
    }
    //public class AddressTambonByTResumeResponse
    //{
    //    public List<AddressByTResumeListResponse> addresslist { get; set; }
    //}
    public class AddressProvinceByTResumeResponse
    {
        internal int status;
        internal string message;
        public List<AddressProvinceList> provincelist { get; set; }
    }
    public class AddressDistrictByTResumeResponse
    {
        internal int status;
        internal string message;
        public List<AddressDistrictList> districtlist { get; set; }
    }
    public class AddressTambonByTResumeResponse
    {
        internal int status;
        internal string message;
        public List<AddressTambonList> tambonlist { get; set; }
    }
    public class AddressProvinceList
    {
        public int provinceid { get; set; }
        public string provincenameth { get; set; }
        public string provincenameen { get; set; }
    }
    public class AddressDistrictList
    {
        public int districtid { get; set; }
        public string districtnameth { get; set; }
        public string districtnameen { get; set; }
    }
    public class AddressTambonList
    {
        public int tambonid { get; set; }
        public string tambonnameth { get; set; }
        public string tambonnameen { get; set; }
    }
    public class AddressZipCodeTResumeResponse
    {
        internal int status;
        internal string message;
        public string zipcode { get; set; }
    }
    public class SetOnColorResumeResponse
    {
        internal int status;
        internal string message;

    }
}
