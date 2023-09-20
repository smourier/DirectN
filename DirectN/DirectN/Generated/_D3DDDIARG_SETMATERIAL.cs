// generated from <Windows SDK Path>\um\d3dumddi.h
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
