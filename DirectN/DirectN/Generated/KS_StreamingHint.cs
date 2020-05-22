// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(7118,9)
using System;

namespace DirectN
{
    [Flags]
    public enum KS_StreamingHint
    {
        KS_StreamingHint_FrameInterval = 0x00000100,
        KS_StreamingHint_KeyFrameRate = 0x00000200,
        KS_StreamingHint_PFrameRate = 0x00000400,
        KS_StreamingHint_CompQuality = 0x00000800,
        KS_StreamingHint_CompWindowSize = 0x00001000,
    }
}
