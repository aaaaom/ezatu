using ProjectServiceEZATU.DTO.Request;
using System.Collections.Generic;

namespace ProjectServiceEZATU.DTO.Request.home
{
    public class MoreScreenRequest
    { 

    }
    public class MoreNisitListNameGenRequest
    {
        public string gen { get; set; }
        public string genname { get; set; }

    }
    public class MoreBoardTeacherListRequest
    {

    }
    public class MoreBoardNisitListRequest
    {
        public string gen { get; set; }
        public string studentid { get; set; }
        public string studentname { get; set; }
        public string studentlastname { get; set; }
    }
    public class MoreBoardNisitDetailRequest
    {
        public string studentcode { get; set; }
    }
    public class MoreContactUsRequest
    {
    }
    public class MoreFAQsRequest
    { 
        public string userlanguage { get; set; }
    } 
    public class MorePDPARequest
    {
        public bool usabilityscreen { get; set; }
        public string pdpaversion { get; set; }
    }
    public class NoActivityRequest
    {
    }public class MoreCourseRequest
    {
    }
    public class MoreRelatedLinksRequest
    {
    }
 public class MorePreViewResumeRequest
    {
        public string userlanguage { get; set; }
    }
    public class MorePreEditResumeRequest
    {
        public Resume resume { get; set; }
    }
    public class Resume
    {
        public bool usabilityscreen { get; set; }
        public string userlanguage { get; set; }
    }
}
