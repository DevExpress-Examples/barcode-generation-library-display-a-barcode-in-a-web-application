<!-- default file list -->
*Files to look at*:

* [BarCodeHandler.ashx](./CS/WebSite/BarCodeHandler.ashx) (VB: [BarCodeHandler.ashx](./VB/WebSite/BarCodeHandler.ashx))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to create and display a BarCode in a web application
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4716/)**
<!-- run online end -->


<p>This example illustrates how you can use our <a href="https://documentation.devexpress.com/OfficeFileAPI/15094/Barcode-Generation-API">Barcode Generation API</a> in ASP.NET to generate and display a barcode image on the webpage. The best approach implies creating a custom HTTP Handler that will generate and output an image. Here is a code of this handler:</p>

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

<p>The <strong>im</strong><strong>g </strong>tag in the main aspx page is defined as follows:</p>

```aspx
<img src="BarCodeHandler.ashx" alt="QRCode" width="200px" height="200px" />
```

<p><strong>See Also:</strong></p>
<p><a href="http://www.codeproject.com/Tips/577385/HTTP-handler-for-image">HTTP-handler for image</a></p>
<p>The<strong> Universal Subscription</strong> or an additional <strong>Office File API Subscription</strong> is required to use this example in production code. Please refer to the <a href="https://www.devexpress.com/Buy/NET/">DevExpress Subscription</a> page for pricing information.</p>
