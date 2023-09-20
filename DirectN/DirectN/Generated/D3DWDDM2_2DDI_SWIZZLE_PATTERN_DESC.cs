// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_2DDI_SWIZZLE_PATTERN_DESC
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3DWDDM2_0DDI_SWIZZLE_BIT_ENTRY[] InterleavePatternSourceBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3DWDDM2_0DDI_SWIZZLE_BIT_ENTRY[] InterleavePatternXORSourceBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3DWDDM2_0DDI_SWIZZLE_BIT_ENTRY[] InterleavePatternXOR2SourceBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3DWDDM2_0DDI_SWIZZLE_BIT_ENTRY[] InterleavePatternXOR3SourceBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3DWDDM2_0DDI_SWIZZLE_BIT_ENTRY[] InterleavePatternXOR4SourceBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3DWDDM2_0DDI_SWIZZLE_BIT_ENTRY[] PostambleXORSourceBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3DWDDM2_0DDI_SWIZZLE_BIT_ENTRY[] PostambleXOR2SourceBits;
        public uint PostambleXORImmediate;
        public uint Flags;
    }
}
