// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3d9types.h(1734,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DSURFACE_DESC
    {
        public _D3DFORMAT Format;
        public _D3DRESOURCETYPE Type;
        public uint Usage;
        public _D3DPOOL Pool;
        public _D3DMULTISAMPLE_TYPE MultiSampleType;
        public uint MultiSampleQuality;
        public uint Width;
        public uint Height;
    }
}
