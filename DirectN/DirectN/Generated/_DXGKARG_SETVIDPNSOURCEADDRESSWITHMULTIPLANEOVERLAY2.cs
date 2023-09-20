// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETVIDPNSOURCEADDRESSWITHMULTIPLANEOVERLAY2
    {
        public uint ContextCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 65)] 
        public IntPtr[] Context;
        public _DXGK_SETVIDPNSOURCEADDRESS_FLAGS Flags;
        public uint VidPnSourceId;
        public uint PlaneCount;
        public IntPtr pPlanes;
        public uint Duration;
    }
}
