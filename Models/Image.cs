using System.Text.Json.Serialization;

namespace RealEstateSearch.Models
{
    public class Image
    {
        public Guid Id { get; set; }
        public required string Url { get; set; }

        [JsonIgnore]
        public Estate? Estate { get; set; }
        public Guid EstateId { get; set; }
    }
}
