
namespace RealEstateSearch.Models
{
    public class Estate
    {
        public Guid Id { get; set; }
        public int Price { get; set; }
        public required string Description { get; set; }
        public required string Title { get; set; }
        public int Size { get; set; }
        public int Rooms { get; set; }
        public int Floor { get; set; }
        public int Year { get; set; }
        public List<Image>? Images { get; set; }
        
        public District? District { get; set; }
        public Guid DistrictId { get; set; }
        public EstateType? EstateType { get; set; }
        public Guid EstateTypeId { get; set; }
    }
}
