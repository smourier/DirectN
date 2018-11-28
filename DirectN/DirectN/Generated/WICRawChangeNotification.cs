using System;

namespace DirectN
{
    [Flags]
    public enum WICRawChangeNotification
    {
        WICRawChangeNotification_ExposureCompensation = 0x00000001,
        WICRawChangeNotification_NamedWhitePoint = 0x00000002,
        WICRawChangeNotification_KelvinWhitePoint = 0x00000004,
        WICRawChangeNotification_RGBWhitePoint = 0x00000008,
        WICRawChangeNotification_Contrast = 0x00000010,
        WICRawChangeNotification_Gamma = 0x00000020,
        WICRawChangeNotification_Sharpness = 0x00000040,
        WICRawChangeNotification_Saturation = 0x00000080,
        WICRawChangeNotification_Tint = 0x00000100,
        WICRawChangeNotification_NoiseReduction = 0x00000200,
        WICRawChangeNotification_DestinationColorContext = 0x00000400,
        WICRawChangeNotification_ToneCurve = 0x00000800,
        WICRawChangeNotification_Rotation = 0x00001000,
        WICRawChangeNotification_RenderMode = 0x00002000,
    }
}
