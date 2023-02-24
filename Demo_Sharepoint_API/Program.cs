using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AuthDbContextConnection") ?? throw new InvalidOperationException("Connection string 'AuthDbContextConnection' not found.");

//builder.Services.AddDbContext<AuthDbContext>(options =>
//    options.UseSqlServer(connectionString));

//builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<AuthDbContext>();

builder.Services.AddDataProtection();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();
//app.MapGet("/username", (HttpContext ctx, IDataProtectionProvider idp) =>
//{
//    var protector = idp.CreateProtector("auth-cookie");

//    var authCookie = ctx.Request.Headers.Cookie.FirstOrDefault(x => x.StartsWith("auth"));
//    var protectedpayload = authCookie.Split("=").Last();
//    var payload = protector.Unprotect(protectedpayload);
//    var parts = payload.Split(":");
//    var key = parts[0];
//    var value = parts[1];  
//    return value;
//});

//app.MapGet("/login", (HttpContext ctx, IDataProtectionProvider idp) =>
//{
//    var protector = idp.CreateProtector("auth-cookie");
//    ctx.Response.Headers["set-cookie"] = "auth=usr:anton";
//    return "ok";
//});

app.Run();
