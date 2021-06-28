// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(4904,9)
using System;

namespace DirectN
{
    [Flags]
    public enum KS_CAPTURE_ALLOC
    {
        KS_CAPTURE_ALLOC_INVALID = 0x00000000,
        KS_CAPTURE_ALLOC_SYSTEM = 0x00000001,
        KS_CAPTURE_ALLOC_VRAM = 0x00000002,
        KS_CAPTURE_ALLOC_SYSTEM_AGP = 0x00000004,
        KS_CAPTURE_ALLOC_VRAM_MAPPED = 0x00000008,
        KS_CAPTURE_ALLOC_SECURE_BUFFER = 0x00000010,
    }
}
