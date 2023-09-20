// generated from <Windows SDK Path>\um\d3dcaps.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DFINDDEVICESEARCH
    {
        public uint dwSize;
        public uint dwFlags;
        public bool bHardware;
        public int dcmColorModel;
        public Guid guid;
        public uint dwCaps;
        public _D3DPrimCaps dpcPrimCaps;
    }
}
