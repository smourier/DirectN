// generated from <Windows SDK Path>\um\d3d12umddi.h
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
