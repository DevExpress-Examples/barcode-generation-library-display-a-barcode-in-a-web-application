<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128612586/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4716)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# How to create and display a BarCode in a web application

## Overview

> **Note:**
>The **Universal Subscription** or an additional **Office File API Subscription** is required to use this example in production code. Please refer to the <a href="https://www.devexpress.com/Buy/NET/">DevExpress Subscription</a> page for pricing information.

This example illustrates how you can use our [Barcode Generation API](https://docs.devexpress.com/OfficeFileAPI/15094/Barcode-Generation-API) in ASP.NET to generate and display a barcode image on the webpage. The best approach implies creating a custom HTTP handler that generates and outputs an image. Here is a code of this handler:

```cs
public class BarCodeHandler : IHttpHandler {
    public void ProcessRequest(HttpContext context) {
        BarCode barCode = new BarCode();

        barCode.Symbology = Symbology.QRCode;
        barCode.CodeText = "123";

        context.Response.ContentType = "image/png";
        barCode.Save(context.Response.OutputStream, ImageFormat.Png);
        context.Response.End();
    }

    public bool IsReusable {
        get {
            return false;
        }
    }
}
```

## Files to Review

* [BarCodeHandler.ashx](./CS/WebSite/BarCodeHandler.ashx) (VB: [BarCodeHandler.ashx](./VB/WebSite/BarCodeHandler.ashx))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=barcode-generation-library-display-a-barcode-in-a-web-application&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=barcode-generation-library-display-a-barcode-in-a-web-application&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

