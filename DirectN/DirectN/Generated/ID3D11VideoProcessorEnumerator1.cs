// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_1.h(4237,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("465217f2-5568-43cf-b5b9-f61d54531ca1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11VideoProcessorEnumerator1
    {
        [PreserveSig]
        HRESULT CheckVideoProcessorFormatConversion(/* [annotation] _In_ */ DXGI_FORMAT InputFormat, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE InputColorSpace, /* [annotation] _In_ */ DXGI_FORMAT OutputFormat, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE OutputColorSpace, /* [annotation] _Out_ */ out bool pSupported);
    }
}
