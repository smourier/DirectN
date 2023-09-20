// generated from <Windows SDK Path>\um\d3d12shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ec25f42d-7006-4f2b-b33e-02cc3375733f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12FunctionParameterReflection
    {
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D12_PARAMETER_DESC pDesc);
    }
}
