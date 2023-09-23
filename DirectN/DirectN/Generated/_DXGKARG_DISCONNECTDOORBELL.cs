// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_DISCONNECTDOORBELL
    {
        public IntPtr hDoorbell;
        public _DXGKARG_DISCONNECTDOORBELL_FLAGS Flags;
    }
}
