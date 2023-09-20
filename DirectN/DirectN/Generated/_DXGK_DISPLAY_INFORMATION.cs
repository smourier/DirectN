// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_DISPLAY_INFORMATION
    {
        public uint Width;
        public uint Height;
        public uint Pitch;
        public _D3DDDIFORMAT ColorFormat;
        public PHYSICAL_ADDRESS PhysicAddress;
        public uint TargetId;
        public uint AcpiId;
    }
}
