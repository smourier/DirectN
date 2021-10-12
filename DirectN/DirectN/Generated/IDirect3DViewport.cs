// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d.h(1188,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [ComImport, Guid("4417c146-33ad-11cf-816f-0000c020156e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DViewport
    {
        [PreserveSig]
        HRESULT Initialize(IDirect3D unnamed__0);
        
        [PreserveSig]
        HRESULT GetViewport(ref _D3DVIEWPORT unnamed__0);
        
        [PreserveSig]
        HRESULT SetViewport(ref _D3DVIEWPORT unnamed__0);
        
        [PreserveSig]
        HRESULT TransformVertices(uint unnamed__0, ref _D3DTRANSFORMDATA unnamed__1, uint unnamed__2, ref uint unnamed__3);
        
        [PreserveSig]
        HRESULT LightElements(uint unnamed__0, ref _D3DLIGHTDATA unnamed__1);
        
        [PreserveSig]
        HRESULT SetBackground(uint unnamed__0);
        
        [PreserveSig]
        HRESULT GetBackground(ref uint unnamed__0, ref bool unnamed__1);
        
        [PreserveSig]
        HRESULT SetBackgroundDepth(LPDIRECTDRAWSURFACE unnamed__0);
        
        [PreserveSig]
        HRESULT GetBackgroundDepth(out LPDIRECTDRAWSURFACE unnamed__0, ref bool unnamed__1);
        
        [PreserveSig]
        HRESULT Clear(uint unnamed__0, ref _D3DRECT unnamed__1, uint unnamed__2);
        
        [PreserveSig]
        HRESULT AddLight(IDirect3DLight unnamed__0);
        
        [PreserveSig]
        HRESULT DeleteLight(IDirect3DLight unnamed__0);
        
        [PreserveSig]
        HRESULT NextLight(IDirect3DLight unnamed__0, out IDirect3DLight unnamed__1, uint unnamed__2);
    }
}
