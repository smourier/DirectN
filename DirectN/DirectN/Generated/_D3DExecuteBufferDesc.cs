// generated from <Windows SDK Path>\um\d3dcaps.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DExecuteBufferDesc
    {
        public uint dwSize;
        public uint dwFlags;
        public uint dwCaps;
        public uint dwBufferSize;
        public IntPtr lpData;
    }
}
