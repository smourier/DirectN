// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;
using DXGI_DDI_HRESOURCE = System.UInt64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_ARG_QUERYRESOURCERESIDENCY
    {
        public ulong hDevice;
        public IntPtr pResources;
        public IntPtr pStatus;
        public IntPtr Resources;
    }
}
