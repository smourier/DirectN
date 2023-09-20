// generated from <Windows SDK Path>\shared\d3d9types.h
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
