<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128612586/26.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4716)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Bar Generation API - Create and Display Barcodes in a Web Application

[DevExpress Barcode Generation API](https://docs.devexpress.com/OfficeFileAPI/15094/barcode-generation-api) is a cross-platform library designed to generate high-quality 1D and 2D barcodes in your .NET applications.

[Documentation](https://docs.devexpress.com/OfficeFileAPI/15094/barcode-generation-api) | [Demo]() | [Getting Started Example](https://docs.devexpress.com/OfficeFileAPI/15114/barcode-generation-api/getting-started) | [Blogs](https://community.devexpress.com/Tags/Office) | [Support](https://supportcenter.devexpress.com)

## Cross-Platform Barcode Generation

DevExpress Barcode Generation API is compatible with the following operating systems and platforms:

* Windows, Linux, macOS
* .NET 8+, .NET Framework 4.6.2+
* Azure, AWS, Docker

## Supported Symbologies
* 1D Barcodes: Codabar, Code 11 (USD-8), Code 128, Code 39 (USD-3), Code 39 Extended, Code 93, Code 93 Extended, EAN 8, EAN 13, EAN-128 (UCC), Industrial 2 of 5, Interleaved 2 of 5, Matrix 2 of 5, MSI - Plessey, PostNet, SSCC-18, UPC Supplemental 2, UPC Supplemental 5, UPC-A, UPC-E0, UPC-E1, GS1 DataBar, UPC Shipping Container Symbol (ITF-14) 
* 2D Barcodes: Aztec Code, Data Matrix (ECC200), EPC QR Code, Micro QR Code, GS1 - Data Matrix, Intelligent Mail, PDF417, QR Code, GS1 - QR Code

## Barcode Output Formats

* Image Formats: BMP, PNG, JPG, EMF, SVG
* PDF
* Print Output

## Key Features

* **Barcode Types (Symbologies)**: Generate popular 1D (EAN, UPC, Code 128) and 2D (QR Code, DataMatrix, PDF417, Aztec) barcode types. 
* **Custom Styling & Layout**: Configure module size, add text, modify colors, and adjust other visual settings. 
* **High-Fidelity Output**: Export barcodes to PNG, JPEG, SVG, or PDF with print-ready quality. 
* **Add Barcode to Documents**: Insert barcodes directly into Word, Excel, PowerPoint, and PDF documents using [DevExpress Document Processing APIs](https://docs.devexpress.com/OfficeFileAPI/14911/office-file-api). 

## Get Started

### Install the NuGet Package: DevExpress.Docs.Barcode

```dotnet add package DevExpress.Docs.Barcode```

### Create a QR Code and Save It to PNG

```csharp
using System.IO;
using DevExpress.Docs.Barcode;
using DevExpress.Drawing;

var qrOptions = new QRCodeOptions();
qrOptions.Dpi = 96;
qrOptions.ModuleSize = 2f;
qrOptions.ShowText = false;
qrOptions.CompactionMode = QRCodeCompactionMode.Byte;
qrOptions.ErrorCorrectionLevel = QRCodeErrorCorrectionLevel.Q;

using var output = new FileStream("BarCodeImage.png", FileMode.Create, FileAccess.Write);
using var generator = new BarcodeGenerator(qrOptions);
generator.Export("https://www.devexpress.com", output, DXImageFormat.Png);
```

## Licensing

DevExpress Barcode Generation API is included in the following DevExpress subscriptions: 

* [DevExpress Office File API](https://www.devexpress.com/products/net/office-file-api/) 
* [DevExpress Universal](https://www.devexpress.com/subscriptions/universal.xml) 

Free 30-day evaluation period is available. 

## Related Components/Packages

[DevExpres.Document.Processor](https://www.nuget.org/packages/DevExpress.Document.Processor) - DevExpress Document Processing APIs for Word, Excel, and PDF documents.

```
dotnet add package DevExpress.Document.Processor
```

[DevExpres.Docs.Presentation](https://www.nuget.org/packages/DevExpress.Docs.Presentation) - DevExpress Document Processing APIs for PowerPoint presentations. 

```
dotnet add package DevExpress.Docs.Presentation
```

[DevExpress.AIIntegration.Docs](https://www.nuget.org/packages/DevExpress.AIIntegration.Docs) - AI-powered Extensions for DevExpress Document Processing APIs.

```
dotnet add package DevExpress.AIIntegration.Docs
```

## Files to Review

* [BarcodeGenerationExamples.cs](/CS/BarcodeGenerationExamples.cs)
* [index.html](/CS/wwwroot/index.html)

<!-- feedback -->
## Does This Example Address Your Development Requirements/Objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=barcode-generation-library-display-a-barcode-in-a-web-application&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=barcode-generation-library-display-a-barcode-in-a-web-application&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->



