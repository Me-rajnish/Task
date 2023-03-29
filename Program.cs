using Microsoft.EntityFrameworkCore;
using Task2.Context;
using Task2.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var localConnectionString = builder.Configuration.GetConnectionString("localDbConnection");
builder.Services.AddDbContext<ApplicationDbContext>(u => u.UseSqlServer(localConnectionString));
builder.Services.AddScoped<IDroneRepository, DroneRepository>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=HomePage}/{id?}");

app.Run();
