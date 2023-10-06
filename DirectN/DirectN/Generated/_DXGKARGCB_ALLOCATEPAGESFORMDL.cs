// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_ALLOCATEPAGESFORMDL
    {
        public long LowAddress;
        public long HighAddress;
        public long SkipBytes;
        public IntPtr TotalBytes;
        public _DXGK_MEMORY_CACHING_TYPE CacheType;
        public uint Flags;
        public IntPtr hMemoryHandle;
        public int pMdl;
    }
}
