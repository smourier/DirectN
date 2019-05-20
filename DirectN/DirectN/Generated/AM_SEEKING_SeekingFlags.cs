// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(3980,1)
using System;

namespace DirectN
{
    [Flags]
    public enum AM_SEEKING_SeekingFlags
    {
        AM_SEEKING_NoPositioning = 0x00000000,
        AM_SEEKING_AbsolutePositioning = 0x00000001,
        AM_SEEKING_RelativePositioning = 0x00000002,
        AM_SEEKING_IncrementalPositioning = 0x00000003,
        AM_SEEKING_PositioningBitsMask = 0x00000003,
        AM_SEEKING_SeekToKeyFrame = 0x00000004,
        AM_SEEKING_ReturnTime = 0x00000008,
        AM_SEEKING_Segment = 0x00000010,
        AM_SEEKING_NoFlush = 0x00000020,
    }
}
