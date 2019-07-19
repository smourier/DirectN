// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(472,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_SETMATERIAL
    {
        public int Diffuse;
        public int Ambient;
        public int Specular;
        public int Emissive;
        public float Power;
    }
}
