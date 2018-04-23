<%@ WebHandler Language="C#" Class="BarCodeHandler" %>

using System;
using System.Web;
using System.Drawing.Imaging;
using DevExpress.BarCodes;

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