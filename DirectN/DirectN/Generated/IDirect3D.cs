// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(208,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3bba0080-2421-11cf-a31a-00aa00b93356"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3D
    {
        [PreserveSig]
        HRESULT Initialize([MarshalAs(UnmanagedType.LPStruct)] Guid __unnamed_0);
        
        [PreserveSig]
        HRESULT EnumDevices(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateLight(ref IntPtr __unnamed_0, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateMaterial(ref IntPtr __unnamed_0, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateViewport(ref IntPtr __unnamed_0, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_1);
        
        [PreserveSig]
        HRESULT FindDevice(IntPtr __unnamed_0, IntPtr __unnamed_1);
    }
}
