// generated from <Windows SDK Path>\um\d3d11shadertracing.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_PIXEL_SHADER_TRACE_DESC
    {
        public ulong Invocation;
        public int X;
        public int Y;
        public ulong SampleMask;
    }
}
