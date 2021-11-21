// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(8908,9)
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
