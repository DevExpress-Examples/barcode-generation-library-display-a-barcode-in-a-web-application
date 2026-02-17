using System.Runtime.Serialization;

namespace BarcodeWebApi.Services;

public enum BarcodeSymbology
{
    // 2D Barcodes
    [EnumMember(Value = "aztec")]
    Aztec,
    
    [EnumMember(Value = "qr")]
    QrCode,
    
    [EnumMember(Value = "micro-qr")]
    MicroQrCode,
    
    [EnumMember(Value = "gs1-qr")]
    QrCodeGS1,
    
    [EnumMember(Value = "datamatrix-ecc200")]
    DataMatrixECC200,
    
    [EnumMember(Value = "gs1-datamatrix")]
    DataMatrixGS1,
    
    [EnumMember(Value = "pdf417")]
    PDF417,
    
    [EnumMember(Value = "intelligent-mail")]
    IntelligentMail,
    
    // 1D Barcodes
    [EnumMember(Value = "codabar")]
    Codabar,
    
    [EnumMember(Value = "code11")]
    Code11,
    
    [EnumMember(Value = "code128")]
    Code128,
    
    [EnumMember(Value = "gs1-128")]
    GS1_128,
    
    [EnumMember(Value = "code39")]
    Code39,
    
    [EnumMember(Value = "code39-extended")]
    Code39Extended,
    
    [EnumMember(Value = "code93")]
    Code93,
    
    [EnumMember(Value = "code93-extended")]
    Code93Extended,
    
    [EnumMember(Value = "deutsche-post-leitcode")]
    DeutschePostLeitcode,
    
    [EnumMember(Value = "deutsche-post-identcode")]
    DeutschePostIdentcode,
    
    [EnumMember(Value = "ean8")]
    EAN8,
    
    [EnumMember(Value = "ean13")]
    EAN13,
    
    [EnumMember(Value = "gs1-databar")]
    GS1DataBar,
    
    [EnumMember(Value = "industrial-2of5")]
    Industrial2of5,
    
    [EnumMember(Value = "interleaved-2of5")]
    Interleaved2of5,
    
    [EnumMember(Value = "matrix-2of5")]
    Matrix2of5,
    
    [EnumMember(Value = "msi-plessey")]
    MSIPlessey,
    
    [EnumMember(Value = "pharmacode")]
    Pharmacode,
    
    [EnumMember(Value = "postnet")]
    PostNet,
    
    [EnumMember(Value = "intelligent-mail-package")]
    IntelligentMailPackage,
    
    [EnumMember(Value = "sscc18")]
    SSCC18,
    
    [EnumMember(Value = "itf14")]
    ITF14,
    
    [EnumMember(Value = "upc-supplemental2")]
    UPCSupplemental2,
    
    [EnumMember(Value = "upc-supplemental5")]
    UPCSupplemental5,
    
    [EnumMember(Value = "upca")]
    UPCA,
    
    [EnumMember(Value = "upce0")]
    UPCE0,
    
    [EnumMember(Value = "upce1")]
    UPCE1
}
