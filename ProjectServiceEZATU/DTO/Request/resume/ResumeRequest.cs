using System.Collections.Generic;

namespace ProjectServiceEZATU.DTO.Request.resume
{
    public class ResumeRequest
    {
    }
    public class MorePreViewResumeRequest
    {
        public string userlanguage { get; set; }
    }
    public class OnSelectResumeRequest
    {
        //public string userlanguage { get; set; }
    }
    public class MorePreEditResumeRequest
    {
        public Resume resume { get; set; }
    }
    public class Resume
    {
        public bool usabilityscreen { get; set; }
        public string userlanguage { get; set; }
    }
    public class ImageUploadResumeRequest
    {
        public string base64 { get; set; }
    }
    public class UserInfoResumeRequest
    {

        public string languageresume { get; set; }
    }
    public class AboutMeResumeRequest
    {
        public string languageresume { get; set; }
    }
    public class PositionResumeRequest
    {
        public int position_id { get; set; }
        public string languageresume { get; set; }
    }
    public class EducationResumeRequest
    {
        public string languageresume { get; set; }
        public int edu_id { get; set; }
        public string type { get; set; }
    }
    public class ExperienceResumeRequest
    {
        public int experience_id { get; set; }
        public string languageresume { get; set; }
    }
    public class ContactResumeRequest
    {
        public string languageresume { get; set; }
    }
    public class AddressResumeRequest
    {
        public string languageresume { get; set; }
    }
    public class CertificateResumeRequest
    {
        public int certificate_id { get; set; }
        public string languageresume { get; set; }
    }
    public class SkillResumeRequest
    {
        public int skill_id { get; set; }
        public string languageresume { get; set; }
    }
    public class SkillLanguageResumeRequest
    {
        public int skillanguage_id { get; set; }
        public string languageresume { get; set; }
    }

    public class EditUserInfoResumeRequest
    {

        public string prefixid { get; set; }
        public string name_th { get; set; }
        public string lastname_th { get; set; }
        public string name_en { get; set; }
        public string lastname_en { get; set; }
    }

    public class EditAboutMeResumeRequest
    {

        public string detailsth { get; set; }

        public string detailsen { get; set; }
    }
    public class EditPositionResumeRequest
    {

        public bool edit { get; set; }
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string position_th { get; set; }
        public string position_en { get; set; }
        public string office_th { get; set; }
        public string office_en { get; set; }
        public string detail_th { get; set; }
        public string detail_en { get; set; }
    }
    public class EditEducationResumeRequest
    {
        public bool edit { get; set; }
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string type { get; set; }
        public string placeofstudy_th { get; set; }
        public string placeofstudy_en { get; set; }
        public string detail_th { get; set; }
        public string detail_en { get; set; }
    } public class EditExperienceResumeRequest
    {
        public bool edit { get; set; }
        public int id { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string position_th { get; set; }
        public string position_en { get; set; }
        public string detail_th { get; set; }
        public string detail_en { get; set; }
        public int orderchoose { get; set; }
    }
    public class EditContactResumeRequest
    {
        public string email { get; set; }
        public string phone { get; set; }
        public string facebook { get; set; }
        public string line { get; set; }
        public string instagram { get; set; }
        public string twitter { get; set; }
        public string youtube { get; set; }
    }
    public class EditAddressResumeRequest
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
        public string zipcode { get; set; }
        //public bool onselected_number { get; set; }
        //public bool onselected_moo { get; set; }
        //public bool onselected_soi { get; set; }
        //public bool onselected_road { get; set; }
        //public bool onselected_subdistrict { get; set; }
        //public bool onselected_district { get; set; }
        //public bool onselected_province { get; set; }
        //public bool onselected_zipcode { get; set; }
    }
    public class EditCertificateResumeRequest
    {
        public bool edit { get; set; }
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string title_th { get; set; }
        public string title_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
    }
    public class EditSkillResumeRequest
    {
        public bool edit { get; set; }
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string value { get; set; }
        public string skill_th { get; set; }
        public string skill_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
    }
    public class EditSkillLanguageResumeRequest
    {
        public bool edit { get; set; }
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string value { get; set; }
        public string language_th { get; set; }
        public string language_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
    }
    public class GeneratepdfRequest 
    {
        public string userid { get; set; }
    } public class GenerateResumePDFRequest
    {
        
    }
    public class AddressProvinceByTResumeRequest
    {
        public string languageresume { get; set; }
    }
    public class AddressDistrictByTResumeRequest
    {
        public string languageresume { get; set; }
        public string province_id { get; set; }
    }
    public class AddressTambonByTResumeRequest
    {
        public string languageresume { get; set; }
        public string district_id { get; set; }
    }
    
