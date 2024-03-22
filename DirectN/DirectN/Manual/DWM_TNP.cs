using System;

namespace DirectN
{
    [Flags]
    public enum DWM_TNP
    {
        DWM_TNP_RECTDESTINATION = 0x00000001,
        DWM_TNP_RECTSOURCE = 0x00000002,
        DWM_TNP_OPACITY = 0x00000004,
        DWM_TNP_VISIBLE = 0x00000008,
        DWM_TNP_SOURCECLIENTAREAONLY = 0x00000010,
    }
}
