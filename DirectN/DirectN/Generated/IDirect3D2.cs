// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(252,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6aae1ec1-662a-11d0-889d-00aa00bbb76a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3D2
    {
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
        
        [PreserveSig]
        HRESULT CreateDevice([MarshalAs(UnmanagedType.LPStruct)] Guid __unnamed_0, IntPtr __unnamed_1, ref IntPtr __unnamed_2);
    }
}
