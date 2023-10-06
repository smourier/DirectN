// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;
using DXGI_DDI_HRESOURCE = System.UInt64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_OFFERRESOURCES1
    {
        public ulong hDevice;
        public IntPtr pResources;
        public uint Resources;
        public _D3DDDI_OFFER_PRIORITY Priority;
        public D3DDDI_OFFER_FLAGS Flags;
    }
}
