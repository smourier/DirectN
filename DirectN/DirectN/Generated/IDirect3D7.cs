// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d.h(351,1)
using System;
using System.Runtime.InteropServices;
using LPD3DENUMDEVICESCALLBACK7 = System.IntPtr;
using LPDIRECT3DDEVICE7 = DirectN.IDirect3DDevice7;
using LPDIRECT3DVERTEXBUFFER7 = DirectN.IDirect3DVertexBuffer7;
using LPDIRECTDRAWSURFACE7 = DirectN.IDirectDrawSurface7;

namespace DirectN
{
    [ComImport, Guid("f5049e77-4861-11d2-a407-00a0c90629a8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3D7
    {
        [PreserveSig]
        HRESULT EnumDevices(ref LPD3DENUMDEVICESCALLBACK7 unnamed__0, IntPtr unnamed__1);
        
        [PreserveSig]
        HRESULT CreateDevice([MarshalAs(UnmanagedType.LPStruct)] Guid unnamed__0, LPDIRECTDRAWSURFACE7 unnamed__1, out LPDIRECT3DDEVICE7 unnamed__2);
        
        [PreserveSig]
        HRESULT CreateVertexBuffer(ref _D3DVERTEXBUFFERDESC unnamed__0, out LPDIRECT3DVERTEXBUFFER7 unnamed__1, uint unnamed__2);
        
        [PreserveSig]
        HRESULT EnumZBufferFormats([MarshalAs(UnmanagedType.LPStruct)] Guid unnamed__0, IntPtr unnamed__1, IntPtr unnamed__2);
        
        [PreserveSig]
        HRESULT EvictManagedTextures();
    }
}
