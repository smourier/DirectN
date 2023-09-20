// generated from <Windows SDK Path>\um\strmif.h
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
