// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(798,9)
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_3
    {
        public uint VidPnTargetId;
        public PHYSICAL_ADDRESS PhysicalAddress;
        public uint PhysicalAdapterMask;
    }
}
