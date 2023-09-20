// generated from <Windows SDK Path>\um\d3dtypes.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DCLIPSTATUS
    {
        public uint dwFlags;
        public uint dwStatus;
        public float minx;
        public float maxx;
        public float miny;
        public float maxy;
        public float minz;
        public float maxz;
    }
}
