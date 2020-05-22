// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dtypes.h(1871,9)
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
