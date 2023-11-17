namespace ProjectServiceEZATU.DTO.Response
{
    public class ResponseBaseHeader
    {
        public int status { get; set; }
        public string message { get; set; }
        public string Modulename { get; set; }
        public bool timeexpire { get; set; }

    }
    public class ResponseBase
    {
        public ResponseBaseHeader head { get; set; }
        public object body { get; set; }

    }
/*    public class Responsedata 
    { 
    }*/
}
