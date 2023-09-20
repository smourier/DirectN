// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT
    {
        public IntPtr hAdapter;
        public IntPtr Size;
        public IntPtr Context;
        public _DXGK_PHYSICAL_MEMORY_TYPE Type;
        public _DXGK_MEMORY_CACHING_TYPE CacheType;
        public _DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0 __union_5;
        public IntPtr hPhysicalMemoryObject;
        public IntPtr hAdapterMemoryObject;
    }
}
