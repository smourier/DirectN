// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\d3d10.h(749,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D10_BIND_FLAG
    {
        D3D10_BIND_VERTEX_BUFFER = 0x00000001,
        D3D10_BIND_INDEX_BUFFER = 0x00000002,
        D3D10_BIND_CONSTANT_BUFFER = 0x00000004,
        D3D10_BIND_SHADER_RESOURCE = 0x00000008,
        D3D10_BIND_STREAM_OUTPUT = 0x00000010,
        D3D10_BIND_RENDER_TARGET = 0x00000020,
        D3D10_BIND_DEPTH_STENCIL = 0x00000040,
    }
}
