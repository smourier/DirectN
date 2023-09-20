// generated from <Windows SDK Path>\um\d3d11sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1911c771-1587-413e-a7e0-fb26c3de0268"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11TracingDevice
    {
        [PreserveSig]
        HRESULT SetShaderTrackingOptionsByType(/* [annotation] _In_ */ uint ResourceTypeFlags, /* [annotation] _In_ */ uint Options);
        
        [PreserveSig]
        HRESULT SetShaderTrackingOptions(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pShader, /* [annotation] _In_ */ uint Options);
    }
}
