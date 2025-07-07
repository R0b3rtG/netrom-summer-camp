using BlazorApp1.Components;
using BlazorApp1.Context;
using BlazorApp1.Repositories.Interfaces;
using Blazorise;
using Blazorise.Bootstrap5;
using Microsoft.Extensions.FileProviders;
using Blazorise.Icons.FontAwesome;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.Repositories.Implementation;
using BlazorApp1.Components.Account;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using BlazorApp1.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
	    options.DefaultScheme = IdentityConstants.ApplicationScheme;
	    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
	.AddIdentityCookies();

builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBootstrap5Providers()
    .AddFontAwesomeIcons();

builder.Services.AddDbContext<ShowTimeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnectionString")));

builder.Services.AddScoped<IRepositoryBand, RepositoryBand>();
builder.Services.AddScoped<IRepositoryFestival, RepositoryFestival>();
builder.Services.AddScoped<IRepositoryBooking, RepositoryBooking>();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole<Guid>>()
    .AddEntityFrameworkStores<ShowTimeContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();


builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
builder.Services.AddAuthenticationCore();

builder.Services.AddAntiforgery();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

//app.UseStaticFiles(new StaticFileOptions
//{
//	FileProvider = new PhysicalFileProvider(
//		   Path.Combine(builder.Environment.ContentRootPath, "img")),
//	RequestPath = "/img"
//});

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
app.MapAdditionalIdentityEndpoints();
app.Run();

