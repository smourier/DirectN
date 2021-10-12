// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(4210,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_BUILDPAGINGBUFFER_COPY_RANGE
    {
        public uint NumPageTableEntries;
        public ulong SrcPageTableAddress;
        public ulong DstPageTableAddress;
        public uint SrcStartPteIndex;
        public uint DstStartPteIndex;
    }
}
