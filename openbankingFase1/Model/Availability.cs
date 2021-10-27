using System.Collections.Generic;

namespace openbankingFase1
{
    public class Availability
    {
        public List<WeekDay> WeekDays { get; set; }
        public string Exception { get; set; }
        public string IsPublicAccessAllowed { get; set; }
    }
}
