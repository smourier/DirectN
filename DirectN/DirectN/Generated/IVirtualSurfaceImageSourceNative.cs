// generated from <Windows SDK Path>\um\windows.ui.xaml.media.dxinterop.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e9550983-360b-4f53-b391-afd695078691"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVirtualSurfaceImageSourceNative : ISurfaceImageSourceNative
    {
        // ISurfaceImageSourceNative
        [PreserveSig]
        new HRESULT SetDevice(/* [annotation][in] _In_ */ IDXGIDevice device);
        
        [PreserveSig]
        new HRESULT BeginDraw(/* [annotation][in] _In_ */ tagRECT updateRect, /* [annotation][out] _Out_ */ out IDXGISurface surface, /* [annotation][out] _Out_ */ out tagPOINT offset);
        
        [PreserveSig]
        new HRESULT EndDraw();
        
        // IVirtualSurfaceImageSourceNative
        [PreserveSig]
        HRESULT Invalidate(/* [annotation][in] _In_ */ tagRECT updateRect);
        
        [PreserveSig]
        HRESULT GetUpdateRectCount(/* [annotation][out] _Out_ */ out uint count);
        
        [PreserveSig]
        HRESULT GetUpdateRects(/* [annotation][size_is][out] _Out_writes_(count) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] tagRECT[] updates, /* [annotation][in] _In_ */ int count);
        
        [PreserveSig]
        HRESULT GetVisibleBounds(/* [annotation][out] _Out_ */ out tagRECT bounds);
        
        [PreserveSig]
        HRESULT RegisterForUpdatesNeeded(/* [annotation][in] _In_opt_ */ IVirtualSurfaceUpdatesCallbackNative callback);
        
        [PreserveSig]
        HRESULT Resize(/* [annotation][in] _In_ */ int newWidth, /* [annotation][in] _In_ */ int newHeight);
    }
}
