using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace ProjectServiceEZATU.Models
{
    public class RegisterModel
    {
        public string titlereg { get; set; }
        public string edtIDreg { get; set; }
        public string edtphonereg { get; set; }
        public string edtemailreg { get; set; }
        public string edtnamereg { get; set; }
        public string edtlnamereg { get; set; }
        public string edtpassreg { get; set; }
        public string edtcpassreg { get; set; }
        public string titleconregis { get; set; }
        public string textotpwillsent { get; set; }
        public string textpleaseconfirm { get; set; }
        public string textsentotpagain { get; set; }
        public string edtotp { get; set; }
        public string edtsignup { get; set; }
        public string btnconfirm { get; set; }
        public string textref { get; set; }
        public string registerpagecontent { get; set; }
        public string label_you_faculty_code { get; set;}
        public string label_you_depar_code { get; set;}

        public string min { get; set; }
        public string resendverification { get; set; }
        public string enteryourpin { get; set; }
        public string findemail { get; set; }
        public string checkmail { get; set; }
        public string btnNext { get; set; }
        public string textPassNote { get; set; }

    }
}
