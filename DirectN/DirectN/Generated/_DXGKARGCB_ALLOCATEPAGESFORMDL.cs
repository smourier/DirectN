// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_ALLOCATEPAGESFORMDL
    {
        public PHYSICAL_ADDRESS LowAddress;
        public PHYSICAL_ADDRESS HighAddress;
        public PHYSICAL_ADDRESS SkipBytes;
        public IntPtr TotalBytes;
        public _DXGK_MEMORY_CACHING_TYPE CacheType;
        public uint Flags;
        public IntPtr hMemoryHandle;
        public IntPtr pMdl;
    }
}
