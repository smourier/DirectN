// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(477,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("93281501-8cf8-11d0-89ab-00a0c9054129"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DDevice2
    {
        [PreserveSig]
        HRESULT GetCaps(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT SwapTextureHandles(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT GetStats(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT AddViewport(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT DeleteViewport(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT NextViewport(IntPtr __unnamed_0, ref IntPtr __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT EnumTextureFormats(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT BeginScene();
        
        [PreserveSig]
        HRESULT EndScene();
        
        [PreserveSig]
        HRESULT GetDirect3D(ref IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT SetCurrentViewport(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetCurrentViewport(ref IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT SetRenderTarget(IntPtr __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT GetRenderTarget(ref IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Begin(_D3DPRIMITIVETYPE __unnamed_0, _D3DVERTEXTYPE __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT BeginIndexed(_D3DPRIMITIVETYPE __unnamed_0, _D3DVERTEXTYPE __unnamed_1, IntPtr __unnamed_2, uint __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT Vertex(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Index(ushort __unnamed_0);
        
        [PreserveSig]
        HRESULT End(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetRenderState(_D3DRENDERSTATETYPE __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT SetRenderState(_D3DRENDERSTATETYPE __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT GetLightState(_D3DLIGHTSTATETYPE __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT SetLightState(_D3DLIGHTSTATETYPE __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT SetTransform(_D3DTRANSFORMSTATETYPE __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT GetTransform(_D3DTRANSFORMSTATETYPE __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT MultiplyTransform(_D3DTRANSFORMSTATETYPE __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT DrawPrimitive(_D3DPRIMITIVETYPE __unnamed_0, _D3DVERTEXTYPE __unnamed_1, IntPtr __unnamed_2, uint __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitive(_D3DPRIMITIVETYPE __unnamed_0, _D3DVERTEXTYPE __unnamed_1, IntPtr __unnamed_2, uint __unnamed_3, IntPtr __unnamed_4, uint __unnamed_5, uint __unnamed_6);
        
        [PreserveSig]
        HRESULT SetClipStatus(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetClipStatus(IntPtr __unnamed_0);
    }
}
