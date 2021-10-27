using System.Collections.Generic;

namespace openbankingFase1
{
    public class Branches
    {
        public Indentification Indentification  { get; set; }
        public PostalAddress PostalAddress { get; set; }
        public Availability Availability { get; set; }
        public List<Phones> Phones { get; set; }
        public List<Services> Services { get; set; }

    }
}
