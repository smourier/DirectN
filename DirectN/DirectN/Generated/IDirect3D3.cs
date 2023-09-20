// generated from <Windows SDK Path>\um\d3d.h
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
    [ComImport, Guid("bb223240-e72b-11d0-a9b4-00aa00c0993e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3D3
    {
        [PreserveSig]
        HRESULT EnumDevices(IntPtr unnamed__0, IntPtr unnamed__1);
        
        [PreserveSig]
        HRESULT CreateLight(out LPDIRECT3DLIGHT unnamed__0, LPUNKNOWN unnamed__1);
        
        [PreserveSig]
        HRESULT CreateMaterial(out LPDIRECT3DMATERIAL3 unnamed__0, LPUNKNOWN unnamed__1);
        
        [PreserveSig]
        HRESULT CreateViewport(out LPDIRECT3DVIEWPORT3 unnamed__0, LPUNKNOWN unnamed__1);
        
        [PreserveSig]
        HRESULT FindDevice(ref _D3DFINDDEVICESEARCH unnamed__0, ref _D3DFINDDEVICERESULT unnamed__1);
        
        [PreserveSig]
        HRESULT CreateDevice([MarshalAs(UnmanagedType.LPStruct)] Guid unnamed__0, LPDIRECTDRAWSURFACE4 unnamed__1, out LPDIRECT3DDEVICE3 unnamed__2, LPUNKNOWN unnamed__3);
        
        [PreserveSig]
        HRESULT CreateVertexBuffer(ref _D3DVERTEXBUFFERDESC unnamed__0, out LPDIRECT3DVERTEXBUFFER unnamed__1, uint unnamed__2, LPUNKNOWN unnamed__3);
        
        [PreserveSig]
        HRESULT EnumZBufferFormats([MarshalAs(UnmanagedType.LPStruct)] Guid unnamed__0, IntPtr unnamed__1, IntPtr unnamed__2);
        
        [PreserveSig]
        HRESULT EvictManagedTextures();
    }
}
