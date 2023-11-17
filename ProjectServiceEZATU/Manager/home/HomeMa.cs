using Dapper;
using Dapper.Contrib.Extensions;
using ProjectServiceEZATU.Database;
using ProjectServiceEZATU.DTO.Request.activity;
using ProjectServiceEZATU.DTO.Request.home;
using ProjectServiceEZATU.DTO.Response.more;
using ProjectServiceEZATU.Models.home;
using ProjectServiceEZATU.Service.Interface.home;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebApplication.JwtHelpers;
using WebApplication.Models;
using ProjectServiceEZATU.DTO.Response.home;
using System.Globalization;
using ProjectServiceEZATU.Models;
using ProjectServiceEZATU.Database.ConstantFixedDB;
using SendGrid.Helpers.Mail;
using SendGrid;
using System.Text;
using System.Threading;
using ProjectServiceEZATU.Jwt.JWTManager;
using ProjectServiceEZATU.Models.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.CodeAnalysis.Emit;
using static Org.BouncyCastle.Math.EC.ECCurve;
using ProjectServiceEZATU.DTO.Request.login;

namespace ProjectServiceEZATU.Manager.home
{
    public class HomeMa : IHome
    {
        private readonly ILogger<HomeMa> _logger;
        private readonly DapperContext _context;
        private readonly JwtSettings jwtSettings;
        private readonly ChangePasswordResponse status;
        public static string DateTimeFormat_dd_MM_yyyy = ConstantFixedDB.DateTimeFormat_dd_MM_yyyy;
        public static string DateTimeFormatHH_mm_ss_dd_MM_yyyy = ConstantFixedDB.DateTimeFormatHH_mm_ss_dd_MM_yyyy;
        public HomeMa(ILogger<HomeMa> logger, DapperContext context, JwtSettings jwtSettings)
        {
            _logger = logger;
            _context = context;
            this.jwtSettings = jwtSettings;
        }

