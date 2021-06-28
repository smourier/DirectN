// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d.h(594,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECT3DTEXTURE2 = DirectN.IDirect3DTexture2;
using LPDIRECT3DVERTEXBUFFER = DirectN.IDirect3DVertexBuffer;
using LPDIRECT3DVIEWPORT3 = DirectN.IDirect3DViewport3;
using LPDIRECTDRAWSURFACE4 = DirectN.IDirectDrawSurface4;

namespace DirectN
{
    [ComImport, Guid("b0ab3b60-33d7-11d1-a981-00c04fd7b174"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DDevice3
    {
        [PreserveSig]
        HRESULT GetCaps(ref _D3DDeviceDesc unnamed__0, ref _D3DDeviceDesc unnamed__1);
        
        [PreserveSig]
        HRESULT GetStats(ref _D3DSTATS unnamed__0);
        
        [PreserveSig]
        HRESULT AddViewport(LPDIRECT3DVIEWPORT3 unnamed__0);
        
        [PreserveSig]
        HRESULT DeleteViewport(LPDIRECT3DVIEWPORT3 unnamed__0);
        
        [PreserveSig]
        HRESULT NextViewport(LPDIRECT3DVIEWPORT3 unnamed__0, out LPDIRECT3DVIEWPORT3 unnamed__1, uint unnamed__2);
        
        [PreserveSig]
        HRESULT EnumTextureFormats(IntPtr unnamed__0, IntPtr unnamed__1);
        
        [PreserveSig]
        HRESULT BeginScene();
        
        [PreserveSig]
        HRESULT EndScene();
        
        [PreserveSig]
        HRESULT GetDirect3D(out IDirect3D3 unnamed__0);
        
        [PreserveSig]
        HRESULT SetCurrentViewport(LPDIRECT3DVIEWPORT3 unnamed__0);
        
        [PreserveSig]
        HRESULT GetCurrentViewport(out LPDIRECT3DVIEWPORT3 unnamed__0);
        
        [PreserveSig]
        HRESULT SetRenderTarget(LPDIRECTDRAWSURFACE4 unnamed__0, uint unnamed__1);
        
        [PreserveSig]
        HRESULT GetRenderTarget(out LPDIRECTDRAWSURFACE4 unnamed__0);
        
        [PreserveSig]
        HRESULT Begin(_D3DPRIMITIVETYPE unnamed__0, uint unnamed__1, uint unnamed__2);
        
        [PreserveSig]
        HRESULT BeginIndexed(_D3DPRIMITIVETYPE unnamed__0, uint unnamed__1, IntPtr unnamed__2, uint unnamed__3, uint unnamed__4);
        
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
        HRESULT DrawPrimitive(_D3DPRIMITIVETYPE unnamed__0, uint unnamed__1, IntPtr unnamed__2, uint unnamed__3, uint unnamed__4);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitive(_D3DPRIMITIVETYPE unnamed__0, uint unnamed__1, IntPtr unnamed__2, uint unnamed__3, ref ushort unnamed__4, uint unnamed__5, uint unnamed__6);
        
        [PreserveSig]
        HRESULT SetClipStatus(ref _D3DCLIPSTATUS unnamed__0);
        
        [PreserveSig]
        HRESULT GetClipStatus(ref _D3DCLIPSTATUS unnamed__0);
        
        [PreserveSig]
        HRESULT DrawPrimitiveStrided(_D3DPRIMITIVETYPE unnamed__0, uint unnamed__1, ref _D3DDRAWPRIMITIVESTRIDEDDATA unnamed__2, uint unnamed__3, uint unnamed__4);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitiveStrided(_D3DPRIMITIVETYPE unnamed__0, uint unnamed__1, ref _D3DDRAWPRIMITIVESTRIDEDDATA unnamed__2, uint unnamed__3, ref ushort unnamed__4, uint unnamed__5, uint unnamed__6);
        
        [PreserveSig]
        HRESULT DrawPrimitiveVB(_D3DPRIMITIVETYPE unnamed__0, LPDIRECT3DVERTEXBUFFER unnamed__1, uint unnamed__2, uint unnamed__3, uint unnamed__4);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitiveVB(_D3DPRIMITIVETYPE unnamed__0, LPDIRECT3DVERTEXBUFFER unnamed__1, ref ushort unnamed__2, uint unnamed__3, uint unnamed__4);
        
        [PreserveSig]
        HRESULT ComputeSphereVisibility(ref _D3DVECTOR unnamed__0, ref LPD3DVALUE unnamed__1, uint unnamed__2, uint unnamed__3, ref uint unnamed__4);
        
        [PreserveSig]
        HRESULT GetTexture(uint unnamed__0, out LPDIRECT3DTEXTURE2 unnamed__1);
        
        [PreserveSig]
        HRESULT SetTexture(uint unnamed__0, LPDIRECT3DTEXTURE2 unnamed__1);
        
        [PreserveSig]
        HRESULT GetTextureStageState(uint unnamed__0, _D3DTEXTURESTAGESTATETYPE unnamed__1, ref uint unnamed__2);
        
        [PreserveSig]
        HRESULT SetTextureStageState(uint unnamed__0, _D3DTEXTURESTAGESTATETYPE unnamed__1, uint unnamed__2);
        
        [PreserveSig]
        HRESULT ValidateDevice(ref uint unnamed__0);
    }
}
