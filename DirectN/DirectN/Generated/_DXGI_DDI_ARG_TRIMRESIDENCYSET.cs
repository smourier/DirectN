// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_TRIMRESIDENCYSET
    {
        public ulong hDevice;
        public D3DDDI_TRIMRESIDENCYSET_FLAGS TrimFlags;
        public ulong NumBytesToTrim;
    }
}
