var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSignalR(); // Added by me!
builder.Services.AddControllers(); // Added by me!
builder.Services.AddRazorPages(); // Added by me!
builder.Services.AddEndpointsApiExplorer(); // Added by me!
builder.Services.AddMemoryCache(); // Added by me!
builder.Configuration.AddIniFile("appsettings.ini"); // Added by me!
builder.Logging.AddJsonConsole(); // Added by me!
builder.WebHost.UseWebRoot("root"); // Added by me!

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

app.MapRazorPages(); // Added by me!
app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()); // Added by me!

app.Run();
