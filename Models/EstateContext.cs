using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace RealEstateSearch.Models
{
    public class EstateContext : DbContext
    {
        public EstateContext(DbContextOptions<EstateContext> options)
            : base(options)
        {
        }

        public DbSet<Estate> Estate { get; set; }

        public DbSet<City> City { get; set; }

        public DbSet<District> District { get; set; }

        public DbSet<EstateType> EstateType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var estateType1 = new EstateType
            {
                Id = Guid.NewGuid(),
                Name = "Satılık"
            };

            var estateType2 = new EstateType
            {
                Id = Guid.NewGuid(),
                Name = "Kiralık"
            };

            var city1 = new City
            {
                Id = Guid.NewGuid(),
                Name = "İstanbul"
            };

            var city2 = new City
            {
                Id = Guid.NewGuid(),
                Name = "Ankara"
            };

            var city3 = new City
            {
                Id = Guid.NewGuid(),
                Name = "İzmir"
            };

            var district1 = new District
            {
                Id = Guid.NewGuid(),
                Name = "Kadıköy",
                CityId = city1.Id
            };

            var district2 = new District
            {
                Id = Guid.NewGuid(),
                Name = "Beşiktaş",
                CityId = city1.Id
            };

            var district3 = new District
            {
                Id = Guid.NewGuid(),
                Name = "Çankaya",
                CityId = city2.Id
            };

            var district4 = new District
            {
                Id = Guid.NewGuid(),
                Name = "Keçiören",
                CityId = city2.Id
            };

            var district5 = new District
            {
                Id = Guid.NewGuid(),
                Name = "Bornova",
                CityId = city3.Id
            };

            var district6 = new District
            {
                Id = Guid.NewGuid(),
                Name = "Çiğli",
                CityId = city3.Id
            };

            var estateTypeList = new List<EstateType>
            {
                estateType1,
                estateType2
            };

            var districtList = new List<District>
            {
                district1,
                district2,
                district3,
                district4,
                district5,
                district6
            };

            var estateList = new List<Estate>();
            var imageList = new List<Image>();

            for (var i = 0; i < 24; i++)
            {
                var estate = new Estate
                {
                    Id = Guid.NewGuid(),
                    Description = "Açıklama " + i,
                    DistrictId = districtList[RandomNumberGenerator.GetInt32(0, districtList.Count)].Id,
                    EstateTypeId = estateTypeList[RandomNumberGenerator.GetInt32(0, estateTypeList.Count)].Id,
                    Floor = i,
                    Price = i + 1 * 100000,
                    Rooms = i + 1,
                    Size = i + 1 * 100,
                    Title = "Emlak " + i,
                    Year = 2010 + i
                };

                estateList.Add(estate);
            }

            foreach (var estate in estateList)
            {
                var image = new Image
                {
                    Id = Guid.NewGuid(),
                    EstateId = estate.Id,
                    Url = "https://placehold.co/300x200"
                };

                var image2 = new Image
                {
                    Id = Guid.NewGuid(),
                    EstateId = estate.Id,
                    Url = "https://placehold.co/600x400"
                };

                imageList.Add(image);
                imageList.Add(image2);

            }

            modelBuilder.Entity<City>().HasData(city1, city2, city3);
            modelBuilder.Entity<EstateType>().HasData(estateTypeList);
            modelBuilder.Entity<District>().HasData(districtList);
            modelBuilder.Entity<Image>().HasData(imageList);
            modelBuilder.Entity<Estate>().HasData(estateList);

            base.OnModelCreating(modelBuilder);

        }
    }

}
