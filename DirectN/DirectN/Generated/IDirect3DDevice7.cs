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
        HRESULT GetCaps(ref _D3DDeviceDesc7 __unnamed_0);
        
        [PreserveSig]
        HRESULT EnumTextureFormats(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT BeginScene();
        
        [PreserveSig]
        HRESULT EndScene();
        
        [PreserveSig]
        HRESULT GetDirect3D(out IDirect3D7 __unnamed_0);
        
        [PreserveSig]
        HRESULT SetRenderTarget(LPDIRECTDRAWSURFACE7 __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT GetRenderTarget(out LPDIRECTDRAWSURFACE7 __unnamed_0);
        
        [PreserveSig]
        HRESULT Clear(uint __unnamed_0, ref _D3DRECT __unnamed_1, uint __unnamed_2, uint __unnamed_3, float __unnamed_4, uint __unnamed_5);
        
        [PreserveSig]
        HRESULT SetTransform(_D3DTRANSFORMSTATETYPE __unnamed_0, ref _D3DMATRIX __unnamed_1);
        
        [PreserveSig]
        HRESULT GetTransform(_D3DTRANSFORMSTATETYPE __unnamed_0, ref _D3DMATRIX __unnamed_1);
        
        [PreserveSig]
        HRESULT SetViewport(ref _D3DVIEWPORT7 __unnamed_0);
        
        [PreserveSig]
        HRESULT MultiplyTransform(_D3DTRANSFORMSTATETYPE __unnamed_0, ref _D3DMATRIX __unnamed_1);
        
        [PreserveSig]
        HRESULT GetViewport(ref _D3DVIEWPORT7 __unnamed_0);
        
        [PreserveSig]
        HRESULT SetMaterial(ref _D3DMATERIAL7 __unnamed_0);
        
        [PreserveSig]
        HRESULT GetMaterial(ref _D3DMATERIAL7 __unnamed_0);
        
        [PreserveSig]
        HRESULT SetLight(uint __unnamed_0, ref _D3DLIGHT7 __unnamed_1);
        
        [PreserveSig]
        HRESULT GetLight(uint __unnamed_0, ref _D3DLIGHT7 __unnamed_1);
        
        [PreserveSig]
        HRESULT SetRenderState(_D3DRENDERSTATETYPE __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT GetRenderState(_D3DRENDERSTATETYPE __unnamed_0, ref uint __unnamed_1);
        
        [PreserveSig]
        HRESULT BeginStateBlock();
        
        [PreserveSig]
        HRESULT EndStateBlock(ref uint __unnamed_0);
        
        [PreserveSig]
        HRESULT PreLoad(LPDIRECTDRAWSURFACE7 __unnamed_0);
        
        [PreserveSig]
        HRESULT DrawPrimitive(_D3DPRIMITIVETYPE __unnamed_0, uint __unnamed_1, IntPtr __unnamed_2, uint __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitive(_D3DPRIMITIVETYPE __unnamed_0, uint __unnamed_1, IntPtr __unnamed_2, uint __unnamed_3, ref ushort __unnamed_4, uint __unnamed_5, uint __unnamed_6);
        
        [PreserveSig]
        HRESULT SetClipStatus(ref _D3DCLIPSTATUS __unnamed_0);
        
        [PreserveSig]
        HRESULT GetClipStatus(ref _D3DCLIPSTATUS __unnamed_0);
        
        [PreserveSig]
        HRESULT DrawPrimitiveStrided(_D3DPRIMITIVETYPE __unnamed_0, uint __unnamed_1, ref _D3DDRAWPRIMITIVESTRIDEDDATA __unnamed_2, uint __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitiveStrided(_D3DPRIMITIVETYPE __unnamed_0, uint __unnamed_1, ref _D3DDRAWPRIMITIVESTRIDEDDATA __unnamed_2, uint __unnamed_3, ref ushort __unnamed_4, uint __unnamed_5, uint __unnamed_6);
        
        [PreserveSig]
        HRESULT DrawPrimitiveVB(_D3DPRIMITIVETYPE __unnamed_0, LPDIRECT3DVERTEXBUFFER7 __unnamed_1, uint __unnamed_2, uint __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitiveVB(_D3DPRIMITIVETYPE __unnamed_0, LPDIRECT3DVERTEXBUFFER7 __unnamed_1, uint __unnamed_2, uint __unnamed_3, ref ushort __unnamed_4, uint __unnamed_5, uint __unnamed_6);
        
        [PreserveSig]
        HRESULT ComputeSphereVisibility(ref _D3DVECTOR __unnamed_0, ref LPD3DVALUE __unnamed_1, uint __unnamed_2, uint __unnamed_3, ref uint __unnamed_4);
        
        [PreserveSig]
        HRESULT GetTexture(uint __unnamed_0, out LPDIRECTDRAWSURFACE7 __unnamed_1);
        
        [PreserveSig]
        HRESULT SetTexture(uint __unnamed_0, LPDIRECTDRAWSURFACE7 __unnamed_1);
        
        [PreserveSig]
        HRESULT GetTextureStageState(uint __unnamed_0, _D3DTEXTURESTAGESTATETYPE __unnamed_1, ref uint __unnamed_2);
        
        [PreserveSig]
        HRESULT SetTextureStageState(uint __unnamed_0, _D3DTEXTURESTAGESTATETYPE __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT ValidateDevice(ref uint __unnamed_0);
        
        [PreserveSig]
        HRESULT ApplyStateBlock(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT CaptureStateBlock(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT DeleteStateBlock(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT CreateStateBlock(_D3DSTATEBLOCKTYPE __unnamed_0, ref uint __unnamed_1);
        
        [PreserveSig]
        HRESULT Load(LPDIRECTDRAWSURFACE7 __unnamed_0, ref tagPOINT __unnamed_1, LPDIRECTDRAWSURFACE7 __unnamed_2, ref tagRECT __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT LightEnable(uint __unnamed_0, bool __unnamed_1);
        
        [PreserveSig]
        HRESULT GetLightEnable(uint __unnamed_0, ref bool __unnamed_1);
        
        [PreserveSig]
        HRESULT SetClipPlane(uint __unnamed_0, ref D3DVALUE __unnamed_1);
        
        [PreserveSig]
        HRESULT GetClipPlane(uint __unnamed_0, ref D3DVALUE __unnamed_1);
        
        [PreserveSig]
        HRESULT GetInfo(uint __unnamed_0, IntPtr __unnamed_1, uint __unnamed_2);
    }
}
