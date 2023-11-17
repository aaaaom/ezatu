namespace ProjectServiceEZATU.DTO.Request.login
{
    public class LogSessionsRequest
    {
        public int id { get; set; }
        public string sessions { get; set; }
        public string userid { get; set; }
        public string phone { get; set; }
        public string phoneversionos { get; set; }
        public string operatingsystem { get; set; }
        public string screenresolution { get; set; }
        public string appversion { get; set; }
        public string packagename { get; set; }
        public bool option { get; set; }

    }
}
