// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(7754,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_HIT_GROUP_DESC_0054
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string HitGroupExport;
        public D3D12DDI_HIT_GROUP_TYPE Type;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string AnyHitShaderImport;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string ClosestHitShaderImport;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string IntersectionShaderImport;
        public D3D12DDI_EXPORT_SUMMARY_FLAGS SummaryFlags;
    }
}
