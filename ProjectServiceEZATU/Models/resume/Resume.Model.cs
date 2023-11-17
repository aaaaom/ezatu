
using ProjectServiceEZATU.DTO.Response.generate;
using Microsoft.AspNetCore.Mvc;
using Dapper.Contrib.Extensions;

namespace ProjectServiceEZATU.Models.resume
{
    public class Resume
    {
    }
    public class EducationPreViewResumeModel
    {
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string type { get; set; }
        public string placeofstudy { get; set; }
        public string PLACEOGSTUDYEN { get; set; }
        public string detail { get; set; }
        public string DETAILEN { get; set; }
        public string onselected { get; set; }
    }
    public class ExperiencePreViewResumeModel
    {
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string userlanguage { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string position { get; set; }
        public string POSITIONEN { get; set; }
        public string detail { get; set; }
        public string DETAILEN { get; set; }
        public string onselected { get; set; }
    }
    public class SkillPreViewResumeModel
    {
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string value { get; set; }
        public string skill_th { get; set; }
        public string skill_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
        public string onselected { get; set; }
    }
    public class CertificatePreViewResumeModel
    {
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string title_th { get; set; }
        public string title_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
        public string onselected { get; set; }
    }
    public class PersonInfoPreViewResumeModel
    {
        public string email { get; set; }
        public string phone { get; set; }
        public string facebook { get; set; }
        public string line { get; set; }
        public string instagram { get; set; }
        public string twitter { get; set; }
        public string youtube { get; set; }
        public string onselected_email { get; set; }
        public string onselected_phone { get; set; }
        public string onselected_facebook { get; set; }
        public string onselected_line { get; set; }
        public string onselected_instagram { get; set; }
        public string onselected_twitter { get; set; }
        public string onselected_youtube { get; set; }

    }
    public class UserInfoPreViewResumeModel
    {
        internal string userid;
        public string prefixid { get; set; }
        public string prefix_th { get; set; }
        public string prefix_en { get; set; }
        public string name_th { get; set; }
        public string lastname_th { get; set; }
        public string name_en { get; set; }
        public string lastname_en { get; set; }

    }

    public class UserInfoPrefixModel
    {
        public string specifically { get; set; }
        public string th { get; set; }
        public string en { get; set; }


    }
    
    public class PositionPreViewResumeModel
    {
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string position_th { get; set; }
        public string position_en { get; set; }
        public string office_th { get; set; }
        public string office_en { get; set; }
        public string detail_th { get; set; }
        public string detail_en { get; set; }
        public string onselected { get; set; }

    }
    public class ImagePreViewResumeModel
    {
        public string image { get; set; }
    }public class ResumeColorPreViewResumeModel
    {
        public string option { get; set; }
    }
    public class AboutMePreViewResumeModel
    {
        public string details { get; set; }
        public string DETAILSEN { get; set; }

    }
    public class AddressResumeModel
    {
        public string userid { get; set; }
        public string number { get; set; }
        public string moo { get; set; }
        public string soi_th { get; set; }
        public string soi_en { get; set; }
        public string road_th { get; set; }
        public string road_en { get; set; }
        public string tambon_th { get; set; }
        public string tambon_en { get; set; }

        public string district_th { get; set; }
        public string district_en { get; set; }
        public string province_th { get; set; }
        public string province_en { get; set; }

        public string zipcode { get; set; }
        public string onselected_number { get; set; }
        public string onselected_moo { get; set; }
        public string onselected_soi { get; set; }
        public string onselected_road { get; set; }
        public string onselected_subdistrict { get; set; }
        public string onselected_district { get; set; }
        public string onselected_province { get; set; }
        public string onselected_zipcode { get; set; }
    }
    public class LanguagePreViewResumeModel
    {
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string value { get; set; }
        public string language_th { get; set; }
        public string language_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
        public string onselected { get; set; }
    }
    public class ImageUploadResumeModel
    
    {
        internal int status;
        internal string message;
        internal string image;
        internal string userid;
        public string created_at { get; set; }
        public string updated_at { get; set; }

    }
    public class QueryUserInfoResumeModel
    {

