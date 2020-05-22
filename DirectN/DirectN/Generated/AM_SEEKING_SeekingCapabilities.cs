// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(3994,1)
using System;

namespace DirectN
{
    [Flags]
    public enum AM_SEEKING_SeekingCapabilities
    {
        AM_SEEKING_CanSeekAbsolute = 0x00000001,
        AM_SEEKING_CanSeekForwards = 0x00000002,
        AM_SEEKING_CanSeekBackwards = 0x00000004,
        AM_SEEKING_CanGetCurrentPos = 0x00000008,
        AM_SEEKING_CanGetStopPos = 0x00000010,
        AM_SEEKING_CanGetDuration = 0x00000020,
        AM_SEEKING_CanPlayBackwards = 0x00000040,
        AM_SEEKING_CanDoSegments = 0x00000080,
        AM_SEEKING_Source = 0x00000100,
    }
}
