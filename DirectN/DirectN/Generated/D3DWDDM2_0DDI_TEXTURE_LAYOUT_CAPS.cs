// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(7427,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_0DDI_TEXTURE_LAYOUT_CAPS
    {
        public uint DeviceDependentLayoutCount;
        public uint DeviceDependentSwizzleCount;
        public bool Supports64KStandardSwizzle;
    }
}
