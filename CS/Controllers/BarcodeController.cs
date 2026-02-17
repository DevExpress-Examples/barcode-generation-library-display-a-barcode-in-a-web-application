using System.Drawing;
using BarcodeWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BarcodeWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BarcodeController : ControllerBase
{
    [HttpGet("/")]
    public IActionResult Index()
    {
        var file = Path.Combine(AppContext.BaseDirectory, "wwwroot", "index.html");
        if (!System.IO.File.Exists(file))
            return NotFound("index.html not found");
        return PhysicalFile(file, "text/html; charset=utf-8");
    }

    [HttpGet("{symbology}")]
    public IActionResult Generate([ModelBinder(typeof(BarcodeSymbologyModelBinder))] BarcodeSymbology symbology, 
        [FromQuery] BarcodeRequest req)
    {
        if (!ValidateRequest(req, out var errorResult))
            return errorResult;

        var backColor = ColorHelper.GetColor(req.BackColor, Color.White);
        var foreColor = ColorHelper.GetColor(req.ForeColor, Color.Black);
        var showText = req.ShowText ?? false;

        byte[] barcodeImage = symbology switch
        {
            // 2D Barcodes
            BarcodeSymbology.Aztec => BarcodeGenerationExamples.GenerateAztec(
                req.Data, backColor, foreColor, showText, req.AztecErrorCorrectionLevel),
            
            BarcodeSymbology.QrCode => BarcodeGenerationExamples.GenerateQrCode(
                req.Data, backColor, foreColor, showText, req.displayLogo ?? false),
            
            BarcodeSymbology.MicroQrCode => BarcodeGenerationExamples.GenerateMicroQrCode(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.QrCodeGS1 => BarcodeGenerationExamples.GenerateQrCodeGS1(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.DataMatrixECC200 => BarcodeGenerationExamples.GenerateDataMatrixECC200(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.DataMatrixGS1 => BarcodeGenerationExamples.GenerateDataMatrixGS1(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.PDF417 => BarcodeGenerationExamples.GeneratePDF417(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.IntelligentMail => BarcodeGenerationExamples.GenerateIntelligentMail(
                req.Data, backColor, foreColor, showText),
            
            // 1D Barcodes
            BarcodeSymbology.Codabar => BarcodeGenerationExamples.GenerateCodabar(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.Code11 => BarcodeGenerationExamples.GenerateCode11(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.Code128 => BarcodeGenerationExamples.GenerateCode128(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.GS1_128 => BarcodeGenerationExamples.GenerateGS1128(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.Code39 => BarcodeGenerationExamples.GenerateCode39(
                req.Data, backColor, foreColor, showText, req.calculateChecksum),
            
            BarcodeSymbology.Code39Extended => BarcodeGenerationExamples.GenerateCode39Extended(
                req.Data, backColor, foreColor, showText, req.calculateChecksum),
            
            BarcodeSymbology.Code93 => BarcodeGenerationExamples.GenerateCode93(
                req.Data, backColor, foreColor, showText, req.calculateChecksum),
            
            BarcodeSymbology.Code93Extended => BarcodeGenerationExamples.GenerateCode93Extended(
                req.Data, backColor, foreColor, showText, req.calculateChecksum),
            
            BarcodeSymbology.DeutschePostLeitcode => BarcodeGenerationExamples.GenerateDeutschePostLeitcode(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.DeutschePostIdentcode => BarcodeGenerationExamples.GenerateDeutschePostIdentcode(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.EAN8 => BarcodeGenerationExamples.GenerateEAN8(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.EAN13 => BarcodeGenerationExamples.GenerateEAN13(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.GS1DataBar => BarcodeGenerationExamples.GenerateGS1DataBar(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.Industrial2of5 => BarcodeGenerationExamples.GenerateIndustrial2of5(
                req.Data, backColor, foreColor, showText, req.calculateChecksum),
            
            BarcodeSymbology.Interleaved2of5 => BarcodeGenerationExamples.GenerateInterleaved2of5(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.Matrix2of5 => BarcodeGenerationExamples.GenerateMatrix2of5(
                req.Data, backColor, foreColor, showText, req.calculateChecksum),
            
            BarcodeSymbology.MSIPlessey => BarcodeGenerationExamples.GenerateMSI(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.Pharmacode => BarcodeGenerationExamples.GeneratePharmacode(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.PostNet => BarcodeGenerationExamples.GeneratePostNet(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.IntelligentMailPackage => BarcodeGenerationExamples.GenerateIntelligentMailPackage(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.SSCC18 => BarcodeGenerationExamples.GenerateSSCC18(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.ITF14 => BarcodeGenerationExamples.GenerateITF14(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.UPCSupplemental2 => BarcodeGenerationExamples.GenerateUPCSupplemental2(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.UPCSupplemental5 => BarcodeGenerationExamples.GenerateUPCSupplemental5(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.UPCA => BarcodeGenerationExamples.GenerateUPCA(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.UPCE0 => BarcodeGenerationExamples.GenerateUPCE0(
                req.Data, backColor, foreColor, showText),
            
            BarcodeSymbology.UPCE1 => BarcodeGenerationExamples.GenerateUPCE1(
                req.Data, backColor, foreColor, showText),
            
            _ => throw new ArgumentOutOfRangeException(nameof(symbology), symbology, "Unsupported symbology type.")
        };

        return File(barcodeImage, "image/png");
    }
    [HttpGet("snippet/{symbology}")]
    public IActionResult GetCodeSnippet([ModelBinder(typeof(BarcodeSymbologyModelBinder))] BarcodeSymbology symbology)
    {
        var methodName = symbology switch
        {
            BarcodeSymbology.Aztec => "GenerateAztec",
            BarcodeSymbology.QrCode => "GenerateQrCode",
            BarcodeSymbology.MicroQrCode => "GenerateMicroQrCode",
            BarcodeSymbology.QrCodeGS1 => "GenerateQrCodeGS1",
            BarcodeSymbology.DataMatrixECC200 => "GenerateDataMatrixECC200",
            BarcodeSymbology.DataMatrixGS1 => "GenerateDataMatrixGS1",
            BarcodeSymbology.PDF417 => "GeneratePDF417",
            BarcodeSymbology.IntelligentMail => "GenerateIntelligentMail",
            BarcodeSymbology.Codabar => "GenerateCodabar",
            BarcodeSymbology.Code11 => "GenerateCode11",
            BarcodeSymbology.Code128 => "GenerateCode128",
            BarcodeSymbology.GS1_128 => "GenerateGS1128",
            BarcodeSymbology.Code39 => "GenerateCode39",
            BarcodeSymbology.Code39Extended => "GenerateCode39Extended",
            BarcodeSymbology.Code93 => "GenerateCode93",
            BarcodeSymbology.Code93Extended => "GenerateCode93Extended",
            BarcodeSymbology.DeutschePostLeitcode => "GenerateDeutschePostLeitcode",
            BarcodeSymbology.DeutschePostIdentcode => "GenerateDeutschePostIdentcode",
            BarcodeSymbology.EAN8 => "GenerateEAN8",
            BarcodeSymbology.EAN13 => "GenerateEAN13",
            BarcodeSymbology.GS1DataBar => "GenerateGS1DataBar",
            BarcodeSymbology.Industrial2of5 => "GenerateIndustrial2of5",
            BarcodeSymbology.Interleaved2of5 => "GenerateInterleaved2of5",
            BarcodeSymbology.Matrix2of5 => "GenerateMatrix2of5",
            BarcodeSymbology.MSIPlessey => "GenerateMSI",
            BarcodeSymbology.Pharmacode => "GeneratePharmacode",
            BarcodeSymbology.PostNet => "GeneratePostNet",
            BarcodeSymbology.IntelligentMailPackage => "GenerateIntelligentMailPackage",
            BarcodeSymbology.SSCC18 => "GenerateSSCC18",
            BarcodeSymbology.ITF14 => "GenerateITF14",
            BarcodeSymbology.UPCSupplemental2 => "GenerateUPCSupplemental2",
            BarcodeSymbology.UPCSupplemental5 => "GenerateUPCSupplemental5",
            BarcodeSymbology.UPCA => "GenerateUPCA",
            BarcodeSymbology.UPCE0 => "GenerateUPCE0",
            BarcodeSymbology.UPCE1 => "GenerateUPCE1",
            _ => null
        };

        if (methodName == null)
            return NotFound("No code snippet available for this symbology.");

        var filePath = Path.Combine(AppContext.BaseDirectory, "", "BarcodeGenerationExamples.cs");
        if (!System.IO.File.Exists(filePath))
            return NotFound("BarcodeGenerationExamples.cs not found.");

        var code = GetMethodCode(filePath, methodName);
        if (string.IsNullOrWhiteSpace(code))
            return NotFound("Code snippet not found.");

        return Content(code, "text/plain");
    }

    // Helper to extract method code by name (simple version)
    private static string GetMethodCode(string filePath, string methodName)
    {
        var lines = System.IO.File.ReadAllLines(filePath);
        var start = Array.FindIndex(lines, l => l.Contains($" {methodName}(") || l.Contains($" {methodName} "));
        if (start == -1) return string.Empty;

        var codeLines = new List<string>();
        int braceCount = 0;
        bool started = false;
        for (int i = start; i < lines.Length; i++)
        {
            var line = lines[i];
            if (!started)
            {
                codeLines.Add(line);
                if (line.Contains("{"))
                {
                    started = true;
                    braceCount = line.Count(c => c == '{') - line.Count(c => c == '}');
                }
            }
            else
            {
                codeLines.Add(line);
                braceCount += line.Count(c => c == '{') - line.Count(c => c == '}');
                if (braceCount == 0)
                    break;
            }
        }
        return string.Join(System.Environment.NewLine, codeLines);
    }
    private bool ValidateRequest(BarcodeRequest req, out IActionResult errorResult)
    {
        if (string.IsNullOrWhiteSpace(req.Data))
        {
            errorResult = BadRequest("Field 'data' is required.");
            return false;
        }

        if (req.Data.Length > 5000)
        {
            errorResult = BadRequest("Field 'data' is too long for this demo (max 5000 chars).");
            return false;
        }

        errorResult = null!;
        return true;
    }
}
