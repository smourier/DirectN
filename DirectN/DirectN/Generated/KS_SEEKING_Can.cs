// generated from <Windows SDK Path>\shared\ks.h
using System;

namespace DirectN
{
    [Flags]
    public enum KS_SEEKING_Can
    {
        KS_SEEKING_CanSeekAbsolute = 0x00000001,
        KS_SEEKING_CanSeekForwards = 0x00000002,
        KS_SEEKING_CanSeekBackwards = 0x00000004,
        KS_SEEKING_CanGetCurrentPos = 0x00000008,
        KS_SEEKING_CanGetStopPos = 0x00000010,
        KS_SEEKING_CanGetDuration = 0x00000020,
        KS_SEEKING_CanPlayBackwards = 0x00000040,
    }
}
