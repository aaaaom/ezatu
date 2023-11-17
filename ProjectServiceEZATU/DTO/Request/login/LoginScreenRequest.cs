using ProjectServiceEZATU.DTO.Request;
using System.ComponentModel.DataAnnotations;

namespace ProjectServiceEZATU.DTO.Request.login
{
    public class LoginScreenRequest : RequestBase
    {
        [Required]
        public string language { get; set; }
    }
}
