// generated from <Windows SDK Path>\um\d3dtypes.h
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
