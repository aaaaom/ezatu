using ProjectServiceEZATU.DTO.Request;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectServiceEZATU.DTO.Request.login
{
    public class LoginSubmitRequest : RequestBase
    {

        public string language { get; set; }
        public string userid { get; set; }
 
        //[Required]
        public string password { get; set; }    
    }
}
