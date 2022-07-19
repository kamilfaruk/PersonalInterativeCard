using PersonalInterativeCard.Data;
using PersonalInterativeCard.MVC.Models.CardModel;
using Microsoft.EntityFrameworkCore;
using NLog;
using PersonalInterativeException.MVC.Models.ExceptionModel;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<InteractiveCardDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("PersonalInteractiveCard.Data")));
builder.Services.AddScoped<DbContext>(provider => provider.GetService<InteractiveCardDbContext>());
//builder.Services.AddScoped<ICardRepository>(provider => provider.GetService<CardRepository>());
builder.Services.AddScoped<ICardRepository, CardRepository>();
builder.Services.AddScoped<IExceptionRepository>(provider => provider.GetService<ExceptionRepository>());



var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
