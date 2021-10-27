using System.Collections.Generic;

namespace openbankingFase1
{
    public class Companies
    {
        public string Name { get; set; }
        public string urlComplementaryList { get; set; }
        public List<Branches> Branches { get; set; }
    }
}