        internal string userid;
        public string prefixid { get; set; }
        public string prefix_th { get; set; }
        public string prefix_en { get; set; }
        public string name_th { get; set; }
        public string lastname_th { get; set; }
        public string name_en { get; set; }
        public string lastname_en { get; set; }
    }
    public class QueryAboutMeResumeModel
    {

        internal string userid;
        public string details { get; set; }
        public string DETAILSEN { get; set; }

    }
    public class QueryPositionResumeModel
    {

        internal string userid;
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string position_th { get; set; }
        public string position_en { get; set; }
        public string office_th { get; set; }
        public string office_en { get; set; }
        public string detail_th { get; set; }
        public string detail_en { get; set; }
        public string onselected { get; set; }

    }
    public class QueryEducationResumeModel
    {

        internal string userid;
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string type { get; set; }
        public string type_th { get; set; }
        public string type_en { get; set; }
        public string placeofstudy { get; set; }
        public string PLACEOGSTUDYEN { get; set; }
        public string detail { get; set; }
        public string DETAILEN { get; set; }
        public string onselected { get; set; }

    }
      public class QueryEducationTypeResumeModel
    {

        public int id { get; set; }
        public string typeid { get; set; }
        public string th { get; set; }
        public string en { get; set; }

    }

    public class QueryContactResumeModel
    {

        internal string userid;
        public string email { get; set; }
        public string phone { get; set; }
        public string facebook { get; set; }
        public string line { get; set; }
        public string instagram { get; set; }
        public string twitter { get; set; }
        public string youtube { get; set; }
        public string onselected_email { get; set; }
        public string onselected_phone { get; set; }
        public string onselected_facebook { get; set; }
        public string onselected_line { get; set; }
        public string onselected_Instagram { get; set; }
        public string onselected_twitter { get; set; }
        public string onselected_youtube { get; set; }

    }
    public class QueryAddressResumeModel
    {

        internal string userid;
        public string number { get; set; }
        public string moo { get; set; }
        public string soi_th { get; set; }
        public string soi_en { get; set; }
        public string road_th { get; set; }
        public string road_en { get; set; }
        public string subdistrict_id { get; set; }
        public string district_id { get; set; }
        public string province_id { get; set; }
        public string zipcode { get; set; }
        public string onselected_number { get; set; }
        public string onselected_moo { get; set; }
        public string onselected_soi { get; set; }
        public string onselected_road { get; set; }
        public string onselected_subdistrict { get; set; }
        public string onselected_district { get; set; }
        public string onselected_province { get; set; }
        public string onselected_zipcode { get; set; }

        public string tambon_th_short { get; set; }
        public string tambon_en_short { get; set; }
        public string district_th_short { get; set; }
        public string province_th { get; set; }
        public string province_en { get; set; }
        public string district_en_short { get; set; }
        public string post_code_main { get; set; }
    }
    public class QueryCertificateResumeModel
    {
        internal string userid;
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string title_th { get; set; }
        public string title_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
        public string onselected { get; set; }


    }  public class QueryExperienceResumeModel
    {
        internal string userid;
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string position { get; set; }
        public string POSITIONEN { get; set; }
        public string detail { get; set; }
        public string DETAILEN { get; set; }
        public string onselected { get; set; }


    }
    public class QuerySkillResumeModel
    {

        internal string userid; public int id { get; set; }
        public int orderchoose { get; set; }
        public string value { get; set; }
        public string skill_th { get; set; }
        public string skill_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }

        public string onselected { get; set; }
    }

    public class QuerySkillLanguageResumeModel
    {



        internal string userid;

        public int id { get; set; }
        public int orderchoose { get; set; }
        public string value { get; set; }
        public string language_th { get; set; }
        public string language_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
        public string onselected { get; set; }

    }

    public class QueryEditUserInfoResumeModel
    {

        internal string userid;

    }
    public class QueryEditAboutMeResumeModel
    {

        internal string userid;

    }
    public class QueryEditPositionResumeModel
    {