    public class AddressZipCodeResumeRequest
    {
        public string languageresume { get; set; }
        public string sub_district_id { get; set; }
    }



    public class SetOnSelectResumeRequest
    {


        public SetOnSelectResumeRequestData data_on_select { get; set; }

    }
    public class SetOnSelectResumeRequestData
    {
        public List<SetOnSelectResume> position_on_select { get; set; }
        public List<SetOnSelectResume> experience_on_select { get; set; }
        public SetOnSelectEducationResumeRequestList education_on_select { get; set; }
        public List<SetOnSelectResume> skill_on_select { get; set; }
        public List<SetOnSelectResume> certificate_on_select { get; set; }
        public List<SetOnSelectResume> language_on_select { get; set; }
        public SetOnSelectSocialResume social_on_select { get; set; }
        public SetOnSelectAddressResume address_on_select { get; set; }
    }
 
    public class SetOnSelectResume
    {
        public int id { get; set; }
        public bool onselect { get; set; }

    }
    public class SetOnSelectSocialResume
    {
        public bool onselected_email { get; set; }
        public bool onselected_phone { get; set; }
        public bool onselected_facebook { get; set; }
        public bool onselected_line { get; set; }
        public bool onselected_instagram { get; set; }
        public bool onselected_twitter { get; set; }
        public bool onselected_youtube { get; set; }

    }
    public class SetOnSelectAddressResume
    {

        public bool onselected_number { get; set; }
        public bool onselected_moo { get; set; }
        public bool onselected_soi { get; set; }
        public bool onselected_road { get; set; }
        public bool onselected_subdistrict { get; set; }
        public bool onselected_district { get; set; }
        public bool onselected_province { get; set; }
        public bool onselected_zipcode { get; set; }

    }
    public class SetOnSelectEducationResumeRequestList
    {
        public List<SetOnSelectResume> hsc_on_select { get; set; }
        public List<SetOnSelectResume> bd_on_select { get; set; }
        public List<SetOnSelectResume> md_on_select { get; set; }
        public List<SetOnSelectResume> dd_on_select { get; set; }
        public List<SetOnSelectResume> hdd_on_select { get; set; }
    }

    public class ColorResumeRequest
    {
        //    public ColorResumeComponentRequest text { get; set; }
        //    public ColorResumeComponentRequest name { get; set; }
        //    public ColorResumeComponentRequest theme { get; set; }
        //    public ColorResumeComponentRequest aboutMe { get; set; }
        //    public ColorResumeComponentRequest position { get; set; }
        //    public ColorResumeComponentRequest education { get; set; }
        //    public ColorResumeComponentRequest contact { get; set; }
        //    public ColorResumeComponentRequest address { get; set; }
        //    public ColorResumeComponentRequest experience { get; set; }
        //    public ColorResumeComponentRequest certificate { get; set; }
        //    public ColorResumeComponentRequest skill { get; set; }
        //    public ColorResumeComponentRequest language { get; set; }
        public List<ColorResumeComponentRequest> color { get; set; }

}
    public class ColorResumeComponentRequest
    {
        public int id { get; set; }
        public string nameColor { get; set; }
        public string parameter { get; set; }
    }
}
