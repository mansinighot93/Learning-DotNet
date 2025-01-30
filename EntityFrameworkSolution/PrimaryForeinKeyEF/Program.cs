using Core.Repositories;
using Core.Repositories.Interfaces;
using Core.Services;
using Core.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IDepartmentRepository,DepartmentRepository>();
builder.Services.AddTransient<IEmployeeRepository,EmployeeRepository>();
builder.Services.AddTransient<IDepartmentService,DepartmentService>();
builder.Services.AddTransient<IEmployeeService,EmployeeService>();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
