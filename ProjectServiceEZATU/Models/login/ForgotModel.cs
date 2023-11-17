using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace ProjectServiceEZATU.Models
{
    public class ForgotModel
    {
        public string titleforgot { get; set; }
        public string edtIDforgot { get; set; }
        public string edtemailforgot { get; set; }
        public string btnforgotnext { get; set; }
        public string titlesetnewpass { get; set; }
        public string textotpwillsent { get; set; }
        public string edtpass { get; set; }
        public string edtcpass { get; set; }
        public string otp { get; set; }
        public string texpleaseconfirm { get; set; }
        public string btnsentotpagain { get; set; }
        public string btnconfirm { get; set; }
        public string textref { get; set; }
        public string resetpasswordcontent { get; set; }
        public string min { get; set; }
        public string resendverification { get; set; }
        public string enteryourpin { get; set; }
        public string findemail { get; set; }
        public string checkmail { get; set; }
        public string textPassNote { get; set; }
        public string btnsubmit { get; set; }

    }
}
