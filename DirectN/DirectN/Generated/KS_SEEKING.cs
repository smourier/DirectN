// generated from <Windows SDK Path>\shared\ks.h
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
