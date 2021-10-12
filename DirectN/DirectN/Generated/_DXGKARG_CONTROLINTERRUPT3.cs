// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(4107,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CONTROLINTERRUPT3
    {
        public _DXGK_INTERRUPT_TYPE InterruptType;
        public _DXGKARG_CONTROLINTERRUPT3__union_0 __union_1;
        public uint VidPnSourceId;
    }
}
