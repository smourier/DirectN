// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dtypes.h(1860,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DSTATUS
    {
        public uint dwFlags;
        public uint dwStatus;
        public _D3DRECT drExtent;
    }
}
