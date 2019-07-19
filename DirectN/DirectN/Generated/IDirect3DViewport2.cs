// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d.h(1253,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [Guid("93281500-8cf8-11d0-89ab-00a0c9054129"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DViewport2 : IDirect3DViewport
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
        HRESULT GetViewport2(ref _D3DVIEWPORT2 unnamed__0);
        
        [PreserveSig]
        HRESULT SetViewport2(ref _D3DVIEWPORT2 unnamed__0);
    }
}
