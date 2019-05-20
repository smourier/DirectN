// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(7462,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_0DDI_SWIZZLE_PATTERN_DESC
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3DWDDM2_0DDI_SWIZZLE_BIT_ENTRY[] InterleavePatternSourceBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3DWDDM2_0DDI_SWIZZLE_BIT_ENTRY[] InterleavePatternXORSourceBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3DWDDM2_0DDI_SWIZZLE_BIT_ENTRY[] InterleavePatternXOR2SourceBits;
        public uint InterleavePatternXOR3;
        public uint Flags;
    }
}
