// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_SURFACEINFO
    {
        public uint Width;
        public uint Height;
        public uint Depth;
        public IntPtr pSysMem;
        public uint SysMemPitch;
        public uint SysMemSlicePitch;
    }
}
