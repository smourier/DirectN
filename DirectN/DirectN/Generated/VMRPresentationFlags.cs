// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(18506,1)
using System;

namespace DirectN
{
    [Flags]
    public enum VMRPresentationFlags
    {
        VMRSample_SyncPoint = 0x00000001,
        VMRSample_Preroll = 0x00000002,
        VMRSample_Discontinuity = 0x00000004,
        VMRSample_TimeValid = 0x00000008,
        VMRSample_SrcDstRectsValid = 0x00000010,
    }
}
