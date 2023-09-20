// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DVIEWPORT9
    {
        public uint X;
        public uint Y;
        public uint Width;
        public uint Height;
        public float MinZ;
        public float MaxZ;
    }
}
