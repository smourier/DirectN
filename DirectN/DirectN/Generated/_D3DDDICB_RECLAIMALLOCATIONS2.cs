// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_RECLAIMALLOCATIONS2
    {
        public uint PagingQueue;
        public uint NumAllocations;
        public IntPtr pResources;
        public IntPtr HandleList;
        public IntPtr pDiscarded;
        public ulong PagingFenceValue;
    }
}
