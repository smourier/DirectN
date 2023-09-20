// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_SETSTREAMSOURCE
    {
        public uint Stream;
        public IntPtr hVertexBuffer;
        public uint Offset;
        public uint Stride;
    }
}
