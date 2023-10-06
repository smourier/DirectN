using System;

namespace DirectN
{
    [Flags]
    public enum QDC
    {
        QDC_ALL_PATHS = 0x00000001,
        QDC_ONLY_ACTIVE_PATHS = 0x00000002,
        QDC_DATABASE_CURRENT = 0x00000004,
        QDC_VIRTUAL_MODE_AWARE = 0x00000010,
        QDC_INCLUDE_HMD = 0x00000020,
        QDC_VIRTUAL_REFRESH_RATE_AWARE = 0x00000040,
    }
}
