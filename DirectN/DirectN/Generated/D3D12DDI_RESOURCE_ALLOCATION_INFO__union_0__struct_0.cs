// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(566,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RESOURCE_ALLOCATION_INFO__union_0__struct_0
    {
        public uint AdditionalDataHeaderAlignment1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public byte[] AdditionalMipLevelSwizzleTransitionsArray;
    }
}
