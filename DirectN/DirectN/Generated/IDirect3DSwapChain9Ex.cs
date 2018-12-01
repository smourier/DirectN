// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9.h(206,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("91886caf-1c3d-4d2e-a0ab-3e4c7d8d3303"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DSwapChain9Ex : IDirect3DSwapChain9
    {
        // IDirect3DSwapChain9
        [PreserveSig]
        new HRESULT QueryInterface([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] object ppvObj);
        
        [PreserveSig]
        new uint AddRef();
        
        [PreserveSig]
        new uint Release();
        
        [PreserveSig]
        new HRESULT Present(ref tagRECT pSourceRect, ref tagRECT pDestRect, IntPtr hDestWindowOverride, ref _RGNDATA pDirtyRegion, uint dwFlags);
        
        [PreserveSig]
        new HRESULT GetFrontBufferData(IDirect3DSurface9 pDestSurface);
        
        [PreserveSig]
        new HRESULT GetBackBuffer(uint iBackBuffer, _D3DBACKBUFFER_TYPE Type, IDirect3DSurface9 ppBackBuffer);
        
        [PreserveSig]
        new HRESULT GetRasterStatus(ref _D3DRASTER_STATUS pRasterStatus);
        
        [PreserveSig]
        new HRESULT GetDisplayMode(ref _D3DDISPLAYMODE pMode);
        
        [PreserveSig]
        new HRESULT GetDevice(IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        new HRESULT GetPresentParameters(ref _D3DPRESENT_PARAMETERS_ pPresentationParameters);
        
        // IDirect3DSwapChain9Ex
        [PreserveSig]
        HRESULT Present(ref tagRECT pSourceRect, ref tagRECT pDestRect, IntPtr hDestWindowOverride, ref _RGNDATA pDirtyRegion, uint dwFlags);
        
        [PreserveSig]
        HRESULT GetFrontBufferData(IDirect3DSurface9 pDestSurface);
        
        [PreserveSig]
        HRESULT GetBackBuffer(uint iBackBuffer, _D3DBACKBUFFER_TYPE Type, IDirect3DSurface9 ppBackBuffer);
        
        [PreserveSig]
        HRESULT GetRasterStatus(ref _D3DRASTER_STATUS pRasterStatus);
        
        [PreserveSig]
        HRESULT GetDisplayMode(ref _D3DDISPLAYMODE pMode);
        
        [PreserveSig]
        HRESULT GetDevice(IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        HRESULT GetPresentParameters(ref _D3DPRESENT_PARAMETERS_ pPresentationParameters);
        
        [PreserveSig]
        HRESULT GetLastPresentCount(ref uint pLastPresentCount);
        
        [PreserveSig]
        HRESULT GetPresentStats(ref _D3DPRESENTSTATS pPresentationStatistics);
        
        [PreserveSig]
        HRESULT GetDisplayModeEx(ref D3DDISPLAYMODEEX pMode, ref D3DDISPLAYROTATION pRotation);
    }
}
