// generated from <Windows SDK Path>\um\windows.ui.xaml.media.dxinterop.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f2e9edc1-d307-4525-9886-0fafaa44163c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
