using System;

namespace DirectN
{
    [Flags]
    public enum SHGSI : int
    {
        SHGSI_SMALLICON = 1,
        SHGSI_SHELLICONSIZE = 4,
        SHGSI_ICON = 0x100,
        SHGSI_SYSICONINDEX = 0x4000,
        SHGSI_LINKOVERLAY = 0x8000,
        SHGSI_SELECTED = 0x10000,
    }
}
