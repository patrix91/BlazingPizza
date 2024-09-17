using Microsoft.EntityFrameworkCore;
using Pizza.WisniewskiStudio.Us³ugi;
using Pizza.WisniewskiStudio.Dane;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddHttpClient();

builder.Services.AddDbContext<PizzaStoreContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<OrderState>();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
var logger = app.Services.GetService<ILogger<Program>>();



using (var scope = scopeFactory.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = scope.ServiceProvider.GetRequiredService<PizzaStoreContext>();

    try
    {
        await context.Database.MigrateAsync();
        await SeedData.SeedAsync(context);
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "b³¹d podczas migracji danych");
    }
    //if (db.Database.EnsureCreated())
    //{
    //    SeedData.Initialize(db);
    //}
}

app.Run();