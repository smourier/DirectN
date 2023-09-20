// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_2DDI_TEXTURE_LAYOUT_CAPS
    {
        public uint DeviceDependentLayoutCount;
        public uint DeviceDependentSwizzleCount;
        public bool Supports64KStandardSwizzle;
        public bool IndexableSwizzlePatterns;
    }
}
