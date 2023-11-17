using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectServiceEZATU.Database.InfarResume
{
    public class infraResumeDB
    {
    }
    [Table("userpositionresume")]
    public class userpositionresumeDbContextData
    {
        public string userid { get; set; }
        public string position { get; set; }
        public string POSITIONEN { get; set; }
    }
}
