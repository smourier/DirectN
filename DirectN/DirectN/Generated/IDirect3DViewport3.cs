// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d.h(1326,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;
using LPDIRECTDRAWSURFACE4 = DirectN.IDirectDrawSurface4;

namespace DirectN
{
    [Guid("b0ab3b61-33d7-11d1-a981-00c04fd7b174"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DViewport3 : IDirect3DViewport2
    {
        // IDirect3DViewport
        [PreserveSig]
        new HRESULT Initialize(IDirect3D __unnamed_0);
        
        [PreserveSig]
        new HRESULT GetViewport(ref _D3DVIEWPORT __unnamed_0);
        
        [PreserveSig]
        new HRESULT SetViewport(ref _D3DVIEWPORT __unnamed_0);
        
        [PreserveSig]
        new HRESULT TransformVertices(uint __unnamed_0, ref _D3DTRANSFORMDATA __unnamed_1, uint __unnamed_2, ref uint __unnamed_3);
        
        [PreserveSig]
        new HRESULT LightElements(uint __unnamed_0, ref _D3DLIGHTDATA __unnamed_1);
        
        [PreserveSig]
        new HRESULT SetBackground(uint __unnamed_0);
        
        [PreserveSig]
        new HRESULT GetBackground(ref uint __unnamed_0, ref bool __unnamed_1);
        
        [PreserveSig]
        new HRESULT SetBackgroundDepth(LPDIRECTDRAWSURFACE __unnamed_0);
        
        [PreserveSig]
        new HRESULT GetBackgroundDepth(out LPDIRECTDRAWSURFACE __unnamed_0, ref bool __unnamed_1);
        
        [PreserveSig]
        new HRESULT Clear(uint __unnamed_0, ref _D3DRECT __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        new HRESULT AddLight(IDirect3DLight __unnamed_0);
        
        [PreserveSig]
        new HRESULT DeleteLight(IDirect3DLight __unnamed_0);
        
        [PreserveSig]
        new HRESULT NextLight(IDirect3DLight __unnamed_0, out IDirect3DLight __unnamed_1, uint __unnamed_2);
        
        // IDirect3DViewport2
        [PreserveSig]
        new HRESULT GetViewport2(ref _D3DVIEWPORT2 __unnamed_0);
        
        [PreserveSig]
        new HRESULT SetViewport2(ref _D3DVIEWPORT2 __unnamed_0);
        
        // IDirect3DViewport3
        [PreserveSig]
        HRESULT SetBackgroundDepth2(LPDIRECTDRAWSURFACE4 __unnamed_0);
        
        [PreserveSig]
        HRESULT GetBackgroundDepth2(out LPDIRECTDRAWSURFACE4 __unnamed_0, ref bool __unnamed_1);
        
        [PreserveSig]
        HRESULT Clear2(uint __unnamed_0, ref _D3DRECT __unnamed_1, uint __unnamed_2, uint __unnamed_3, float __unnamed_4, uint __unnamed_5);
    }
}
