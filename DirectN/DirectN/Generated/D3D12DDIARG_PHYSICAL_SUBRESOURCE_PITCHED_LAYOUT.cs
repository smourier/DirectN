// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(1517,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_PHYSICAL_SUBRESOURCE_PITCHED_LAYOUT
    {
        public DXGI_FORMAT Format;
        public uint PhysicalWidth;
        public uint PhysicalHeight;
        public uint PhysicalDepth;
        public uint Pitch;
        public uint SlicePitch;
    }
}
