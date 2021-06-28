// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgi1_3.h(1357,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2633066b-4514-4c7a-8fd8-12ea98059d18"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIDecodeSwapChain
    {
        [PreserveSig]
        HRESULT PresentBuffer(uint BufferToPresent, uint SyncInterval, uint Flags);
        
        [PreserveSig]
        HRESULT SetSourceRect(ref tagRECT pRect);
        
        [PreserveSig]
        HRESULT SetTargetRect(ref tagRECT pRect);
        
        [PreserveSig]
        HRESULT SetDestSize(uint Width, uint Height);
        
        [PreserveSig]
        HRESULT GetSourceRect(/* [annotation][out] _Out_ */ out tagRECT pRect);
        
        [PreserveSig]
        HRESULT GetTargetRect(/* [annotation][out] _Out_ */ out tagRECT pRect);
        
        [PreserveSig]
        HRESULT GetDestSize(/* [annotation][out] _Out_ */ out uint pWidth, /* [annotation][out] _Out_ */ out uint pHeight);
        
        [PreserveSig]
        HRESULT SetColorSpace(DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS ColorSpace);
        
        [PreserveSig]
        DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS GetColorSpace();
    }
}
