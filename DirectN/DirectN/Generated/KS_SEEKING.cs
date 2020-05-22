// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ks.h(544,9)
using System;

namespace DirectN
{
    [Flags]
    public enum KS_SEEKING
    {
        KS_SEEKING_NoPositioning = 0x00000000,
        KS_SEEKING_AbsolutePositioning = 0x00000001,
        KS_SEEKING_RelativePositioning = 0x00000002,
        KS_SEEKING_IncrementalPositioning = 0x00000003,
        KS_SEEKING_PositioningBitsMask = 0x00000003,
        KS_SEEKING_SeekToKeyFrame = 0x00000004,
        KS_SEEKING_ReturnTime = 0x00000008,
    }
}
