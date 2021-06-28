// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11shader.h(426,1)
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