        public async Task<MoreContactUsResponse> MoreContactUs(MoreContactUsRequest moreContactUsRequest, string id)
        {
            MoreContactUsResponse moreContactUsResponse = new MoreContactUsResponse()
            {
                screeninfo = new BoardContactUsScreenInfoResponse(),
                datamain = new BoardContactUsMainResponse(),
                data = new BoardContactUsResponse(),
            };
            try
            {

                var query = "select a.*, b.userlanguage from LabelScreen a , language b where Screen =  @Screen  and userid = @userid ";
                //var query = "select * from LabelScreen where Screen = @Screen ";
                using (var connection = _context.GetDbconnection())
                {
                    connection.Open();
                    var moreScreenn = (await connection.QueryAsync<ScreenDbContextData>(query, new { Screen = "contactuspage", userid = id })).ToList();
                    foreach (var moreScreenData in moreScreenn)
                    {
                        switch (moreScreenData.parameter.ToLower().Trim())
                        {
                            case "titlecontactus":
                                moreContactUsResponse.screeninfo.titlecontactus = moreScreenData.userlanguage == "EN" ? moreScreenData.EN : moreScreenData.TH;
                                break;
                            case "subtitlecontactus":
                                moreContactUsResponse.screeninfo.subtitlecontactus = moreScreenData.userlanguage == "EN" ? moreScreenData.EN : moreScreenData.TH;
                                break;
                            case "texttel":
                                moreContactUsResponse.screeninfo.texttel = moreScreenData.userlanguage == "EN" ? moreScreenData.EN : moreScreenData.TH;
                                break;
                            case "textfax":
                                moreContactUsResponse.screeninfo.textfax = moreScreenData.userlanguage == "EN" ? moreScreenData.EN : moreScreenData.TH;
                                break;
                            case "textemail":
                                moreContactUsResponse.screeninfo.textemail = moreScreenData.userlanguage == "EN" ? moreScreenData.EN : moreScreenData.TH;
                                break;
                            case "textfacebook":
                                moreContactUsResponse.screeninfo.textfacebook = moreScreenData.userlanguage == "EN" ? moreScreenData.EN : moreScreenData.TH;
                                break;

                            case "texttwitter":
                                moreContactUsResponse.screeninfo.texttwitter = moreScreenData.userlanguage == "EN" ? moreScreenData.EN : moreScreenData.TH;
                                break;
                            case "textinstagram":
                                moreContactUsResponse.screeninfo.textinstagram = moreScreenData.userlanguage == "EN" ? moreScreenData.EN : moreScreenData.TH;
                                break;
                            case "textline":
                                moreContactUsResponse.screeninfo.textline = moreScreenData.userlanguage == "EN" ? moreScreenData.EN : moreScreenData.TH;
                                break;
                            case "textunittime":
                                moreContactUsResponse.screeninfo.textunittime = moreScreenData.userlanguage == "EN" ? moreScreenData.EN : moreScreenData.TH;
                                break;

                        }
                    }
                    query = "select a.*, b.userlanguage from contactdb a , language b where  a.departmentid = 'SC03' and a.contactus = 'Y' and b.userid = @userid ";
                    var contactUsMainQueryData = (await connection.QueryAsync<ContactUsModel>(query, new { userid = id })).ToList();

                    foreach (var contactUsMainData in contactUsMainQueryData)
                    {
                        moreContactUsResponse.datamain.contactname = contactUsMainData.userlanguage == "EN" ? contactUsMainData.contactnameen : contactUsMainData.contactnameth;
                        moreContactUsResponse.datamain.phone = contactUsMainData.phone;
                        moreContactUsResponse.datamain.fax = contactUsMainData.fax;
                        moreContactUsResponse.datamain.email = contactUsMainData.email;
                        moreContactUsResponse.datamain.startperiod = contactUsMainData.userlanguage == "EN" ? contactUsMainData.startperioden : contactUsMainData.startperiodth;
                        moreContactUsResponse.datamain.endtperiod = contactUsMainData.userlanguage == "EN" ? contactUsMainData.endperioden : contactUsMainData.endperiodth;
                        moreContactUsResponse.datamain.starttime = contactUsMainData.starttime;
                        moreContactUsResponse.datamain.endtime = contactUsMainData.endtime;
                        moreContactUsResponse.datamain.address = contactUsMainData.userlanguage == "EN" ? contactUsMainData.addressen : contactUsMainData.address;
                        moreContactUsResponse.datamain.line = contactUsMainData.line;
                        moreContactUsResponse.datamain.facebook = contactUsMainData.facebook;
                        moreContactUsResponse.datamain.instagram = contactUsMainData.instagram;
                        moreContactUsResponse.datamain.twitter = contactUsMainData.twitter;
                        moreContactUsResponse.datamain.lineid = contactUsMainData.lineid;


                    }
                    query = "select a.*, b.userlanguage from contactdb a , language b where  a.departmentid = 'MA01' and a.contactus = 'Y' and b.userid = @userid ";
                    var contactUsQueryData = (await connection.QueryAsync<ContactUsModel>(query, new { userid = id })).ToList();

                    foreach (var contactUsData in contactUsQueryData)
                    {
                        moreContactUsResponse.data.contactname = contactUsData.userlanguage == "EN" ? contactUsData.contactnameen : contactUsData.contactnameth;
                        moreContactUsResponse.data.phone = contactUsData.phone;
                        moreContactUsResponse.data.fax = contactUsData.fax;
                        moreContactUsResponse.data.email = contactUsData.email;
                        moreContactUsResponse.data.startperiod = contactUsData.userlanguage == "EN" ? contactUsData.startperioden : contactUsData.startperiodth;
                        moreContactUsResponse.data.endtperiod = contactUsData.userlanguage == "EN" ? contactUsData.endperioden : contactUsData.endperiodth;
                        moreContactUsResponse.data.starttime = contactUsData.starttime;
                        moreContactUsResponse.data.endtime = contactUsData.endtime;
                        moreContactUsResponse.data.address = contactUsData.userlanguage == "EN" ? contactUsData.addressen : contactUsData.address;
                        moreContactUsResponse.data.line = contactUsData.line;
                        moreContactUsResponse.data.facebook = contactUsData.facebook;
                        moreContactUsResponse.data.instagram = contactUsData.instagram;
                        moreContactUsResponse.data.twitter = contactUsData.twitter;
                        moreContactUsResponse.data.lineid = contactUsData.lineid;


                    }

                }
                moreContactUsResponse.status = 200;
                moreContactUsResponse.message = "success";
            }
            catch (Exception ex)
            {


                moreContactUsResponse.status = 401;
                moreContactUsResponse.message = ex.Message;
            }


            return moreContactUsResponse;
        }
        public async Task<ChangEmail_OTP_OLD_Response> ChangEmail_OTP_OLD(ChangEmail_OTP_OLD_Request changEmail_OTP_OLD_Request, string id) 
        {
            ChangEmail_OTP_OLD_Response changEmail_OTP_OLD_Response = new ChangEmail_OTP_OLD_Response()
            {
            };
            var isUserID = id;
            var isEmail = "";
            var isUserLaguage = "";
            var isPassword = changEmail_OTP_OLD_Request.password;
            byte[] salt = new byte[128 / 8];

            string isPasswordHash = Convert.ToBase64String(inArray: KeyDerivation.Pbkdf2(
                password: isPassword!, prf: KeyDerivationPrf.HMACSHA256, salt: salt, iterationCount: 100000, numBytesRequested: 256 / 8));
            var nameSuppor = "<strong> Support (EZATU)  </ strong > " ;
            var phoneSuppor = "<strong> 0-3810-3011 </ strong> " ;
            var emailSuppor = "<strong> scibuu.pr@gmail.com </ strong >";
            try
            {
                var query = "SELECT a.useremail , a.userid FROM [useraccount] a  WHERE a.userid = @userid  and  a.password = @password COLLATE Thai_CS_AS";


                using (var connection = _context.GetDbconnection())
                {
                    connection.Open();
                    //เช็คว่ารหัสผ่านไม่เป็นค่าว่าง
                    if (isPassword != "")
                    {
                        
                        //เช็คว่า userid password ตรงกัน
                        var checkUserPasswordEmailData = (await connection.QueryAsync<UserAccountModelQuery>(query, new { userid = isUserID, password = isPasswordHash })).FirstOrDefault();
                        if (checkUserPasswordEmailData != null) {
                            if (checkUserPasswordEmailData.useremail != null || checkUserPasswordEmailData.useremail.Trim() != "")
                            {
                                query = "SELECT role FROM membersuserdb WHERE userid = @userid";
                                var CheckEmailTeacher = await connection.QueryFirstOrDefaultAsync<string>(query, new { userid = isUserID});
                                if (CheckEmailTeacher == "ST") //เช็คว่าเป็น email อาจารย์ไหม 
                                {
                                    isEmail = checkUserPasswordEmailData.useremail;
                                    isUserID = id;
                                    int useryear = int.Parse(isUserID.Substring(0, 2));//ปีของผู้ใช้งาน
                                    string yearString = (DateTime.Now.Year + 543).ToString().Substring(2);
                                    int currentyear = int.Parse(yearString);
                                    var checkuniversityemail = Regex.IsMatch(isEmail, @"^\d{8}@go.buu.ac.th$");
                                    if ((checkuniversityemail != null) && (currentyear - useryear >= 4))
                                    {
                                        changEmail_OTP_OLD_Response.alumni_expire = true;

                                        var userEmail = isEmail;
                                        var query2 = "SELECT COUNT(*) FROM [expireemail] WHERE useremail = @useremail";
                                        var result = await connection.QuerySingleAsync<int>(query2, new { useremail = userEmail });
                                        if (result < 1)
                                        {

                                            //isUserID = id;
                                            //insertเข้าไปแล้ว userid null
                                            var tran = connection.BeginTransaction();
                                            var expemailinsert = new expireEmailModel()
                                            {

                                                userid = isUserID,
                                                useremail = isEmail,

                                            };

                                            await connection.InsertAsync(expemailinsert, tran);
                                            tran.Commit();


                                            changEmail_OTP_OLD_Response.useremail = isEmail;
                                            changEmail_OTP_OLD_Response.status = 200;
                                            changEmail_OTP_OLD_Response.message = "expemail";
                                        }
                                        else
                                        {
                                            //changEmail_OTP_OLD_Response.refvalue = RefString.ToString();
                                            changEmail_OTP_OLD_Response.useremail = isEmail;
                                            changEmail_OTP_OLD_Response.status = 200;
                                            changEmail_OTP_OLD_Response.message = "expemail";
                                        }

                                    }

                                    else
                                    {
                                        isEmail = checkUserPasswordEmailData.useremail;
                                        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++copy มา++++++++++++++++++++
                                        query = "DELETE FROM [otptemporary] WHERE userid = @userid  COLLATE Thai_CS_AS ";
                                        var checkDeleteOTPData = (await connection.QueryAsync<ISupport>(query, new { userid = isUserID })).FirstOrDefault();
                                        query = "SELECT a.* FROM [isupport] a ";
                                        var checkUserISupportData = (await connection.QueryAsync<ISupport>(query)).ToList();
                                        foreach (var _checkUserISupportData in checkUserISupportData)
                                        {
                                            nameSuppor = _checkUserISupportData.name == null ? "<strong> Support (EZATU)  </ strong > " : _checkUserISupportData.name;
                                            phoneSuppor = _checkUserISupportData.phone == null ? "<strong> 0-3810-3011 </ strong> " : _checkUserISupportData.phone;
                                            emailSuppor = _checkUserISupportData.email == null ? "<strong> scibuu.pr@gmail.com </ strong >" : _checkUserISupportData.email;
                                        }
                                        const string randomtextRefString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                                        int lengthString = 8;
                                        var RefString = new StringBuilder();
                                        Random RNGString = new Random();
                                        for (var i = 0; i < lengthString; i++)
                                        {
                                            var textRefString = randomtextRefString[RNGString.Next(0, randomtextRefString.Length)];
                                            RefString.Append(textRefString);
                                        }


                                        const string randomtextRefNum = "0123456789";
                                        int lengthNum = 6;
                                        var Refnum = new StringBuilder();
                                        Random RNGNum = new Random();
                                        for (var i = 0; i < lengthNum; i++)
                                        {
                                            var textRefnum = randomtextRefNum[RNGNum.Next(0, randomtextRefNum.Length)];
                                            Refnum.Append(textRefnum);

                                        }

                                        var tran = connection.BeginTransaction();
                                        var emailValue = isEmail;
                                        var emailNameValue = isUserID;





                                        query = "select a.[option] from [tasksoption] a where a.[tasks]  = 'timeotpforgotpassword' ";
                                        var otpTime = (await connection.QueryAsync<TasksOntionDbContextData>(query, new { userid = isUserID }, transaction: tran)).FirstOrDefault();
                                        if (otpTime != null)
                                        {

                                            changEmail_OTP_OLD_Response.time = int.Parse(otpTime.option);

                                        }
                                        else
                                        {
                                            changEmail_OTP_OLD_Response.time = 4;
                                        }

                                        var timeotp = changEmail_OTP_OLD_Response.time;
                                        Execute(RefString, Refnum, emailValue, emailNameValue, nameSuppor, phoneSuppor, emailSuppor, timeotp, isUserLaguage).Wait();
                                        static async Task Execute(StringBuilder refString, StringBuilder refnum, string emaiValue, string emailNameValue, string nameSuppor, string phoneSuppor, string emailSuppor, int timeotp, string isUserLaguage)
                                        {

                                            var apiKey = "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";
                                            var client = new SendGridClient(apiKey);
                                            var from = new EmailAddress("ezautest@gmail.com", "Support Nisit Information Management System (EZATU) Applications ");
                                            var to = new EmailAddress(emaiValue, emailNameValue);
                                            var plainTextContent = "Confirm change password";
                                            if (isUserLaguage == "TH")
                                            {
                                                var subject = "ยืนยันการเปลี่ยนอีเมล ";
                                                var htmlContent = "<strong>การยืนยันตนโปรดระมัดระวังมิจฉาชีพ กรุณาอย่านำรหัสยืนยันตนให้บุคคลอื่น</strong> "
                                                    + "<strong><br> <br> รหัส OTP Code :</strong> " + refnum.ToString() + "<strong> </ strong > " +
                                                    "<strong> <br> <br>Reference code(รหัสอ้างอิง): </ strong >" + refString.ToString() + "<strong>  </ strong > " +
                                                     "<strong><br>  <br>หมดเวลา: </strong>" + DateTime.Now.AddMinutes(timeotp).ToString(DateTimeFormatHH_mm_ss_dd_MM_yyyy) +
                                                    " <strong> <br><br> <br>  </strong>" + nameSuppor + "<strong>  </ strong > " +
                                                   " <strong>  <br> <br>ติดต่อเรา </strong>" +
                                                    " <strong>  <br> โทร  : </strong>" + phoneSuppor + "<strong>  </ strong > " +
                                                   " <strong>  <br> อิเมล :  </strong>" + emailSuppor + "<strong>  </ strong > ";
                                                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                                                var response = await client.SendEmailAsync(msg);
                                            }
                                            else
                                            {
                                                var subject = "Confirm change email ";
                                                var htmlContent = "<strong>Confirmation, please be careful of scammers. Please do not give your verification code to other people.</strong> "
                                                    + "<strong><br> <br>  OTP Code :</strong> " + refnum.ToString() + "<strong> </ strong > " +
                                                    "<strong> <br> <br>Reference code: </ strong >" + refString.ToString() + "<strong>  </ strong > " +
                                                     "<strong><br>  <br>Time Out: </strong>" + DateTime.Now.AddMinutes(timeotp).ToString(DateTimeFormatHH_mm_ss_dd_MM_yyyy) +
                                                    " <strong> <br><br> <br>  </strong>" + nameSuppor + "<strong>  </ strong > " +
                                                   " <strong>  <br> <br>Contact Us </strong>" +
                                                    " <strong>  <br> Phone  : </strong>" + phoneSuppor + "<strong>  </ strong > " +
                                                   " <strong>  <br> E-mail :  </strong>" + emailSuppor + "<strong>  </ strong > ";
                                                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                                                var response = await client.SendEmailAsync(msg);
                                            }
                                        }


                                        string hashedisOTP = Convert.ToBase64String(inArray: KeyDerivation.Pbkdf2(
                                            password: Refnum.ToString()!, prf: KeyDerivationPrf.HMACSHA256, salt: salt, iterationCount: 100000, numBytesRequested: 256 / 8));
                                        var datainsert = new OTPTemporaryDbContextData()
                                        {

                                            userid = isUserID,
                                            email = isEmail,
                                            valueref = RefString.ToString(),
                                            otp = hashedisOTP,
                                            createAt = DateTime.UtcNow.AddHours(7).ToString(DateTimeFormat_dd_MM_yyyy, new CultureInfo("en-US")),
                                            timeout = DateTime.UtcNow.AddHours(7).AddMinutes(timeotp).AddSeconds(60).ToString(DateTimeFormat_dd_MM_yyyy, new CultureInfo("en-US")),

                                        };

                                        await connection.InsertAsync(datainsert, tran);
                                        //query = "select a.* from otptemporary a where a.userid  = @userid  ";
                                        //var otptemporary = (await connection.QueryAsync<Deleteotp>(query, new { userid = isUserID }, transaction: tran)).FirstOrDefault();
                                        //if (otptemporary != null)
                                        //{
                                        //    var deleteOTPTemporarye = new OTPTtemporaryData()
                                        //    {

                                        //        id = otptemporary.id,
                                        //        userid = otptemporary.userid,
                                        //        email = otptemporary.email,
                                        //        valueref = otptemporary.valueref,
                                        //        otp = otptemporary.otp,
                                        //        createAt = otptemporary.timeout,
                                        //        timeout = otptemporary.timeout

                                        //    };


                                        //    await connection.DeleteAsync(deleteOTPTemporarye, tran);
                                        //}
                                        tran.Commit();


                                        changEmail_OTP_OLD_Response.refvalue = RefString.ToString();
                                        changEmail_OTP_OLD_Response.useremail = isEmail;
                                        changEmail_OTP_OLD_Response.status = 200;
                                        changEmail_OTP_OLD_Response.message = "otpsuccess";
                                    }
                                }
                                else
                                {
                                    isEmail = checkUserPasswordEmailData.useremail;
                                    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++copy มา++++++++++++++++++++
                                    query = "DELETE FROM [otptemporary] WHERE userid = @userid  COLLATE Thai_CS_AS ";
                                    var checkDeleteOTPData = (await connection.QueryAsync<ISupport>(query, new { userid = isUserID })).FirstOrDefault();
                                    query = "SELECT a.* FROM [isupport] a ";
                                    var checkUserISupportData = (await connection.QueryAsync<ISupport>(query)).ToList();
                                    foreach (var _checkUserISupportData in checkUserISupportData)
                                    {
                                        nameSuppor = _checkUserISupportData.name == null ? "<strong> Support (EZATU)  </ strong > " : _checkUserISupportData.name;
                                        phoneSuppor = _checkUserISupportData.phone == null ? "<strong> 0-3810-3011 </ strong> " : _checkUserISupportData.phone;
                                        emailSuppor = _checkUserISupportData.email == null ? "<strong> scibuu.pr@gmail.com </ strong >" : _checkUserISupportData.email;
                                    }
                                    const string randomtextRefString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                                    int lengthString = 8;
                                    var RefString = new StringBuilder();
                                    Random RNGString = new Random();
                                    for (var i = 0; i < lengthString; i++)
                                    {
                                        var textRefString = randomtextRefString[RNGString.Next(0, randomtextRefString.Length)];
                                        RefString.Append(textRefString);
                                    }


                                    const string randomtextRefNum = "0123456789";
                                    int lengthNum = 6;
                                    var Refnum = new StringBuilder();
                                    Random RNGNum = new Random();
                                    for (var i = 0; i < lengthNum; i++)
                                    {
                                        var textRefnum = randomtextRefNum[RNGNum.Next(0, randomtextRefNum.Length)];
                                        Refnum.Append(textRefnum);

                                    }

                                    var tran = connection.BeginTransaction();
                                    var emailValue = isEmail;
                                    var emailNameValue = isUserID;





                                    query = "select a.[option] from [tasksoption] a where a.[tasks]  = 'timeotpforgotpassword' ";
                                    var otpTime = (await connection.QueryAsync<TasksOntionDbContextData>(query, new { userid = isUserID }, transaction: tran)).FirstOrDefault();
                                    if (otpTime != null)
                                    {

                                        changEmail_OTP_OLD_Response.time = int.Parse(otpTime.option);

                                    }
                                    else
                                    {
                                        changEmail_OTP_OLD_Response.time = 4;
                                    }

                                    var timeotp = changEmail_OTP_OLD_Response.time;
                                    Execute(RefString, Refnum, emailValue, emailNameValue, nameSuppor, phoneSuppor, emailSuppor, timeotp, isUserLaguage).Wait();
                                    static async Task Execute(StringBuilder refString, StringBuilder refnum, string emaiValue, string emailNameValue, string nameSuppor, string phoneSuppor, string emailSuppor, int timeotp, string isUserLaguage)
                                    {

                                        var apiKey = "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";
                                        var client = new SendGridClient(apiKey);
                                        var from = new EmailAddress("ezautest@gmail.com", "Support Nisit Information Management System (EZATU) Applications ");
                                        var to = new EmailAddress(emaiValue, emailNameValue);
                                        var plainTextContent = "Confirm change password";
                                        if (isUserLaguage == "TH")
                                        {
                                            var subject = "ยืนยันการเปลี่ยนอีเมล ";
                                            var htmlContent = "<strong>การยืนยันตนโปรดระมัดระวังมิจฉาชีพ กรุณาอย่านำรหัสยืนยันตนให้บุคคลอื่น</strong> "
                                                + "<strong><br> <br> รหัส OTP Code :</strong> " + refnum.ToString() + "<strong> </ strong > " +
                                                "<strong> <br> <br>Reference code(รหัสอ้างอิง): </ strong >" + refString.ToString() + "<strong>  </ strong > " +
                                                 "<strong><br>  <br>หมดเวลา: </strong>" + DateTime.Now.AddMinutes(timeotp).ToString(DateTimeFormatHH_mm_ss_dd_MM_yyyy) +
                                                " <strong> <br><br> <br>  </strong>" + nameSuppor + "<strong>  </ strong > " +
                                               " <strong>  <br> <br>ติดต่อเรา </strong>" +
                                                " <strong>  <br> โทร  : </strong>" + phoneSuppor + "<strong>  </ strong > " +
                                               " <strong>  <br> อิเมล :  </strong>" + emailSuppor + "<strong>  </ strong > ";
                                            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                                            var response = await client.SendEmailAsync(msg);
                                        }
                                        else
                                        {
                                            var subject = "Confirm change email ";
                                            var htmlContent = "<strong>Confirmation, please be careful of scammers. Please do not give your verification code to other people.</strong> "
                                                + "<strong><br> <br>  OTP Code :</strong> " + refnum.ToString() + "<strong> </ strong > " +
                                                "<strong> <br> <br>Reference code: </ strong >" + refString.ToString() + "<strong>  </ strong > " +
                                                 "<strong><br>  <br>Time Out: </strong>" + DateTime.Now.AddMinutes(timeotp).ToString(DateTimeFormatHH_mm_ss_dd_MM_yyyy) +
                                                " <strong> <br><br> <br>  </strong>" + nameSuppor + "<strong>  </ strong > " +
                                               " <strong>  <br> <br>Contact Us </strong>" +
                                                " <strong>  <br> Phone  : </strong>" + phoneSuppor + "<strong>  </ strong > " +
                                               " <strong>  <br> E-mail :  </strong>" + emailSuppor + "<strong>  </ strong > ";
                                            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                                            var response = await client.SendEmailAsync(msg);
                                        }
                                    }


                                    string hashedisOTP = Convert.ToBase64String(inArray: KeyDerivation.Pbkdf2(
                                        password: Refnum.ToString()!, prf: KeyDerivationPrf.HMACSHA256, salt: salt, iterationCount: 100000, numBytesRequested: 256 / 8));
                                    var datainsert = new OTPTemporaryDbContextData()
                                    {

                                        userid = isUserID,
                                        email = isEmail,
                                        valueref = RefString.ToString(),
                                        otp = hashedisOTP,
                                        createAt = DateTime.UtcNow.AddHours(7).ToString(DateTimeFormat_dd_MM_yyyy, new CultureInfo("en-US")),
                                        timeout = DateTime.UtcNow.AddHours(7).AddMinutes(timeotp).AddSeconds(60).ToString(DateTimeFormat_dd_MM_yyyy, new CultureInfo("en-US")),

                                    };

                                    await connection.InsertAsync(datainsert, tran);
                                    //query = "select a.* from otptemporary a where a.userid  = @userid  ";
                                    //var otptemporary = (await connection.QueryAsync<Deleteotp>(query, new { userid = isUserID }, transaction: tran)).FirstOrDefault();
                                    //if (otptemporary != null)
                                    //{
                                    //    var deleteOTPTemporarye = new OTPTtemporaryData()
                                    //    {

                                    //        id = otptemporary.id,
                                    //        userid = otptemporary.userid,
                                    //        email = otptemporary.email,
                                    //        valueref = otptemporary.valueref,
                                    //        otp = otptemporary.otp,
                                    //        createAt = otptemporary.timeout,
                                    //        timeout = otptemporary.timeout

                                    //    };


                                    //    await connection.DeleteAsync(deleteOTPTemporarye, tran);
                                    //}
                                    tran.Commit();


                                    changEmail_OTP_OLD_Response.refvalue = RefString.ToString();
                                    changEmail_OTP_OLD_Response.useremail = isEmail;
                                    changEmail_OTP_OLD_Response.status = 200;
                                    changEmail_OTP_OLD_Response.message = "otpsuccess";
                                }
                            }
                            else
                            {
                                //ไม่พบemail หรือ รหัสผ่านไม่ถูกต้อง
                                changEmail_OTP_OLD_Response.status = 204;
                                changEmail_OTP_OLD_Response.message = "invalidpassword";

                            }
                        } 
                        else
                        {
                            //รหัสผ่านไม่ถูกต้อง
                            changEmail_OTP_OLD_Response.status = 204;
                            changEmail_OTP_OLD_Response.message = "invalidpassword";
                        } 
                        
                    }
                    else
                    {
                        //แจ้งpassword เป็นค่าว่าง
                        changEmail_OTP_OLD_Response.status = 204;
                        changEmail_OTP_OLD_Response.message = "fillempty";
                    }


                    query = "select a.* from errorscreen a  where a.screen =  @Screen  ";
                    var sendotpforoldemail = (await connection.QueryAsync<ScreenDbContextData>(query, new { Screen = "changemailpage" })).ToList();

                    foreach (var IssendotpforoldemailData in sendotpforoldemail)
                    {
                        switch (IssendotpforoldemailData.parameter.ToLower().Trim())
                        {
                            case "fillempty":
                                changEmail_OTP_OLD_Response.fillempty = isUserLaguage == "EN" ? IssendotpforoldemailData.EN : IssendotpforoldemailData.TH;
                                break;
                            case "otpsuccess":
                                changEmail_OTP_OLD_Response.otpsuccess = isUserLaguage == "EN" ? IssendotpforoldemailData.EN : IssendotpforoldemailData.TH;
                                break;
                            case "invalidpassword":
                                changEmail_OTP_OLD_Response.invalidpassword = isUserLaguage == "EN" ? IssendotpforoldemailData.EN : IssendotpforoldemailData.TH;
                                break;
                            case "expemail":
                                changEmail_OTP_OLD_Response.expemail = isUserLaguage == "EN" ? IssendotpforoldemailData.EN : IssendotpforoldemailData.TH;
                                break;
                            case "emailsub":
                                changEmail_OTP_OLD_Response.emailsub = isUserLaguage == "EN" ? IssendotpforoldemailData.EN : IssendotpforoldemailData.TH;
                                break;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                var connection = _context.GetDbconnection();
                var tran = connection.BeginTransaction();
                tran.Rollback();
                if (isUserLaguage == "EN")
                {
                    changEmail_OTP_OLD_Response.status = 401;
                    changEmail_OTP_OLD_Response.message = "erroroccurred";
                }
                else
                {
                    changEmail_OTP_OLD_Response.status = 401;
                    changEmail_OTP_OLD_Response.message = "erroroccurred";
                }

            }

            return changEmail_OTP_OLD_Response;
        }
        public async Task<SubmitOTPConfirmChangeEmailResponse> submitOTPConfirmChangeEmail(SubmitOTPConfirmChangeEmailRequest submitOTPConfirmChangeEmailRequest, string id)
        {
            SubmitOTPConfirmChangeEmailResponse submitOTPConfirmChangeEmailResponse = new SubmitOTPConfirmChangeEmailResponse()
            {

            };


            var isUserID = id;
            

            using var connection = _context.GetDbconnection();
            var refValueText = submitOTPConfirmChangeEmailRequest.refvaluetext;
            var checkotp = submitOTPConfirmChangeEmailRequest.otp;
            var isNewEmail = submitOTPConfirmChangeEmailRequest.newemail;
            var isConfirmEmail = submitOTPConfirmChangeEmailRequest.confirmemail;
            var isLanguage = submitOTPConfirmChangeEmailRequest.language;
            try
            {
                connection.Open();

                var query = "SELECT a.* FROM [expireemail] a  WHERE a.userid = @userid  ";
                var checkexpemail = await connection.QueryFirstOrDefaultAsync<string>(query, new { userid = isUserID });
                var ischeckexpemail = checkexpemail ?? string.Empty;
                if (ischeckexpemail == "")
                {
                    
                    
                    if (checkotp != "" && isNewEmail != "" && isConfirmEmail != "")
                    {
                        if (checkotp != "") //otp not null
                        {
                            //connection.Open();
                            byte[] salt = new byte[128 / 8];

                            string hashedisOTP = Convert.ToBase64String(inArray: KeyDerivation.Pbkdf2(
                                password: submitOTPConfirmChangeEmailRequest.otp!, prf: KeyDerivationPrf.HMACSHA256, salt: salt, iterationCount: 100000, numBytesRequested: 256 / 8));


                            {//เจ๊งตรงนี้
                                refValueText = submitOTPConfirmChangeEmailRequest.refvaluetext;
                                checkotp = submitOTPConfirmChangeEmailRequest.otp;
                                query = "SELECT a.* FROM [otptemporary] a  WHERE a.userid = @userid and  a.valueref = @refValueText and otp = @otp";
                                var checkOTPData = (await connection.QueryAsync<otptemporaryModel>(query,
                                new
                                {
                                    userid = isUserID,
                                    otp = hashedisOTP,
                                    email = submitOTPConfirmChangeEmailRequest.newemail,
                                    refValueText = submitOTPConfirmChangeEmailRequest.refvaluetext
                                })).FirstOrDefault();


                                if (checkOTPData != null)
                                {

                                    string iStringimeExpire = checkOTPData.timeout;
                                    DateTime dateTimeOut = DateTime.ParseExact(iStringimeExpire, DateTimeFormat_dd_MM_yyyy, null);
                                    string iStringUtcNow = DateTime.UtcNow.AddHours(7).ToString(DateTimeFormat_dd_MM_yyyy, new CultureInfo("en-US"));
                                    DateTime dateTimeNow = DateTime.ParseExact(iStringUtcNow, DateTimeFormat_dd_MM_yyyy, null);
                                    int result1 = DateTime.Compare(dateTimeOut, dateTimeNow);
                                    if (dateTimeOut > dateTimeNow)
                                    {
                                        //new email not null
                                        var checknewemail = isNewEmail;
                                        if (checknewemail != "")
                                        {

                                            var checkConfirmEmail = isConfirmEmail;
                                            if (checkConfirmEmail != "")
                                            {
                                                var checkemail = submitOTPConfirmChangeEmailRequest.newemail;
                                                Regex validateGuidRegex5 = new Regex("(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])");
                                                var isvalidemail = validateGuidRegex5.IsMatch(submitOTPConfirmChangeEmailRequest.newemail);
                                                if (isvalidemail)
                                                {
                                                    var userEmail = submitOTPConfirmChangeEmailRequest.newemail;
                                                    var query2 = "SELECT COUNT(*) FROM [useraccount] WHERE useremail = @useremail";
                                                    var result = await connection.QuerySingleAsync<int>(query2, new { useremail = userEmail });

                                                    if (result < 1)
                                                    {
                                                        submitOTPConfirmChangeEmailResponse.status = 200;
                                                        submitOTPConfirmChangeEmailResponse.message = "สำเร็จ"; //ใช้format ไปก่อน ค่อยมาเปลี่ยน //<=เปลี่ยนแล้ว ค่อยมาเปลี่ยนอีกรอบ
                                                        if (checknewemail == checkConfirmEmail)

                                                        {


                                                            query = "SELECT a.* FROM [isupport] a ";
                                                            var checkUserISupportData = (await connection.QueryAsync<ISupport>(query)).ToList();
                                                            foreach (var _checkUserISupportData in checkUserISupportData)

                                                            {
                                                                query = "DELETE FROM [otptemporary] WHERE email = @email  COLLATE Thai_CS_AS ";
                                                                var checkDeleteOTPData = (await connection.QueryAsync<ISupport>(query, new { email = isNewEmail })).FirstOrDefault();
                                                                //const string randomtextRefString = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                                                                //int lengthString = 16;
                                                                const string randomtextRefString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                                                                int lengthString = 8;
                                                                var RefString = new StringBuilder();
                                                                Random RNGString = new Random();
                                                                for (var i = 0; i < lengthString; i++)
                                                                {
                                                                    var textRefString = randomtextRefString[RNGString.Next(0, randomtextRefString.Length)];
                                                                    RefString.Append(textRefString);

                                                                }
                                                                const string randomtextRefNum = "0123456789";
                                                                int lengthNum = 6;
                                                                var Refnum = new StringBuilder();
                                                                Random RNGNum = new Random();
                                                                for (var i = 0; i < lengthNum; i++)
                                                                {
                                                                    var textRefnum = randomtextRefNum[RNGNum.Next(0, randomtextRefNum.Length)];
                                                                    Refnum.Append(textRefnum);

                                                                }
                                                                string hashedisPassword = Convert.ToBase64String(inArray: KeyDerivation.Pbkdf2(
                                                               password: Refnum.ToString()!, prf: KeyDerivationPrf.HMACSHA256, salt: salt, iterationCount: 100000, numBytesRequested: 256 / 8));

                                                                var tran = connection.BeginTransaction();
                                                                query = "select a.[option] from [tasksoption] a where a.[tasks]  = 'timeotpforgotpassword' ";
                                                                var otpTime = (await connection.QueryAsync<TasksOntionDbContextData>(query, new { email = isNewEmail }, transaction: tran)).FirstOrDefault();
                                                                if (otpTime != null)
                                                                {

                                                                    submitOTPConfirmChangeEmailResponse.time = int.Parse(otpTime.option);

                                                                }
                                                                else
                                                                {
                                                                    submitOTPConfirmChangeEmailResponse.time = 4;
                                                                }

                                                                //var isUserID = id;
                                                                var timeotp = submitOTPConfirmChangeEmailResponse.time;
                                                                var emailValue = isNewEmail;
                                                                var isUserLaguage = "";
                                                                var emailNameValue = id; //เพื่อแก้เป็น isUserID
                                                                var nameSuppor = _checkUserISupportData.name == null ? "<strong> Support (EZATU)  </ strong > " : _checkUserISupportData.name;
                                                                var phoneSuppor = _checkUserISupportData.phone == null ? "<strong> 0-3810-3011 </ strong> " : _checkUserISupportData.phone;
                                                                var emailSuppor = _checkUserISupportData.email == null ? "<strong> scibuu.pr@gmail.com </ strong >" : _checkUserISupportData.email;
                                                                Execute(RefString, Refnum, emailValue, emailNameValue, nameSuppor, phoneSuppor, emailSuppor, timeotp, isUserLaguage, emailValue).Wait();
                                                                static async Task Execute(StringBuilder refString, StringBuilder refnum, string emaiValue, string emailNameValue, string nameSuppor, string phoneSuppor, string emailSuppor, int timeotp, string isUserLaguage, string emailValue)
                                                                {
                                                                    var apiKey = "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";
                                                                    var client = new SendGridClient(apiKey);
                                                                    var from = new EmailAddress("ezautest@gmail.com", "Support Nisit Information Management System (EZATU) Applications ");

                                                                    var to = new EmailAddress(emailValue, emailNameValue);
                                                                    var plainTextContent = "Confirm account login";
                                                                    if (isUserLaguage == "TH")
                                                                    {
                                                                        var subject = "ยืนยันการลงทะเบียนอีเมลใหม่ ";
                                                                        var htmlContent = "<strong>การยืนยันตนโปรดระมัดระวังมิจฉาชีพ กรุณาอย่านำรหัสยืนยันตนให้บุคคลอื่น</strong> "
                                                                            + "<strong><br> <br> รหัส OTP Code :</strong> " + refnum.ToString() + "<strong> </ strong > " +
                                                                            "<strong> <br> <br>Reference code(รหัสอ้างอิง): </ strong >" + refString.ToString() + "<strong>  </ strong > " +
                                                                            "<strong><br>  <br>หมดเวลา: </strong>" + DateTime.Now.AddMinutes(timeotp).ToString(DateTimeFormatHH_mm_ss_dd_MM_yyyy) +
                                                                            " <strong> <br><br> <br>  </strong>" + nameSuppor + "<strong>  </ strong > " +
                                                                            " <strong>  <br> <br>ติดต่อเรา </strong>" +
                                                                            " <strong>  <br> โทร  : </strong>" + phoneSuppor + "<strong>  </ strong > " +
                                                                            " <strong>  <br> อิเมล :  </strong>" + emailSuppor + "<strong>  </ strong > ";
                                                                        var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                                                                        var response = await client.SendEmailAsync(msg);
                                                                    }
                                                                    else
                                                                    {
                                                                        var subject = "Confirm New Email ";
                                                                        var htmlContent = "<strong>Confirmation, please be careful of scammers. Please do not give your verification code to other people.</strong> "
                                                                            + "<strong><br> <br>  OTP Code :</strong> " + refnum.ToString() + "<strong> </ strong > " +
                                                                            "<strong> <br> <br>Reference code: </ strong >" + refString.ToString() + "<strong>  </ strong > " +
                                                                             "<strong><br>  <br>Time Out: </strong>" + DateTime.Now.AddMinutes(timeotp).ToString(DateTimeFormatHH_mm_ss_dd_MM_yyyy) +
                                                                            " <strong> <br><br> <br>  </strong>" + nameSuppor + "<strong>  </ strong > " +
                                                                           " <strong>  <br> <br>Contact Us </strong>" +
                                                                            " <strong>  <br> Phone  : </strong>" + phoneSuppor + "<strong>  </ strong > " +
                                                                           " <strong>  <br> E-mail :  </strong>" + emailSuppor + "<strong>  </ strong > ";
                                                                        var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                                                                        var response = await client.SendEmailAsync(msg);
                                                                    }
                                                                }
                                                                //query = "DELETE FROM [otptemporary] WHERE userid = @userid  COLLATE Thai_CS_AS ";
                                                                //var checkDeleteOTPData = (await connection.QueryAsync<ISupport>(query, new { userid = isUserID })).FirstOrDefault();

                                                                var datainsert = new OTPTemporaryDbContextData()
                                                                {

                                                                    userid = id,
                                                                    email = checknewemail,
                                                                    valueref = RefString.ToString(),
                                                                    otp = hashedisPassword,
                                                                    createAt = DateTime.UtcNow.AddHours(7).ToString(DateTimeFormat_dd_MM_yyyy, new CultureInfo("en-US")),
                                                                    timeout = DateTime.UtcNow.AddHours(7).AddMinutes(timeotp).AddSeconds(30).ToString(DateTimeFormat_dd_MM_yyyy, new CultureInfo("en-US"))

                                                                };
                                                                await connection.InsertAsync(datainsert, tran);

                                                                
                                                               

                                                                //เจ๊งตรงนี้
                                                                tran.Commit();
                                                                submitOTPConfirmChangeEmailResponse.status = 200;
                                                                submitOTPConfirmChangeEmailResponse.message = "otpsuccess";
                                                                submitOTPConfirmChangeEmailResponse.refvalueforSubmitChangeEmail = RefString.ToString();
                                                                submitOTPConfirmChangeEmailResponse.sendotptonewemail = isNewEmail;

                                                            }

                                                        }
                                                        else
                                                        {

                                                            submitOTPConfirmChangeEmailResponse.status = 204;
                                                            submitOTPConfirmChangeEmailResponse.message = "errornewandconfirm";

                                                        }
                                                    }
                                                    else
                                                    {
                                                        submitOTPConfirmChangeEmailResponse.status = 204;
                                                        submitOTPConfirmChangeEmailResponse.message = "emailsub";
                                                    }
                                                }
                                                else
                                                {

                                                    submitOTPConfirmChangeEmailResponse.status = 204;
                                                    submitOTPConfirmChangeEmailResponse.message = "typeemail";

                                                }

                                            }
                                            else
                                            {

                                                submitOTPConfirmChangeEmailResponse.status = 204;
                                                submitOTPConfirmChangeEmailResponse.message = "fillempty";
                                            }

                                        }
                                        else
                                        {

                                            submitOTPConfirmChangeEmailResponse.status = 204;
                                            submitOTPConfirmChangeEmailResponse.message = "fillempty";
                                        }
                                    }
                                    else
                                    {
                                        submitOTPConfirmChangeEmailResponse.status = 204;
                                        submitOTPConfirmChangeEmailResponse.message = "expotp";
                                    }

                                }

                                else
                                {

                                    submitOTPConfirmChangeEmailResponse.status = 204;
                                    submitOTPConfirmChangeEmailResponse.message = "invalidotp";

                                }
                            }
                        }
                        else
                        {
                            //otp null warning
                            submitOTPConfirmChangeEmailResponse.status = 204;
                            submitOTPConfirmChangeEmailResponse.message = "otpempty";
                        }

                    }
                    else
                    {
                        //newemail and confirmemail null warning
                        submitOTPConfirmChangeEmailResponse.status = 204;
                        submitOTPConfirmChangeEmailResponse.message = "fillempty";
                    }
                }
                else
                {
                    isNewEmail = submitOTPConfirmChangeEmailRequest.newemail;
                    isConfirmEmail = submitOTPConfirmChangeEmailRequest.confirmemail;
                    isLanguage = submitOTPConfirmChangeEmailRequest.language;
                    if (isNewEmail != "" && isConfirmEmail != "")
                    {

                        //connection.Open();
                        byte[] salt = new byte[128 / 8];

                        //string hashedisOTP = Convert.ToBase64String(inArray: KeyDerivation.Pbkdf2(
                        //    password: submitnewemailRequest.submitOTPConfirmChangeEmailRequest.otp!, prf: KeyDerivationPrf.HMACSHA256, salt: salt, iterationCount: 100000, numBytesRequested: 256 / 8));

                        //new email not null
                        var checknewemail = isNewEmail;
                        if (checknewemail != "")
                        {

                            var checkConfirmEmail = isConfirmEmail;
                            if (checkConfirmEmail != "")
                            {
                                var checkemail = submitOTPConfirmChangeEmailRequest.newemail;
                                Regex validateGuidRegex5 = new Regex("(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])");
                                var isvalidemail = validateGuidRegex5.IsMatch(submitOTPConfirmChangeEmailRequest.newemail);
                                if (isvalidemail)
                                {
                                    var userEmail = submitOTPConfirmChangeEmailRequest.newemail;
                                    var query2 = "SELECT COUNT(*) FROM [useraccount] WHERE useremail = @useremail";
                                    var result = await connection.QuerySingleAsync<int>(query2, new { useremail = userEmail });

                                    if (result < 1)
                                    {
                                        submitOTPConfirmChangeEmailResponse.status = 200;
                                        submitOTPConfirmChangeEmailResponse.message = "สำเร็จ"; //ใช้format ไปก่อน ค่อยมาเปลี่ยน //<=เปลี่ยนแล้ว ค่อยมาเปลี่ยนอีกรอบ
                                        if (checknewemail == checkConfirmEmail)

                                        {

                                            query = "SELECT a.* FROM [isupport] a ";
                                            var checkUserISupportData = (await connection.QueryAsync<ISupport>(query)).ToList();
                                            foreach (var _checkUserISupportData in checkUserISupportData)

                                            {
                                                query = "DELETE FROM [otptemporary] WHERE email = @email  COLLATE Thai_CS_AS ";
                                                var checkDeleteOTPData = (await connection.QueryAsync<ISupport>(query, new { email = isNewEmail })).FirstOrDefault();
                                                //const string randomtextRefString = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                                                //int lengthString = 16;
                                                const string randomtextRefString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                                                int lengthString = 8;
                                                var RefString = new StringBuilder();
                                                Random RNGString = new Random();
                                                for (var i = 0; i < lengthString; i++)
                                                {
                                                    var textRefString = randomtextRefString[RNGString.Next(0, randomtextRefString.Length)];
                                                    RefString.Append(textRefString);

                                                }
                                                const string randomtextRefNum = "0123456789";
                                                int lengthNum = 6;
                                                var Refnum = new StringBuilder();
                                                Random RNGNum = new Random();
                                                for (var i = 0; i < lengthNum; i++)
                                                {
                                                    var textRefnum = randomtextRefNum[RNGNum.Next(0, randomtextRefNum.Length)];
                                                    Refnum.Append(textRefnum);

                                                }
                                                string hashedisPassword = Convert.ToBase64String(inArray: KeyDerivation.Pbkdf2(
                                               password: Refnum.ToString()!, prf: KeyDerivationPrf.HMACSHA256, salt: salt, iterationCount: 100000, numBytesRequested: 256 / 8));

                                                var tran = connection.BeginTransaction();
                                                query = "select a.[option] from [tasksoption] a where a.[tasks]  = 'timeotpforgotpassword' ";
                                                var otpTime = (await connection.QueryAsync<TasksOntionDbContextData>(query, new { email = isNewEmail }, transaction: tran)).FirstOrDefault();
                                                if (otpTime != null)
                                                {

                                                    submitOTPConfirmChangeEmailResponse.time = int.Parse(otpTime.option);

                                                }
                                                else
                                                {
                                                    submitOTPConfirmChangeEmailResponse.time = 4;
                                                }

                                                //var isUserID = id;
                                                var timeotp = submitOTPConfirmChangeEmailResponse.time;
                                                var emailValue = isNewEmail;
                                                var isUserLaguage = "";
                                                var emailNameValue = id; //เพื่อแก้เป็น isUserID
                                                var nameSuppor = _checkUserISupportData.name == null ? "<strong> Support (EZATU)  </ strong > " : _checkUserISupportData.name;
                                                var phoneSuppor = _checkUserISupportData.phone == null ? "<strong> 0-3810-3011 </ strong> " : _checkUserISupportData.phone;
                                                var emailSuppor = _checkUserISupportData.email == null ? "<strong> scibuu.pr@gmail.com </ strong >" : _checkUserISupportData.email;
                                                Execute(RefString, Refnum, emailValue, emailNameValue, nameSuppor, phoneSuppor, emailSuppor, timeotp, isUserLaguage, emailValue).Wait();
                                                static async Task Execute(StringBuilder refString, StringBuilder refnum, string emaiValue, string emailNameValue, string nameSuppor, string phoneSuppor, string emailSuppor, int timeotp, string isUserLaguage, string emailValue)
                                                {
                                                    var apiKey = "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";
                                                    var client = new SendGridClient(apiKey);
                                                    var from = new EmailAddress("ezautest@gmail.com", "Support Nisit Information Management System (EZATU) Applications ");

                                                    var to = new EmailAddress(emailValue, emailNameValue);
                                                    var plainTextContent = "Confirm account login";
                                                    if (isUserLaguage == "TH")
                                                    {
                                                        var subject = "ยืนยันการลงทะเบียนอีเมลใหม่ ";
                                                        var htmlContent = "<strong>การยืนยันตนโปรดระมัดระวังมิจฉาชีพ กรุณาอย่านำรหัสยืนยันตนให้บุคคลอื่น</strong> "
                                                            + "<strong><br> <br> รหัส OTP Code :</strong> " + refnum.ToString() + "<strong> </ strong > " +
                                                            "<strong> <br> <br>Reference code(รหัสอ้างอิง): </ strong >" + refString.ToString() + "<strong>  </ strong > " +
                                                            "<strong><br>  <br>หมดเวลา: </strong>" + DateTime.Now.AddMinutes(timeotp).ToString(DateTimeFormatHH_mm_ss_dd_MM_yyyy) +
                                                            " <strong> <br><br> <br>  </strong>" + nameSuppor + "<strong>  </ strong > " +
                                                            " <strong>  <br> <br>ติดต่อเรา </strong>" +
                                                            " <strong>  <br> โทร  : </strong>" + phoneSuppor + "<strong>  </ strong > " +
                                                            " <strong>  <br> อิเมล :  </strong>" + emailSuppor + "<strong>  </ strong > ";
                                                        var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                                                        var response = await client.SendEmailAsync(msg);
                                                    }
                                                    else
                                                    {
                                                        var subject = "Confirm New Email ";
                                                        var htmlContent = "<strong>Confirmation, please be careful of scammers. Please do not give your verification code to other people.</strong> "
                                                            + "<strong><br> <br>  OTP Code :</strong> " + refnum.ToString() + "<strong> </ strong > " +
                                                            "<strong> <br> <br>Reference code: </ strong >" + refString.ToString() + "<strong>  </ strong > " +
                                                             "<strong><br>  <br>Time Out: </strong>" + DateTime.Now.AddMinutes(timeotp).ToString(DateTimeFormatHH_mm_ss_dd_MM_yyyy) +
                                                            " <strong> <br><br> <br>  </strong>" + nameSuppor + "<strong>  </ strong > " +
                                                           " <strong>  <br> <br>Contact Us </strong>" +
                                                            " <strong>  <br> Phone  : </strong>" + phoneSuppor + "<strong>  </ strong > " +
                                                           " <strong>  <br> E-mail :  </strong>" + emailSuppor + "<strong>  </ strong > ";
                                                        var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                                                        var response = await client.SendEmailAsync(msg);
                                                    }
                                                }

                                                

                                                var datainsert = new OTPTemporaryDbContextData()
                                                {

                                                    userid = id,
                                                    email = checknewemail,
                                                    valueref = RefString.ToString(),
                                                    otp = hashedisPassword,
                                                    createAt = DateTime.UtcNow.AddHours(7).ToString(DateTimeFormat_dd_MM_yyyy, new CultureInfo("en-US")),
                                                    timeout = DateTime.UtcNow.AddHours(7).AddMinutes(timeotp).AddSeconds(30).ToString(DateTimeFormat_dd_MM_yyyy, new CultureInfo("en-US"))

                                                };
                                                await connection.InsertAsync(datainsert, tran);

                                               
                                                tran.Commit();
                                               
                                                //submitOTPConfirmChangeEmailResponse.refvalue = RefString.ToString();
                                                submitOTPConfirmChangeEmailResponse.status = 200;
                                                submitOTPConfirmChangeEmailResponse.message = "otpsuccess";
                                                submitOTPConfirmChangeEmailResponse.refvalueforSubmitChangeEmail = RefString.ToString();
                                                submitOTPConfirmChangeEmailResponse.sendotptonewemail = isNewEmail;

                                            }

                                        }
                                        else
                                        {

                                            submitOTPConfirmChangeEmailResponse.status = 204;
                                            submitOTPConfirmChangeEmailResponse.message = "errornewandconfirm";

                                        }
                                    }
                                    else
                                    {
                                        submitOTPConfirmChangeEmailResponse.status = 204;
                                        submitOTPConfirmChangeEmailResponse.message = "emailsub";
                                    }
                                }
                                else
                                {

                                    submitOTPConfirmChangeEmailResponse.status = 204;
                                    submitOTPConfirmChangeEmailResponse.message = "typeemail";

                                }

                            }
                            else
                            {

                                submitOTPConfirmChangeEmailResponse.status = 204;
                                submitOTPConfirmChangeEmailResponse.message = "fillempty";
                            }

                        }
                        else
                        {

                            submitOTPConfirmChangeEmailResponse.status = 204;
                            submitOTPConfirmChangeEmailResponse.message = "fillempty";
                        }

                    }
                    else
                    {
                        //newemail and confirmemail null warning
                        submitOTPConfirmChangeEmailResponse.status = 204;
                        submitOTPConfirmChangeEmailResponse.message = "fillempty";
                    }
                }




                query = "select a.* from errorscreen a  where a.screen =  @Screen  ";
                var submitconfirmchangeemail = (await connection.QueryAsync<ScreenDbContextData>(query, new { Screen = "changemailpage" })).ToList();

                foreach (var IssubmitconfirmchangeemailData in submitconfirmchangeemail)
                {
                    switch (IssubmitconfirmchangeemailData.parameter.ToLower().Trim())
                    {

                        case "errornewandconfirm":
                            submitOTPConfirmChangeEmailResponse.errornewandconfirm = submitOTPConfirmChangeEmailResponse.language == "EN" ? IssubmitconfirmchangeemailData.EN : IssubmitconfirmchangeemailData.TH;
                            break;
                        case "typeemail":
                            submitOTPConfirmChangeEmailResponse.typeemail = submitOTPConfirmChangeEmailResponse.language == "EN" ? IssubmitconfirmchangeemailData.EN : IssubmitconfirmchangeemailData.TH;
                            break;
                        case "fillempty":
                            submitOTPConfirmChangeEmailResponse.fillempty = submitOTPConfirmChangeEmailResponse.language == "EN" ? IssubmitconfirmchangeemailData.EN : IssubmitconfirmchangeemailData.TH;
                            break;
                        case "newemailsub":
                            submitOTPConfirmChangeEmailResponse.newemailsub = submitOTPConfirmChangeEmailResponse.language == "EN" ? IssubmitconfirmchangeemailData.EN : IssubmitconfirmchangeemailData.TH;
                            break;
                        case "confirmnewemailsub":
                            submitOTPConfirmChangeEmailResponse.confirmnewemailsub = submitOTPConfirmChangeEmailResponse.language == "EN" ? IssubmitconfirmchangeemailData.EN : IssubmitconfirmchangeemailData.TH;
                            break;
                        case "invalidotp":
                            submitOTPConfirmChangeEmailResponse.invalidotp = submitOTPConfirmChangeEmailResponse.language == "EN" ? IssubmitconfirmchangeemailData.EN : IssubmitconfirmchangeemailData.TH;
                            break;
                        case "changeemailsuccess":
                            submitOTPConfirmChangeEmailResponse.otpsuccess = submitOTPConfirmChangeEmailResponse.language == "EN" ? IssubmitconfirmchangeemailData.EN : IssubmitconfirmchangeemailData.TH;
                            break;
                        case "otpempty":
                            submitOTPConfirmChangeEmailResponse.otpempty = submitOTPConfirmChangeEmailResponse.language == "EN" ? IssubmitconfirmchangeemailData.EN : IssubmitconfirmchangeemailData.TH;
                            break;
                        case "emailsub":
                            submitOTPConfirmChangeEmailResponse.emailsub = submitOTPConfirmChangeEmailResponse.language == "EN" ? IssubmitconfirmchangeemailData.EN : IssubmitconfirmchangeemailData.TH;
                            break;
                        case "expotp":
                            submitOTPConfirmChangeEmailResponse.expotp = submitOTPConfirmChangeEmailResponse.language == "EN" ? IssubmitconfirmchangeemailData.EN : IssubmitconfirmchangeemailData.TH;
                            break;


                    }
                }
            
               
            }
            catch (Exception ex)
            {

                var tran = connection.BeginTransaction();
                tran.Rollback();
                if (submitOTPConfirmChangeEmailRequest.language == "EN")
                {
                    submitOTPConfirmChangeEmailResponse.status = 401;
                    submitOTPConfirmChangeEmailResponse.message = "Failed to change email";
                }
                else
                {
                    submitOTPConfirmChangeEmailResponse.status = 401;
                    submitOTPConfirmChangeEmailResponse.message = "เปลี่ยนอีเมลไม่สำเร็จ";

                }

            }

            return submitOTPConfirmChangeEmailResponse;
        }

        public async Task<SubmitOTPChangeEmailResponse> submitOTPChangeEmail(SubmitOTPChangeEmailRequest submitOTPChangeEmailRequest, string id)
        {
            SubmitOTPChangeEmailResponse submitOTPnewemailResponse = new SubmitOTPChangeEmailResponse()
            {

            };

            var isUserID = id;

            var query = "SELECT a.* FROM [otptemporary] a  WHERE a.valueref = @refValueText  and  a.otp = @OTP  ";
            var checkotp = submitOTPChangeEmailRequest.otp;
            var isLanguage = submitOTPChangeEmailRequest.language;
            var refValueText = submitOTPChangeEmailRequest.refvalue;
            using var connection = _context.GetDbconnection();
            try
            {
                if (checkotp != "") //otp not null
                {
                    connection.Open();
                    byte[] salt = new byte[128 / 8];

                    string hashedisOTP = Convert.ToBase64String(inArray: KeyDerivation.Pbkdf2(
                        password: submitOTPChangeEmailRequest.otp!, prf: KeyDerivationPrf.HMACSHA256, salt: salt, iterationCount: 100000, numBytesRequested: 256 / 8));


                    {
                        var checkOTPData = (await connection.QueryAsync<otptemporaryModel>(query,
                        new
                        {
                            userid = isUserID,
                            OTP = hashedisOTP,
                            refValueText = submitOTPChangeEmailRequest.refvalue
                        })).FirstOrDefault();

                        if (checkOTPData != null)
                        {
                            string iStringimeExpire = checkOTPData.timeout;
                            DateTime dateTimeOut = DateTime.ParseExact(iStringimeExpire, DateTimeFormat_dd_MM_yyyy, null);
                            string iStringUtcNow = DateTime.UtcNow.AddHours(7).ToString(DateTimeFormat_dd_MM_yyyy, new CultureInfo("en-US"));
                            DateTime dateTimeNow = DateTime.ParseExact(iStringUtcNow, DateTimeFormat_dd_MM_yyyy, null);

                            int result1 = DateTime.Compare(dateTimeOut, dateTimeNow);


                            if (dateTimeOut > dateTimeNow)
                            {
                                var query1 = "SELECT a.email FROM [otptemporary] a  WHERE a.valueref = @refValueText  and  a.otp = @OTP  ";
                                var emailResult = await connection.QueryFirstOrDefaultAsync<string>(query1, new { refValueText = submitOTPChangeEmailRequest.refvalue, OTP = hashedisOTP });
                                var isNewEmail = emailResult ?? string.Empty;
                                var tran = connection.BeginTransaction();
                                var dataupdate = new UpdateEmailModel()
                                {
                                    userid = isUserID,
                                    useremail = isNewEmail

                                };
                                await connection.UpdateAsync(dataupdate, tran);

                                tran.Commit();

                                submitOTPnewemailResponse.status = 200;
                                submitOTPnewemailResponse.message = "changeemailsuccess";
                            }
                            else
                            {

                                submitOTPnewemailResponse.status = 204;
                                submitOTPnewemailResponse.message = "expotp";
                            }
                        }
                        else
                        {

                            submitOTPnewemailResponse.status = 204;
                            submitOTPnewemailResponse.message = "invalidotp";
                        }
                    }
                    {

                    }
                }
                else
                {

                    submitOTPnewemailResponse.status = 204;
                    submitOTPnewemailResponse.message = "otpempty";
                }

                query = "select a.* from errorscreen a  where a.screen =  @Screen  ";
                var submitconfirmchangeemail = (await connection.QueryAsync<ScreenDbContextData>(query, new { Screen = "changemailpage" })).ToList();

                foreach (var IssubmitconfirmchangeemailData in submitconfirmchangeemail)
                {
                    switch (IssubmitconfirmchangeemailData.parameter.ToLower().Trim())
                    {
                        case "invalidotp":
                            submitOTPnewemailResponse.invalidotp = submitOTPnewemailResponse.language == "EN" ? IssubmitconfirmchangeemailData.EN : IssubmitconfirmchangeemailData.TH;
                            break;
                        case "changeemailsuccess":
                            submitOTPnewemailResponse.changeemailsuccess = submitOTPnewemailResponse.language == "EN" ? IssubmitconfirmchangeemailData.EN : IssubmitconfirmchangeemailData.TH;
                            break;
                        case "otpempty":
                            submitOTPnewemailResponse.otpempty = submitOTPnewemailResponse.language == "EN" ? IssubmitconfirmchangeemailData.EN : IssubmitconfirmchangeemailData.TH;
                            break;
                        case "expotp":
                            submitOTPnewemailResponse.expotp = submitOTPnewemailResponse.language == "EN" ? IssubmitconfirmchangeemailData.EN : IssubmitconfirmchangeemailData.TH;
                            break;


                    }
                }
            }
            catch (Exception e)
            {
                var tran = connection.BeginTransaction();
                tran.Rollback();
                if (submitOTPChangeEmailRequest.language == "EN")
                {
                    submitOTPnewemailResponse.status = 401;
                    submitOTPnewemailResponse.message = "erroroccurred";
                }
                else
                {
                    submitOTPnewemailResponse.status = 401;
                    submitOTPnewemailResponse.message = "erroroccurred";

                }
            }


            return submitOTPnewemailResponse;
        }
        public async Task<ChangeEmailScreenResponse> ChangeEmailScreen(ChangeEmailScreenRequest changeEmailScreenRequest, String id) {
            ChangeEmailScreenResponse changemailpageResponse = new ChangeEmailScreenResponse()
            {
                errorButton = new ErrorButton(),
                alertMessageChangeEmail = new AlertMessageChangeEmail(),
            };
            try
            {
                var query = "select a.*, b.userlanguage from LabelScreen a , language b where Screen =  @Screen  and userid = @userid ";
                //query = "select a.*, b.userlanguage from LabelScreen a , language b where Screen =  @Screen  and userid = @userid ";
                using (var connection = _context.GetDbconnection())
                {
                    connection.Open();
                    var cregisterpageScreennData = (await connection.QueryAsync<ScreenDbContextData>(query, new { Screen = "changemailpage", userid = id })).ToList();
                    foreach (var screenData in cregisterpageScreennData)
                    {
                        switch (screenData.parameter.Trim())
                        {
                            case "resetRefMin":
                                changemailpageResponse.resetRefMin = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "texPassword":
                                changemailpageResponse.texPassword = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "btnconfirm":
                                changemailpageResponse.btnconfirm = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "btnCancel":
                                changemailpageResponse.btnCancel = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "titlechangEmail":
                                changemailpageResponse.titlechangEmail = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "texCheckEmail":
                                changemailpageResponse.texCheckEmail = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "texFindEmail":
                                changemailpageResponse.texFindEmail = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "EnterOTP":
                                changemailpageResponse.EnterOTP = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "textref":
                                changemailpageResponse.textref = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "resetRef":
                                changemailpageResponse.resetRef = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "edtNewEmail":
                                changemailpageResponse.edtNewEmail = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "edtConNewEmail":
                                changemailpageResponse.edtConNewEmail = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "btnSubmit":
                                changemailpageResponse.btnSubmit = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "texEXPEmail":
                                changemailpageResponse.texEXPEmail = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;


                        }
                    }
                }

                query = "select a.*, b.userlanguage from errorscreen a , language b where Screen =  @Screen  and userid = @userid";
                using (var connection = _context.GetDbconnection())
                {
                    connection.Open();
                    var cregisterpageScreennData = (await connection.QueryAsync<ScreenDbContextData>(query, new { Screen = "changemailpage", userid = id })).ToList();
                    foreach (var screenData in cregisterpageScreennData)
                    {
                        switch (screenData.parameter.Trim())
                        {
                           
                            case "texConfirmChangeEmail":
                                changemailpageResponse.alertMessageChangeEmail.texConfirmChangeEmail = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "ChangeSuc":
                                changemailpageResponse.alertMessageChangeEmail.ChangeSuc = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                        }
                    }
                }

                query = "select a.*, b.userlanguage from errorscreen a , language b where Screen =  @Screen  and userid = @userid";
                using (var connection = _context.GetDbconnection())
                {
                    connection.Open();
                    var cregisterpageScreennData = (await connection.QueryAsync<ScreenDbContextData>(query, new { Screen = "button", userid = id })).ToList();
                    foreach (var screenData in cregisterpageScreennData)
                    {
                        switch (screenData.parameter.Trim())
                        {

                            case "buttoncancel":
                                changemailpageResponse.errorButton.buttoncancel = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "buttonno":
                                changemailpageResponse.errorButton.buttonno = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "buttonyes":
                                changemailpageResponse.errorButton.buttonyes = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "buttonconfirm":
                                changemailpageResponse.errorButton.buttonconfirm = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                            case "buttonok":
                                changemailpageResponse.errorButton.buttonok = screenData.userlanguage == "EN" ? screenData.EN : screenData.TH;
                                break;
                        }
                    }
                }
            }
            catch { }

            return changemailpageResponse;

        }
    }
}
