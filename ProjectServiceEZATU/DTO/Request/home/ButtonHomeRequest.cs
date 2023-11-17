using ProjectServiceEZATU.DTO.Request;
namespace ProjectServiceEZATU.DTO.Request.home
{
    public class ButtonHomeRequest
    {
    }
    public class ImageUploadRequest
    {
        public string base64 { get; set; }

        public string tccode { get; set; }
    }
    public class ImageUploadResumeRequest
    {
        public string base64 { get; set; }
    }
}
