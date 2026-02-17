using DevExpress.Docs.Barcode;
using DevExpress.Drawing;
public sealed record BarcodeRequest
{
    public required string Data { get; init; }

    public bool? ShowText { get; init; }
    public string? BackColor { get; init; }
    public string? ForeColor { get; init; }
    public AztecCodeErrorCorrectionLevel? AztecErrorCorrectionLevel { get; init; }
    public bool? calculateChecksum { get; init; }
    public bool? displayLogo { get; init; }
}
