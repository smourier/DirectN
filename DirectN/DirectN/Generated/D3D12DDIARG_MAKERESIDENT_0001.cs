// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(478,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_MAKERESIDENT_0001
    {
        public uint NumAdapters;
        public IntPtr pRTPagingQueue;
        public uint NumObjects;
        public IntPtr pObjects;
        public D3DDDI_MAKERESIDENT_FLAGS Flags;
        public IntPtr pPagingFenceValue;
        public uint WaitMask;
    }
}
