// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;
using DXGI_DDI_HRESOURCE = System.UInt64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_RECLAIMRESOURCES
    {
        public ulong hDevice;
        public IntPtr pResources;
        public IntPtr pDiscarded;
        public uint Resources;
    }
}
