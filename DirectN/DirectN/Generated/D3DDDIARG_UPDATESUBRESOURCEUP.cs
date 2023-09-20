// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDIARG_UPDATESUBRESOURCEUP
    {
        public IntPtr hResource;
        public uint SubResourceIndex;
        public _D3DDDIBOX DstBox;
        public IntPtr pSysMemUP;
        public uint RowPitch;
        public uint DepthPitch;
        public D3DDDIARG_COPYFLAGS Flags;
    }
}
