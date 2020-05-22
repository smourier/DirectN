// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12shader.h(433,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ec25f42d-7006-4f2b-b33e-02cc3375733f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12FunctionParameterReflection
    {
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D12_PARAMETER_DESC pDesc);
    }
}
