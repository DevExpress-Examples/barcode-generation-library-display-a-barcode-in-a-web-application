namespace BarcodeDemoApi.Middleware;

public sealed class BarcodeRequestValidationMiddleware
{
    private readonly RequestDelegate _next;

    public BarcodeRequestValidationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if (!context.Request.Path.StartsWithSegments("/barcode", StringComparison.OrdinalIgnoreCase))
        {
            await _next(context);
            return;
        }

        var data = context.Request.Query["data"].ToString();

        if (string.IsNullOrWhiteSpace(data))
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            context.Response.ContentType = "text/plain";
            await context.Response.WriteAsync("Field 'data' is required.");
            return;
        }

        if (data.Length > 5000)
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            context.Response.ContentType = "text/plain";
            await context.Response.WriteAsync("Field 'data' is too long for this demo (max 5000 chars).");
            return;
        }

        await _next(context);
    }
}
