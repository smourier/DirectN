// generated from <Windows SDK Path>\um\d3d.h
using System;
using System.Runtime.InteropServices;
using LPDIRECT3DTEXTURE2 = DirectN.IDirect3DTexture2;
using LPDIRECT3DVIEWPORT2 = DirectN.IDirect3DViewport2;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [ComImport, Guid("93281501-8cf8-11d0-89ab-00a0c9054129"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DDevice2
    {
        [PreserveSig]
        HRESULT GetCaps(ref _D3DDeviceDesc unnamed__0, ref _D3DDeviceDesc unnamed__1);
        
        [PreserveSig]
        HRESULT SwapTextureHandles(LPDIRECT3DTEXTURE2 unnamed__0, LPDIRECT3DTEXTURE2 unnamed__1);
        
        [PreserveSig]
        HRESULT GetStats(ref _D3DSTATS unnamed__0);
        
        [PreserveSig]
        HRESULT AddViewport(LPDIRECT3DVIEWPORT2 unnamed__0);
        
        [PreserveSig]
        HRESULT DeleteViewport(LPDIRECT3DVIEWPORT2 unnamed__0);
        
        [PreserveSig]
        HRESULT NextViewport(LPDIRECT3DVIEWPORT2 unnamed__0, out LPDIRECT3DVIEWPORT2 unnamed__1, uint unnamed__2);
        
        [PreserveSig]
        HRESULT EnumTextureFormats(IntPtr unnamed__0, IntPtr unnamed__1);
        
        [PreserveSig]
        HRESULT BeginScene();
        
        [PreserveSig]
        HRESULT EndScene();
        
        [PreserveSig]
        HRESULT GetDirect3D(out IDirect3D2 unnamed__0);
        
        [PreserveSig]
        HRESULT SetCurrentViewport(LPDIRECT3DVIEWPORT2 unnamed__0);
        
        [PreserveSig]
        HRESULT GetCurrentViewport(out LPDIRECT3DVIEWPORT2 unnamed__0);
        
        [PreserveSig]
        HRESULT SetRenderTarget(LPDIRECTDRAWSURFACE unnamed__0, uint unnamed__1);
        
        [PreserveSig]
        HRESULT GetRenderTarget(out LPDIRECTDRAWSURFACE unnamed__0);
        
        [PreserveSig]
        HRESULT Begin(_D3DPRIMITIVETYPE unnamed__0, _D3DVERTEXTYPE unnamed__1, uint unnamed__2);
        
        [PreserveSig]
        HRESULT BeginIndexed(_D3DPRIMITIVETYPE unnamed__0, _D3DVERTEXTYPE unnamed__1, IntPtr unnamed__2, uint unnamed__3, uint unnamed__4);
        
        [PreserveSig]
        HRESULT Vertex(IntPtr unnamed__0);
        
        [PreserveSig]
        HRESULT Index(ushort unnamed__0);
        
        [PreserveSig]
        HRESULT End(uint unnamed__0);
        
        [PreserveSig]
        HRESULT GetRenderState(_D3DRENDERSTATETYPE unnamed__0, ref uint unnamed__1);
        
        [PreserveSig]
        HRESULT SetRenderState(_D3DRENDERSTATETYPE unnamed__0, uint unnamed__1);
        
        [PreserveSig]
        HRESULT GetLightState(_D3DLIGHTSTATETYPE unnamed__0, ref uint unnamed__1);
        
        [PreserveSig]
        HRESULT SetLightState(_D3DLIGHTSTATETYPE unnamed__0, uint unnamed__1);
        
        [PreserveSig]
        HRESULT SetTransform(_D3DTRANSFORMSTATETYPE unnamed__0, ref _D3DMATRIX unnamed__1);
        
        [PreserveSig]
        HRESULT GetTransform(_D3DTRANSFORMSTATETYPE unnamed__0, ref _D3DMATRIX unnamed__1);
        
        [PreserveSig]
        HRESULT MultiplyTransform(_D3DTRANSFORMSTATETYPE unnamed__0, ref _D3DMATRIX unnamed__1);
        
        [PreserveSig]
        HRESULT DrawPrimitive(_D3DPRIMITIVETYPE unnamed__0, _D3DVERTEXTYPE unnamed__1, IntPtr unnamed__2, uint unnamed__3, uint unnamed__4);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitive(_D3DPRIMITIVETYPE unnamed__0, _D3DVERTEXTYPE unnamed__1, IntPtr unnamed__2, uint unnamed__3, ref ushort unnamed__4, uint unnamed__5, uint unnamed__6);
        
        [PreserveSig]
        HRESULT SetClipStatus(ref _D3DCLIPSTATUS unnamed__0);
        
        [PreserveSig]
        HRESULT GetClipStatus(ref _D3DCLIPSTATUS unnamed__0);
    }
}
