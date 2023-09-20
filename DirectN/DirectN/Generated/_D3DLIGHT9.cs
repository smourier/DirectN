// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DLIGHT9
    {
        public _D3DLIGHTTYPE Type;
        public _D3DCOLORVALUE Diffuse;
        public _D3DCOLORVALUE Specular;
        public _D3DCOLORVALUE Ambient;
        public _D3DVECTOR Position;
        public _D3DVECTOR Direction;
        public float Range;
        public float Falloff;
        public float Attenuation0;
        public float Attenuation1;
        public float Attenuation2;
        public float Theta;
        public float Phi;
    }
}
