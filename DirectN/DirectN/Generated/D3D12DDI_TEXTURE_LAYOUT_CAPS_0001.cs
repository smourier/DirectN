// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(2585,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_TEXTURE_LAYOUT_CAPS_0001
    {
        public uint DeviceDependentLayoutCount;
        public uint DeviceDependentSwizzleCount;
        public bool Supports64KStandardSwizzle;
        public bool SupportsRowMajorTexture;
    }
}
