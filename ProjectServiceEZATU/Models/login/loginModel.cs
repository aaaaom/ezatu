using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProjectServiceEZATU.Database;

namespace ProjectServiceEZATU.Models
{
    public class LoginModel
    {
        public ErrorButton errorbutton { get; set; }

        //public string Parameter { get; set; }
        public string btnChangeLang { get; set; }
     
        public string edtID { get; set; }
        public string edtPass { get; set; }
        public string btnLogin { get; set; }
        public string btnForgotPass { get; set; }
        public string btnReg { get; set; }
        public string textReg { get; set; }
        public string textWelcome { get; set; }
        public string texLoginAccount { get; set; }
        public string texRememberMe { get; set; }
        public string texLanguage { get; set; }
        internal string texLanguageEnglish { get; set; }
        internal string texLanguageThai { get; set; }
        public string imgLogo { get; set; }
        public string imgSubLogo { get; set; }


        /// <summary>
        /// 
        /// </summary>
        //public string Screen { get; set; }
        //public string paremeter { get; set; }
        //public string en_EN { get; set; }
        //public string th_TH { get; set; }
    }
    public class LoginsubmitModel 
    {
        internal string message;
        internal int status;
        internal string passnot;
        internal string usernotregis;
        internal string userorpass;

        public string token { get; set; }
        public string language { get; set; }
        public string refreshtoken { get; set; }
        public string role { get; set; }
        public DateTime expires { get; set; }
    } 
    public class SendOTPForgotPasswordResponse
    {
        public string refvalue { get; set; }
        public int time { get; set; }

        internal int status;
        internal string message;
        internal string language;
        internal string fillempty;
        internal string userandemailnotregis;
        internal string findemail;
        internal string enteremail;
        internal string enteruser;
        internal string failuser;
        internal string erroroccurred;
        internal string typeemail;
    } 
    public class SubmitOTPForgotPasswordResponse
    {
        
        internal int status;
        internal string message;
        internal string fillempty;
        internal string language;
        internal string erroroccurred;
        internal string trypassword;
        internal string errorspecial;
        internal string leastnum;
        internal string lowercase;
        internal string uppercase;
        internal string alertlengthpassword;
        internal string format;
        internal string invalidotp;
        internal string expotp;
        internal string failed;
        internal string passwordconfirmempty;
        internal string passwordempty;
        internal string otpempty;
    }
    public class RegisterSubmitOTPResponse
    {
        
        internal int status;
        internal string message;
        internal string erroroccurred;
        internal string fillempty;
        internal string alertlengthpassword;
        internal string consub;
        internal string expotp;
        internal string invalidotp;
        internal string fail;
    }
    public class RegistersubmitResponse
    {
        public string refvalue { get; set; }
        public int time { get; set; }
        internal int status;
        internal string message;
        internal string fillempty;
        internal string phone;
        internal string lengthphone;
        internal string typeemail;
        internal string passwordsconfirmation;
        internal string errorspecial;
        internal string leastnum;
        internal string lowercase;
        internal string uppercase;
        internal string alertlengthpassword;
        internal string format;
        internal string phonesub;
        internal string emailsub;
        internal string useridsub;
        internal string notuser;
        internal string consub;
        internal string passsub;
        internal string numsub;
        internal string emailsubs;
        internal string lastsub;
        internal string namesub;
        internal string usersub;
        internal string fail;
    }
   
    public class Regishttpcode
    {
        internal int status;
        internal string message;
    }
    public class RegisCk
    {
        internal int id;
        internal string userid;
        internal string password;
        internal string name;
        internal string lastname;
    }
    public class ISupport
    {
        internal string name;
        internal string email;
        internal string phone;
    }
    public class otptemporaryModel
    {
        public int id { get; set; }
        public string userid { get; set; }
        public string email { get; set; }
        public string valueref { get; set; }
        public string otp { get; set; }
        public string createAt { get; set; }
        public string timeout { get; set; }
        public string branchid { get; set; }
        public string departmentid { get; set; }
        public string facultyid { get; set; }
        public string role { get; set; }
        public string nickname { get; set; }
        public string gen { get; set; }
        public string phone { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
    }
    public class LogSessionsRespond
    {
        internal int status;
        internal string message;
        public int id { get; set; }
        public string sessions { get; set; }
        internal string date { get; set; }
    }
}

