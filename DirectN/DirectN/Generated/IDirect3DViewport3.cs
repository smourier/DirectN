// generated from <Windows SDK Path>\um\d3d.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;
using LPDIRECTDRAWSURFACE4 = DirectN.IDirectDrawSurface4;

namespace DirectN
{
    [ComImport, Guid("b0ab3b61-33d7-11d1-a981-00c04fd7b174"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DViewport3 : IDirect3DViewport2
    {
        // IDirect3DViewport
        [PreserveSig]
        new HRESULT Initialize(IDirect3D unnamed__0);
        
        [PreserveSig]
        new HRESULT GetViewport(ref _D3DVIEWPORT unnamed__0);
        
        [PreserveSig]
        new HRESULT SetViewport(ref _D3DVIEWPORT unnamed__0);
        
        [PreserveSig]
        new HRESULT TransformVertices(uint unnamed__0, ref _D3DTRANSFORMDATA unnamed__1, uint unnamed__2, ref uint unnamed__3);
        
        [PreserveSig]
        new HRESULT LightElements(uint unnamed__0, ref _D3DLIGHTDATA unnamed__1);
        
        [PreserveSig]
        new HRESULT SetBackground(uint unnamed__0);
        
        [PreserveSig]
        new HRESULT GetBackground(ref uint unnamed__0, ref bool unnamed__1);
        
        [PreserveSig]
        new HRESULT SetBackgroundDepth(LPDIRECTDRAWSURFACE unnamed__0);
        
        [PreserveSig]
        new HRESULT GetBackgroundDepth(out LPDIRECTDRAWSURFACE unnamed__0, ref bool unnamed__1);
        
        [PreserveSig]
        new HRESULT Clear(uint unnamed__0, ref _D3DRECT unnamed__1, uint unnamed__2);
        
        [PreserveSig]
        new HRESULT AddLight(IDirect3DLight unnamed__0);
        
        [PreserveSig]
        new HRESULT DeleteLight(IDirect3DLight unnamed__0);
        
        [PreserveSig]
        new HRESULT NextLight(IDirect3DLight unnamed__0, out IDirect3DLight unnamed__1, uint unnamed__2);
        
        // IDirect3DViewport2
        [PreserveSig]
        new HRESULT GetViewport2(ref _D3DVIEWPORT2 unnamed__0);
        
        [PreserveSig]
        new HRESULT SetViewport2(ref _D3DVIEWPORT2 unnamed__0);
        
        // IDirect3DViewport3
        [PreserveSig]
        HRESULT SetBackgroundDepth2(LPDIRECTDRAWSURFACE4 unnamed__0);
        
        [PreserveSig]
        HRESULT GetBackgroundDepth2(out LPDIRECTDRAWSURFACE4 unnamed__0, ref bool unnamed__1);
        
        [PreserveSig]
        HRESULT Clear2(uint unnamed__0, ref _D3DRECT unnamed__1, uint unnamed__2, uint unnamed__3, float unnamed__4, uint unnamed__5);
    }
}
