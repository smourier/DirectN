// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(23648,1)
using System;

namespace DirectN
{
    [Flags]
    public enum _AM_DVD_GRAPH_FLAGS
    {
        AM_DVD_HWDEC_PREFER = 0x00000001,
        AM_DVD_HWDEC_ONLY = 0x00000002,
        AM_DVD_SWDEC_PREFER = 0x00000004,
        AM_DVD_SWDEC_ONLY = 0x00000008,
        AM_DVD_NOVPE = 0x00000100,
        AM_DVD_DO_NOT_CLEAR = 0x00000200,
        AM_DVD_VMR9_ONLY = 0x00000800,
        AM_DVD_EVR_ONLY = 0x00001000,
        AM_DVD_EVR_QOS = 0x00002000,
        AM_DVD_ADAPT_GRAPH = 0x00004000,
        AM_DVD_MASK = 0x0000FFFF,
    }
}
