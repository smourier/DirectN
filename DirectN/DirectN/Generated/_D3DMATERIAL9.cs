// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9types.h(172,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DMATERIAL9
    {
        public _D3DCOLORVALUE Diffuse;
        public _D3DCOLORVALUE Ambient;
        public _D3DCOLORVALUE Specular;
        public _D3DCOLORVALUE Emissive;
        public float Power;
    }
}
