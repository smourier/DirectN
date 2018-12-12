// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(297,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECT3DDEVICE3 = DirectN.IDirect3DDevice3;
using LPDIRECT3DLIGHT = DirectN.IDirect3DLight;
using LPDIRECT3DMATERIAL3 = DirectN.IDirect3DMaterial3;
using LPDIRECT3DVERTEXBUFFER = DirectN.IDirect3DVertexBuffer;
using LPDIRECT3DVIEWPORT3 = DirectN.IDirect3DViewport3;
using LPDIRECTDRAWSURFACE4 = DirectN.IDirectDrawSurface4;
using LPUNKNOWN = System.Object;

namespace DirectN
{
    [Guid("bb223240-e72b-11d0-a9b4-00aa00c0993e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3D3
    {
        [PreserveSig]
        HRESULT EnumDevices(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateLight(out LPDIRECT3DLIGHT __unnamed_0, LPUNKNOWN __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateMaterial(out LPDIRECT3DMATERIAL3 __unnamed_0, LPUNKNOWN __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateViewport(out LPDIRECT3DVIEWPORT3 __unnamed_0, LPUNKNOWN __unnamed_1);
        
        [PreserveSig]
        HRESULT FindDevice(ref _D3DFINDDEVICESEARCH __unnamed_0, ref _D3DFINDDEVICERESULT __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateDevice([MarshalAs(UnmanagedType.LPStruct)] Guid __unnamed_0, LPDIRECTDRAWSURFACE4 __unnamed_1, out LPDIRECT3DDEVICE3 __unnamed_2, LPUNKNOWN __unnamed_3);
        
        [PreserveSig]
        HRESULT CreateVertexBuffer(ref _D3DVERTEXBUFFERDESC __unnamed_0, out LPDIRECT3DVERTEXBUFFER __unnamed_1, uint __unnamed_2, LPUNKNOWN __unnamed_3);
        
        [PreserveSig]
        HRESULT EnumZBufferFormats([MarshalAs(UnmanagedType.LPStruct)] Guid __unnamed_0, IntPtr __unnamed_1, IntPtr __unnamed_2);
        
        [PreserveSig]
        HRESULT EvictManagedTextures();
    }
}
