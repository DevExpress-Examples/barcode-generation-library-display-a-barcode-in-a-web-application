public sealed record BarcodeRequest
{
    public required string Data { get; init; }

    public bool? ShowText { get; init; }
    public string? BackColor { get; init; }
    public string? ForeColor { get; init; }
}