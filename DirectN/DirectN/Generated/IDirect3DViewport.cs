// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d.h(1188,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [Guid("4417c146-33ad-11cf-816f-0000c020156e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DViewport
    {
        [PreserveSig]
        HRESULT Initialize(IDirect3D __unnamed_0);
        
        [PreserveSig]
        HRESULT GetViewport(ref _D3DVIEWPORT __unnamed_0);
        
        [PreserveSig]
        HRESULT SetViewport(ref _D3DVIEWPORT __unnamed_0);
        
        [PreserveSig]
        HRESULT TransformVertices(uint __unnamed_0, ref _D3DTRANSFORMDATA __unnamed_1, uint __unnamed_2, ref uint __unnamed_3);
        
        [PreserveSig]
        HRESULT LightElements(uint __unnamed_0, ref _D3DLIGHTDATA __unnamed_1);
        
        [PreserveSig]
        HRESULT SetBackground(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetBackground(ref uint __unnamed_0, ref bool __unnamed_1);
        
        [PreserveSig]
        HRESULT SetBackgroundDepth(LPDIRECTDRAWSURFACE __unnamed_0);
        
        [PreserveSig]
        HRESULT GetBackgroundDepth(out LPDIRECTDRAWSURFACE __unnamed_0, ref bool __unnamed_1);
        
        [PreserveSig]
        HRESULT Clear(uint __unnamed_0, ref _D3DRECT __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT AddLight(IDirect3DLight __unnamed_0);
        
        [PreserveSig]
        HRESULT DeleteLight(IDirect3DLight __unnamed_0);
        
        [PreserveSig]
        HRESULT NextLight(IDirect3DLight __unnamed_0, out IDirect3DLight __unnamed_1, uint __unnamed_2);
    }
}
