// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(12047,9)
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
