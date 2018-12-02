// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(477,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECT3DTEXTURE2 = DirectN.IDirect3DTexture2;
using LPDIRECT3DVIEWPORT2 = DirectN.IDirect3DViewport2;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [Guid("93281501-8cf8-11d0-89ab-00a0c9054129"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DDevice2
    {
        [PreserveSig]
        HRESULT GetCaps(ref _D3DDeviceDesc __unnamed_0, ref _D3DDeviceDesc __unnamed_1);
        
        [PreserveSig]
        HRESULT SwapTextureHandles(ref LPDIRECT3DTEXTURE2 __unnamed_0, ref LPDIRECT3DTEXTURE2 __unnamed_1);
        
        [PreserveSig]
        HRESULT GetStats(ref _D3DSTATS __unnamed_0);
        
        [PreserveSig]
        HRESULT AddViewport(ref LPDIRECT3DVIEWPORT2 __unnamed_0);
        
        [PreserveSig]
        HRESULT DeleteViewport(ref LPDIRECT3DVIEWPORT2 __unnamed_0);
        
        [PreserveSig]
        HRESULT NextViewport(ref LPDIRECT3DVIEWPORT2 __unnamed_0, ref LPDIRECT3DVIEWPORT2 __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT EnumTextureFormats(ref IntPtr __unnamed_0, ref IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT BeginScene();
        
        [PreserveSig]
        HRESULT EndScene();
        
        [PreserveSig]
        HRESULT GetDirect3D(ref IDirect3D2 __unnamed_0);
        
        [PreserveSig]
        HRESULT SetCurrentViewport(ref LPDIRECT3DVIEWPORT2 __unnamed_0);
        
        [PreserveSig]
        HRESULT GetCurrentViewport(ref LPDIRECT3DVIEWPORT2 __unnamed_0);
        
        [PreserveSig]
        HRESULT SetRenderTarget(ref LPDIRECTDRAWSURFACE __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT GetRenderTarget(ref LPDIRECTDRAWSURFACE __unnamed_0);
        
        [PreserveSig]
        HRESULT Begin(_D3DPRIMITIVETYPE __unnamed_0, _D3DVERTEXTYPE __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT BeginIndexed(_D3DPRIMITIVETYPE __unnamed_0, _D3DVERTEXTYPE __unnamed_1, ref IntPtr __unnamed_2, uint __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT Vertex(ref IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Index(ushort __unnamed_0);
        
        [PreserveSig]
        HRESULT End(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetRenderState(_D3DRENDERSTATETYPE __unnamed_0, ref uint __unnamed_1);
        
        [PreserveSig]
        HRESULT SetRenderState(_D3DRENDERSTATETYPE __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT GetLightState(_D3DLIGHTSTATETYPE __unnamed_0, ref uint __unnamed_1);
        
        [PreserveSig]
        HRESULT SetLightState(_D3DLIGHTSTATETYPE __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT SetTransform(_D3DTRANSFORMSTATETYPE __unnamed_0, ref _D3DMATRIX __unnamed_1);
        
        [PreserveSig]
        HRESULT GetTransform(_D3DTRANSFORMSTATETYPE __unnamed_0, ref _D3DMATRIX __unnamed_1);
        
        [PreserveSig]
        HRESULT MultiplyTransform(_D3DTRANSFORMSTATETYPE __unnamed_0, ref _D3DMATRIX __unnamed_1);
        
        [PreserveSig]
        HRESULT DrawPrimitive(_D3DPRIMITIVETYPE __unnamed_0, _D3DVERTEXTYPE __unnamed_1, ref IntPtr __unnamed_2, uint __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitive(_D3DPRIMITIVETYPE __unnamed_0, _D3DVERTEXTYPE __unnamed_1, ref IntPtr __unnamed_2, uint __unnamed_3, ref ushort __unnamed_4, uint __unnamed_5, uint __unnamed_6);
        
        [PreserveSig]
        HRESULT SetClipStatus(ref _D3DCLIPSTATUS __unnamed_0);
        
        [PreserveSig]
        HRESULT GetClipStatus(ref _D3DCLIPSTATUS __unnamed_0);
    }
}
