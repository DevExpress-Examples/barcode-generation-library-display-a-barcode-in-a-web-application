using System.Drawing;
using DevExpress.Docs.Barcode;
using DevExpress.Drawing;

namespace BarcodeWebApi;

public class BarcodeGenerationExamples
{
    // 2D Barcodes

    public static byte[] GenerateAztec(string data, Color backColor, Color foreColor, bool showText,
        AztecCodeErrorCorrectionLevel? errorCorrectionLevel = null)
    {
        var options = new AztecCodeOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        if (errorCorrectionLevel.HasValue)
            options.ErrorCorrectionLevel = errorCorrectionLevel.Value;

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateQrCode(string data, Color backColor, Color foreColor, bool showText,
        bool displayLogo = false)
    {
        var options = new QRCodeOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        if (displayLogo) {
            using var fileStream = new FileStream("logo.png", FileMode.Open);
            options.Logo = DXImage.FromStream(fileStream);
            options.ModuleSize = 40;
            options.ErrorCorrectionLevel = QRCodeErrorCorrectionLevel.L;
        }

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateMicroQrCode(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new MicroQRCodeOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateQrCodeGS1(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new QRCodeGS1Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateDataMatrixECC200(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new DataMatrixOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateDataMatrixGS1(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new DataMatrixGS1Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GeneratePDF417(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new PDF417Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateIntelligentMail(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new IntelligentMailOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    // 1D Barcodes

    public static byte[] GenerateCodabar(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new CodabarOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateCode11(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new Code11Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateCode128(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new Code128Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateGS1128(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new EAN128Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateCode39(string data, Color backColor, Color foreColor, bool showText,
        bool? calculateChecksum = null)
    {
        var options = new Code39Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        if (calculateChecksum.HasValue)
            options.CalculateChecksum = calculateChecksum.Value;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateCode39Extended(string data, Color backColor, Color foreColor, bool showText,
        bool? calculateChecksum = null)
    {
        var options = new Code39ExtendedOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        if (calculateChecksum.HasValue)
            options.CalculateChecksum = calculateChecksum.Value;

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateCode93(string data, Color backColor, Color foreColor, bool showText,
        bool? calculateChecksum = null)
    {
        var options = new Code93Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        if (calculateChecksum.HasValue)
            options.CalculateChecksum = calculateChecksum.Value;

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateCode93Extended(string data, Color backColor, Color foreColor, bool showText,
        bool? calculateChecksum = null)
    {
        var options = new Code93ExtendedOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        if (calculateChecksum.HasValue)
            options.CalculateChecksum = calculateChecksum.Value;

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateDeutschePostLeitcode(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new DeutschePostLeitcodeOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateDeutschePostIdentcode(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new DeutschePostIdentcodeOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateEAN8(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new EAN8Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateEAN13(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new EAN13Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateGS1DataBar(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new DataBarOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateIndustrial2of5(string data, Color backColor, Color foreColor, bool showText,
        bool? calculateChecksum = null)
    {
        var options = new Industrial2of5Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        if (calculateChecksum.HasValue)
            options.CalculateChecksum = calculateChecksum.Value;

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateInterleaved2of5(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new Interleaved2of5Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateMatrix2of5(string data, Color backColor, Color foreColor, bool showText,
        bool? calculateChecksum = null)
    {
        var options = new Matrix2of5Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        if (calculateChecksum.HasValue)
            options.CalculateChecksum = calculateChecksum.Value;

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateMSI(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new CodeMSIOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GeneratePharmacode(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new PharmacodeOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GeneratePostNet(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new PostNetOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateIntelligentMailPackage(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new IntelligentMailPackageOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateSSCC18(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new SSCCOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateITF14(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new ITF14Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateUPCSupplemental2(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new UPCSupplemental2Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateUPCSupplemental5(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new UPCSupplemental5Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateUPCA(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new UPCAOptions();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateUPCE0(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new UPCE0Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }

    public static byte[] GenerateUPCE1(string data, Color backColor, Color foreColor, bool showText)
    {
        var options = new UPCE1Options();
        options.BackColor = backColor;
            options.ForeColor = foreColor;
            options.ShowText = showText;
        

        using var ms = new MemoryStream();
        using var generator = new BarcodeGenerator(options);
        generator.Export(data, ms, DXImageFormat.Png);
        return ms.ToArray();
    }
}
