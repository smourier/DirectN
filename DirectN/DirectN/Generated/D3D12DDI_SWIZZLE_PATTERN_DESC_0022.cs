// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_SWIZZLE_PATTERN_DESC_0022
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3D12DDI_SWIZZLE_BIT_ENTRY[] InterleavePatternSourceBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3D12DDI_SWIZZLE_BIT_ENTRY[] InterleavePatternXORSourceBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3D12DDI_SWIZZLE_BIT_ENTRY[] InterleavePatternXOR2SourceBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3D12DDI_SWIZZLE_BIT_ENTRY[] InterleavePatternXOR3SourceBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3D12DDI_SWIZZLE_BIT_ENTRY[] InterleavePatternXOR4SourceBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3D12DDI_SWIZZLE_BIT_ENTRY[] PostambleXORSourceBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3D12DDI_SWIZZLE_BIT_ENTRY[] PostambleXOR2SourceBits;
        public uint PostambleXORImmediate;
        public D3D12DDI_SWIZZLE_PATTERN_FLAGS Flags;
    }
}
