// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(1253,1)
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
        new HRESULT Initialize(ref IDirect3D __unnamed_0);
        
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
        new HRESULT SetBackgroundDepth(ref LPDIRECTDRAWSURFACE __unnamed_0);
        
        [PreserveSig]
        new HRESULT GetBackgroundDepth(ref LPDIRECTDRAWSURFACE __unnamed_0, ref bool __unnamed_1);
        
        [PreserveSig]
        new HRESULT Clear(uint __unnamed_0, ref _D3DRECT __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        new HRESULT AddLight(ref IDirect3DLight __unnamed_0);
        
        [PreserveSig]
        new HRESULT DeleteLight(ref IDirect3DLight __unnamed_0);
        
        [PreserveSig]
        new HRESULT NextLight(ref IDirect3DLight __unnamed_0, ref IDirect3DLight __unnamed_1, uint __unnamed_2);
        
        // IDirect3DViewport2
        [PreserveSig]
        HRESULT GetViewport2(ref _D3DVIEWPORT2 __unnamed_0);
        
        [PreserveSig]
        HRESULT SetViewport2(ref _D3DVIEWPORT2 __unnamed_0);
    }
}
