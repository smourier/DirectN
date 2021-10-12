// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(209,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_SWIZZLE_PATTERN_DESC_0003
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3D12DDI_SWIZZLE_BIT_ENTRY[] InterleavePatternSourceBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3D12DDI_SWIZZLE_BIT_ENTRY[] InterleavePatternXORSourceBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3D12DDI_SWIZZLE_BIT_ENTRY[] InterleavePatternXOR2SourceBits;
        public bool StackDepthSlices;
    }
}
