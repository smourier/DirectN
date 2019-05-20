// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(8806,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETTRACKEDWORKLOADPOWERLEVEL
    {
        public uint PowerLevel;
        public uint EffectivePowerLevel;
        public _DXGK_TRACKEDWORKLOAD_STATE_FLAGS Flags;
    }
}
