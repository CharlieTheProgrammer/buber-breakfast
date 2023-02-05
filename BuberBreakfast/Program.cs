using BuberBreakfast.Persistence;
using BuberBreakfast.Services.Breakfasts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddScoped<IBreakfastService, BreakfastService>();
    builder.Services.AddDbContext<BuberBreakfastDbContext>(options =>
        options.UseSqlite("Data Source=BuberBreakfast.db"));
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}