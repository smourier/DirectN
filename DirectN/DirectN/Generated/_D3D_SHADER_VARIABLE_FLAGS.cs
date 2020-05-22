// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dcommon.h(608,1)
using System;

namespace DirectN
{
    [Flags]
    public enum _D3D_SHADER_VARIABLE_FLAGS
    {
        D3D_SVF_USERPACKED = 0x00000001,
        D3D_SVF_USED = 0x00000002,
        D3D_SVF_INTERFACE_POINTER = 0x00000004,
        D3D_SVF_INTERFACE_PARAMETER = 0x00000008,
        D3D10_SVF_USERPACKED = 0x00000001,
        D3D10_SVF_USED = 0x00000002,
        D3D11_SVF_INTERFACE_POINTER = 0x00000004,
        D3D11_SVF_INTERFACE_PARAMETER = 0x00000008,
        D3D_SVF_FORCE_DWORD = 0x7FFFFFFF,
    }
}
