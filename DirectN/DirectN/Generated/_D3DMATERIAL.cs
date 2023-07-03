// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\d3dtypes.h(723,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DMATERIAL
    {
        public uint dwSize;
        public _D3DMATERIAL__union_0 __union_1;
        public _D3DMATERIAL__union_1 __union_2;
        public _D3DMATERIAL__union_2 __union_3;
        public _D3DMATERIAL__union_3 __union_4;
        public _D3DMATERIAL__union_4 __union_5;
        public uint hTexture;
        public uint dwRampSize;
    }
}
