using System;

namespace DirectN
{
    [Flags]
    public enum WICBitmapAlphaChannelOption
    {
        WICBitmapUseAlpha = 0x00000000,
        WICBitmapUsePremultipliedAlpha = 0x00000001,
        WICBitmapIgnoreAlpha = 0x00000002,
    }
}
