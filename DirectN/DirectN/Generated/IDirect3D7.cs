// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(351,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f5049e77-4861-11d2-a407-00a0c90629a8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3D7
    {
        [PreserveSig]
        HRESULT EnumDevices(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateDevice([MarshalAs(UnmanagedType.LPStruct)] Guid __unnamed_0, IntPtr __unnamed_1, ref IntPtr __unnamed_2);
        
        [PreserveSig]
        HRESULT CreateVertexBuffer(IntPtr __unnamed_0, ref IntPtr __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT EnumZBufferFormats([MarshalAs(UnmanagedType.LPStruct)] Guid __unnamed_0, IntPtr __unnamed_1, IntPtr __unnamed_2);
        
        [PreserveSig]
        HRESULT EvictManagedTextures();
    }
}
