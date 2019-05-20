// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(518,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_RECLAIMRESOURCES_0001
    {
        public uint NumAdapters;
        public IntPtr pRTPagingQueue;
        public uint NumObjects;
        public IntPtr pObjects;
        public IntPtr pDiscarded;
        public IntPtr pPagingFenceValue;
        public uint WaitMask;
    }
}
