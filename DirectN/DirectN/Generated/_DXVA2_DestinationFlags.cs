// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva2swdev.h(35,9)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVA2_DestinationFlags
    {
        DXVA2_DestinationFlag_Background_Changed = 0x00000001,
        DXVA2_DestinationFlag_TargetRect_Changed = 0x00000002,
        DXVA2_DestinationFlag_ColorData_Changed = 0x00000004,
        DXVA2_DestinationFlag_Alpha_Changed = 0x00000008,
        DXVA2_DestinationFlag_RFF = 0x00010000,
        DXVA2_DestinationFlag_TFF = 0x00020000,
        DXVA2_DestinationFlag_RFF_TFF_Present = 0x00040000,
        DXVA2_DestinationFlagMask = unchecked((int)0xFFFF000F),
    }
}
