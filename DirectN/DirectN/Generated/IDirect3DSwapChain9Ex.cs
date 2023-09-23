// generated from <Windows SDK Path>\shared\d3d9.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("91886caf-1c3d-4d2e-a0ab-3e4c7d8d3303"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DSwapChain9Ex : IDirect3DSwapChain9
    {
        // IDirect3DSwapChain9
        [PreserveSig]
        new HRESULT Present(ref tagRECT pSourceRect, ref tagRECT pDestRect, IntPtr hDestWindowOverride, ref _RGNDATA pDirtyRegion, uint dwFlags);
        
        [PreserveSig]
        new HRESULT GetFrontBufferData(IDirect3DSurface9 pDestSurface);
        
        [PreserveSig]
        new HRESULT GetBackBuffer(uint iBackBuffer, _D3DBACKBUFFER_TYPE Type, out IDirect3DSurface9 ppBackBuffer);
        
        [PreserveSig]
        new HRESULT GetRasterStatus(ref _D3DRASTER_STATUS pRasterStatus);
        
        [PreserveSig]
        new HRESULT GetDisplayMode(ref _D3DDISPLAYMODE pMode);
        
        [PreserveSig]
        new HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        new HRESULT GetPresentParameters(IntPtr pPresentationParameters);
        
        // IDirect3DSwapChain9Ex
        [PreserveSig]
        HRESULT GetLastPresentCount(ref uint pLastPresentCount);
        
        [PreserveSig]
        HRESULT GetPresentStats(IntPtr pPresentationStatistics);
        
        [PreserveSig]
        HRESULT GetDisplayModeEx(ref D3DDISPLAYMODEEX pMode, ref D3DDISPLAYROTATION pRotation);
    }
}
