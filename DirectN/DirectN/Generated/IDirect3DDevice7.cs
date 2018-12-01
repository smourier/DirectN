// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(738,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f5049e79-4861-11d2-a407-00a0c90629a8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DDevice7
    {
        [PreserveSig]
        HRESULT GetCaps(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT EnumTextureFormats(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT BeginScene();
        
        [PreserveSig]
        HRESULT EndScene();
        
        [PreserveSig]
        HRESULT GetDirect3D(ref IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT SetRenderTarget(IntPtr __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT GetRenderTarget(ref IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Clear(uint __unnamed_0, IntPtr __unnamed_1, uint __unnamed_2, uint __unnamed_3, float __unnamed_4, uint __unnamed_5);
        
        [PreserveSig]
        HRESULT SetTransform(_D3DTRANSFORMSTATETYPE __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT GetTransform(_D3DTRANSFORMSTATETYPE __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT SetViewport(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT MultiplyTransform(_D3DTRANSFORMSTATETYPE __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT GetViewport(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT SetMaterial(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetMaterial(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT SetLight(uint __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT GetLight(uint __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT SetRenderState(_D3DRENDERSTATETYPE __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT GetRenderState(_D3DRENDERSTATETYPE __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT BeginStateBlock();
        
        [PreserveSig]
        HRESULT EndStateBlock(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT PreLoad(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT DrawPrimitive(_D3DPRIMITIVETYPE __unnamed_0, uint __unnamed_1, IntPtr __unnamed_2, uint __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitive(_D3DPRIMITIVETYPE __unnamed_0, uint __unnamed_1, IntPtr __unnamed_2, uint __unnamed_3, IntPtr __unnamed_4, uint __unnamed_5, uint __unnamed_6);
        
        [PreserveSig]
        HRESULT SetClipStatus(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetClipStatus(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT DrawPrimitiveStrided(_D3DPRIMITIVETYPE __unnamed_0, uint __unnamed_1, IntPtr __unnamed_2, uint __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitiveStrided(_D3DPRIMITIVETYPE __unnamed_0, uint __unnamed_1, IntPtr __unnamed_2, uint __unnamed_3, IntPtr __unnamed_4, uint __unnamed_5, uint __unnamed_6);
        
        [PreserveSig]
        HRESULT DrawPrimitiveVB(_D3DPRIMITIVETYPE __unnamed_0, IntPtr __unnamed_1, uint __unnamed_2, uint __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitiveVB(_D3DPRIMITIVETYPE __unnamed_0, IntPtr __unnamed_1, uint __unnamed_2, uint __unnamed_3, IntPtr __unnamed_4, uint __unnamed_5, uint __unnamed_6);
        
        [PreserveSig]
        HRESULT ComputeSphereVisibility(IntPtr __unnamed_0, IntPtr __unnamed_1, uint __unnamed_2, uint __unnamed_3, IntPtr __unnamed_4);
        
        [PreserveSig]
        HRESULT GetTexture(uint __unnamed_0, ref IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT SetTexture(uint __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT GetTextureStageState(uint __unnamed_0, _D3DTEXTURESTAGESTATETYPE __unnamed_1, IntPtr __unnamed_2);
        
        [PreserveSig]
        HRESULT SetTextureStageState(uint __unnamed_0, _D3DTEXTURESTAGESTATETYPE __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT ValidateDevice(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT ApplyStateBlock(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT CaptureStateBlock(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT DeleteStateBlock(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT CreateStateBlock(_D3DSTATEBLOCKTYPE __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT Load(IntPtr __unnamed_0, IntPtr __unnamed_1, IntPtr __unnamed_2, IntPtr __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT LightEnable(uint __unnamed_0, bool __unnamed_1);
        
        [PreserveSig]
        HRESULT GetLightEnable(uint __unnamed_0, ref bool __unnamed_1);
        
        [PreserveSig]
        HRESULT SetClipPlane(uint __unnamed_0, ref float __unnamed_1);
        
        [PreserveSig]
        HRESULT GetClipPlane(uint __unnamed_0, ref float __unnamed_1);
        
        [PreserveSig]
        HRESULT GetInfo(uint __unnamed_0, IntPtr __unnamed_1, uint __unnamed_2);
    }
}
