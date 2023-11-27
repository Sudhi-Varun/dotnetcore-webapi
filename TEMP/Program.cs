using project1.ServiceContracts;
using project1.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); //adds all the controller classes as services

builder.Services.AddScoped<IMyDependency, MyDependency>();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllers();

app.Run();