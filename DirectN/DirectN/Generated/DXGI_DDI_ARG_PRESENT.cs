// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(83,9)
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
