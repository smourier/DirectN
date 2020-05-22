// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(19575,1)
using System;

namespace DirectN
{
    [Flags]
    public enum VMRMode
    {
        VMRMode_Windowed = 0x00000001,
        VMRMode_Windowless = 0x00000002,
        VMRMode_Renderless = 0x00000004,
        VMRMode_Mask = 0x00000007,
    }
}
