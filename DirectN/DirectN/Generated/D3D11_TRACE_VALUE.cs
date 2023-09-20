// generated from <Windows SDK Path>\um\d3d11shadertracing.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_TRACE_VALUE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] Bits;
        public byte ValidMask;
    }
}
