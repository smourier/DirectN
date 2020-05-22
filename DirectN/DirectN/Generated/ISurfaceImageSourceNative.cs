// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\windows.ui.xaml.media.dxinterop.h(138,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f2e9edc1-d307-4525-9886-0fafaa44163c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISurfaceImageSourceNative
    {
        [PreserveSig]
        HRESULT SetDevice(/* [annotation][in] _In_ */ IDXGIDevice device);
        
        [PreserveSig]
        HRESULT BeginDraw(/* [annotation][in] _In_ */ tagRECT updateRect, /* [annotation][out] _Out_ */ out IDXGISurface surface, /* [annotation][out] _Out_ */ out tagPOINT offset);
        
        [PreserveSig]
        HRESULT EndDraw();
    }
}
