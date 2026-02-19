using System.Drawing;
using DevExpress.Docs.Barcode;
using DevExpress.Drawing;
using Microsoft.AspNetCore.Mvc;

namespace BarcodeDemoApi.Controllers;

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

    [HttpGet("aztec")]
    public IActionResult Aztec([FromQuery] BarcodeRequest req)
    {
        var options = new AztecCodeOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("qr")]
    public IActionResult QrCode([FromQuery] BarcodeRequest req)
    {
        var options = new QRCodeOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("micro-qr")]
    public IActionResult MicroQrCode([FromQuery] BarcodeRequest req)
    {
        var options = new MicroQRCodeOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("gs1-qr")]
    public IActionResult QrCodeGS1([FromQuery] BarcodeRequest req)
    {
        var options = new QRCodeGS1Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("datamatrix-ecc200")]
    public IActionResult DataMatrixECC200([FromQuery] BarcodeRequest req)
    {
        var options = new DataMatrixOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("gs1-datamatrix")]
    public IActionResult DataMatrixGS1([FromQuery] BarcodeRequest req)
    {
        var options = new DataMatrixGS1Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("pdf417")]
    public IActionResult PDF417([FromQuery] BarcodeRequest req)
    {
        var options = new PDF417Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("intelligent-mail")]
    public IActionResult IntelligentMail([FromQuery] BarcodeRequest req)
    {
        var options = new IntelligentMailOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("codabar")]
    public IActionResult Codabar([FromQuery] BarcodeRequest req)
    {
        var options = new CodabarOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("code11")]
    public IActionResult Code11([FromQuery] BarcodeRequest req)
    {
        var options = new Code11Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("code128")]
    public IActionResult Code128([FromQuery] BarcodeRequest req)
    {
        var options = new Code128Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("gs1-128")]
    public IActionResult GS1128([FromQuery] BarcodeRequest req)
    {
        var options = new EAN128Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("code39")]
    public IActionResult Code39([FromQuery] BarcodeRequest req)
    {
        var options = new Code39Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("code39-extended")]
    public IActionResult Code39Extended([FromQuery] BarcodeRequest req)
    {
        var options = new Code39ExtendedOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("code93")]
    public IActionResult Code93([FromQuery] BarcodeRequest req)
    {
        var options = new Code93Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("code93-extended")]
    public IActionResult Code93Extended([FromQuery] BarcodeRequest req)
    {
        var options = new Code93ExtendedOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("deutsche-post-leitcode")]
    public IActionResult DeutschePostLeitcode([FromQuery] BarcodeRequest req)
    {
        var options = new DeutschePostLeitcodeOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("deutsche-post-identcode")]
    public IActionResult DeutschePostIdentcode([FromQuery] BarcodeRequest req)
    {
        var options = new DeutschePostIdentcodeOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("ean8")]
    public IActionResult EAN8([FromQuery] BarcodeRequest req)
    {
        var options = new EAN8Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("ean13")]
    public IActionResult EAN13([FromQuery] BarcodeRequest req)
    {
        var options = new EAN13Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("gs1-databar")]
    public IActionResult GS1DataBar([FromQuery] BarcodeRequest req)
    {
        var options = new DataBarOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("industrial-2of5")]
    public IActionResult Industrial2of5([FromQuery] BarcodeRequest req)
    {
        var options = new Industrial2of5Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("interleaved-2of5")]
    public IActionResult Interleaved2of5([FromQuery] BarcodeRequest req)
    {
        var options = new Interleaved2of5Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("matrix-2of5")]
    public IActionResult Matrix2of5([FromQuery] BarcodeRequest req)
    {
        var options = new Matrix2of5Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("msi-plessey")]
    public IActionResult MSI([FromQuery] BarcodeRequest req)
    {
        var options = new CodeMSIOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("pharmacode")]
    public IActionResult Pharmacode([FromQuery] BarcodeRequest req)
    {
        var options = new PharmacodeOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("postnet")]
    public IActionResult PostNet([FromQuery] BarcodeRequest req)
    {
        var options = new PostNetOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("intelligent-mail-package")]
    public IActionResult IntelligentMailPackage([FromQuery] BarcodeRequest req)
    {
        var options = new IntelligentMailPackageOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("sscc18")]
    public IActionResult SSCC18([FromQuery] BarcodeRequest req)
    {
        var options = new SSCCOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("itf14")]
    public IActionResult ITF14([FromQuery] BarcodeRequest req)
    {
        var options = new ITF14Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("upc-supplemental2")]
    public IActionResult UPCSupplemental2([FromQuery] BarcodeRequest req)
    {
        var options = new UPCSupplemental2Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("upc-supplemental5")]
    public IActionResult UPCSupplemental5([FromQuery] BarcodeRequest req)
    {
        var options = new UPCSupplemental5Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("upca")]
    public IActionResult UPCA([FromQuery] BarcodeRequest req)
    {
        var options = new UPCAOptions
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("upce0")]
    public IActionResult UPCE0([FromQuery] BarcodeRequest req)
    {
        var options = new UPCE0Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }

    [HttpGet("upce1")]
    public IActionResult UPCE1([FromQuery] BarcodeRequest req)
    {
        var options = new UPCE1Options
        {
            BackColor = ColorHelper.GetColor(req.BackColor, Color.White),
            ForeColor = ColorHelper.GetColor(req.ForeColor, Color.Black),
            ShowText = req.ShowText ?? false
        };

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(req.Data, ms, DXImageFormat.Png);
        return File(ms.ToArray(), "image/png");
    }
}
