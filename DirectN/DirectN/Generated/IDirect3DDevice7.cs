// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d.h(738,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECT3DVERTEXBUFFER7 = DirectN.IDirect3DVertexBuffer7;
using LPDIRECTDRAWSURFACE7 = DirectN.IDirectDrawSurface7;

namespace DirectN
{
    [Guid("f5049e79-4861-11d2-a407-00a0c90629a8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DDevice7
    {
        [PreserveSig]
        HRESULT GetCaps(ref _D3DDeviceDesc7 unnamed__0);
        
        [PreserveSig]
        HRESULT EnumTextureFormats(IntPtr unnamed__0, IntPtr unnamed__1);
        
        [PreserveSig]
        HRESULT BeginScene();
        
        [PreserveSig]
        HRESULT EndScene();
        
        [PreserveSig]
        HRESULT GetDirect3D(out IDirect3D7 unnamed__0);
        
        [PreserveSig]
        HRESULT SetRenderTarget(LPDIRECTDRAWSURFACE7 unnamed__0, uint unnamed__1);
        
        [PreserveSig]
        HRESULT GetRenderTarget(out LPDIRECTDRAWSURFACE7 unnamed__0);
        
        [PreserveSig]
        HRESULT Clear(uint unnamed__0, ref _D3DRECT unnamed__1, uint unnamed__2, uint unnamed__3, float unnamed__4, uint unnamed__5);
        
        [PreserveSig]
        HRESULT SetTransform(_D3DTRANSFORMSTATETYPE unnamed__0, ref _D3DMATRIX unnamed__1);
        
        [PreserveSig]
        HRESULT GetTransform(_D3DTRANSFORMSTATETYPE unnamed__0, ref _D3DMATRIX unnamed__1);
        
        [PreserveSig]
        HRESULT SetViewport(ref _D3DVIEWPORT7 unnamed__0);
        
        [PreserveSig]
        HRESULT MultiplyTransform(_D3DTRANSFORMSTATETYPE unnamed__0, ref _D3DMATRIX unnamed__1);
        
        [PreserveSig]
        HRESULT GetViewport(ref _D3DVIEWPORT7 unnamed__0);
        
        [PreserveSig]
        HRESULT SetMaterial(ref _D3DMATERIAL7 unnamed__0);
        
        [PreserveSig]
        HRESULT GetMaterial(ref _D3DMATERIAL7 unnamed__0);
        
        [PreserveSig]
        HRESULT SetLight(uint unnamed__0, ref _D3DLIGHT7 unnamed__1);
        
        [PreserveSig]
        HRESULT GetLight(uint unnamed__0, ref _D3DLIGHT7 unnamed__1);
        
        [PreserveSig]
        HRESULT SetRenderState(_D3DRENDERSTATETYPE unnamed__0, uint unnamed__1);
        
        [PreserveSig]
        HRESULT GetRenderState(_D3DRENDERSTATETYPE unnamed__0, ref uint unnamed__1);
        
        [PreserveSig]
        HRESULT BeginStateBlock();
        
        [PreserveSig]
        HRESULT EndStateBlock(ref uint unnamed__0);
        
        [PreserveSig]
        HRESULT PreLoad(LPDIRECTDRAWSURFACE7 unnamed__0);
        
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
        HRESULT DrawPrimitiveVB(_D3DPRIMITIVETYPE unnamed__0, LPDIRECT3DVERTEXBUFFER7 unnamed__1, uint unnamed__2, uint unnamed__3, uint unnamed__4);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitiveVB(_D3DPRIMITIVETYPE unnamed__0, LPDIRECT3DVERTEXBUFFER7 unnamed__1, uint unnamed__2, uint unnamed__3, ref ushort unnamed__4, uint unnamed__5, uint unnamed__6);
        
        [PreserveSig]
        HRESULT ComputeSphereVisibility(ref _D3DVECTOR unnamed__0, ref LPD3DVALUE unnamed__1, uint unnamed__2, uint unnamed__3, ref uint unnamed__4);
        
        [PreserveSig]
        HRESULT GetTexture(uint unnamed__0, out LPDIRECTDRAWSURFACE7 unnamed__1);
        
        [PreserveSig]
        HRESULT SetTexture(uint unnamed__0, LPDIRECTDRAWSURFACE7 unnamed__1);
        
        [PreserveSig]
        HRESULT GetTextureStageState(uint unnamed__0, _D3DTEXTURESTAGESTATETYPE unnamed__1, ref uint unnamed__2);
        
        [PreserveSig]
        HRESULT SetTextureStageState(uint unnamed__0, _D3DTEXTURESTAGESTATETYPE unnamed__1, uint unnamed__2);
        
        [PreserveSig]
        HRESULT ValidateDevice(ref uint unnamed__0);
        
        [PreserveSig]
        HRESULT ApplyStateBlock(uint unnamed__0);
        
        [PreserveSig]
        HRESULT CaptureStateBlock(uint unnamed__0);
        
        [PreserveSig]
        HRESULT DeleteStateBlock(uint unnamed__0);
        
        [PreserveSig]
        HRESULT CreateStateBlock(_D3DSTATEBLOCKTYPE unnamed__0, ref uint unnamed__1);
        
        [PreserveSig]
        HRESULT Load(LPDIRECTDRAWSURFACE7 unnamed__0, ref tagPOINT unnamed__1, LPDIRECTDRAWSURFACE7 unnamed__2, ref tagRECT unnamed__3, uint unnamed__4);
        
        [PreserveSig]
        HRESULT LightEnable(uint unnamed__0, bool unnamed__1);
        
        [PreserveSig]
        HRESULT GetLightEnable(uint unnamed__0, ref bool unnamed__1);
        
        [PreserveSig]
        HRESULT SetClipPlane(uint unnamed__0, ref float unnamed__1);
        
        [PreserveSig]
        HRESULT GetClipPlane(uint unnamed__0, ref float unnamed__1);
        
        [PreserveSig]
        HRESULT GetInfo(uint unnamed__0, IntPtr unnamed__1, uint unnamed__2);
    }
}
