﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(1696,1)
using System;

namespace DirectN
{
    [Flags]
    public enum _MFMEDIASOURCE_CHARACTERISTICS
    {
        MFMEDIASOURCE_IS_LIVE = 0x00000001,
        MFMEDIASOURCE_CAN_SEEK = 0x00000002,
        MFMEDIASOURCE_CAN_PAUSE = 0x00000004,
        MFMEDIASOURCE_HAS_SLOW_SEEK = 0x00000008,
        MFMEDIASOURCE_HAS_MULTIPLE_PRESENTATIONS = 0x00000010,
        MFMEDIASOURCE_CAN_SKIPFORWARD = 0x00000020,
        MFMEDIASOURCE_CAN_SKIPBACKWARD = 0x00000040,
        MFMEDIASOURCE_DOES_NOT_USE_NETWORK = 0x00000080,
    }
}