        internal string userid;

    }
    public class QueryEditEducationResumeModel
    {

        internal string userid;

    }
    public class QueryEditExperienceResumeModel
    {

        internal string userid;

    } 
    
    public class QueryEditContactResumeModel
    {

        internal string userid;

    }
    public class QueryEditAddressResumeModel
    {

        internal string userid;

    }
    public class QueryEditCertificateResumeModel
    {

        internal string userid;

    }
    public class QueryEditSkillResumeModel
    {

        internal string userid;

    }

    public class QueryEditSkillLanguageResumeModel
    {

        internal string userid;

    }
    public class AddressByTModel
    {
        public int province_id { get; set; }
        public string province_th { get; set; }
        public string province_en { get; set; }
        public int district_id { get; set; }
        public string district_th_short { get; set; }
        public string district_en_short { get; set; }
        public int tambon_id { get; set; }
        public int post_code_main { get; set; }
        public string tambon_th_short { get; set; }
        public string tambon_en_short { get; set; }


    }
    public class ColorResumeModel

    {
        internal int status;
        internal string message;
        internal string image;
        internal string userid;
        internal string parameter;
        internal string colorid;

    }

    [Table("keeplogexperienceresume")]
    public class insertExperienceResumeData
    {
        public string userid { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string position { get; set; }
        public string POSITIONEN { get; set; }
        public string detail { get; set; }
        public string DETAILEN { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }

    }
    [Table("keeplogexperienceresume")]
    public class insertExperienceResumeDataisNull
    {
        public string userid { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string position { get; set; }
        public string POSITIONEN { get; set; }
        public string detail { get; set; }
        public string DETAILEN { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }

    }
    public class QueryCreateExperienceResumeModel
    {

        public string created_at;
        public string updated_at;
        public string created;
    }
    public class Datatime
    {

        public string created_at;
        public string updated_at;
    }
    public class QueryCreateExperienceResumeData
    {

        public string created_at;
        public string updated_at;

    }
    public class QueryInforResumeData
    {

        public string created_at;
        public string updated_at;

    }
    public class QueryAboutmeResumeData
    {

        public string created_at;
        public string updated_at;

    }
    public class QueryPositionResumeData
    {

        public string created_at;
        public string updated_at;

    } 
    public class QueryEduResumeData
    {

        public string created_at;
        public string updated_at;

    }
    public class QueryContactResumeData
    {

        public string created_at;
        public string updated_at;

    } 
    public class QueryAddressResumeData
    {

        public string created_at;
        public string updated_at;

    }
    public class QueryCertiResumeData
    {

        public string created_at;
        public string updated_at;

    } 
    public class QuerySkillResumeData
    {

        public string created_at;
        public string updated_at;

    }
    public class QueryLangResumeData
    {

        public string created_at;
        public string updated_at;

    } 
    public class QueryimgResumeData
    {

        public string created_at;
        public string updated_at;

    }
    public class InsertDataresumetoanotherdatabase
    {

