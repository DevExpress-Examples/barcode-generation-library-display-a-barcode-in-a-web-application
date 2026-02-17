using BarcodeWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllers();

app.Run();app.Run();