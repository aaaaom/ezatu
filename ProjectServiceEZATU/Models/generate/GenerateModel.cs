namespace ProjectServiceEZATU.Models.generate
{
    public class GenerateModels
    {
        public string aboutme { get; set; }
        public string image { get; set; }
        public string adddress { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string skill { get; set; }
        public string skill2 { get; set; }
        public string skill3 { get; set; }
        public string number { get; set; }
        public string moo { get; set; }
        public string soi { get; set; }
        public string road { get; set; }
        public string subdistrict { get; set; }
        public string district { get; set; }
        public string province { get; set; }
        public string zipcode { get; set; }
        public string email { get; set; }
        public string facebook { get; set; }
        public string instagram { get; set; }
        public string phone { get; set; }
        public string positionoffice { get; set; }
        public string positionoffice2 { get; set; }
        public string positionoffice3 { get; set; }
        public string office { get; set; }
        public string office2 { get; set; }
        public string office3 { get; set; }
        public string detailoffice { get; set; }
        public string detailoffice2 { get; set; }
        public string detailoffice3 { get; set; }
        public string startdateoffice { get; set; }
        public string enddateoffice { get; set; }
        public string startdateoffice2 { get; set; }
        public string enddateoffice2 { get; set; }
        public string startdateoffice3 { get; set; }
        public string enddateoffice3 { get; set; }
        public string experienceoffice { get; set; }
        public string education { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string placeofstudy { get; set; }
        public string bd { get; set; }
        public string md { get; set; }
        public string dd { get; set; }
        public string hsc { get; set; }
        public string startdatelearn { get; set; }
        public string enddatelearn { get; set;}
        public string detaillearn { get; set;}
        public string skillvalue { get; set;}
        public string skilldetail { get; set;}
        public string skillvalue2 { get; set; }
        public string skilldetail2 { get; set; }
        public string skillvalue3 { get; set; }
        public string skilldetail3 { get; set; }

        public string positionexperience { get; set; }
        public string positionexperience2 { get; set; }
        public string positionexperience3 { get; set; }
        public string experiencedetail { get; set; }
        public string experiencedetail2 { get; set; }
        public string experiencedetail3 { get; set; }
        public string educationhscend { get; set;}
        public string educationhscstart { get; set;}
        public string educationhsctype { get; set;}
        public string educationhscplace { get; set; }
        public string educationhscdetail { get; set; }
        public string educationbdend { get; set; }
        public string educationbdstart { get; set; }
        public string educationbdtype { get; set; }
        public string educationbdplace { get; set; }
        public string educationbddetail { get; set; }
        public string educationmdend { get; set; }
        public string educationmdstart { get; set; }
        public string educationmdtype { get; set; }
        public string educationmdplace { get; set; }
        public string educationmddetail { get; set; }
        public string educationddend { get; set; }
        public string educationddstart { get; set; }
        public string educationddtype { get; set; }
        public string educationddplace { get; set; }
        public string educationdddetail { get; set; }
        public string educationhddend { get; set; }
        public string educationhddstart { get; set; }
        public string educationhddtype { get; set; }
        public string educationhddplace { get; set; }
        public string educationhdddetail { get; set; }
        public string language { get; set; }
        public string languagedetail { get; set; }
        public string languagevalue { get; set; }
        public string language2 { get; set; }
        public string languagedetail2 { get; set; }
        public string languagevalue2 { get; set; }
        public string language3 { get; set; }
        public string languagedetail3 { get; set; }
        public string languagevalue3 { get; set; }
        public string textabout{ get; set;}
        public string texteducation { get; set;}
        public string textexperience { get; set; }
        public string textname { get; set;}
        public string textskill{ get; set;}
        public string textcontact { get; set;}
        public string textaddress { get; set;}
        public string textlanguage { get; set;}
        public string texthsc { get; set; }
        public string textbd { get; set; }
        public string textmd { get; set; }
        public string textdd { get; set; }
        public string texthdd { get; set; }
        public string textatten { get; set; }
        public string textmoo { get; set; }
        public string textsoi{ get; set; }
        public string textroad { get; set; }
        public string textpro { get; set; }
        public string textsub { get; set; }
        public string textdis { get; set; }
        public string textzip { get; set; }
        public string texthouse { get; set; }
    }
    public class aboutmeDBContextData
    {
        public string userid { get; set; }

        public string details { get; set; }
        public string image { get; set; }
    }
    public class GenRespone 
    {
        public string aboutme { get; set; }
        public string image { get; set; }
        public string adddress { get; set; }
        public string name { get; set;}
        public string lastname { get; set;}
        public string skill { get; set; }
        public string moo { get; set; }
        public string soi { get; set; }
        public string road { get; set; }
        public string subdistrict { get; set; }
        public string district { get; set; }
        public string province { get; set; }
        public string zipcode { get; set; }
        public string email { get; set; }
        public string facebook { get; set; }
        public string instagram { get; set; }
        public string phone { get; set; }
        public string position { get; set; }
        public string office { get; set; }
        public string detail { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string experience { get; set; }
        public string education { get; set; }
        public string title { get; set; }
        public string description { get; set; }

    }
    public class EducationGenPDFResumeModels
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
    public class ExperienceGenPDFResumeModels
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
    public class SkillGenPDFResumeModels
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
    public class CertificateGenPDFResumeModels
    {
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string title_th { get; set; }
        public string title_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
        public string onselected { get; set; }
    }
    public class PersonInfoGenPDFResumeModels
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
    public class UserInfoGenPDFResumeModels
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

    public class UserInfoPrefixModels
    {
        public string specifically { get; set; }
        public string th { get; set; }
        public string en { get; set; }


    }

    public class PositionGenPDFResumeModels
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
    public class ImageGenPDFResumeModels
    {
        public string image { get; set; }
    }
    public class ResumeColorGenPDFResumeModels
    {
        public string option { get; set; }
    }
    public class AboutMeGenPDFResumeModels
    {
        public string details { get; set; }
        public string DETAILSEN { get; set; }

    }
    public class AddressResumeModels
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
    public class LanguageGenPDFResumeModels
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
    public class ImageUploadResumeModels

    {
        internal int status;
        internal string message;
        internal string image;
        internal string userid;

    }
    public class QueryUserInfoResumeModels
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
    public class QueryAboutMeResumeModels
    {

        internal string userid;
        public string details { get; set; }
        public string DETAILSEN { get; set; }

    }
    public class QueryPositionResumeModels
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
    public class QueryEducationResumeModels
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
    public class QueryEducationTypeResumeModels
    {

        public int id { get; set; }
        public string typeid { get; set; }
        public string th { get; set; }
        public string en { get; set; }

    }

    public class QueryContactResumeModels
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
    public class QueryAddressResumeModels
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
    public class QueryCertificateResumeModels
    {
        internal string userid;
        public int id { get; set; }
        public int orderchoose { get; set; }
        public string title_th { get; set; }
        public string title_en { get; set; }
        public string description_th { get; set; }
        public string description_en { get; set; }
        public string onselected { get; set; }


    }
    public class QueryExperienceResumeModels
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
    public class QuerySkillResumeModels
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

    public class QuerySkillLanguageResumeModels
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

    public class QueryEditUserInfoResumeModels
    {

        internal string userid;

    }
    public class QueryEditAboutMeResumeModels
    {

        internal string userid;

    }
    public class QueryEditPositionResumeModels
    {

        internal string userid;

    }
    public class QueryEditEducationResumeModels
    {

        internal string userid;

    }
    public class QueryEditExperienceResumeModels
    {

        internal string userid;

    }

    public class QueryEditContactResumeModels
    {

        internal string userid;

    }
    public class QueryEditAddressResumeModels
    {

        internal string userid;

    }
    public class QueryEditCertificateResumeModels
    {

        internal string userid;

    }
    public class QueryEditSkillResumeModels
    {

        internal string userid;

    }

    public class QueryEditSkillLanguageResumeModels
    {

        internal string userid;

    }
    public class AddressByTModels
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
    public class ColorResumeModels

    {
        internal int status;
        internal string message;
        internal string image;
        internal string userid;
        internal string parameter;
        internal string colorid;

    }

}
