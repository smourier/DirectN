// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(13209,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DEVICE_REMOVED_EXTENDED_DATA
    {
        public D3D12_DRED_FLAGS Flags;
        public IntPtr pHeadAutoBreadcrumbNode;
    }
}
