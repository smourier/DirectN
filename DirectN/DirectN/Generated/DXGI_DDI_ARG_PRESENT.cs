// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_ARG_PRESENT
    {
        public ulong hDevice;
        public ulong hSurfaceToPresent;
        public uint SrcSubResourceIndex;
        public ulong hDstResource;
        public uint DstSubResourceIndex;
        public IntPtr pDXGIContext;
        public DXGI_DDI_PRESENT_FLAGS Flags;
        public DXGI_DDI_FLIP_INTERVAL_TYPE FlipInterval;
    }
}