        internal int status;
        internal string message;
        public Datatoinsert data { get; set; }

    }
    public class Datatoinsert
    { 
        public QueryCreateExperienceResumeData experienceResumeData { get; set; }
        public QueryInforResumeData inforData { get; set; }
        public Datatime datatime { get; set; }
        public QueryAboutmeResumeData aboutmeData { get; set; } 
        public QueryPositionResumeData positiontime { get; set; }
        public QueryEduResumeData edutime { get; set; }
        public QueryContactResumeData contacttime { get; set; }
        public QueryAddressResumeData addresstime { get; set; }
        public QueryCertiResumeData certitime { get; set; }
        public QuerySkillResumeData skilltime { get; set; }
        public QueryLangResumeData langtime { get; set; }
        public QueryimgResumeData imgtime { get; set; }

        
    }
    [Table("keeploguserinforesume")]
    public class insertInforResumeDataisNull
    {
        public string userid { get; set; }
        public string prefixid { get; set; }
        public string name_th { get; set; }
        public string lastname_th { get; set; }
        public string name_en { get; set; }
        public string lastname_en { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
    [Table("keeploguserinforesume")]
    public class insertInforResumeData
    {
        public string userid { get; set; }
        public string prefixid { get; set; }
        public string name_th { get; set; }
        public string lastname_th { get; set; }
        public string name_en { get; set; }
        public string lastname_en { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
    [Table("keeploguseraboutmeresume")]
    public class insertAboutmeResumeData
    {
        public string userid { get; set; }
        public string details { get; set; }
        public string DETAILSEN { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
    [Table("keeploguseraboutmeresume")]
    public class insertUpdateAboutmeResumeData
    {
        public string userid { get; set; }
        public string details { get; set; }
        public string DETAILSEN { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
    [Table("keeploguserpositionresume")]
    public class insertPositionResumeData
    {
        public string userid { get; set; }
        public string position_th { get; set; }
        public string position_en { get; set; }
        public string office_th { get; set; }
        public string office_en { get; set; }
        public string detail_th { get; set; }
        public string detail_en { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
    [Table("keeploguserpositionresume")]
    public class insertUpdatePositionResumeData
    {
        public string userid { get; set; }
        public string position_th { get; set; }
        public string position_en { get; set; }
        public string office_th { get; set; }
        public string office_en { get; set; }
        public string detail_th { get; set; }
        public string detail_en { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
    [Table("keeplogusereducationresume")]
    public class insertEduResumeData
    {
        public string userid { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string type { get; set; }
        public string placeofstudy { get; set; }
        public string detail { get; set; }
        public string PLACEOGSTUDYEN { get; set; }
        public string DETAILEN { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
    [Table("keeplogusereducationresume")]
    public class insertUpdateEduResumeData
    {
        public string userid { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string type { get; set; }
        public string placeofstudy { get; set; }
        public string detail { get; set; }
        public string PLACEOGSTUDYEN { get; set; }
        public string DETAILEN { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    } 
    [Table("keeplogusercontactresume")]
    public class insertContactResumeData
    {
        public string userid { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string facebook { get; set; }
        public string line { get; set; }
        public string instagram { get; set; }
        public string twitter { get; set; }
        public string youtube { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
    [Table("keeplogusercontactresume")]
    public class insertUpdateContactResumeData
    {
        public string userid { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string facebook { get; set; }
        public string line { get; set; }
        public string instagram { get; set; }
        public string twitter { get; set; }
        public string youtube { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
    [Table("keeploguseraddressresume")]
    public class insertAddressResumeData
    {
        public string userid { get; set; }
        public string number { get; set; }
        public string moo { get; set; }
        public string soi_th { get; set; }
        public string soi_en { get; set; }
        public string road_th { get; set; }
        public string road_en { get; set; }
        public string subdistrict_id { get; set; }
        public string district_id { get; set; }
        public string province_id { get; set; }
        public string zipcode { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
    [Table("keeplogusercertifresume")]
    public class insertCertiResumeData
    {
        public string userid { get; set; }
        public string title_th { get; set; }
        public string title_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    } 
    [Table("keeploguserskillresume")]
    public class insertSkillResumeData
    {
        public string userid { get; set; }
        public string value { get; set; }
        public string skill_th { get; set; }
        public string skill_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
    [Table("keeploguserskillresume")]
    public class insertUpdateSkillResumeData
    {
        public string userid { get; set; }
        public string value { get; set; }
        public string skill_th { get; set; }
        public string skill_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
    [Table("keeploguserlanguageresume")]
    public class insertLangResumeData
    {
        public string userid { get; set; }
        public string value { get; set; }
        public string language_th { get; set; }
        public string language_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    } 
    [Table("keeploguserlanguageresume")]
    public class insertUpdateLangResumeData
    {
        public string userid { get; set; }
        public string value { get; set; }
        public string language_th { get; set; }
        public string language_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    } 
    [Table("keeploguserimageresume")]
    public class insertimgResumeData
    {
        public string userid { get; set; }
        public string image { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }

    }
   
}
