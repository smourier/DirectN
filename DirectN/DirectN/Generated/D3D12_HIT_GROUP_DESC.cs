// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_HIT_GROUP_DESC
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string HitGroupExport;
        public D3D12_HIT_GROUP_TYPE Type;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string AnyHitShaderImport;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string ClosestHitShaderImport;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string IntersectionShaderImport;
    }
}
