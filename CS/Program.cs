using BarcodeDemoApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.UseMiddleware<BarcodeRequestValidationMiddleware>();
app.UseStaticFiles();
app.MapControllers();

app.Run();
