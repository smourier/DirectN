// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(252,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECT3DDEVICE2 = DirectN.IDirect3DDevice2;
using LPDIRECT3DLIGHT = DirectN.IDirect3DLight;
using LPDIRECT3DMATERIAL2 = DirectN.IDirect3DMaterial2;
using LPDIRECT3DVIEWPORT2 = DirectN.IDirect3DViewport2;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [Guid("6aae1ec1-662a-11d0-889d-00aa00bbb76a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3D2
    {
        [PreserveSig]
        HRESULT EnumDevices(ref IntPtr __unnamed_0, ref IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateLight(ref LPDIRECT3DLIGHT __unnamed_0, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateMaterial(ref LPDIRECT3DMATERIAL2 __unnamed_0, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateViewport(ref LPDIRECT3DVIEWPORT2 __unnamed_0, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_1);
        
        [PreserveSig]
        HRESULT FindDevice(ref _D3DFINDDEVICESEARCH __unnamed_0, ref _D3DFINDDEVICERESULT __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateDevice([MarshalAs(UnmanagedType.LPStruct)] Guid __unnamed_0, ref LPDIRECTDRAWSURFACE __unnamed_1, ref LPDIRECT3DDEVICE2 __unnamed_2);
    }
}
