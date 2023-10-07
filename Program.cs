

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateSearch.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// var connectionString = builder.Configuration.GetConnectionString("Mssql");
// builder.Services.AddDbContext<EstateContext>(options => options.UseSqlServer(connectionString));
var connectionString = builder.Configuration.GetConnectionString("Sqlite");
builder.Services.AddDbContext<EstateContext>(options => options.UseSqlite(connectionString));


var app = builder.Build();

using var scope = app.Services.CreateScope();
var dbContext = scope.ServiceProvider.GetRequiredService<EstateContext>();
dbContext.Database.Migrate();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/estate", async (EstateContext db,
    [FromQuery] int? minPrice,
    [FromQuery] int? maxPrice,
    [FromQuery] string? search,
    [FromQuery] int? minSize,
    [FromQuery] int? maxRooms,
    [FromQuery] int? minFloor,
    [FromQuery] int? maxYear,
    [FromQuery] Guid? districtId,
    [FromQuery] Guid? estateTypeId) =>
{
    var query = db.Estate
           .Include(estate => estate.EstateType)
           .Include(estate => estate.Images)
           .Include(estate => estate.District)
#nullable disable
           .ThenInclude(district => district.City)
           .AsQueryable();

    if (minPrice.HasValue)
    {
        query = query.Where(estate => estate.Price >= minPrice.Value);
    }

    if (maxPrice.HasValue)
    {
        query = query.Where(estate => estate.Price <= maxPrice.Value);
    }

    if (!string.IsNullOrEmpty(search))
    {
        query = query.Where(estate =>
            estate.Description.Contains(search) || estate.Title.Contains(search));
    }

    if (minSize.HasValue)
    {
        query = query.Where(estate => estate.Size >= minSize.Value);
    }

    if (maxRooms.HasValue)
    {
        query = query.Where(estate => estate.Rooms <= maxRooms.Value);
    }

    if (minFloor.HasValue)
    {
        query = query.Where(estate => estate.Floor >= minFloor.Value);
    }

    if (maxYear.HasValue)
    {
        query = query.Where(estate => estate.Year <= maxYear.Value);
    }

    if (districtId.HasValue)
    {
        query = query.Where(estate => estate.DistrictId == districtId.Value);
    }

    if (estateTypeId.HasValue)
    {
        query = query.Where(estate => estate.EstateTypeId == estateTypeId.Value);
    }
    query = query.OrderBy(estate => estate.Id);

    return await query.ToListAsync();
});
app.Run();
