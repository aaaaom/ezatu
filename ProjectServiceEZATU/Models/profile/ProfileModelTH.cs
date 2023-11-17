using ProjectServiceEZATU.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ProjectServiceEZATU.Models.profile
{
    public class ProfileModelTH
    {
        public ScreenProfileModelTH screeninfo { get; set; }
        public generalTHResponse profile_generalTH { get; set; }
        public academicTH profile_academicTH { get; set; }
        public contactTH profile_contactTH { get; set; }
        public ProfilePositionTC profilePositionTC_List { get; set; }
    }
    public class ProfilePositionTC
    {
        public List<PositionTC> position { get; set; }
    }
    public class PositionTC
    {
        public string positionvalue { get; set; }
        public string positionname { get; set; }
    }
    public class AllprofileTH
    {
        public ProfileacademicTH profile_academicTH { get; set; }
        public generalTH profile_generalTH { get; set; }
    }
    public class ScreenProfileModelTH
    {
        public String titleprofile { get; set; }
        public String subtitlegeninfo { get; set; }
        public String subtitlecont { get; set; }
        public String subtitleeduinfo { get; set; }
        public String textedit { get; set; }
        public String textsave { get; set; }
        public String textname { get; set; }
        public String textlname { get; set; }
        public String textnickname { get; set; }
        public String textacaposit { get; set; }
        public String textgdegree { get; set; }
        public String textmdegree { get; set; }
        public String textphd { get; set; }
        public String textunivdg { get; set; }
        public String textunivmdg { get; set; }
        public String textunivphd { get; set; }
        public String textreserch { get; set; }
        public String texttel { get; set; }
        public String textemail { get; set; }
        public String textworkshop { get; set; }



    }
    public class generalTH
    {
        public String name { get; set; }
        public String lastname { get; set; }
        public String nickname { get; set; }
        public String role { get; set; }
        public String position { get; set; }
        public String langeuage { get; set; }
        public String rolename { get; set; }
        public String email { get; set; }
        public String teacherid { get; set; }
        public String userlanguage { get; set; }
        public String roleTH { get; set; }
        public String roleEN { get; set; }
        public String userposition { get; set; }
        public String departmentnameth { get; set; }
        public String departmentnameen { get; set; }
        public String facultynameth { get; set; }
        public String facultynameen { get; set; }
        public String positionth { get; set; }
        public String positionen { get; set; }

    }
    public class generalTHResponse
    {
        public String name { get; set; }
        public String lastname { get; set; }
        public String nickname { get; set; }
        public String role { get; set; }
        //public List<PositionTC> position { get; set; }
        public String position { get; set; }
        public String language { get; set; }
        public String rolename { get; set; }
        public String email { get; set; }
        public String teacherid { get; set; }
        public String departmentname { get; set; }
        public String facultyname { get; set; }
        public String img { get; set; }
        public string positionvalue { get; set; }

    }
    public class generalProfileInfoModelImgeEmailTH
    {

        public String img { get; set; }

        public String email { get; set; }
    }
    public class academicTH
    {
        public String graduatedegree { get; set; }
        public String masterdegree { get; set; }
        public String phd { get; set; }
        public String reshercharea { get; set; }
        public String univofgraduatedegree { get; set; }
        public String univofmasterdegree { get; set; }
        public String univofphd { get; set; }

    }
    public class ProfileacademicTH
    {
        public String graduatedegree { get; set; }
        public String masterdegree { get; set; }
        public String phd { get; set; }
        public String reshercharea { get; set; }
        public String univofgraduatedegree { get; set; }
        public String univofmasterdegree { get; set; }
        public String univofphd { get; set; }
        public String userlanguage { get; set; }


    }
    public class contactTH
    {
        public String phone { get; set; }
        public String email { get; set; }
        public String workshop { get; set; }
    }
    public class PositionProfileTCModel
    {
        public String value { get; set; }
        public String positionname { get; set; }
        public String TH { get; set; }
        public String EN { get; set; }
        public String userlanguage { get; set; }
    }
    public class ScreenDbContextDataTH
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
    public class profileDbContext : DbContext
    {
        public profileDbContext(DbContextOptions<profileDbContext> options) : base(options)
        {

        }
        public ScreenDbContextDataTH LabelScreen { get; set; }
        public UserDbContextData user { get; set; }

    }

    public class generalProfileInfoModel
    {
        public String name { get; set; }
        public String lastname { get; set; }
        public String nickname { get; set; }
        public String position { get; set; }
        public String enposition { get; set; }
        public String studentid { get; set; }
        public String userlanguage { get; set; }
        public String roleTH { get; set; }
        public String roleEN { get; set; }
        public String role { get; set; }
    }

    public class GeneralProfileTHSubmitModel
    {
        internal int status;
        internal string message;
        internal string letteronly;
        public ProfilePositionTC profilePositionTC_List { get; set; }
        public ProfilePositionResponse profilePositionResponse { get; set; }
        public generalTHResponse profile_generalTH { get; set; }

    }
}

public class AcademicProfileTHSubmitModel
{
    internal int status;
    internal string message;
}
public class ContactProfileTHSubmitModel
{
    internal int status;
    internal string message;
    internal string errorphone;
    internal string erroremail;
}
//public class PositionTC
//{ 
//    public string positionvalue { get; set; }
//    public string positionname { get; set; }
//}
public class ProfilePositionResponse
{
    public string userposition { get; set; }
    public string positionvalue { get; set; }
    public string userlanguage { get; set; }
    public string positionen { get; set; }
    public string positionth { get; set; }
}
//public class ProfilePositionTC
//{ 
//    public List<PositionTC> position { get; set; }
//}
public class PositionProfileTCModel
{
    public String value { get; set; }
    public String positionname { get; set; }
    public String TH { get; set; }
    public String EN { get; set; }
    public String userlanguage { get; set; }
}


