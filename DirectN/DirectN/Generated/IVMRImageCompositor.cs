// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\strmif.h(21271,5)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE7 = DirectN.IDirectDrawSurface7;

namespace DirectN
{
    [ComImport, Guid("7a4fb5af-479f-4074-bb40-ce6722e43c82"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRImageCompositor
    {
        [PreserveSig]
        HRESULT InitCompositionTarget(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pD3DDevice, /* [in] */ LPDIRECTDRAWSURFACE7 pddsRenderTarget);
        
        [PreserveSig]
        HRESULT TermCompositionTarget(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pD3DDevice, /* [in] */ LPDIRECTDRAWSURFACE7 pddsRenderTarget);
        
        [PreserveSig]
        HRESULT SetStreamMediaType(/* [in] */ uint dwStrmID, /* [in] */ ref _AMMediaType pmt, /* [in] */ bool fTexture);
        
        [PreserveSig]
        HRESULT CompositeImage(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pD3DDevice, /* [in] */ LPDIRECTDRAWSURFACE7 pddsRenderTarget, /* [in] */ ref _AMMediaType pmtRenderTarget, /* [in] */ long rtStart, /* [in] */ long rtEnd, /* [in] */ uint dwClrBkGnd, /* [in] */ ref _VMRVIDEOSTREAMINFO pVideoStreamInfo, /* [in] */ uint cStreams);
    }
}
