// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKVGPU_ESCAPE_RESUME
    {
        public _DXGKVGPU_ESCAPE_HEAD Header;
        public LUID DeviceLuid;
        public uint Flags;
    }
}
