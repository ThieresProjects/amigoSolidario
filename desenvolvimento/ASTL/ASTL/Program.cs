using ASTL.Data.Providers.SqlServer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//IConfigurationRoot configuration;

//if (builder.Environment.IsEnvironment("External"))
//{
//    configuration = new ConfigurationBuilder()
//        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
//        .AddJsonFile($"appsettings.Local.json")
//        .Build();

//}
//else
//{
//    configuration = new ConfigurationBuilder()
//        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
//        .AddJsonFile($"appsettings.External.json")
//        .Build();
//}

//builder.Services.AddDbContext<Context>(options =>
//    options.UseSqlServer(configuration.GetConnectionString("BANDERA"))
//);

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
