namespace openbankingFase1
{
    public class PostalAddress
    {
        public string Address { get; set; }
        public string AdditionalInfo { get; set; }
        public string DistrictName { get; set; }
        public string TownName { get; set; }
        public string IbgeCode { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public GeographicCoordinates GeographicCoordinates { get; set; }

    }
}
