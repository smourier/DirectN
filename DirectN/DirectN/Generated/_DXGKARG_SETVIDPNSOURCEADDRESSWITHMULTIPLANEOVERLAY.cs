// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(5834,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETVIDPNSOURCEADDRESSWITHMULTIPLANEOVERLAY
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
