// generated from <Windows SDK Path>\um\d3dtypes.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DPICKRECORD
    {
        public byte bOpcode;
        public byte bPad;
        public uint dwOffset;
        public float dvZ;
    }
}
