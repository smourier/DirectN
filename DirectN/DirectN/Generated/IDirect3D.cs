// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(208,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECT3DLIGHT = DirectN.IDirect3DLight;
using LPDIRECT3DMATERIAL = DirectN.IDirect3DMaterial;
using LPDIRECT3DVIEWPORT = DirectN.IDirect3DViewport;

namespace DirectN
{
    [Guid("3bba0080-2421-11cf-a31a-00aa00b93356"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3D
    {
        [PreserveSig]
        HRESULT Initialize([MarshalAs(UnmanagedType.LPStruct)] Guid __unnamed_0);
        
        [PreserveSig]
        HRESULT EnumDevices(ref IntPtr __unnamed_0, ref IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateLight(LPDIRECT3DLIGHT __unnamed_0, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateMaterial(LPDIRECT3DMATERIAL __unnamed_0, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateViewport(LPDIRECT3DVIEWPORT __unnamed_0, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_1);
        
        [PreserveSig]
        HRESULT FindDevice(ref _D3DFINDDEVICESEARCH __unnamed_0, ref _D3DFINDDEVICERESULT __unnamed_1);
    }
}
