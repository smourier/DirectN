// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(497,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_LIGHT
    {
        public int Type;
        public int Diffuse;
        public int Specular;
        public int Ambient;
        public int Position;
        public int Direction;
        public float Range;
        public float Falloff;
        public float Attenuation0;
        public float Attenuation1;
        public float Attenuation2;
        public float Theta;
        public float Phi;
    }
}
