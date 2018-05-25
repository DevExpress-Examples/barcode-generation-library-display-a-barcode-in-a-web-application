# How to create and display a BarCode in a web application


<p>This example illustrates how you can use our new <a href="http://help.devexpress.com/#DocumentServer/CustomDocument15094">Barcode Generation API</a> in ASP.NET to generate and display a barcode image on the webpage. The best approach implies creating a custom HTTP Handler that will generate and output an image. Here is a code of this handler:</p>
<p> </p>


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


<p> </p>
<p>The <strong>im</strong><strong>g </strong>tag in the main aspx page is defined as follows:</p>
<p> </p>


```aspx
<img src="BarCodeHandler.ashx" alt="QRCode" width="200px" height="200px" />
```


<p> </p>
<p><strong>See Also:</strong></p>
<p><a href="http://www.codeproject.com/Tips/577385/HTTP-handler-for-image">HTTP-handler for image</a><br><br>The<strong> Universal Subscription</strong> or an additional <strong>Document Server Subscription</strong> is required to use this example in production code. Please refer to the <a href="http://www.devexpress.com/Subscriptions/">DevExpress Subscription</a> page for pricing information.</p>

<br/>


