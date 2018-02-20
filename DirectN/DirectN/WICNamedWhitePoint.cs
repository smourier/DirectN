using System;

namespace DirectN
{
    [Flags]
    public enum WICNamedWhitePoint
    {
        WICWhitePointDefault = 0x00000001,
        WICWhitePointDaylight = 0x00000002,
        WICWhitePointCloudy = 0x00000004,
        WICWhitePointShade = 0x00000008,
        WICWhitePointTungsten = 0x00000010,
        WICWhitePointFluorescent = 0x00000020,
        WICWhitePointFlash = 0x00000040,
        WICWhitePointUnderwater = 0x00000080,
        WICWhitePointCustom = 0x00000100,
        WICWhitePointAutoWhiteBalance = 0x00000200,
        WICWhitePointAsShot = WICWhitePointDefault
    }
}
