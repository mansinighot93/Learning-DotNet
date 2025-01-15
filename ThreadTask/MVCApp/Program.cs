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

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

//Custom Routes
app.MapControllerRoute(
    name: "CropDetails",
    pattern: "farms/{farmName}/greenhouse/{unitNo}/crop/{cropName}",
    defaults: new {controller = "Farms",action = "CropDetails"}
    );

app.MapControllerRoute(
    name: "GreenhouseDetails",
    pattern: "farms/{farmName}/greenhouse/{unitNo}",
    defaults: new {controller = "Farms", action = "GreenhouseDetails"}
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
