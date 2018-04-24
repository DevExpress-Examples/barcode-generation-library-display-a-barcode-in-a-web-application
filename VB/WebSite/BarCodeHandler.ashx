<%@ WebHandler Language="vb" Class="BarCodeHandler" %>

Imports System
Imports System.Web
Imports System.Drawing.Imaging
Imports DevExpress.BarCodes

Public Class BarCodeHandler
    Implements IHttpHandler

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Dim barCode As New BarCode()

        barCode.Symbology = Symbology.QRCode
        barCode.CodeText = "123"

        context.Response.ContentType = "image/png"
        barCode.Save(context.Response.OutputStream, ImageFormat.Png)
        context.Response.End()
    End Sub

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property
End Class