// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11sdklayers.h(458,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1911c771-1587-413e-a7e0-fb26c3de0268"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11TracingDevice
    {
        [PreserveSig]
        HRESULT SetShaderTrackingOptionsByType(/* [annotation] _In_ */ uint ResourceTypeFlags, /* [annotation] _In_ */ uint Options);
        
        [PreserveSig]
        HRESULT SetShaderTrackingOptions(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pShader, /* [annotation] _In_ */ uint Options);
    }
}
