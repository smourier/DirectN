// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dtypes.h(553,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DVIEWPORT
    {
        public uint dwSize;
        public uint dwX;
        public uint dwY;
        public uint dwWidth;
        public uint dwHeight;
        public float dvScaleX;
        public float dvScaleY;
        public float dvMaxX;
        public float dvMaxY;
        public float dvMinZ;
        public float dvMaxZ;
    }
}
