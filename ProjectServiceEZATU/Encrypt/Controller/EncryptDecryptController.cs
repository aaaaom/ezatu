using ProjectServiceEZATU.Encrypt.Enmodel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectServiceEZATU.Encrypt.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncryptDecryptController : ControllerBase
    {
        [HttpGet]
        [Route("Encrypt")]
        public string Encrypt(string text)
        {
            var encryptSring = EncryptDecryptManager.Encrypt(text);
            return encryptSring;
        }
        [HttpGet]
        [Route("Decrypt")]
        public string Decrypt(string text)
        {
            var decryptSring = EncryptDecryptManager.Decrypt(text);
            return decryptSring;
        }
    }
}
