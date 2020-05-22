// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dcomp.h(1420,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e334bc12-3937-4e02-85eb-fcf4eb30d2c8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionSurfaceFactory
    {
        [PreserveSig]
        HRESULT CreateSurface(/* THIS_ _In_ */ uint width, /* _In_ */ uint height, /* _In_ */ DXGI_FORMAT pixelFormat, /* _In_ */ DXGI_ALPHA_MODE alphaMode, /* _Outptr_ */ out IDCompositionSurface surface);
        
        [PreserveSig]
        HRESULT CreateVirtualSurface(/* THIS_ _In_ */ uint initialWidth, /* _In_ */ uint initialHeight, /* _In_ */ DXGI_FORMAT pixelFormat, /* _In_ */ DXGI_ALPHA_MODE alphaMode, /* _Outptr_ */ out IDCompositionVirtualSurface virtualSurface);
    }
}
