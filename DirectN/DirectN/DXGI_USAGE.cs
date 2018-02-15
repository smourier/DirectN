using System;

namespace DirectN
{
    [Flags]
    public enum DXGI_USAGE
    {
        DXGI_CPU_ACCESS_NONE = (0),
        DXGI_CPU_ACCESS_DYNAMIC = (1),
        DXGI_CPU_ACCESS_READ_WRITE = (2),
        DXGI_CPU_ACCESS_SCRATCH = (3),
        DXGI_CPU_ACCESS_FIELD = 15,
        DXGI_USAGE_SHADER_INPUT = (1 << (0 + 4)),
        DXGI_USAGE_RENDER_TARGET_OUTPUT = (1 << (1 + 4)),
        DXGI_USAGE_BACK_BUFFER = (1 << (2 + 4)),
        DXGI_USAGE_SHARED = (1 << (3 + 4)),
        DXGI_USAGE_READ_ONLY = (1 << (4 + 4)),
        DXGI_USAGE_DISCARD_ON_PRESENT = (1 << (5 + 4)),
        DXGI_USAGE_UNORDERED_ACCESS = (1 << (6 + 4)),
    }
}