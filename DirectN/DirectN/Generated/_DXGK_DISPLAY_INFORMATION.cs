// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmdt.h(1467,9)
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
