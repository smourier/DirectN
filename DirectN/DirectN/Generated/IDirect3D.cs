// generated from <Windows SDK Path>\um\d3d.h
using System;
using System.Runtime.InteropServices;
using LPDIRECT3DLIGHT = DirectN.IDirect3DLight;
using LPDIRECT3DMATERIAL = DirectN.IDirect3DMaterial;
using LPDIRECT3DVIEWPORT = DirectN.IDirect3DViewport;

namespace DirectN
{
    [ComImport, Guid("3bba0080-2421-11cf-a31a-00aa00b93356"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3D
    {
        [PreserveSig]
        HRESULT Initialize([MarshalAs(UnmanagedType.LPStruct)] Guid unnamed__0);
        
        [PreserveSig]
        HRESULT EnumDevices(IntPtr unnamed__0, IntPtr unnamed__1);
        
        [PreserveSig]
        HRESULT CreateLight(out LPDIRECT3DLIGHT unnamed__0, [MarshalAs(UnmanagedType.IUnknown)] object unnamed__1);
        
        [PreserveSig]
        HRESULT CreateMaterial(out LPDIRECT3DMATERIAL unnamed__0, [MarshalAs(UnmanagedType.IUnknown)] object unnamed__1);
        
        [PreserveSig]
        HRESULT CreateViewport(out LPDIRECT3DVIEWPORT unnamed__0, [MarshalAs(UnmanagedType.IUnknown)] object unnamed__1);
        
        [PreserveSig]
        HRESULT FindDevice(ref _D3DFINDDEVICESEARCH unnamed__0, ref _D3DFINDDEVICERESULT unnamed__1);
    }
}
