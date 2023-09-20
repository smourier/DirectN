// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
