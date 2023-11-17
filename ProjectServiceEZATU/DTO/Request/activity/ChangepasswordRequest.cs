using ProjectServiceEZATU.DTO.Request;
namespace ProjectServiceEZATU.DTO.Request.home
{
    public class ChangepasswordRequest
    {

        public string currentpassword { get; set; }
        public string newpassword { get; set; }
        public string confirmpassword { get; set; }
        public string refreshToken { get; set; }

    }
}
