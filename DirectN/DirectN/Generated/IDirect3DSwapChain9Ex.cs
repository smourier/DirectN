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
        new HRESULT Present(ref tagRECT pSourceRect, ref tagRECT pDestRect, ref IntPtr hDestWindowOverride, ref _RGNDATA pDirtyRegion, uint dwFlags);
        
        [PreserveSig]
        new HRESULT GetFrontBufferData(ref IDirect3DSurface9 pDestSurface);
        
        [PreserveSig]
        new HRESULT GetBackBuffer(uint iBackBuffer, _D3DBACKBUFFER_TYPE Type, ref IDirect3DSurface9 ppBackBuffer);
        
        [PreserveSig]
        new HRESULT GetRasterStatus(ref _D3DRASTER_STATUS pRasterStatus);
        
        [PreserveSig]
        new HRESULT GetDisplayMode(ref _D3DDISPLAYMODE pMode);
        
        [PreserveSig]
        new HRESULT GetDevice(ref IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        new HRESULT GetPresentParameters(ref _D3DPRESENT_PARAMETERS_ pPresentationParameters);
        
        // IDirect3DSwapChain9Ex
        [PreserveSig]
        HRESULT GetLastPresentCount(ref uint pLastPresentCount);
        
        [PreserveSig]
        HRESULT GetPresentStats(ref _D3DPRESENTSTATS pPresentationStatistics);
        
        [PreserveSig]
        HRESULT GetDisplayModeEx(ref D3DDISPLAYMODEEX pMode, ref D3DDISPLAYROTATION pRotation);
    }
}
