// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(594,1)
using System;
using System.Runtime.InteropServices;
using LPD3DVALUE = System.Single;
using LPDIRECT3DTEXTURE2 = DirectN.IDirect3DTexture2;
using LPDIRECT3DVERTEXBUFFER = DirectN.IDirect3DVertexBuffer;
using LPDIRECT3DVIEWPORT3 = DirectN.IDirect3DViewport3;
using LPDIRECTDRAWSURFACE4 = DirectN.IDirectDrawSurface4;

namespace DirectN
{
    [Guid("b0ab3b60-33d7-11d1-a981-00c04fd7b174"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DDevice3
    {
        [PreserveSig]
        HRESULT GetCaps(ref _D3DDeviceDesc __unnamed_0, ref _D3DDeviceDesc __unnamed_1);
        
        [PreserveSig]
        HRESULT GetStats(ref _D3DSTATS __unnamed_0);
        
        [PreserveSig]
        HRESULT AddViewport(ref LPDIRECT3DVIEWPORT3 __unnamed_0);
        
        [PreserveSig]
        HRESULT DeleteViewport(ref LPDIRECT3DVIEWPORT3 __unnamed_0);
        
        [PreserveSig]
        HRESULT NextViewport(ref LPDIRECT3DVIEWPORT3 __unnamed_0, ref LPDIRECT3DVIEWPORT3 __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT EnumTextureFormats(ref IntPtr __unnamed_0, ref IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT BeginScene();
        
        [PreserveSig]
        HRESULT EndScene();
        
        [PreserveSig]
        HRESULT GetDirect3D(ref IDirect3D3 __unnamed_0);
        
        [PreserveSig]
        HRESULT SetCurrentViewport(ref LPDIRECT3DVIEWPORT3 __unnamed_0);
        
        [PreserveSig]
        HRESULT GetCurrentViewport(ref LPDIRECT3DVIEWPORT3 __unnamed_0);
        
        [PreserveSig]
        HRESULT SetRenderTarget(ref LPDIRECTDRAWSURFACE4 __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT GetRenderTarget(ref LPDIRECTDRAWSURFACE4 __unnamed_0);
        
        [PreserveSig]
        HRESULT Begin(_D3DPRIMITIVETYPE __unnamed_0, uint __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT BeginIndexed(_D3DPRIMITIVETYPE __unnamed_0, uint __unnamed_1, ref IntPtr __unnamed_2, uint __unnamed_3, uint __unnamed_4);
        
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
        HRESULT DrawPrimitive(_D3DPRIMITIVETYPE __unnamed_0, uint __unnamed_1, ref IntPtr __unnamed_2, uint __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitive(_D3DPRIMITIVETYPE __unnamed_0, uint __unnamed_1, ref IntPtr __unnamed_2, uint __unnamed_3, ref ushort __unnamed_4, uint __unnamed_5, uint __unnamed_6);
        
        [PreserveSig]
        HRESULT SetClipStatus(ref _D3DCLIPSTATUS __unnamed_0);
        
        [PreserveSig]
        HRESULT GetClipStatus(ref _D3DCLIPSTATUS __unnamed_0);
        
        [PreserveSig]
        HRESULT DrawPrimitiveStrided(_D3DPRIMITIVETYPE __unnamed_0, uint __unnamed_1, ref _D3DDRAWPRIMITIVESTRIDEDDATA __unnamed_2, uint __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitiveStrided(_D3DPRIMITIVETYPE __unnamed_0, uint __unnamed_1, ref _D3DDRAWPRIMITIVESTRIDEDDATA __unnamed_2, uint __unnamed_3, ref ushort __unnamed_4, uint __unnamed_5, uint __unnamed_6);
        
        [PreserveSig]
        HRESULT DrawPrimitiveVB(_D3DPRIMITIVETYPE __unnamed_0, ref LPDIRECT3DVERTEXBUFFER __unnamed_1, uint __unnamed_2, uint __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitiveVB(_D3DPRIMITIVETYPE __unnamed_0, ref LPDIRECT3DVERTEXBUFFER __unnamed_1, ref ushort __unnamed_2, uint __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT ComputeSphereVisibility(ref _D3DVECTOR __unnamed_0, ref LPD3DVALUE __unnamed_1, uint __unnamed_2, uint __unnamed_3, ref uint __unnamed_4);
        
        [PreserveSig]
        HRESULT GetTexture(uint __unnamed_0, ref LPDIRECT3DTEXTURE2 __unnamed_1);
        
        [PreserveSig]
        HRESULT SetTexture(uint __unnamed_0, ref LPDIRECT3DTEXTURE2 __unnamed_1);
        
        [PreserveSig]
        HRESULT GetTextureStageState(uint __unnamed_0, _D3DTEXTURESTAGESTATETYPE __unnamed_1, ref uint __unnamed_2);
        
        [PreserveSig]
        HRESULT SetTextureStageState(uint __unnamed_0, _D3DTEXTURESTAGESTATETYPE __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT ValidateDevice(ref uint __unnamed_0);
    }
}
