using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2633066b-4514-4c7a-8fd8-12ea98059d18"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIDecodeSwapChain
    {
        [PreserveSig]
        HRESULT PresentBuffer(int BufferToPresent, int SyncInterval, DXGI_PRESENT Flags);

        [PreserveSig]
        HRESULT SetSourceRect(ref RECT pRect);

        [PreserveSig]
        HRESULT SetTargetRect(ref RECT pRect);

        [PreserveSig]
        HRESULT SetDestSize(int Width, int Height);

        [PreserveSig]
        HRESULT GetSourceRect(out RECT pRect);

        [PreserveSig]
        HRESULT GetTargetRect(out RECT pRect);

        [PreserveSig]
        HRESULT GetDestSize(out int pWidth, out int pHeight);

        [PreserveSig]
        HRESULT SetColorSpace(DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS ColorSpace);

        [PreserveSig]
        DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS GetColorSpace();
    }
}
