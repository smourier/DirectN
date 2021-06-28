// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d.h(252,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECT3DDEVICE2 = DirectN.IDirect3DDevice2;
using LPDIRECT3DLIGHT = DirectN.IDirect3DLight;
using LPDIRECT3DMATERIAL2 = DirectN.IDirect3DMaterial2;
using LPDIRECT3DVIEWPORT2 = DirectN.IDirect3DViewport2;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [ComImport, Guid("6aae1ec1-662a-11d0-889d-00aa00bbb76a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3D2
    {
        [PreserveSig]
        HRESULT EnumDevices(IntPtr unnamed__0, IntPtr unnamed__1);
        
        [PreserveSig]
        HRESULT CreateLight(out LPDIRECT3DLIGHT unnamed__0, [MarshalAs(UnmanagedType.IUnknown)] object unnamed__1);
        
        [PreserveSig]
        HRESULT CreateMaterial(out LPDIRECT3DMATERIAL2 unnamed__0, [MarshalAs(UnmanagedType.IUnknown)] object unnamed__1);
        
        [PreserveSig]
        HRESULT CreateViewport(out LPDIRECT3DVIEWPORT2 unnamed__0, [MarshalAs(UnmanagedType.IUnknown)] object unnamed__1);
        
        [PreserveSig]
        HRESULT FindDevice(ref _D3DFINDDEVICESEARCH unnamed__0, ref _D3DFINDDEVICERESULT unnamed__1);
        
        [PreserveSig]
        HRESULT CreateDevice([MarshalAs(UnmanagedType.LPStruct)] Guid unnamed__0, LPDIRECTDRAWSURFACE unnamed__1, out LPDIRECT3DDEVICE2 unnamed__2);
    }
}
