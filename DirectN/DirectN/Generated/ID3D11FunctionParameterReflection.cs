// generated from <Windows SDK Path>\um\d3d11shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("42757488-334f-47fe-982e-1a65d08cc462"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11FunctionParameterReflection
    {
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D11_PARAMETER_DESC pDesc);
    }
}
