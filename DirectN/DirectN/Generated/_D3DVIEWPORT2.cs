// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dtypes.h(568,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DVIEWPORT2
    {
        public uint dwSize;
        public uint dwX;
        public uint dwY;
        public uint dwWidth;
        public uint dwHeight;
        public float dvClipX;
        public float dvClipY;
        public float dvClipWidth;
        public float dvClipHeight;
        public float dvMinZ;
        public float dvMaxZ;
    }
}
