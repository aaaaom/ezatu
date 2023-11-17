namespace ProjectServiceEZATU.DTO.Response.Function
{
    public class FunctionSreenResponse
    {
        internal string message { get; set; }
        internal int status { get; set; }
        public string langeuage { get; set; }
        public string texttitle { get; set; }
        public string textsubtitle { get; set; }
        public string textresume { get; set; }
        public string textsetting { get; set; }
        public string textcalendar { get; set; }
        public string textscanner { get; set; }
        public string role { get; set; }
    }

    public class QRScreenResponse
    {
        internal string message { get; set; }
        internal int status { get; set; }
        public string langeuage { get; set;}
        public string texttitle { get; set; }
        public string textdetailqr { get; set; }
    }
}
