// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_DISPLAY_INFORMATION
    {
        public uint Width;
        public uint Height;
        public uint Pitch;
        public _D3DDDIFORMAT ColorFormat;
        public long PhysicAddress;
        public uint TargetId;
        public uint AcpiId;
    }
}
