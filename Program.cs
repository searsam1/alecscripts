var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
app.MapRazorPages();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// =====================================
// using Microsoft.AspNetCore.Identity;
// using Microsoft.EntityFrameworkCore;
// using MvcAlecScripts.Areas.Identity.Data;
// var builder = WebApplication.CreateBuilder(args);
// var connectionString = builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING");
//     builder.Services.AddDbContext<MvcAlecScriptsIdentityDbContext>(options =>
//         options.UseSqlServer(connectionString));
        
//         builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//             .AddEntityFrameworkStores<MvcAlecScriptsIdentityDbContext>();
// var services = builder.Services;
// var configuration = builder.Configuration;

// services.AddAuthentication().AddGoogle(googleOptions =>
//     {
//         googleOptions.ClientId = configuration["Authentication:Google:ClientId"];
//         googleOptions.ClientSecret = configuration["Authentication:Google:ClientSecret"];
//     });
// // Add services to the container.
// builder.Services.AddControllersWithViews();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Home/Error");
//     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//     app.UseHsts();
// }

// app.UseHttpsRedirection();
// app.UseStaticFiles();

// app.UseRouting();
// app.UseAuthentication();
// app.UseAuthorization();
// app.MapRazorPages();
// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");

// app.Run();
