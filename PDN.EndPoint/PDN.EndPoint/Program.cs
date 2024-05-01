using Microsoft.OpenApi.Models;
using PDN.Application;
using PDN.EndPoint;
using PDN.EndPoint.MiddleWares;
using PDN.Presentation.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add DipendecyInjection Of All Projects that needs
builder.Services
    .AddInfrastructureServices(builder.Configuration)
    .AddApplicationServices()
    .AddWebApiServices();

//  Add Presentation and Controller Services
builder.Services
    .AddControllers()
    .AddApplicationPart(typeof(ProjectController).Assembly)
    .AddControllersAsServices();

// Add Swagger Default Configs
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Config MW
app.UseMiddleware<ExceptionHandlingMW>();

app.UseSwagger();

//Swagger UI Default Configs
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
