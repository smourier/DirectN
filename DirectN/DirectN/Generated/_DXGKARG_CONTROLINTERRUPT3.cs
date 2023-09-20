// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
