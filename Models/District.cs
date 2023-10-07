namespace RealEstateSearch.Models
{
    public class District
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public City? City { get; set; }
        public Guid CityId { get; set; }

    }
}
