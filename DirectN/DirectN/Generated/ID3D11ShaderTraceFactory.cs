// generated from <Windows SDK Path>\um\d3d11shadertracing.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1fbad429-66ab-41cc-9617-667ac10e4459"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11ShaderTraceFactory
    {
        [PreserveSig]
        HRESULT CreateShaderTrace(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pShader, /* [annotation] _In_ */ ref D3D11_SHADER_TRACE_DESC pTraceDesc, /* [annotation] _COM_Outptr_ */ out ID3D11ShaderTrace ppShaderTrace);
    }
}
