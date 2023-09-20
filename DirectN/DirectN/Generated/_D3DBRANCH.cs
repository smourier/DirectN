// generated from <Windows SDK Path>\um\d3dtypes.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DBRANCH
    {
        public uint dwMask;
        public uint dwValue;
        public bool bNegate;
        public uint dwOffset;
    }
}
