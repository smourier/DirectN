// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11shadertracing.h(484,5)
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
