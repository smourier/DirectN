// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(14205,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DRED_BREADCRUMB_CONTEXT
    {
        public uint BreadcrumbIndex;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pContextString;
    }
}
